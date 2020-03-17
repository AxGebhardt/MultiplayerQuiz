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
    public partial class Optionen : Form
    {
        public Optionen()
        {
            InitializeComponent();

            txt_A1.Text = Convert.ToString(Start.A_1);
            txt_A2.Text = Convert.ToString(Start.A_2);
            txt_A3.Text = Convert.ToString(Start.A_3);
            txt_A4.Text = Convert.ToString(Start.A_4);

            txt_B1.Text = Convert.ToString(Start.B_1);
            txt_B2.Text = Convert.ToString(Start.B_2);
            txt_B3.Text = Convert.ToString(Start.B_3);
            txt_B4.Text = Convert.ToString(Start.B_4);
        }

        private void txt_A1_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox txt = (TextBox)sender;

            txt.Text = Convert.ToString(e.KeyCode);

            switch (Convert.ToString(txt.Tag))
            {
                case "A1":
                    Start.A_1 = e.KeyCode;
                    break;
                case "A2":
                    Start.A_2 = e.KeyCode;
                    break;
                case "A3":
                    Start.A_3 = e.KeyCode;
                    break;
                case "A4":
                    Start.A_4 = e.KeyCode;
                    break;

                case "B1":
                    Start.B_1 = e.KeyCode;
                    break;
                case "B2":
                    Start.B_2 = e.KeyCode;
                    break;
                case "B3":
                    Start.B_3 = e.KeyCode;
                    break;
                case "B4":
                    Start.B_4 = e.KeyCode;
                    break;
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
