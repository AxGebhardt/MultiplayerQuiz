using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Fragen : Form
    {
        //Wert mit der richtigen Antwort
        int antwort;
        
        //Anzahl der Zeit in Sekunden 1:1
        int i;

        //Speichert die Antworten der Spieler ein
        int Spieler1;
        int Spieler2;

        bool A = false;
        bool B = false;

        //Bool um Tastatureingaben ein/auszuschalten
        bool eingabe = true;
        bool eingabeA = true;
        bool eingabeB = true;

        Label[] label_fragen = new Label[4];

        public Fragen(Quiz_Assets Aufgabe)
        {
            InitializeComponent();

            this.KeyPreview = true;

            //Anzahl der Zeit in Sekunden 1:1
            i = 15;

            //
            this.Text = Aufgabe.Kategorie;
            
            //
            Frage_label.Text = Aufgabe.Frage;
            Antwort1.Text = "1) " + Aufgabe.Antwort1;
            Antwort2.Text = "2) " + Aufgabe.Antwort2;
            Antwort3.Text = "3) " + Aufgabe.Antwort3;
            Antwort4.Text = "4) " + Aufgabe.Antwort4;

            //
            antwort = Aufgabe.Loesung;
            
            //
            SpielerA_label.Text = "Spieler A";
            SpielerB_label.Text = "Spieler B";
            SpielerA_label.ForeColor = Color.Red;
            SpielerB_label.ForeColor = Color.Red;

            //
            label_fragen[0] = Antwort1;
            label_fragen[1] = Antwort2;
            label_fragen[2] = Antwort3;
            label_fragen[3] = Antwort4;

            //
            Stopuhr.Enabled = true;
            Stopuhr.Start();
            label1.Text = Convert.ToString(i);
        }

        //TODO Wahrscheinlich löschen
        private void antwort_aufruf(object sender, EventArgs e)
        {
            /*
            Button btn = (Button)sender;
            if(Convert.ToInt32(btn.Tag) == antwort)
            {
                MessageBox.Show("Richtig!");
                Form1.punktzahl++;
                this.Close();
            }
            else
            {
                MessageBox.Show("Falsch!");
                this.Close();
            }
             * */
        }

        private void Stopuhr_Tick(object sender, EventArgs e)
        {
            //Stoppt den Timer wenn beide Spieler eine Antwort abgegeben haben.
            if (A && B) i = 0; else i--;

            //Zeigt den Timer an.
            label1.Text = Convert.ToString(i);

            //If-Abfragen für bestimmte Zeiten
            if (i <= 10)
            {
                label1.ForeColor = Color.Orange;
            }
            if(i <= 5)
            {
                label1.ForeColor = Color.Red;
            }

            if(i == 0)
            {
                Stopuhr.Stop();
                Stopuhr.Enabled = false;
                eingabe = false;
                label_fragen[antwort-1].Text += " \u221A";

                //Abfrage zu verschiedenen Situation (A = Richtig + B = Richtig | A/B = Falsch + A/B = Richtig | A/B = Keine Antwort + A/B = Richtig/Falsch | A+B = Keine Antwort |)
                if (Spieler1 == 0 && Spieler2 != 0)
                {
                    SpielerA_label.Text = "Keine Antwort!";
                    SpielerA_label.ForeColor = Color.Red;

                    if (Spieler2 == antwort)
                    {
                        SpielerB_label.Text += ": Richtig!";
                        SpielerB_label.ForeColor = Color.Green;
                        Form1.punktzahlB++;
                        label_fragen[Spieler2 - 1].Text += " (Spieler B)";
                        label_fragen[Spieler2 - 1].ForeColor = Color.Green;
                    }
                    else
                    {
                        SpielerB_label.Text += ": Falsch!";
                        SpielerB_label.ForeColor = Color.Red;
                        label_fragen[Spieler2 - 1].Text += " (Spieler B)";
                        label_fragen[Spieler2 - 1].ForeColor = Color.Red;
                    }

                }
                else if (Spieler2 == 0 && Spieler1 != 0)
                {
                    SpielerB_label.Text = "Keine Antwort!";
                    SpielerB_label.ForeColor = Color.Red;


                    if (Spieler1 == antwort)
                    {
                        SpielerA_label.Text += ": Richtig!";
                        SpielerA_label.ForeColor = Color.Green;
                        Form1.punktzahlA++;
                        label_fragen[Spieler1 - 1].Text += " (Spieler A)";
                        label_fragen[Spieler1 - 1].ForeColor = Color.Green;
                    }
                    else
                    {
                        SpielerA_label.Text += ": Falsch!";
                        SpielerA_label.ForeColor = Color.Red;
                        label_fragen[Spieler1 - 1].Text += " (Spieler A)";
                        label_fragen[Spieler1 - 1].ForeColor = Color.Red;
                    }
                }
                else if (Spieler1 == 0 && Spieler2 == 0)
                {
                    SpielerA_label.Text = "Keine Antwort!";
                    SpielerA_label.ForeColor = Color.Red;
                    SpielerB_label.Text = "Keine Antwort!";
                    SpielerB_label.ForeColor = Color.Red;
                }
                else if (Spieler1 != 0 && Spieler2 != 0)
                {
                    /* Schreibt B 2x mal //Buggt noch rum
                    if (Spieler1 == Spieler2)
                    {
                        label_fragen[Spieler1 - 1].Text += " (Spieler A),";
                        label_fragen[Spieler2 - 1].Text += " (Spieler B)";
                        label_fragen[Spieler1 - 1].ForeColor = Color.Red;
                        tester = false;

                    }
                     * */
                    if (Spieler1 == antwort)
                    {
                        SpielerA_label.Text += ": Richtig!";
                        SpielerA_label.ForeColor = Color.Green;
                        Form1.punktzahlA++;
                        label_fragen[Spieler1 - 1].Text += " (Spieler A)";
                    }
                    else
                    {
                        SpielerA_label.Text += ": Falsch!";
                        SpielerA_label.ForeColor = Color.Red;
                        label_fragen[Spieler1 - 1].Text += " (Spieler A)";
                        label_fragen[Spieler1 - 1].ForeColor = Color.Red;
                    }

                    if (Spieler2 == antwort)
                    {
                        SpielerB_label.Text += ": Richtig!";
                        SpielerB_label.ForeColor = Color.Green;
                        Form1.punktzahlB++;
                        label_fragen[Spieler2 - 1].Text += " (Spieler B)";
                    }
                    else
                    {
                        SpielerB_label.Text += ": Falsch!";
                        SpielerB_label.ForeColor = Color.Red;
                        label_fragen[Spieler2 - 1].Text += " (Spieler B)";
                        label_fragen[Spieler2 - 1].ForeColor = Color.Red;
                    }
                }

                //Richtige Antwort wird Grün.
                label_fragen[antwort - 1].ForeColor = Color.Green;

                //
                next_btn.Visible = true;
            }
        }

        private void Fragen_KeyDown(object sender, KeyEventArgs e)
        {
            #region Spieler A Steuerung
            //Spieler A
            if (e.KeyCode == Start.A_1 && eingabe && eingabeA)
            {
                Spieler1 = 1;
                SpielerA_label.ForeColor = Color.Green;
                A = true;
                eingabeA = false;
            }
            if (e.KeyCode == Start.A_2 && eingabe && eingabeA)
            {
                Spieler1 = 2;
                SpielerA_label.ForeColor = Color.Green;
                A = true;
                eingabeA = false;
            }
            if (e.KeyCode == Start.A_3 && eingabe && eingabeA)
            {
                Spieler1 = 3;
                SpielerA_label.ForeColor = Color.Green;
                A = true;
                eingabeA = false;
            }
            if (e.KeyCode == Start.A_4 && eingabe && eingabeA)
            {
                Spieler1 = 4;
                SpielerA_label.ForeColor = Color.Green;
                A = true;
                eingabeA = false;
            }
#endregion

            #region Spieler B Steuerung
            //Spieler B
            if (e.KeyCode == Start.B_1 && eingabe && eingabeB)
            {
                Spieler2 = 1;
                SpielerB_label.ForeColor = Color.Green;
                B = true;
                eingabeB = false;
            }
            if (e.KeyCode == Start.B_2 && eingabe && eingabeB)
            {
                Spieler2 = 2;
                SpielerB_label.ForeColor = Color.Green;
                B = true;
                eingabeB = false;
            }
            if (e.KeyCode == Start.B_3 && eingabe && eingabeB)
            {
                Spieler2 = 3;
                SpielerB_label.ForeColor = Color.Green;
                B = true;
                eingabeB = false;
            }
            if (e.KeyCode == Start.B_4 && eingabe && eingabeB)
            {
                Spieler2 = 4;
                SpielerB_label.ForeColor = Color.Green;
                B = true;
                eingabeB = false;
            }
            #endregion

            #region Debug Modus
            //Debug Modus
            if(e.KeyCode == Keys.Escape && Form1.debug)
            {
                this.Close();
            }

            if(e.KeyCode == Keys.F12)
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
            #endregion
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
