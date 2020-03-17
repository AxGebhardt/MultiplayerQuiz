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
    public partial class Namen : Form
    {
        public static string TeamA;
        public static string TeamB;
        public Namen()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            TeamA = textBox1.Text;
            TeamB = textBox2.Text;

            Form1 main = new Form1();
            this.Close();
            main.Show();
        }
    }
}
