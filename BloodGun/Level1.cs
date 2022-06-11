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
    public partial class Level1 : Form
    {
        public Level1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Settings settings = new Settings();
            settings.Show(); 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LabelSoika.Text = "10";
            Label2Soika.Text = "10";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((LabelSoika.Text == "10") && (Label2Soika.Text == "10"))
            {
                LabelCount.Text = "0.03";
                Soika.Visible = false;
                pictureBox1.Visible = true;
            }
            else if ((LabelSoika.Text == "8") && (Label2Soika.Text == "8"))
            {
                LabelCount.Text = "0.15";
                button2.Visible = false;
                pictureBox2.Visible = true;
            }
            else if ((LabelSoika.Text == "3") && (Label2Soika.Text == "3"))
            {
                LabelCount.Text = "NaN";
                Elf.Visible = false;
                pictureBox3.Visible = true;
            }
            else if ((LabelSoika.Text == "6") && (Label2Soika.Text == "6"))
            {
                Zvezda.Visible = false;
                Soika.Visible = false;
                pictureBoxWin.Visible = true;
                buttonExicute.Visible = true;
                buttonNext.Visible = true;
            }
            if ((pictureBox1.Visible == true) && (pictureBox2.Visible == true) && (pictureBox3.Visible == true))
            {
                button3.Visible = true;
            }
        }

        private void Zvezda_Click(object sender, EventArgs e)
        {
            LabelSoika.Text = "6";
            Label2Soika.Text = "6";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            LabelSoika.Text = "8";
            Label2Soika.Text = "8";
        }

        private void Elf_Click(object sender, EventArgs e)
        {
            LabelSoika.Text = "3";
            Label2Soika.Text = "3";
        }

        private void buttonExicute_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void buttonNext_Click(object sender, EventArgs e)
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
            Level2 level2 = new Level2();
            level2.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Data.Restart = Data.Restart + 1;
            this.Hide();
            Level1 level1 = new Level1();
            level1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Competences
            Competences.bg_change_completion("Check_info", Competences.records[0]);
            Competences.bg_change_completion("Check_info", Competences.records[1]);

            pictureBoxWIKI1.Visible = true;
            buttonExit4.Visible = true;
        }

        private void buttonExit4_Click(object sender, EventArgs e)
        {          
            Data.Rate = Data.Rate + 0.1;
            pictureBoxWIKI1.Visible = false;
            buttonExit4.Visible = false;
        }
    }
}
