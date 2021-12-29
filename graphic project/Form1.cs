using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graphic_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        Random r = new Random();
        int fireCount = 0;
        int point = 0;
        void moveEnemy(PictureBox enemy)
        {

            if (enemy.Left >= 0)
            {
                enemy.Left -= (10+(5*(Convert.ToInt32(label1.Text)/10)));
            }
            else
            {
                enemy.Location = new Point(800, r.Next(100, this.Height - 60));
            }
            if (player.Bounds.IntersectsWith(enemy.Bounds))
            {
                player.Image = Properties.Resources._checked;
                faild.Visible = true;
                enemytimer.Stop();
                fire1.Stop();
                fire1p.Visible = false;
                fire2.Stop();
                fire2p.Visible = false;
                fire3.Stop();
                fire3p.Visible = false;
            }
            if (fire1p.Bounds.IntersectsWith(enemy.Bounds) && fire1p.Visible == true)
            {
                point++;
                label1.Text = point.ToString();
                fire1.Stop();
                fire1p.Visible = false;
                enemy.Location = new Point(800, r.Next(100, this.Height - 60));
            }
            else if (fire2p.Bounds.IntersectsWith(enemy.Bounds) && fire2p.Visible == true)
            {
                point++;
                label1.Text = point.ToString();
                fire2.Stop();
                fire2p.Visible = false;
                enemy.Location = new Point(800, r.Next(100, this.Height - 60));
            }
            else if (fire3p.Bounds.IntersectsWith(enemy.Bounds) && fire3p.Visible == true)
            {
                point++;
                label1.Text = point.ToString();
                fire3.Stop();
                fire3p.Visible = false;
                enemy.Location = new Point(800, r.Next(100, this.Height - 60));
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (faild.Visible == false)
            {
                if (e.KeyCode == Keys.Up)
                {
                    if (player.Top >= 0)
                    {
                        player.Top -= 15;
                    }
                }
                if (e.KeyCode == Keys.Down)
                {
                    if (player.Top <= this.Height - 90)
                    {
                        player.Top += 8;
                    }
                }
                if (e.KeyCode == Keys.Space)
                {
                    if (fireCount == 0)
                    {
                        fire1.Start();
                        fire1p.Location = player.Location;
                        fireCount++;
                    }
                    else if (fireCount == 1)
                    {
                        fire2.Start();
                        fire2p.Location = player.Location;
                        fireCount++;
                    }
                    else if (fireCount == 2)
                    {
                        fire3.Start();
                        fire3p.Location = player.Location;
                        fireCount = 0;
                    }
                }
            }
        }

        private void enemytimer_Tick(object sender, EventArgs e)
        {
            moveEnemy(enemy1);
            moveEnemy(enemy2);
            moveEnemy(enemy3);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fire1_Tick(object sender, EventArgs e)
        {
            fire1p.Visible = true;
            fire1p.Left += 30;
        }

        private void fire2_Tick(object sender, EventArgs e)
        {
            fire2p.Visible = true;
            fire2p.Left += 30;
        }

        private void fire3_Tick(object sender, EventArgs e)
        {
            fire3p.Visible = true;
            fire3p.Left += 30;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void enemy2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
