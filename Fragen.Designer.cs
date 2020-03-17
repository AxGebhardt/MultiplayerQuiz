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
    partial class Fragen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Frage_label = new System.Windows.Forms.Label();
            this.Frage_Panel = new System.Windows.Forms.Panel();
            this.Antworten_Panel = new System.Windows.Forms.Panel();
            this.Antwort4 = new System.Windows.Forms.Label();
            this.Antwort3 = new System.Windows.Forms.Label();
            this.Antwort2 = new System.Windows.Forms.Label();
            this.Antwort1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Stopuhr = new System.Windows.Forms.Timer(this.components);
            this.SpielerA_label = new System.Windows.Forms.Label();
            this.SpielerB_label = new System.Windows.Forms.Label();
            this.next_btn = new System.Windows.Forms.Button();
            this.Frage_Panel.SuspendLayout();
            this.Antworten_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Frage_label
            // 
            this.Frage_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Frage_label.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Frage_label.Location = new System.Drawing.Point(0, 0);
            this.Frage_label.Margin = new System.Windows.Forms.Padding(3, 0, 0, 3);
            this.Frage_label.Name = "Frage_label";
            this.Frage_label.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.Frage_label.Size = new System.Drawing.Size(482, 53);
            this.Frage_label.TabIndex = 0;
            this.Frage_label.Text = "PlatzhalterPlatzhalterPlatzhalter";
            this.Frage_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Frage_Panel
            // 
            this.Frage_Panel.Controls.Add(this.Frage_label);
            this.Frage_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Frage_Panel.Location = new System.Drawing.Point(0, 0);
            this.Frage_Panel.Name = "Frage_Panel";
            this.Frage_Panel.Size = new System.Drawing.Size(482, 53);
            this.Frage_Panel.TabIndex = 1;
            this.Frage_Panel.Click += new System.EventHandler(this.antwort_aufruf);
            // 
            // Antworten_Panel
            // 
            this.Antworten_Panel.BackColor = System.Drawing.Color.White;
            this.Antworten_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Antworten_Panel.Controls.Add(this.Antwort4);
            this.Antworten_Panel.Controls.Add(this.Antwort3);
            this.Antworten_Panel.Controls.Add(this.Antwort2);
            this.Antworten_Panel.Controls.Add(this.Antwort1);
            this.Antworten_Panel.Location = new System.Drawing.Point(3, 53);
            this.Antworten_Panel.Name = "Antworten_Panel";
            this.Antworten_Panel.Size = new System.Drawing.Size(478, 192);
            this.Antworten_Panel.TabIndex = 2;
            // 
            // Antwort4
            // 
            this.Antwort4.BackColor = System.Drawing.SystemColors.Control;
            this.Antwort4.Dock = System.Windows.Forms.DockStyle.Top;
            this.Antwort4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Antwort4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Antwort4.Location = new System.Drawing.Point(0, 144);
            this.Antwort4.Name = "Antwort4";
            this.Antwort4.Padding = new System.Windows.Forms.Padding(205, 0, 0, 0);
            this.Antwort4.Size = new System.Drawing.Size(476, 48);
            this.Antwort4.TabIndex = 8;
            this.Antwort4.Tag = "4";
            this.Antwort4.Text = "4) Antwort4";
            this.Antwort4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Antwort3
            // 
            this.Antwort3.BackColor = System.Drawing.SystemColors.Control;
            this.Antwort3.Dock = System.Windows.Forms.DockStyle.Top;
            this.Antwort3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Antwort3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Antwort3.Location = new System.Drawing.Point(0, 96);
            this.Antwort3.Name = "Antwort3";
            this.Antwort3.Padding = new System.Windows.Forms.Padding(205, 0, 0, 0);
            this.Antwort3.Size = new System.Drawing.Size(476, 48);
            this.Antwort3.TabIndex = 7;
            this.Antwort3.Tag = "3";
            this.Antwort3.Text = "3) Antwort3";
            this.Antwort3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Antwort2
            // 
            this.Antwort2.BackColor = System.Drawing.SystemColors.Control;
            this.Antwort2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Antwort2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Antwort2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Antwort2.Location = new System.Drawing.Point(0, 48);
            this.Antwort2.Name = "Antwort2";
            this.Antwort2.Padding = new System.Windows.Forms.Padding(205, 0, 0, 0);
            this.Antwort2.Size = new System.Drawing.Size(476, 48);
            this.Antwort2.TabIndex = 6;
            this.Antwort2.Tag = "2";
            this.Antwort2.Text = "2) Antwort2";
            this.Antwort2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Antwort1
            // 
            this.Antwort1.BackColor = System.Drawing.SystemColors.Control;
            this.Antwort1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Antwort1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Antwort1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Antwort1.Location = new System.Drawing.Point(0, 0);
            this.Antwort1.Name = "Antwort1";
            this.Antwort1.Padding = new System.Windows.Forms.Padding(205, 0, 0, 0);
            this.Antwort1.Size = new System.Drawing.Size(476, 48);
            this.Antwort1.TabIndex = 5;
            this.Antwort1.Tag = "1";
            this.Antwort1.Text = "1) Antwort1";
            this.Antwort1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(0, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 45);
            this.label1.TabIndex = 4;
            this.label1.Text = "Timer";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Stopuhr
            // 
            this.Stopuhr.Interval = 1000;
            this.Stopuhr.Tick += new System.EventHandler(this.Stopuhr_Tick);
            // 
            // SpielerA_label
            // 
            this.SpielerA_label.BackColor = System.Drawing.Color.Transparent;
            this.SpielerA_label.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpielerA_label.Location = new System.Drawing.Point(0, 246);
            this.SpielerA_label.Name = "SpielerA_label";
            this.SpielerA_label.Size = new System.Drawing.Size(207, 47);
            this.SpielerA_label.TabIndex = 5;
            this.SpielerA_label.Text = "Spieler A";
            this.SpielerA_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SpielerB_label
            // 
            this.SpielerB_label.BackColor = System.Drawing.Color.Transparent;
            this.SpielerB_label.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpielerB_label.Location = new System.Drawing.Point(274, 246);
            this.SpielerB_label.Name = "SpielerB_label";
            this.SpielerB_label.Size = new System.Drawing.Size(207, 47);
            this.SpielerB_label.TabIndex = 6;
            this.SpielerB_label.Text = "Spieler B";
            this.SpielerB_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // next_btn
            // 
            this.next_btn.Location = new System.Drawing.Point(189, 253);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(102, 34);
            this.next_btn.TabIndex = 7;
            this.next_btn.Text = "Nächstes Thema";
            this.next_btn.UseVisualStyleBackColor = true;
            this.next_btn.Visible = false;
            this.next_btn.Click += new System.EventHandler(this.next_btn_Click);
            // 
            // Fragen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(482, 294);
            this.Controls.Add(this.next_btn);
            this.Controls.Add(this.SpielerB_label);
            this.Controls.Add(this.SpielerA_label);
            this.Controls.Add(this.Antworten_Panel);
            this.Controls.Add(this.Frage_Panel);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Fragen";
            this.Text = "Fragen";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Fragen_KeyDown);
            this.Frage_Panel.ResumeLayout(false);
            this.Antworten_Panel.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label Frage_label;
        private System.Windows.Forms.Panel Frage_Panel;
        private System.Windows.Forms.Panel Antworten_Panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer Stopuhr;
        private System.Windows.Forms.Label Antwort1;
        private System.Windows.Forms.Label Antwort4;
        private System.Windows.Forms.Label Antwort3;
        private System.Windows.Forms.Label Antwort2;
        private System.Windows.Forms.Label SpielerA_label;
        private System.Windows.Forms.Label SpielerB_label;
        private System.Windows.Forms.Button next_btn;
    }
}