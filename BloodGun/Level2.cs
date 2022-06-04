using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodGun_PORT
{
    public partial class Level2 : Form
    {
        public Level2()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Settings settings= new Settings();
            settings.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LabelSoika3.Text = "25";
            LabelSoika4.Text = "25";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LabelSoika3.Text = "4";
            LabelSoika4.Text = "4";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LabelSoika3.Text = "20";
            LabelSoika4.Text = "20";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LabelSoika3.Text = "10";
            LabelSoika4.Text = "10";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if ((LabelSoika3.Text == "25") && (LabelSoika4.Text == "25"))
            {
                LabelCount2.Text = "0.07";
                button1.Visible = false;
                pictureBox1.Visible = true;
            }
            else if ((LabelSoika3.Text == "20") && (LabelSoika4.Text == "20"))
            {
                LabelCount2.Text = "0.13";
                button2.Visible = false;
                pictureBox2.Visible = true;
            }
            else if ((LabelSoika3.Text == "4") && (LabelSoika4.Text == "4"))
            {
                LabelCount2.Text = "0.15";
                button4.Visible = false;
                pictureBox3.Visible = true;
            }
            else if ((LabelSoika3.Text == "10") && (LabelSoika4.Text == "10"))
            {
                button2.Visible = false;
                button1.Visible = false;
                pictureBoxWin2.Visible = true;
                buttonExicute2.Visible = true;
                buttonAchievements.Visible = true;
            }
            if ((pictureBox1.Visible == true) && (pictureBox2.Visible == true) && (pictureBox3.Visible == true))
            {
                button7.Visible = true;
            }
            }

        private void buttonExicute2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Data.Restart = Data.Restart + 1;
            Hide();
            Level2 level2 = new Level2();
            level2.Show();
        }

        private void buttonAchievements_Click(object sender, EventArgs e)
        {
            if ((pictureBox1.Visible == false) && (pictureBox2.Visible == false) && (pictureBox3.Visible == false))
            {
                Data.Rate = Data.Rate + 1;
            }
            if ((pictureBox1.Visible == false) && (pictureBox2.Visible == false) && (pictureBox3.Visible == true))
            {
                Data.Rate = Data.Rate + 0.8;
            }
            if ((pictureBox1.Visible == false) && (pictureBox2.Visible == true) && (pictureBox3.Visible == true))
            {
                Data.Rate = Data.Rate + 0.6;
            }
            if ((pictureBox1.Visible == true) && (pictureBox2.Visible == true) && (pictureBox3.Visible == true))
            {
                Data.Rate = Data.Rate + 0;
            }
            Data.Complete = Data.Complete + 1;
            this.Hide();
            Achievements achievements = new Achievements();
            achievements.Show();
        }
    }
}
