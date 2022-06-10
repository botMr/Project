namespace BloodGun_PORT
{
    partial class Level1
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
            // Competences
            Competences.bg_change_completion("Check_info", Competences.records[0]);
            Competences.bg_change_completion("Check_info", Competences.records[1]);

            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Level1));
            this.button1 = new System.Windows.Forms.Button();
            this.LabelSoika = new System.Windows.Forms.Label();
            this.Label2Soika = new System.Windows.Forms.Label();
            this.Soika = new System.Windows.Forms.Button();
            this.LabelCount = new System.Windows.Forms.Label();
            this.StartBattle = new System.Windows.Forms.Button();
            this.Zvezda = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Elf = new System.Windows.Forms.Button();
            this.pictureBoxWin = new System.Windows.Forms.PictureBox();
            this.buttonExicute = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBoxWIKI1 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonExit4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWIKI1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 97);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LabelSoika
            // 
            this.LabelSoika.AutoSize = true;
            this.LabelSoika.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(36)))), ((int)(((byte)(29)))));
            this.LabelSoika.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelSoika.Location = new System.Drawing.Point(577, 189);
            this.LabelSoika.Name = "LabelSoika";
            this.LabelSoika.Size = new System.Drawing.Size(17, 18);
            this.LabelSoika.TabIndex = 1;
            this.LabelSoika.Text = "n";
            this.LabelSoika.Click += new System.EventHandler(this.label1_Click);
            // 
            // Label2Soika
            // 
            this.Label2Soika.AutoSize = true;
            this.Label2Soika.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(36)))), ((int)(((byte)(29)))));
            this.Label2Soika.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label2Soika.Location = new System.Drawing.Point(421, 235);
            this.Label2Soika.Name = "Label2Soika";
            this.Label2Soika.Size = new System.Drawing.Size(17, 18);
            this.Label2Soika.TabIndex = 2;
            this.Label2Soika.Text = "n";
            // 
            // Soika
            // 
            this.Soika.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Soika.BackgroundImage")));
            this.Soika.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Soika.FlatAppearance.BorderSize = 0;
            this.Soika.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Soika.Location = new System.Drawing.Point(405, 287);
            this.Soika.Name = "Soika";
            this.Soika.Size = new System.Drawing.Size(114, 225);
            this.Soika.TabIndex = 3;
            this.Soika.UseVisualStyleBackColor = true;
            this.Soika.Click += new System.EventHandler(this.button2_Click);
            // 
            // LabelCount
            // 
            this.LabelCount.AutoSize = true;
            this.LabelCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(36)))), ((int)(((byte)(29)))));
            this.LabelCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCount.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LabelCount.Location = new System.Drawing.Point(654, 211);
            this.LabelCount.Name = "LabelCount";
            this.LabelCount.Size = new System.Drawing.Size(58, 25);
            this.LabelCount.TabIndex = 4;
            this.LabelCount.Text = "0.39";
            // 
            // StartBattle
            // 
            this.StartBattle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("StartBattle.BackgroundImage")));
            this.StartBattle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StartBattle.FlatAppearance.BorderSize = 0;
            this.StartBattle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartBattle.Location = new System.Drawing.Point(417, 518);
            this.StartBattle.Name = "StartBattle";
            this.StartBattle.Size = new System.Drawing.Size(254, 69);
            this.StartBattle.TabIndex = 5;
            this.StartBattle.UseVisualStyleBackColor = true;
            this.StartBattle.Click += new System.EventHandler(this.button3_Click);
            // 
            // Zvezda
            // 
            this.Zvezda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Zvezda.BackgroundImage")));
            this.Zvezda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Zvezda.FlatAppearance.BorderSize = 0;
            this.Zvezda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Zvezda.Location = new System.Drawing.Point(285, 287);
            this.Zvezda.Name = "Zvezda";
            this.Zvezda.Size = new System.Drawing.Size(114, 225);
            this.Zvezda.TabIndex = 6;
            this.Zvezda.UseVisualStyleBackColor = true;
            this.Zvezda.Click += new System.EventHandler(this.Zvezda_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(156, 287);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 225);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Elf
            // 
            this.Elf.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Elf.BackgroundImage")));
            this.Elf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Elf.FlatAppearance.BorderSize = 0;
            this.Elf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Elf.Location = new System.Drawing.Point(27, 287);
            this.Elf.Name = "Elf";
            this.Elf.Size = new System.Drawing.Size(114, 225);
            this.Elf.TabIndex = 8;
            this.Elf.UseVisualStyleBackColor = true;
            this.Elf.Click += new System.EventHandler(this.Elf_Click);
            // 
            // pictureBoxWin
            // 
            this.pictureBoxWin.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxWin.Image")));
            this.pictureBoxWin.Location = new System.Drawing.Point(314, 3);
            this.pictureBoxWin.Name = "pictureBoxWin";
            this.pictureBoxWin.Size = new System.Drawing.Size(442, 395);
            this.pictureBoxWin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxWin.TabIndex = 9;
            this.pictureBoxWin.TabStop = false;
            this.pictureBoxWin.Visible = false;
            // 
            // buttonExicute
            // 
            this.buttonExicute.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonExicute.BackgroundImage")));
            this.buttonExicute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonExicute.FlatAppearance.BorderSize = 0;
            this.buttonExicute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExicute.Location = new System.Drawing.Point(363, 414);
            this.buttonExicute.Name = "buttonExicute";
            this.buttonExicute.Size = new System.Drawing.Size(156, 62);
            this.buttonExicute.TabIndex = 10;
            this.buttonExicute.UseVisualStyleBackColor = true;
            this.buttonExicute.Visible = false;
            this.buttonExicute.Click += new System.EventHandler(this.buttonExicute_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonNext.BackgroundImage")));
            this.buttonNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonNext.FlatAppearance.BorderSize = 0;
            this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNext.Location = new System.Drawing.Point(556, 414);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(156, 62);
            this.buttonNext.TabIndex = 11;
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Visible = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(106)))), ((int)(((byte)(45)))));
            this.pictureBox1.Location = new System.Drawing.Point(156, 526);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 69);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(106)))), ((int)(((byte)(45)))));
            this.pictureBox2.Location = new System.Drawing.Point(87, 526);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(63, 69);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(106)))), ((int)(((byte)(45)))));
            this.pictureBox3.Location = new System.Drawing.Point(27, 526);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(61, 69);
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(271, 526);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 61);
            this.button3.TabIndex = 15;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // pictureBoxWIKI1
            // 
            this.pictureBoxWIKI1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxWIKI1.Image")));
            this.pictureBoxWIKI1.Location = new System.Drawing.Point(147, 3);
            this.pictureBoxWIKI1.Name = "pictureBoxWIKI1";
            this.pictureBoxWIKI1.Size = new System.Drawing.Size(786, 560);
            this.pictureBoxWIKI1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxWIKI1.TabIndex = 16;
            this.pictureBoxWIKI1.TabStop = false;
            this.pictureBoxWIKI1.Visible = false;
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(20, 124);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 95);
            this.button4.TabIndex = 17;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonExit4
            // 
            this.buttonExit4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonExit4.BackgroundImage")));
            this.buttonExit4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonExit4.FlatAppearance.BorderSize = 0;
            this.buttonExit4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit4.Location = new System.Drawing.Point(867, 3);
            this.buttonExit4.Name = "buttonExit4";
            this.buttonExit4.Size = new System.Drawing.Size(66, 72);
            this.buttonExit4.TabIndex = 18;
            this.buttonExit4.UseVisualStyleBackColor = true;
            this.buttonExit4.Visible = false;
            this.buttonExit4.Click += new System.EventHandler(this.buttonExit4_Click);
            // 
            // Level1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 607);
            this.ControlBox = false;
            this.Controls.Add(this.buttonExit4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.pictureBoxWIKI1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonExicute);
            this.Controls.Add(this.pictureBoxWin);
            this.Controls.Add(this.Elf);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Zvezda);
            this.Controls.Add(this.StartBattle);
            this.Controls.Add(this.LabelCount);
            this.Controls.Add(this.Soika);
            this.Controls.Add(this.Label2Soika);
            this.Controls.Add(this.LabelSoika);
            this.Controls.Add(this.button1);
            this.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Level1";
            this.Text = "Level1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWIKI1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LabelSoika;
        private System.Windows.Forms.Label Label2Soika;
        private System.Windows.Forms.Button Soika;
        private System.Windows.Forms.Label LabelCount;
        private System.Windows.Forms.Button StartBattle;
        private System.Windows.Forms.Button Zvezda;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Elf;
        private System.Windows.Forms.PictureBox pictureBoxWin;
        private System.Windows.Forms.Button buttonExicute;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBoxWIKI1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonExit4;
    }
}