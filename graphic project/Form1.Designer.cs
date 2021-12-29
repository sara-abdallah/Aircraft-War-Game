
namespace graphic_project
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.player = new System.Windows.Forms.PictureBox();
            this.fire1p = new System.Windows.Forms.PictureBox();
            this.enemy3 = new System.Windows.Forms.PictureBox();
            this.enemy2 = new System.Windows.Forms.PictureBox();
            this.enemy1 = new System.Windows.Forms.PictureBox();
            this.fire3p = new System.Windows.Forms.PictureBox();
            this.fire2p = new System.Windows.Forms.PictureBox();
            this.enemytimer = new System.Windows.Forms.Timer(this.components);
            this.fire1 = new System.Windows.Forms.Timer(this.components);
            this.fire2 = new System.Windows.Forms.Timer(this.components);
            this.fire3 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.faild = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fire1p)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fire3p)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fire2p)).BeginInit();
            this.panel1.SuspendLayout();
            this.faild.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("player.BackgroundImage")));
            this.player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.player.Location = new System.Drawing.Point(12, 205);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(128, 86);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            this.player.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // fire1p
            // 
            this.fire1p.BackColor = System.Drawing.Color.Transparent;
            this.fire1p.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fire1p.BackgroundImage")));
            this.fire1p.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fire1p.Location = new System.Drawing.Point(103, 261);
            this.fire1p.Name = "fire1p";
            this.fire1p.Size = new System.Drawing.Size(100, 30);
            this.fire1p.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fire1p.TabIndex = 3;
            this.fire1p.TabStop = false;
            this.fire1p.Visible = false;
            // 
            // enemy3
            // 
            this.enemy3.BackColor = System.Drawing.Color.Transparent;
            this.enemy3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("enemy3.BackgroundImage")));
            this.enemy3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.enemy3.Location = new System.Drawing.Point(734, 351);
            this.enemy3.Name = "enemy3";
            this.enemy3.Size = new System.Drawing.Size(100, 50);
            this.enemy3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy3.TabIndex = 4;
            this.enemy3.TabStop = false;
            this.enemy3.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // enemy2
            // 
            this.enemy2.BackColor = System.Drawing.Color.Transparent;
            this.enemy2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("enemy2.BackgroundImage")));
            this.enemy2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.enemy2.Location = new System.Drawing.Point(734, 218);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(100, 50);
            this.enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy2.TabIndex = 5;
            this.enemy2.TabStop = false;
            this.enemy2.Click += new System.EventHandler(this.enemy2_Click);
            // 
            // enemy1
            // 
            this.enemy1.BackColor = System.Drawing.Color.Transparent;
            this.enemy1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("enemy1.BackgroundImage")));
            this.enemy1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.enemy1.Location = new System.Drawing.Point(697, 81);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(100, 50);
            this.enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy1.TabIndex = 6;
            this.enemy1.TabStop = false;
            // 
            // fire3p
            // 
            this.fire3p.BackColor = System.Drawing.Color.Transparent;
            this.fire3p.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fire3p.BackgroundImage")));
            this.fire3p.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fire3p.Location = new System.Drawing.Point(103, 333);
            this.fire3p.Name = "fire3p";
            this.fire3p.Size = new System.Drawing.Size(100, 30);
            this.fire3p.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fire3p.TabIndex = 7;
            this.fire3p.TabStop = false;
            this.fire3p.Visible = false;
            // 
            // fire2p
            // 
            this.fire2p.BackColor = System.Drawing.Color.Transparent;
            this.fire2p.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fire2p.BackgroundImage")));
            this.fire2p.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fire2p.Location = new System.Drawing.Point(103, 297);
            this.fire2p.Name = "fire2p";
            this.fire2p.Size = new System.Drawing.Size(100, 30);
            this.fire2p.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fire2p.TabIndex = 8;
            this.fire2p.TabStop = false;
            this.fire2p.Visible = false;
            // 
            // enemytimer
            // 
            this.enemytimer.Enabled = true;
            this.enemytimer.Interval = 150;
            this.enemytimer.Tick += new System.EventHandler(this.enemytimer_Tick);
            // 
            // fire1
            // 
            this.fire1.Tick += new System.EventHandler(this.fire1_Tick);
            // 
            // fire2
            // 
            this.fire2.Tick += new System.EventHandler(this.fire2_Tick);
            // 
            // fire3
            // 
            this.fire3.Tick += new System.EventHandler(this.fire3_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 44);
            this.label1.TabIndex = 9;
            this.label1.Text = "0";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 42);
            this.label2.TabIndex = 11;
            this.label2.Text = "Score:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(697, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 64);
            this.panel1.TabIndex = 12;
            // 
            // faild
            // 
            this.faild.BackColor = System.Drawing.Color.Transparent;
            this.faild.Controls.Add(this.panel2);
            this.faild.Controls.Add(this.label3);
            this.faild.Location = new System.Drawing.Point(209, 133);
            this.faild.Name = "faild";
            this.faild.Size = new System.Drawing.Size(505, 268);
            this.faild.TabIndex = 13;
            this.faild.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(97, 144);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 97);
            this.panel2.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(155, 49);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 38);
            this.button3.TabIndex = 3;
            this.button3.Text = "NO";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(300, 33);
            this.label4.TabIndex = 1;
            this.label4.Text = "Would you like to play again?";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(66, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 37);
            this.button2.TabIndex = 2;
            this.button2.Text = "YES";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(490, 106);
            this.label3.TabIndex = 0;
            this.label3.Text = "GAME OVER";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(880, 557);
            this.Controls.Add(this.faild);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.fire2p);
            this.Controls.Add(this.fire3p);
            this.Controls.Add(this.enemy1);
            this.Controls.Add(this.enemy2);
            this.Controls.Add(this.enemy3);
            this.Controls.Add(this.fire1p);
            this.Controls.Add(this.player);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "War planes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fire1p)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fire3p)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fire2p)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.faild.ResumeLayout(false);
            this.faild.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox fire1p;
        private System.Windows.Forms.PictureBox enemy3;
        private System.Windows.Forms.PictureBox enemy2;
        private System.Windows.Forms.PictureBox enemy1;
        private System.Windows.Forms.PictureBox fire3p;
        private System.Windows.Forms.PictureBox fire2p;
        private System.Windows.Forms.Timer enemytimer;
        private System.Windows.Forms.Timer fire1;
        private System.Windows.Forms.Timer fire2;
        private System.Windows.Forms.Timer fire3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel faild;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
    }
}

