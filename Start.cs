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

namespace Quiz
{
    public partial class Start : Form
    {
        //Spieler A Steuerung
        public static Keys A_1 = Keys.D1;
        public static Keys A_2 = Keys.D2;
        public static Keys A_3 = Keys.D3;
        public static Keys A_4 = Keys.D4;

        //Spieler B Steuerung
        public static Keys B_1 = Keys.NumPad1;
        public static Keys B_2 = Keys.NumPad2;
        public static Keys B_3 = Keys.NumPad3;
        public static Keys B_4 = Keys.NumPad4;

        //Objekte/Variablen/Listen für die Ausgabe von Fragen
        Random rnd = new Random();

        //Liste die später die Aufgaben beinhalten wird
        List<Quiz_Assets> Fragen = new List<Quiz_Assets>();

        int s = 0;

        public Start()
        {
            InitializeComponent();

            //Variable zum zwischenspeichern der gesplitten Zeilen
            string[] zeile;

            //Objekte
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

            label_feature.Text = Fragen[rnd.Next(Fragen.Count)].Frage;
            Frage.Start();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            Namen Start = new Namen();
            this.Hide();
            Start.Show();
        }

        //"Credits"
        private void btn_credits_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by A. Gebhardt ITA3a\n\nGespielt wird am PC//" + Environment.MachineName);
        }

        //"Hilfe"
        private void btn_hilfe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In den Optionen kann man die Steuerung ansehen und ändern.\nMit \"Spiel Starten\" kann man anfangen!");
        }

        private void btn_optionen_Click(object sender, EventArgs e)
        {
            Optionen optionen = new Optionen();

            optionen.Show();
        }

        private void Frage_Tick(object sender, EventArgs e)
        {
            if(s == 60)
            {
                label_feature.Text = Fragen[rnd.Next(Fragen.Count)].Frage;
                s = 0;
            }
            else
            {
                s++;
            }
        }


        int mn = 0;
        private void Start_VisibleChanged(object sender, EventArgs e)
        {
            mn++;
            if(mn == 2){ Frage.Stop(); }
        }
    }
}
