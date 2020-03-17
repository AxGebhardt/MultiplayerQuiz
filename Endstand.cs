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
    public partial class Endstand : Form
    {
        public Endstand(string TeamA, string TeamB, int gewinner)
        {
            InitializeComponent();


            switch (gewinner)
            {
                case 1:
                    label_gewinner.Text = TeamA;
                    label_gewinner_ausgabe.Text = TeamA + " hat gewonnen!";
                    break;
                case 2:
                    label_gewinner.Text = TeamB;
                    label_gewinner_ausgabe.Text = TeamB + " hat gewonnen!";
                    break;
                case 3:
                    label_gewinner.Text = "Unentschieden";
                    label_gewinner_ausgabe.Text = "Beide waren gleich gut, Unentschieden!";
                    break;
            }
        }

        private void Endstand_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
