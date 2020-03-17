namespace Quiz
{
    partial class Endstand
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Endstand));
            this.Top_panel = new System.Windows.Forms.Panel();
            this.Bottom_panel = new System.Windows.Forms.Panel();
            this.Main_panel = new System.Windows.Forms.Panel();
            this.Pokal = new System.Windows.Forms.PictureBox();
            this.label_gewinner = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.top_style = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_gewinner_ausgabe = new System.Windows.Forms.Label();
            this.Top_panel.SuspendLayout();
            this.Bottom_panel.SuspendLayout();
            this.Main_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pokal)).BeginInit();
            this.SuspendLayout();
            // 
            // Top_panel
            // 
            this.Top_panel.Controls.Add(this.top_style);
            this.Top_panel.Controls.Add(this.label1);
            this.Top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Top_panel.Location = new System.Drawing.Point(0, 0);
            this.Top_panel.Name = "Top_panel";
            this.Top_panel.Size = new System.Drawing.Size(552, 67);
            this.Top_panel.TabIndex = 0;
            // 
            // Bottom_panel
            // 
            this.Bottom_panel.Controls.Add(this.label_gewinner_ausgabe);
            this.Bottom_panel.Controls.Add(this.panel1);
            this.Bottom_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Bottom_panel.Location = new System.Drawing.Point(0, 436);
            this.Bottom_panel.Name = "Bottom_panel";
            this.Bottom_panel.Size = new System.Drawing.Size(552, 58);
            this.Bottom_panel.TabIndex = 1;
            // 
            // Main_panel
            // 
            this.Main_panel.Controls.Add(this.label_gewinner);
            this.Main_panel.Controls.Add(this.Pokal);
            this.Main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_panel.Location = new System.Drawing.Point(0, 67);
            this.Main_panel.Name = "Main_panel";
            this.Main_panel.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.Main_panel.Size = new System.Drawing.Size(552, 369);
            this.Main_panel.TabIndex = 2;
            // 
            // Pokal
            // 
            this.Pokal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pokal.Image = ((System.Drawing.Image)(resources.GetObject("Pokal.Image")));
            this.Pokal.Location = new System.Drawing.Point(0, 15);
            this.Pokal.Name = "Pokal";
            this.Pokal.Size = new System.Drawing.Size(552, 354);
            this.Pokal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pokal.TabIndex = 0;
            this.Pokal.TabStop = false;
            // 
            // label_gewinner
            // 
            this.label_gewinner.BackColor = System.Drawing.Color.White;
            this.label_gewinner.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_gewinner.ForeColor = System.Drawing.Color.Gold;
            this.label_gewinner.Location = new System.Drawing.Point(192, 319);
            this.label_gewinner.Name = "label_gewinner";
            this.label_gewinner.Size = new System.Drawing.Size(167, 29);
            this.label_gewinner.TabIndex = 1;
            this.label_gewinner.Text = "Test";
            this.label_gewinner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(552, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "Endstand";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // top_style
            // 
            this.top_style.BackColor = System.Drawing.Color.Maroon;
            this.top_style.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.top_style.Location = new System.Drawing.Point(0, 62);
            this.top_style.Name = "top_style";
            this.top_style.Size = new System.Drawing.Size(552, 5);
            this.top_style.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 5);
            this.panel1.TabIndex = 0;
            // 
            // label_gewinner_ausgabe
            // 
            this.label_gewinner_ausgabe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_gewinner_ausgabe.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_gewinner_ausgabe.ForeColor = System.Drawing.Color.Lime;
            this.label_gewinner_ausgabe.Location = new System.Drawing.Point(0, 5);
            this.label_gewinner_ausgabe.Name = "label_gewinner_ausgabe";
            this.label_gewinner_ausgabe.Size = new System.Drawing.Size(552, 53);
            this.label_gewinner_ausgabe.TabIndex = 1;
            this.label_gewinner_ausgabe.Text = "Test hat Gewonnen!";
            this.label_gewinner_ausgabe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Endstand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(552, 494);
            this.Controls.Add(this.Main_panel);
            this.Controls.Add(this.Bottom_panel);
            this.Controls.Add(this.Top_panel);
            this.Name = "Endstand";
            this.Text = "Endstand";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Endstand_FormClosed);
            this.Top_panel.ResumeLayout(false);
            this.Bottom_panel.ResumeLayout(false);
            this.Main_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pokal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Top_panel;
        private System.Windows.Forms.Panel Bottom_panel;
        private System.Windows.Forms.Panel Main_panel;
        private System.Windows.Forms.Label label_gewinner;
        private System.Windows.Forms.PictureBox Pokal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel top_style;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_gewinner_ausgabe;
    }
}