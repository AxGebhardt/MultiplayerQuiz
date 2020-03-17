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
    partial class Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.Panel_Header = new System.Windows.Forms.Panel();
            this.Label_titel = new System.Windows.Forms.Label();
            this.Panel_footer = new System.Windows.Forms.Panel();
            this.label_feature = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Panel_inhalt = new System.Windows.Forms.Panel();
            this.btn_credits = new System.Windows.Forms.Button();
            this.btn_hilfe = new System.Windows.Forms.Button();
            this.btn_optionen = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.Frage = new System.Windows.Forms.Timer(this.components);
            this.top_style = new System.Windows.Forms.Panel();
            this.Panel_Header.SuspendLayout();
            this.Panel_footer.SuspendLayout();
            this.Panel_inhalt.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Header
            // 
            this.Panel_Header.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Header.Controls.Add(this.top_style);
            this.Panel_Header.Controls.Add(this.Label_titel);
            this.Panel_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Header.Location = new System.Drawing.Point(0, 0);
            this.Panel_Header.Name = "Panel_Header";
            this.Panel_Header.Size = new System.Drawing.Size(370, 73);
            this.Panel_Header.TabIndex = 0;
            // 
            // Label_titel
            // 
            this.Label_titel.BackColor = System.Drawing.Color.Transparent;
            this.Label_titel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_titel.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_titel.ForeColor = System.Drawing.Color.Maroon;
            this.Label_titel.Location = new System.Drawing.Point(0, 0);
            this.Label_titel.Name = "Label_titel";
            this.Label_titel.Size = new System.Drawing.Size(370, 73);
            this.Label_titel.TabIndex = 0;
            this.Label_titel.Text = "Quiz 2017";
            this.Label_titel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panel_footer
            // 
            this.Panel_footer.BackColor = System.Drawing.Color.Transparent;
            this.Panel_footer.Controls.Add(this.label_feature);
            this.Panel_footer.Controls.Add(this.panel1);
            this.Panel_footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel_footer.Location = new System.Drawing.Point(0, 348);
            this.Panel_footer.Name = "Panel_footer";
            this.Panel_footer.Size = new System.Drawing.Size(370, 72);
            this.Panel_footer.TabIndex = 0;
            // 
            // label_feature
            // 
            this.label_feature.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_feature.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(215)))), ((int)(((byte)(180)))));
            this.label_feature.Location = new System.Drawing.Point(0, 23);
            this.label_feature.Name = "label_feature";
            this.label_feature.Size = new System.Drawing.Size(370, 49);
            this.label_feature.TabIndex = 1;
            this.label_feature.Text = "Das ist eine Testfrage? Das ist eine Testfrage?Das ist eine Testfrage? Das ist ei" +
    "ne Testfrage?";
            this.label_feature.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_feature.UseCompatibleTextRendering = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Location = new System.Drawing.Point(0, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 5);
            this.panel1.TabIndex = 0;
            // 
            // Panel_inhalt
            // 
            this.Panel_inhalt.BackColor = System.Drawing.Color.Transparent;
            this.Panel_inhalt.Controls.Add(this.btn_credits);
            this.Panel_inhalt.Controls.Add(this.btn_hilfe);
            this.Panel_inhalt.Controls.Add(this.btn_optionen);
            this.Panel_inhalt.Controls.Add(this.btn_start);
            this.Panel_inhalt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_inhalt.Location = new System.Drawing.Point(0, 73);
            this.Panel_inhalt.Name = "Panel_inhalt";
            this.Panel_inhalt.Size = new System.Drawing.Size(370, 275);
            this.Panel_inhalt.TabIndex = 0;
            // 
            // btn_credits
            // 
            this.btn_credits.BackColor = System.Drawing.Color.Transparent;
            this.btn_credits.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_credits.BackgroundImage")));
            this.btn_credits.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_credits.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_credits.FlatAppearance.BorderSize = 0;
            this.btn_credits.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btn_credits.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btn_credits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_credits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_credits.ForeColor = System.Drawing.Color.Lime;
            this.btn_credits.Location = new System.Drawing.Point(75, 210);
            this.btn_credits.Name = "btn_credits";
            this.btn_credits.Size = new System.Drawing.Size(224, 59);
            this.btn_credits.TabIndex = 4;
            this.btn_credits.Text = "Credits";
            this.btn_credits.UseVisualStyleBackColor = false;
            this.btn_credits.Click += new System.EventHandler(this.btn_credits_Click);
            // 
            // btn_hilfe
            // 
            this.btn_hilfe.BackColor = System.Drawing.Color.Transparent;
            this.btn_hilfe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_hilfe.BackgroundImage")));
            this.btn_hilfe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_hilfe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_hilfe.FlatAppearance.BorderSize = 0;
            this.btn_hilfe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btn_hilfe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btn_hilfe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hilfe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hilfe.ForeColor = System.Drawing.Color.Lime;
            this.btn_hilfe.Location = new System.Drawing.Point(75, 145);
            this.btn_hilfe.Name = "btn_hilfe";
            this.btn_hilfe.Size = new System.Drawing.Size(224, 59);
            this.btn_hilfe.TabIndex = 3;
            this.btn_hilfe.Text = "Hilfe";
            this.btn_hilfe.UseVisualStyleBackColor = false;
            this.btn_hilfe.Click += new System.EventHandler(this.btn_hilfe_Click);
            // 
            // btn_optionen
            // 
            this.btn_optionen.BackColor = System.Drawing.Color.Transparent;
            this.btn_optionen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_optionen.BackgroundImage")));
            this.btn_optionen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_optionen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_optionen.FlatAppearance.BorderSize = 0;
            this.btn_optionen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btn_optionen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btn_optionen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_optionen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_optionen.ForeColor = System.Drawing.Color.Lime;
            this.btn_optionen.Location = new System.Drawing.Point(75, 80);
            this.btn_optionen.Name = "btn_optionen";
            this.btn_optionen.Size = new System.Drawing.Size(224, 59);
            this.btn_optionen.TabIndex = 2;
            this.btn_optionen.Text = "Optionen";
            this.btn_optionen.UseVisualStyleBackColor = false;
            this.btn_optionen.Click += new System.EventHandler(this.btn_optionen_Click);
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.Transparent;
            this.btn_start.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_start.BackgroundImage")));
            this.btn_start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_start.FlatAppearance.BorderSize = 0;
            this.btn_start.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btn_start.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.ForeColor = System.Drawing.Color.Lime;
            this.btn_start.Location = new System.Drawing.Point(75, 15);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(224, 59);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "Spiel Starten";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // Frage
            // 
            this.Frage.Enabled = true;
            this.Frage.Tick += new System.EventHandler(this.Frage_Tick);
            // 
            // top_style
            // 
            this.top_style.BackColor = System.Drawing.Color.Maroon;
            this.top_style.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.top_style.Location = new System.Drawing.Point(0, 68);
            this.top_style.Name = "top_style";
            this.top_style.Size = new System.Drawing.Size(370, 5);
            this.top_style.TabIndex = 1;
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(370, 420);
            this.Controls.Add(this.Panel_inhalt);
            this.Controls.Add(this.Panel_footer);
            this.Controls.Add(this.Panel_Header);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(395, 1038);
            this.MinimumSize = new System.Drawing.Size(386, 450);
            this.Name = "Start";
            this.Text = "Start";
            this.VisibleChanged += new System.EventHandler(this.Start_VisibleChanged);
            this.Panel_Header.ResumeLayout(false);
            this.Panel_footer.ResumeLayout(false);
            this.Panel_inhalt.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Header;
        private System.Windows.Forms.Label Label_titel;
        private System.Windows.Forms.Panel Panel_footer;
        private System.Windows.Forms.Panel Panel_inhalt;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_credits;
        private System.Windows.Forms.Button btn_hilfe;
        private System.Windows.Forms.Button btn_optionen;
        private Panel panel1;
        private Label label_feature;
        private Timer Frage;
        private Panel top_style;
    }
}