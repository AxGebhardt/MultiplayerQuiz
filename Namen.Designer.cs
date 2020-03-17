namespace Quiz
{
    partial class Namen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Namen));
            this.titel_label = new System.Windows.Forms.Label();
            this.Bottom_panel = new System.Windows.Forms.Panel();
            this.Top_panel = new System.Windows.Forms.Panel();
            this.inhalt_panel = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label_teamA = new System.Windows.Forms.Label();
            this.label_teamB = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Bottom_panel.SuspendLayout();
            this.Top_panel.SuspendLayout();
            this.inhalt_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titel_label
            // 
            this.titel_label.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titel_label.ForeColor = System.Drawing.Color.Lime;
            this.titel_label.Location = new System.Drawing.Point(1, 3);
            this.titel_label.Name = "titel_label";
            this.titel_label.Size = new System.Drawing.Size(433, 58);
            this.titel_label.TabIndex = 0;
            this.titel_label.Text = "Geben Sie zwei Teamnamen ein um zu beginnen";
            this.titel_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Bottom_panel
            // 
            this.Bottom_panel.Controls.Add(this.panel1);
            this.Bottom_panel.Controls.Add(this.btn_start);
            this.Bottom_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Bottom_panel.Location = new System.Drawing.Point(0, 172);
            this.Bottom_panel.Name = "Bottom_panel";
            this.Bottom_panel.Size = new System.Drawing.Size(434, 62);
            this.Bottom_panel.TabIndex = 1;
            // 
            // Top_panel
            // 
            this.Top_panel.Controls.Add(this.titel_label);
            this.Top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Top_panel.Location = new System.Drawing.Point(0, 0);
            this.Top_panel.Name = "Top_panel";
            this.Top_panel.Size = new System.Drawing.Size(434, 64);
            this.Top_panel.TabIndex = 2;
            // 
            // inhalt_panel
            // 
            this.inhalt_panel.Controls.Add(this.panel2);
            this.inhalt_panel.Controls.Add(this.label_teamB);
            this.inhalt_panel.Controls.Add(this.label_teamA);
            this.inhalt_panel.Controls.Add(this.textBox2);
            this.inhalt_panel.Controls.Add(this.textBox1);
            this.inhalt_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inhalt_panel.Location = new System.Drawing.Point(0, 64);
            this.inhalt_panel.Name = "inhalt_panel";
            this.inhalt_panel.Size = new System.Drawing.Size(434, 108);
            this.inhalt_panel.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(61, 49);
            this.textBox1.MaxLength = 10;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(259, 49);
            this.textBox2.MaxLength = 10;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_teamA
            // 
            this.label_teamA.AutoSize = true;
            this.label_teamA.ForeColor = System.Drawing.Color.Lime;
            this.label_teamA.Location = new System.Drawing.Point(87, 33);
            this.label_teamA.Name = "label_teamA";
            this.label_teamA.Size = new System.Drawing.Size(44, 13);
            this.label_teamA.TabIndex = 2;
            this.label_teamA.Text = "Team A";
            // 
            // label_teamB
            // 
            this.label_teamB.AutoSize = true;
            this.label_teamB.ForeColor = System.Drawing.Color.Lime;
            this.label_teamB.Location = new System.Drawing.Point(289, 33);
            this.label_teamB.Name = "label_teamB";
            this.label_teamB.Size = new System.Drawing.Size(44, 13);
            this.label_teamB.TabIndex = 3;
            this.label_teamB.Text = "Team B";
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
            this.btn_start.Location = new System.Drawing.Point(152, 12);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(126, 38);
            this.btn_start.TabIndex = 3;
            this.btn_start.Text = "Spielen";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 5);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(434, 5);
            this.panel2.TabIndex = 4;
            // 
            // Namen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(434, 234);
            this.ControlBox = false;
            this.Controls.Add(this.inhalt_panel);
            this.Controls.Add(this.Top_panel);
            this.Controls.Add(this.Bottom_panel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(450, 250);
            this.MinimumSize = new System.Drawing.Size(450, 250);
            this.Name = "Namen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Bottom_panel.ResumeLayout(false);
            this.Top_panel.ResumeLayout(false);
            this.inhalt_panel.ResumeLayout(false);
            this.inhalt_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titel_label;
        private System.Windows.Forms.Panel Bottom_panel;
        private System.Windows.Forms.Panel Top_panel;
        private System.Windows.Forms.Panel inhalt_panel;
        private System.Windows.Forms.Label label_teamB;
        private System.Windows.Forms.Label label_teamA;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}