using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagicCardPortTest
{
    public partial class Batlecs : Form
    {
        public Batlecs()
        {
            InitializeComponent();
        }

        public void buttonMats1_Click(object sender, EventArgs e)
        {
                picturePikiPlayer.Visible = false;
                pictureCherviPlayer.Visible = true;
                AI();
        }

        public void buttonMats2_Click(object sender, EventArgs e)
        {
            pictureBubiPlayer.Visible = false;
            pictureKrestiPlayer.Visible = true;
            AI();
        }

        public void button2_Click(object sender, EventArgs e)
        {
            pictureKrestiPlayer.Visible = false;
            pictureBubiPlayer.Visible = true;
            AI();
        }

        public void AI()
        {
            if (pictureCherviPlayer.Visible == true)
            {                
                pictureBubi.Visible = false;
                pictureKresti.Visible = true;
            }
             if (picturePikiPlayer.Visible == true)
            {
                pictureKresti.Visible = false;
                pictureBubi.Visible = true;
            }
             if (pictureKrestiPlayer.Visible == true)
            {
                picturePiki.Visible = false;
                pictureChervi.Visible = true;
            }
             if (pictureBubiPlayer.Visible == true)
            {
                pictureChervi.Visible = false;
                picturePiki.Visible = true;
            }
            var block1 = ((pictureKresti.Visible == true) && (pictureChervi.Visible == true));
            var block11 = ((pictureKresti.Visible == true) && (picturePiki.Visible == true));
            var block2 = ((pictureBubi.Visible == true) && (picturePiki.Visible == true));
            var block22 = ((pictureBubi.Visible == true) && (pictureChervi.Visible == true));

            if ((block1 || block11) || (block2 || block22))
            {
                button2.Enabled = false;
                buttonMast4.Enabled = false;
                buttonMats1.Enabled = false;
                buttonMats2.Enabled = false;
                buttonAgain.Visible = true;
                buttonAchivment.Visible = true;
            }
            if ((pictureBubiPlayer.Visible == true) || (pictureKrestiPlayer.Visible == true) || (picturePikiPlayer.Visible == true) || (pictureCherviPlayer.Visible == true))
            {
                label4.Text = "Всего в колоде: 34";
            }
            if (block1 || block11 || block2 || block22)
            {
                label4.Text = "Всего в колоде: 32";
            }
            Count();

        }

        public void Count()
        {
            var block1 = ((pictureKresti.Visible == true) && (pictureChervi.Visible == true));
            var block11 = ((pictureKresti.Visible == true) && (picturePiki.Visible == true));
            var block2 = ((pictureBubi.Visible == true) && (picturePiki.Visible == true));
            var block22 = ((pictureBubi.Visible == true) && (pictureChervi.Visible == true));

            if (block1 || block11 || block2 || block22)
            {
                label3.Text = "Вы: 0.514";
                label2.Text = "Противник: 0.529";
            }
        }

        private void buttonAgain_Click(object sender, EventArgs e)
        {
            label3.Text = "Вы: 0";
            label2.Text = "Противник: 0";
            label4.Text = "Всего в колоде: 36";
            button2.Enabled = true;
            buttonMast4.Enabled = true;
            buttonMats1.Enabled = true;
            buttonMats2.Enabled = true;
            buttonAgain.Visible = false;
            buttonAchivment.Visible = false;
            pictureBubi.Visible = false;
            pictureBubiPlayer.Visible = false;
            pictureChervi.Visible = false;
            pictureCherviPlayer.Visible = false;
            pictureKresti.Visible = false;
            pictureKrestiPlayer.Visible = false;
            picturePiki.Visible = false;
            picturePikiPlayer.Visible = false;
            Data.Error = Data.Error + 1;
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void buttonLaw_Click(object sender, EventArgs e)
        {
            pictureRule.Visible = true;
            buttonClose.Visible = true;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            pictureRule.Visible = false;
            buttonMenu.Visible = true;
            pictureBox3.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            button2.Enabled = true;
            buttonMast4.Enabled = true;
            buttonMats1.Enabled = true;
            buttonMats2.Enabled = true;
            buttonClose.Visible = false;
            Data.Rang = Data.Rang + 0.1;
        }

        private void buttonMast4_Click(object sender, EventArgs e)
        {
            pictureCherviPlayer.Visible = false;
            picturePikiPlayer.Visible = true;
            AI();
        }

        private void buttonAchivment_Click(object sender, EventArgs e)
        {
            Data.Rang = Data.Rang - 0.5;
            Data.Lvl = Data.Lvl + 1;
            this.Hide();
            Achiv achiv = new Achiv();
            achiv.Show();
        }
    }
}
