using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagicCardPortTest
{
    public partial class Lvl2 : Form
    {
        public Lvl2()
        {
            InitializeComponent();
        }

        private void Mast1_Click(object sender, EventArgs e)
        {
            buttonAgain.Visible = true;
        }

        private void Mast2_Click(object sender, EventArgs e)
        {
            if (counterMast2.Text == "Крести: 8")
            {
                counterMast2.Text = "Крести: 7";
                label2.Text = "Всего в колоде:34";
                pictureBoxAns.Visible = true;
                pictureBox3.Visible = true;
                buttonBack.Visible = true;
                buttonNext.Visible = true;
                buttonAgain.Visible = true;
            }
            Mast1.Enabled = false;
            Mast2.Enabled = false;
            Mast3.Enabled = false;
            Mast4.Enabled = false;
        }

        private void Mast3_Click(object sender, EventArgs e)
        {
            buttonAgain.Visible = true;
        }

        private void Mast4_Click(object sender, EventArgs e)
        {
            buttonAgain.Visible = true;
        }

        private void buttonAgain_Click(object sender, EventArgs e)
        {
            pictureBoxAns.Visible = false;
            pictureBox3.Visible = false;
            counterMast1.Text = "Черви: 9";
            counterMast2.Text = "Крести: 8";
            counterMast3.Text = "Бубны: 9";
            counterMast4.Text = "Пики: 9";
            label2.Text = "Всего в колоде:35";
            buttonBack.Visible = false;
            buttonNext.Visible = false;
            buttonAgain.Visible = false;
            Mast1.Enabled = true;
            Mast2.Enabled = true;
            Mast3.Enabled = true;
            Mast4.Enabled = true;
            Data.Error = Data.Error + 1;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lvl1 lvl1 = new Lvl1();
            lvl1.Show();
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            Data.Rang = Data.Rang + 1.0;
            Data.Lvl = Data.Lvl + 1;
            this.Hide();
            Batlecs batlecs = new Batlecs();
            batlecs.Show();
        }
    }
}
