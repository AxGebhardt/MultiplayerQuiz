using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

#region TODO

/*  TODO
 *  
 *  > Allgemein
 *  - Endauswertung vom Quiz (Aussehen verbessern)
 *  - Style
 *  
 *  
 *  > Form1 (Hauptform)
 *  - Besseres Layout / Regeln bzw. Steuerungserklärung hinzufügen
 *
 * 
 *  > Fragen (Form für die Fragen)
 *  - Center Position der Antworten verbessern
 *    (Momentan ist padding auf festen 205px eingestellt, was 
 *     dazu führt das lange Antworten zu Problemen führen könnten)
 *     
 *     
 *  > Wichtig
 *  - Fehler abfangen  
 *     
 */

#endregion

#region Dokumentation

/*
 *  Name: Alexander Gebhardt
 *  Klasse: ITA3
 *  
 *  Momentan können nur 12 Fragen über die 'Fragen.csv' Datei eingelesen werden.
 *  Diese MUSS sich im moment im Debug Ordner befinden (Relativer Pfad undso).
 *  
 *  Format sollte folgendermaßen sein:
 *  
 *  Kategorie (String) | Frage (String) | Antwort 1 (String) | Antwort2 (String) | Antwort3 (String)| Antwort4 (String) | Richtige Antwort (Integer) |
 *  Mathe              | Was ist 1+1 ?  |         2          |         3         |         5        |          10       |            1               |
 *  
 *  Die erste Zeile wird standartmäßig übersprungen.
 *  
 * 
 */

#endregion

#region Version

    /*
     *  Quiz V1.00 //20.09.2017
     *  - Einlesen von .csv Datei möglich
     *  - Kategorie Auswahl
     *  - Antworteingabe über die Tastatur, Spieler A (1,2,3,4) Spieler B (Numpad 1,2,3,4)
     *  - Timer
     *  - ...
     *  
     *  
     *  
     */

#endregion


namespace Quiz
{
    public partial class Form1 : Form
    {
        //Globale Variablen
        public static int punktzahlA = 0;
        public static int punktzahlB = 0;
        public static bool debug = false;

        //Variable zum zwischenspeichern der gesplitten Zeilen
        string[] zeile;

        //Liste die später die Aufgaben beinhalten wird
        List<Quiz_Assets> Assets = new List<Quiz_Assets>();
        List<Quiz_Assets> Fragen = new List<Quiz_Assets>();

        //Random Objekt
        Random rnd = new Random();

        //Manuelle Zähler
        int x = 0;
        int kategorien;
        int zaehler = 0;
        int random;


        public Form1()
        {
            InitializeComponent();

            //Team Namen ausgeben
            PunktzahlA_label.Text = Namen.TeamA + ": 0";
            PunktzahlB_label.Text = Namen.TeamB + ": 0";

            //Objekte zum Auslesen der Fragen/Datei
            FileStream Stream;
            StreamReader Leser;

            try
            {
                Stream = new FileStream("Fragen.csv", FileMode.Open, FileAccess.Read);
                Leser = new StreamReader(Stream, Encoding.Default);

                Leser.ReadLine(); //1. Zeile überspringen
                while (Leser.Peek() != -1)
                {
                    zeile = Leser.ReadLine().Split(';');
                    Fragen.Add(new Quiz_Assets(zeile));
                    zaehler++;
                }
                Leser.Close();
            }

            //TODO: Fehler abfangen
            catch (FileNotFoundException fnfe)
            {
                MessageBox.Show("\t\t\t    Fehler \n\n" + fnfe.FileName + " konnte nicht gefunden werden!\nBitte gehen Sie sicher, dass die Datei im Debug Ordner ist!\n\n Starten Sie ggf. das Programm neu!");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "\n\n Bitte beheben Sie den Fehler und starten Sie das Programm neu!");
            }

            //Ruft Methode Zufall auf
            zufall();

            //Code zum bennenen der Kategorie Buttons
            foreach (Control c in Controls)
            {
                try
                {
                    if (c.Tag.Equals("Kategorie"))
                    {
                        c.Text = Assets[x].Kategorie;
                        c.Tag = x;
                        x++;
                        kategorien++;
                    }

                }
                catch (Exception)
                {
                    continue;
                }
            }
          }

        //Methode für das auswählen einer Kategorie
        private void Fragen_aufruf(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Enabled = false;
            Fragen form = new Fragen(Assets[Convert.ToInt32(btn.Tag)]);
            form.Show();
            form.Focus();
            this.Hide();

            //Ruft die Methode "Punktzahl_aktualieseren" auf
            form.FormClosed += new System.Windows.Forms.FormClosedEventHandler(Punktzahl_aktualieseren);
        }

        //Methode die aufgerufen wird, wenn das Fragen.cs(Form) geschlossen wurde. Im moment zur Punkte aktualiesierung da.
        private void Punktzahl_aktualieseren(object sender, EventArgs e)
        {
            //Aktualiesiert die Punktzahlen
            this.Show();
            PunktzahlA_label.Text = Namen.TeamA + ": " + punktzahlA;
            PunktzahlB_label.Text = Namen.TeamB + ": " + punktzahlB;

            //Code zum auswerten des Gewinners
            if(endstand())
            {
                if(punktzahlA>punktzahlB)
                {
                    Endstand ende = new Endstand(Namen.TeamA, Namen.TeamA, 1);
                    ende.Show();
                    this.Hide();
                }
                else if (punktzahlA == punktzahlB)
                {
                    Endstand ende = new Endstand(Namen.TeamA, Namen.TeamB, 3);
                    ende.Show();
                    this.Hide();
                }
                else if (punktzahlB>punktzahlA)
                {
                    Endstand ende = new Endstand(Namen.TeamA, Namen.TeamB, 2);
                    ende.Show();
                    this.Hide();
                }
            }
            else
            {
                //MessageBox.Show("Alle Buttons wurden noch nicht gedrückt");
            }
        }

        //Prüft ob das Spiel zu ende ist
        private bool endstand()
        {
            //Prüft ob alle Buttons gedrückt wurden
            //Standartmäßig nicht also = false
            bool pruefer = false; 

            foreach(Control c in Controls)
            {
                if (c.Name.Contains("button"))
                {
                    //Wenn der momentan geprüfte Button disabled ist, wird der pruefer true gesetzt.
                    if(c.Enabled == false)
                    {
                        pruefer = true;
                    }
                    //Ist ein Button mal noch nicht disabled, wird false zurückgeschickt
                    else
                    {
                        return false;
                    }
                }
            }

            //Sind alle buttons gedrückt, wird true gesendet.
            return pruefer;
        }

        //Methode die bei Tastenanschlägen ausgeführt wird.
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                if (Form1.debug)
                {
                    Form1.debug = false;
                }
                else
                {
                    Form1.debug = true;
                }
            }
        }

        //Methode zum ausgeben von 12 verschiedenen Kategorien u. fragen
        public void zufall()
        {
            random = rnd.Next(0, Fragen.Count);
            Assets.Add(Fragen[random]);
            Fragen.Remove(Fragen[random]);

            while(Assets.Count < 12)
            {                
                random = rnd.Next(0, Fragen.Count);

                bool tester = true;

                for (int w = 0; w < Assets.Count; w++)
                {
                    if(Assets[w].Kategorie.Contains(Fragen[random].Kategorie))
                    {
                        tester = false;   
                    }
                }

                if(tester)
                {
                    Assets.Add(Fragen[random]); 
                }
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
