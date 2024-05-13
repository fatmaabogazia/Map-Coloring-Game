namespace Coloring_Map_AI
{
    partial class Map_Coloring
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ai_butt = new System.Windows.Forms.Button();
            this.ReturnButtom = new System.Windows.Forms.Button();
            this.CrossButtom = new System.Windows.Forms.Button();
            this.ChooseColor = new Coloring_Map_AI.MapColoring();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BlueLabel = new Coloring_Map_AI.MapColoring();
            this.GreenLabel = new Coloring_Map_AI.MapColoring();
            this.RedLabel = new Coloring_Map_AI.MapColoring();
            this.djibouti = new Coloring_Map_AI.MapColoring();
            this.libya = new Coloring_Map_AI.MapColoring();
            this.tunisia = new Coloring_Map_AI.MapColoring();
            this.palestine = new Coloring_Map_AI.MapColoring();
            this.jordon = new Coloring_Map_AI.MapColoring();
            this.egypt = new Coloring_Map_AI.MapColoring();
            this.submit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel1.Controls.Add(this.ai_butt);
            this.panel1.Controls.Add(this.ReturnButtom);
            this.panel1.Controls.Add(this.CrossButtom);
            this.panel1.Controls.Add(this.ChooseColor);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.BlueLabel);
            this.panel1.Controls.Add(this.GreenLabel);
            this.panel1.Controls.Add(this.RedLabel);
            this.panel1.Controls.Add(this.djibouti);
            this.panel1.Controls.Add(this.libya);
            this.panel1.Controls.Add(this.tunisia);
            this.panel1.Controls.Add(this.palestine);
            this.panel1.Controls.Add(this.jordon);
            this.panel1.Controls.Add(this.egypt);
            this.panel1.Controls.Add(this.submit);
            this.panel1.Location = new System.Drawing.Point(98, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(517, 535);
            this.panel1.TabIndex = 0;
            // 
            // ai_butt
            // 
            this.ai_butt.BackColor = System.Drawing.Color.MistyRose;
            this.ai_butt.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ai_butt.Location = new System.Drawing.Point(393, 476);
            this.ai_butt.Name = "ai_butt";
            this.ai_butt.Size = new System.Drawing.Size(111, 43);
            this.ai_butt.TabIndex = 14;
            this.ai_butt.Text = "Solve The Map";
            this.ai_butt.UseVisualStyleBackColor = false;
            this.ai_butt.Click += new System.EventHandler(this.ai_butt_Click);
            // 
            // ReturnButtom
            // 
            this.ReturnButtom.BackColor = System.Drawing.Color.MistyRose;
            this.ReturnButtom.Image = global::Coloring_Map_AI.Properties.Resources.ReturnImageN31;
            this.ReturnButtom.Location = new System.Drawing.Point(16, 12);
            this.ReturnButtom.Name = "ReturnButtom";
            this.ReturnButtom.Size = new System.Drawing.Size(47, 50);
            this.ReturnButtom.TabIndex = 1;
            this.ReturnButtom.UseVisualStyleBackColor = false;
            this.ReturnButtom.Click += new System.EventHandler(this.ReturnButtom_Click);
            // 
            // CrossButtom
            // 
            this.CrossButtom.Image = global::Coloring_Map_AI.Properties.Resources.croosImgN;
            this.CrossButtom.Location = new System.Drawing.Point(457, 12);
            this.CrossButtom.Name = "CrossButtom";
            this.CrossButtom.Size = new System.Drawing.Size(47, 50);
            this.CrossButtom.TabIndex = 13;
            this.CrossButtom.UseVisualStyleBackColor = true;
            this.CrossButtom.Click += new System.EventHandler(this.CrossButtom_Click);
            // 
            // ChooseColor
            // 
            this.ChooseColor.AutoSize = true;
            this.ChooseColor.ForeColor = System.Drawing.Color.Black;
            this.ChooseColor.Location = new System.Drawing.Point(58, 371);
            this.ChooseColor.MaximumSize = new System.Drawing.Size(170, 40);
            this.ChooseColor.Name = "ChooseColor";
            this.ChooseColor.Size = new System.Drawing.Size(162, 40);
            this.ChooseColor.TabIndex = 12;
            this.ChooseColor.Text = "Choose The Color ,\r\nThen Choose The Region\r\n\r\n";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Blue"});
            this.comboBox1.Location = new System.Drawing.Point(61, 414);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(138, 24);
            this.comboBox1.TabIndex = 10;
            // 
            // BlueLabel
            // 
            this.BlueLabel.AutoSize = true;
            this.BlueLabel.BackColor = System.Drawing.Color.Blue;
            this.BlueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BlueLabel.Location = new System.Drawing.Point(168, 466);
            this.BlueLabel.MinimumSize = new System.Drawing.Size(70, 40);
            this.BlueLabel.Name = "BlueLabel";
            this.BlueLabel.Size = new System.Drawing.Size(70, 40);
            this.BlueLabel.TabIndex = 9;
            // 
            // GreenLabel
            // 
            this.GreenLabel.AutoSize = true;
            this.GreenLabel.BackColor = System.Drawing.Color.Green;
            this.GreenLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GreenLabel.Location = new System.Drawing.Point(92, 466);
            this.GreenLabel.MinimumSize = new System.Drawing.Size(70, 40);
            this.GreenLabel.Name = "GreenLabel";
            this.GreenLabel.Size = new System.Drawing.Size(70, 40);
            this.GreenLabel.TabIndex = 8;
            // 
            // RedLabel
            // 
            this.RedLabel.AutoSize = true;
            this.RedLabel.BackColor = System.Drawing.Color.Red;
            this.RedLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RedLabel.Location = new System.Drawing.Point(16, 466);
            this.RedLabel.MinimumSize = new System.Drawing.Size(70, 40);
            this.RedLabel.Name = "RedLabel";
            this.RedLabel.Size = new System.Drawing.Size(70, 40);
            this.RedLabel.TabIndex = 7;
            // 
            // djibouti
            // 
            this.djibouti.AutoSize = true;
            this.djibouti.BackColor = System.Drawing.Color.White;
            this.djibouti.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.djibouti.Location = new System.Drawing.Point(373, 269);
            this.djibouti.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.djibouti.MinimumSize = new System.Drawing.Size(100, 70);
            this.djibouti.Name = "djibouti";
            this.djibouti.Size = new System.Drawing.Size(100, 70);
            this.djibouti.TabIndex = 6;
            this.djibouti.Text = "Djibouti";
            this.djibouti.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.djibouti.Click += new System.EventHandler(this.djibouti_Click);
            // 
            // libya
            // 
            this.libya.AutoSize = true;
            this.libya.BackColor = System.Drawing.Color.White;
            this.libya.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.libya.Location = new System.Drawing.Point(108, 190);
            this.libya.MinimumSize = new System.Drawing.Size(100, 70);
            this.libya.Name = "libya";
            this.libya.Size = new System.Drawing.Size(100, 70);
            this.libya.TabIndex = 5;
            this.libya.Text = "Libya";
            this.libya.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.libya.Click += new System.EventHandler(this.libya_Click);
            // 
            // tunisia
            // 
            this.tunisia.AutoSize = true;
            this.tunisia.BackColor = System.Drawing.Color.White;
            this.tunisia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tunisia.Location = new System.Drawing.Point(163, 56);
            this.tunisia.MinimumSize = new System.Drawing.Size(100, 70);
            this.tunisia.Name = "tunisia";
            this.tunisia.Size = new System.Drawing.Size(100, 70);
            this.tunisia.TabIndex = 4;
            this.tunisia.Text = "Tunisia";
            this.tunisia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tunisia.Click += new System.EventHandler(this.tunisia_Click);
            // 
            // palestine
            // 
            this.palestine.AutoSize = true;
            this.palestine.BackColor = System.Drawing.Color.White;
            this.palestine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.palestine.Location = new System.Drawing.Point(263, 97);
            this.palestine.MinimumSize = new System.Drawing.Size(100, 70);
            this.palestine.Name = "palestine";
            this.palestine.Size = new System.Drawing.Size(100, 70);
            this.palestine.TabIndex = 3;
            this.palestine.Text = "Palestine";
            this.palestine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.palestine.Click += new System.EventHandler(this.palestine_Click);
            // 
            // jordon
            // 
            this.jordon.AutoSize = true;
            this.jordon.BackColor = System.Drawing.Color.White;
            this.jordon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.jordon.Location = new System.Drawing.Point(308, 167);
            this.jordon.MinimumSize = new System.Drawing.Size(100, 70);
            this.jordon.Name = "jordon";
            this.jordon.Size = new System.Drawing.Size(100, 70);
            this.jordon.TabIndex = 2;
            this.jordon.Text = "Jordon";
            this.jordon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.jordon.Click += new System.EventHandler(this.jordon_Click);
            // 
            // egypt
            // 
            this.egypt.AutoSize = true;
            this.egypt.BackColor = System.Drawing.Color.White;
            this.egypt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.egypt.Location = new System.Drawing.Point(208, 167);
            this.egypt.MinimumSize = new System.Drawing.Size(100, 70);
            this.egypt.Name = "egypt";
            this.egypt.Size = new System.Drawing.Size(100, 70);
            this.egypt.TabIndex = 1;
            this.egypt.Text = "Egypt";
            this.egypt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.egypt.Click += new System.EventHandler(this.egypt_Click);
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.Color.MistyRose;
            this.submit.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(393, 427);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(111, 43);
            this.submit.TabIndex = 0;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // Map_Coloring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 597);
            this.Controls.Add(this.panel1);
            this.Name = "Map_Coloring";
            this.Text = "Map Coloring Game";
            this.Load += new System.EventHandler(this.Map_Coloring_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MapColoring djibouti;
        private MapColoring libya;
        private MapColoring tunisia;
        private MapColoring palestine;
        private MapColoring jordon;
        private MapColoring egypt;
        private System.Windows.Forms.Button submit;
        private MapColoring BlueLabel;
        private MapColoring GreenLabel;
        private MapColoring RedLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private MapColoring ChooseColor;
        private System.Windows.Forms.Button CrossButtom;
        private System.Windows.Forms.Button ReturnButtom;
        private System.Windows.Forms.Button ai_butt;
    }
}

