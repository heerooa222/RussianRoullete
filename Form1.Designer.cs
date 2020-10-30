namespace RussianRoullete
{
    partial class Form1
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
            this.fire_button = new System.Windows.Forms.Button();
            this.play_again_button = new System.Windows.Forms.Button();
            this.spin_button = new System.Windows.Forms.Button();
            this.load_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.win_lbl = new System.Windows.Forms.Label();
            this.randon_number_lbl = new System.Windows.Forms.Label();
            this.lose_lbl = new System.Windows.Forms.Label();
            this.bullets_fired_lbl = new System.Windows.Forms.Label();
            this.total_lbl = new System.Windows.Forms.Label();
            this.win_ans_lbl = new System.Windows.Forms.Label();
            this.Ran_ans_lbl = new System.Windows.Forms.Label();
            this.lose_ans_lbl = new System.Windows.Forms.Label();
            this.total_ans_lbl = new System.Windows.Forms.Label();
            this.bullet_ans_lbl = new System.Windows.Forms.Label();
            this.lblRandom = new System.Windows.Forms.Label();
            this.lbl_bullets_fired = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // fire_button
            // 
            this.fire_button.Location = new System.Drawing.Point(655, 24);
            this.fire_button.Name = "fire_button";
            this.fire_button.Size = new System.Drawing.Size(104, 60);
            this.fire_button.TabIndex = 0;
            this.fire_button.Text = "Fire";
            this.fire_button.UseVisualStyleBackColor = true;
            this.fire_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // play_again_button
            // 
            this.play_again_button.Location = new System.Drawing.Point(655, 152);
            this.play_again_button.Name = "play_again_button";
            this.play_again_button.Size = new System.Drawing.Size(104, 61);
            this.play_again_button.TabIndex = 1;
            this.play_again_button.Text = "Play again";
            this.play_again_button.UseVisualStyleBackColor = true;
            this.play_again_button.Click += new System.EventHandler(this.play_again_button_Click);
            // 
            // spin_button
            // 
            this.spin_button.Location = new System.Drawing.Point(655, 90);
            this.spin_button.Name = "spin_button";
            this.spin_button.Size = new System.Drawing.Size(104, 56);
            this.spin_button.TabIndex = 2;
            this.spin_button.Text = "Spin Chambers";
            this.spin_button.UseVisualStyleBackColor = true;
            this.spin_button.Click += new System.EventHandler(this.spin_button_Click);
            // 
            // load_button
            // 
            this.load_button.Location = new System.Drawing.Point(655, 219);
            this.load_button.Name = "load_button";
            this.load_button.Size = new System.Drawing.Size(104, 56);
            this.load_button.TabIndex = 4;
            this.load_button.Text = "Load Bullets";
            this.load_button.UseVisualStyleBackColor = true;
            this.load_button.Click += new System.EventHandler(this.load_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RussianRoullete.Properties.Resources.open;
            this.pictureBox1.Location = new System.Drawing.Point(78, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(551, 263);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // win_lbl
            // 
            this.win_lbl.AutoSize = true;
            this.win_lbl.Location = new System.Drawing.Point(25, 307);
            this.win_lbl.Name = "win_lbl";
            this.win_lbl.Size = new System.Drawing.Size(35, 17);
            this.win_lbl.TabIndex = 5;
            this.win_lbl.Text = "wins";
            this.win_lbl.Click += new System.EventHandler(this.win_lbl_Click);
            // 
            // randon_number_lbl
            // 
            this.randon_number_lbl.AutoSize = true;
            this.randon_number_lbl.Location = new System.Drawing.Point(131, 307);
            this.randon_number_lbl.Name = "randon_number_lbl";
            this.randon_number_lbl.Size = new System.Drawing.Size(113, 17);
            this.randon_number_lbl.TabIndex = 6;
            this.randon_number_lbl.Text = "Random number";
            this.randon_number_lbl.Click += new System.EventHandler(this.randon_number_lbl_Click);
            // 
            // lose_lbl
            // 
            this.lose_lbl.AutoSize = true;
            this.lose_lbl.Location = new System.Drawing.Point(75, 307);
            this.lose_lbl.Name = "lose_lbl";
            this.lose_lbl.Size = new System.Drawing.Size(34, 17);
            this.lose_lbl.TabIndex = 7;
            this.lose_lbl.Text = "lose";
            // 
            // bullets_fired_lbl
            // 
            this.bullets_fired_lbl.AutoSize = true;
            this.bullets_fired_lbl.Location = new System.Drawing.Point(333, 307);
            this.bullets_fired_lbl.Name = "bullets_fired_lbl";
            this.bullets_fired_lbl.Size = new System.Drawing.Size(81, 17);
            this.bullets_fired_lbl.TabIndex = 8;
            this.bullets_fired_lbl.Text = "bullets fired";
            // 
            // total_lbl
            // 
            this.total_lbl.AutoSize = true;
            this.total_lbl.Location = new System.Drawing.Point(265, 307);
            this.total_lbl.Name = "total_lbl";
            this.total_lbl.Size = new System.Drawing.Size(40, 17);
            this.total_lbl.TabIndex = 9;
            this.total_lbl.Text = "Total";
            // 
            // win_ans_lbl
            // 
            this.win_ans_lbl.AutoSize = true;
            this.win_ans_lbl.Location = new System.Drawing.Point(15, 352);
            this.win_ans_lbl.Name = "win_ans_lbl";
            this.win_ans_lbl.Size = new System.Drawing.Size(0, 17);
            this.win_ans_lbl.TabIndex = 10;
            // 
            // Ran_ans_lbl
            // 
            this.Ran_ans_lbl.AutoSize = true;
            this.Ran_ans_lbl.Location = new System.Drawing.Point(131, 352);
            this.Ran_ans_lbl.Name = "Ran_ans_lbl";
            this.Ran_ans_lbl.Size = new System.Drawing.Size(0, 17);
            this.Ran_ans_lbl.TabIndex = 11;
            // 
            // lose_ans_lbl
            // 
            this.lose_ans_lbl.AutoSize = true;
            this.lose_ans_lbl.Location = new System.Drawing.Point(76, 352);
            this.lose_ans_lbl.Name = "lose_ans_lbl";
            this.lose_ans_lbl.Size = new System.Drawing.Size(0, 17);
            this.lose_ans_lbl.TabIndex = 12;
            // 
            // total_ans_lbl
            // 
            this.total_ans_lbl.AutoSize = true;
            this.total_ans_lbl.Location = new System.Drawing.Point(265, 352);
            this.total_ans_lbl.Name = "total_ans_lbl";
            this.total_ans_lbl.Size = new System.Drawing.Size(0, 17);
            this.total_ans_lbl.TabIndex = 13;
            // 
            // bullet_ans_lbl
            // 
            this.bullet_ans_lbl.AutoSize = true;
            this.bullet_ans_lbl.Location = new System.Drawing.Point(333, 352);
            this.bullet_ans_lbl.Name = "bullet_ans_lbl";
            this.bullet_ans_lbl.Size = new System.Drawing.Size(0, 17);
            this.bullet_ans_lbl.TabIndex = 14;
            // 
            // lblRandom
            // 
            this.lblRandom.AutoSize = true;
            this.lblRandom.Location = new System.Drawing.Point(137, 337);
            this.lblRandom.Name = "lblRandom";
            this.lblRandom.Size = new System.Drawing.Size(0, 17);
            this.lblRandom.TabIndex = 15;
            // 
            // lbl_bullets_fired
            // 
            this.lbl_bullets_fired.AutoSize = true;
            this.lbl_bullets_fired.Location = new System.Drawing.Point(339, 337);
            this.lbl_bullets_fired.Name = "lbl_bullets_fired";
            this.lbl_bullets_fired.Size = new System.Drawing.Size(0, 17);
            this.lbl_bullets_fired.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "o";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "o";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "o";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "o";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(333, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "o";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 429);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_bullets_fired);
            this.Controls.Add(this.lblRandom);
            this.Controls.Add(this.bullet_ans_lbl);
            this.Controls.Add(this.total_ans_lbl);
            this.Controls.Add(this.lose_ans_lbl);
            this.Controls.Add(this.Ran_ans_lbl);
            this.Controls.Add(this.win_ans_lbl);
            this.Controls.Add(this.total_lbl);
            this.Controls.Add(this.bullets_fired_lbl);
            this.Controls.Add(this.lose_lbl);
            this.Controls.Add(this.randon_number_lbl);
            this.Controls.Add(this.win_lbl);
            this.Controls.Add(this.load_button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.spin_button);
            this.Controls.Add(this.play_again_button);
            this.Controls.Add(this.fire_button);
            this.Name = "Form1";
            this.Text = "russianroulette";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fire_button;
        private System.Windows.Forms.Button play_again_button;
        private System.Windows.Forms.Button spin_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button load_button;
        private System.Windows.Forms.Label win_lbl;
        private System.Windows.Forms.Label randon_number_lbl;
        private System.Windows.Forms.Label lose_lbl;
        private System.Windows.Forms.Label bullets_fired_lbl;
        private System.Windows.Forms.Label total_lbl;
        private System.Windows.Forms.Label win_ans_lbl;
        private System.Windows.Forms.Label Ran_ans_lbl;
        private System.Windows.Forms.Label lose_ans_lbl;
        private System.Windows.Forms.Label total_ans_lbl;
        private System.Windows.Forms.Label bullet_ans_lbl;
        private System.Windows.Forms.Label lblRandom;
        private System.Windows.Forms.Label lbl_bullets_fired;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

