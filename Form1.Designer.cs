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
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.PunktzahlA_label = new System.Windows.Forms.Label();
            this.PunktzahlB_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 77);
            this.button1.TabIndex = 0;
            this.button1.Tag = "Kategorie";
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Fragen_aufruf);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(135, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 77);
            this.button2.TabIndex = 1;
            this.button2.Tag = "Kategorie";
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Fragen_aufruf);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(257, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 77);
            this.button3.TabIndex = 2;
            this.button3.Tag = "Kategorie";
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Fragen_aufruf);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(379, 13);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 77);
            this.button4.TabIndex = 3;
            this.button4.Tag = "Kategorie";
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Fragen_aufruf);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(379, 96);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(116, 77);
            this.button5.TabIndex = 7;
            this.button5.Tag = "Kategorie";
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Fragen_aufruf);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(257, 96);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(116, 77);
            this.button6.TabIndex = 6;
            this.button6.Tag = "Kategorie";
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Fragen_aufruf);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(135, 95);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(116, 77);
            this.button7.TabIndex = 5;
            this.button7.Tag = "Kategorie";
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Fragen_aufruf);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(13, 96);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(116, 77);
            this.button8.TabIndex = 4;
            this.button8.Tag = "Kategorie";
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Fragen_aufruf);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(379, 179);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(116, 77);
            this.button9.TabIndex = 11;
            this.button9.Tag = "Kategorie";
            this.button9.Text = "button9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Fragen_aufruf);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(257, 179);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(116, 77);
            this.button10.TabIndex = 10;
            this.button10.Tag = "Kategorie";
            this.button10.Text = "button10";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.Fragen_aufruf);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(135, 178);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(116, 77);
            this.button11.TabIndex = 9;
            this.button11.Tag = "Kategorie";
            this.button11.Text = "button11";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.Fragen_aufruf);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(13, 179);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(116, 77);
            this.button12.TabIndex = 8;
            this.button12.Tag = "Kategorie";
            this.button12.Text = "button12";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.Fragen_aufruf);
            // 
            // PunktzahlA_label
            // 
            this.PunktzahlA_label.AutoSize = true;
            this.PunktzahlA_label.Location = new System.Drawing.Point(10, 272);
            this.PunktzahlA_label.Name = "PunktzahlA_label";
            this.PunktzahlA_label.Size = new System.Drawing.Size(111, 13);
            this.PunktzahlA_label.TabIndex = 12;
            this.PunktzahlA_label.Text = "Punktzahl Spieler A: 0";
            // 
            // PunktzahlB_label
            // 
            this.PunktzahlB_label.AutoSize = true;
            this.PunktzahlB_label.Location = new System.Drawing.Point(384, 272);
            this.PunktzahlB_label.Name = "PunktzahlB_label";
            this.PunktzahlB_label.Size = new System.Drawing.Size(111, 13);
            this.PunktzahlB_label.TabIndex = 13;
            this.PunktzahlB_label.Text = "Punktzahl Spieler B: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 294);
            this.Controls.Add(this.PunktzahlB_label);
            this.Controls.Add(this.PunktzahlA_label);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Quiz";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label PunktzahlA_label;
        private System.Windows.Forms.Label PunktzahlB_label;
    }
}

