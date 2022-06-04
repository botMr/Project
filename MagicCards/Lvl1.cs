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
    public partial class Lvl1 : Form
    {
        public Lvl1()
        {
            InitializeComponent();
        }

        public void Mast1_Click(object sender, EventArgs e)
        {          
                if (counterMast1.Text == "Черви: 9")
                {
                    counterMast1.Text = "Черви: 8";
                    pictureBoxAns1.Visible = true;

                    if (pictureBoxAns1.Visible == true)
                    {
                      Mast2.Enabled = false;
                      Mast3.Enabled = false;
                      Mast4.Enabled = false;
                    }
                    Eight();
                }
                else if (counterMast1.Text == "Черви: 8")
                {
                    counterMast1.Text = "Черви: 7";
                    Seven();
                }
                buttonAgain.Visible = true;
                buttonNext.Visible = true;          
        }

        public void Mast2_Click(object sender, EventArgs e)
        {
            if (counterMast2.Text == "Крести: 9")
            {
                counterMast2.Text = "Крести: 8";
                pictureBoxAns2.Visible = true;
                if (pictureBoxAns2.Visible == true)
                {
                    Mast1.Enabled = false;
                    Mast3.Enabled = false;
                    Mast4.Enabled = false;
                }
                Eight();
            }
            else if (counterMast2.Text == "Крести: 8")
            {
                counterMast2.Text = "Крести: 7";
                Seven();
            }
           buttonAgain.Visible = true;
           buttonNext.Visible = true;
        }

        public void Mast4_Click(object sender, EventArgs e)
        {
            if (counterMast4.Text == "Пики: 9")
            {
                counterMast4.Text = "Пики: 8";
                pictureBoxAns4.Visible = true;
                if (pictureBoxAns4.Visible == true)
                {
                    Mast1.Enabled = false;
                    Mast2.Enabled = false;
                    Mast3.Enabled = false;
                }

                Eight();
            }
            else if (counterMast4.Text == "Пики: 8")
            {
                counterMast4.Text = "Пики: 7";
                Seven();
            }
            buttonAgain.Visible = true;
            buttonNext.Visible = true;
        }

        public void Mast3_Click(object sender, EventArgs e)
        {
            if (counterMast3.Text == "Бубны: 9")
            {
                counterMast3.Text = "Бубны: 8";
                pictureBoxAns3.Visible = true;
                if (pictureBoxAns3.Visible == true)
                {
                    Mast1.Enabled = false;
                    Mast2.Enabled = false;
                    Mast4.Enabled = false;
                }

                Eight();
            }
            else if (counterMast3.Text == "Бубны: 8")
            {
                counterMast3.Text = "Бубны: 7";
                Seven();
            }
            buttonAgain.Visible = true;
            buttonNext.Visible = true;
        }

        public void Eight()
        {
            int count = 36;
            if (counterMast1.Text.Contains("8") & (counterMast2.Text.Contains("9")) & (counterMast3.Text.Contains("9")) & (counterMast4.Text.Contains("9")))
            {
                count = count - 1;
                label2.Text = "Всего в колоде:" + count;
            }
            else if (counterMast1.Text.Contains("9") & (counterMast2.Text.Contains("8")) & (counterMast3.Text.Contains("9")) & (counterMast4.Text.Contains("9")))
            {
                count = count - 1;
                label2.Text = "Всего в колоде:" + count;
            }
            else if (counterMast1.Text.Contains("9") & (counterMast2.Text.Contains("9")) & (counterMast3.Text.Contains("8")) & (counterMast4.Text.Contains("9")))
            {
                count = count - 1;
                label2.Text = "Всего в колоде:" + count;
            }
            else if (counterMast1.Text.Contains("9") & (counterMast2.Text.Contains("9")) & (counterMast3.Text.Contains("9")) & (counterMast4.Text.Contains("8")))
            {
                count = count - 1;
                label2.Text = "Всего в колоде:" + count;
            }
            else if (counterMast1.Text.Contains("8") & (counterMast2.Text.Contains("9")) & (counterMast3.Text.Contains("9")) & (counterMast4.Text.Contains("8")))
            {
                count = count - 2;
                label2.Text = "Всего в колоде:" + count;
            }
            else if (counterMast1.Text.Contains("9") & (counterMast2.Text.Contains("8")) & (counterMast3.Text.Contains("8")) & (counterMast4.Text.Contains("9")))
            {
                count = count - 2;
                label2.Text = "Всего в колоде:" + count;
            }
            else if (counterMast1.Text.Contains("8") & (counterMast2.Text.Contains("9")) & (counterMast3.Text.Contains("8")) & (counterMast4.Text.Contains("9")))
            {
                count = count - 2;
                label2.Text = "Всего в колоде:" + count;
            }
            else if (counterMast1.Text.Contains("9") & (counterMast2.Text.Contains("8")) & (counterMast3.Text.Contains("9")) & (counterMast4.Text.Contains("8")))
            {
                count = count - 2;
                label2.Text = "Всего в колоде:" + count;
            }
            else if (counterMast1.Text.Contains("8") & (counterMast2.Text.Contains("8")) & (counterMast3.Text.Contains("9")) & (counterMast4.Text.Contains("9")))
            {
                count = count - 2;
                label2.Text = "Всего в колоде:" + count;
            }
            else if (counterMast1.Text.Contains("9") & (counterMast2.Text.Contains("9")) & (counterMast3.Text.Contains("8")) & (counterMast4.Text.Contains("8")))
            {
                count = count - 2;
                label2.Text = "Всего в колоде:" + count;
            }
            else if (counterMast1.Text.Contains("9") & (counterMast2.Text.Contains("8")) & (counterMast3.Text.Contains("8")) & (counterMast4.Text.Contains("8")))
            {
                count = count - 3;
                label2.Text = "Всего в колоде:" + count;
            }
            else if (counterMast1.Text.Contains("8") & (counterMast2.Text.Contains("9")) & (counterMast3.Text.Contains("8")) & (counterMast4.Text.Contains("8")))
            {
                count = count - 3;
                label2.Text = "Всего в колоде:" + count;
            }
            else if (counterMast1.Text.Contains("8") & (counterMast2.Text.Contains("8")) & (counterMast3.Text.Contains("9")) & (counterMast4.Text.Contains("8")))
            {
                count = count - 3;
                label2.Text = "Всего в колоде:" + count;
            }
            else if (counterMast1.Text.Contains("8") & (counterMast2.Text.Contains("8")) & (counterMast3.Text.Contains("8")) & (counterMast4.Text.Contains("9")))
            {
                count = count - 3;
                label2.Text = "Всего в колоде:" + count;
            }
            else if (counterMast1.Text.Contains("8") & (counterMast2.Text.Contains("8")) & (counterMast3.Text.Contains("8")) & (counterMast4.Text.Contains("8")))
            {
                count = count - 4;
                label2.Text = "Всего в колоде:" + count;
            }
        }

        public void Seven()
        {
            int count = 32;
            if (counterMast1.Text.Contains("7") & (counterMast2.Text.Contains("8")) & (counterMast3.Text.Contains("8")) & (counterMast4.Text.Contains("8")))
            {
                count = count - 1;
                label2.Text = "Всего в колоде:" + count;
            }
            else if (counterMast1.Text.Contains("8") & (counterMast2.Text.Contains("7")) & (counterMast3.Text.Contains("8")) & (counterMast4.Text.Contains("8")))
            {
                count = count - 1;
                label2.Text = "Всего в колоде:" + count;
            }
            else if (counterMast1.Text.Contains("8") & (counterMast2.Text.Contains("8")) & (counterMast3.Text.Contains("7")) & (counterMast4.Text.Contains("8")))
            {
                count = count - 1;
                label2.Text = "Всего в колоде:" + count;
            }
            else if (counterMast1.Text.Contains("8") & (counterMast2.Text.Contains("8")) & (counterMast3.Text.Contains("8")) & (counterMast4.Text.Contains("7")))
            {
                count = count - 1;
                label2.Text = "Всего в колоде:" + count;
            }
            else if (counterMast1.Text.Contains("8") & (counterMast2.Text.Contains("7")) & (counterMast3.Text.Contains("7")) & (counterMast4.Text.Contains("8")))
            {
                count = count - 2;
                label2.Text = "Всего в колоде:" + count;
            }
            else if (counterMast1.Text.Contains("7") & (counterMast2.Text.Contains("8")) & (counterMast3.Text.Contains("8")) & (counterMast4.Text.Contains("7")))
            {
                count = count - 2;
                label2.Text = "Всего в колоде:" + count;
            }
            else if (counterMast1.Text.Contains("8") & (counterMast2.Text.Contains("7")) & (counterMast3.Text.Contains("8")) & (counterMast4.Text.Contains("7")))
            {
                count = count - 2;
                label2.Text = "Всего в колоде:" + count;
            }
            else if (counterMast1.Text.Contains("7") & (counterMast2.Text.Contains("8")) & (counterMast3.Text.Contains("7")) & (counterMast4.Text.Contains("8")))
            {
                count = count - 2;
                label2.Text = "Всего в колоде:" + count;
            }
            else if (counterMast1.Text.Contains("7") & (counterMast2.Text.Contains("7")) & (counterMast3.Text.Contains("8")) & (counterMast4.Text.Contains("8")))
            {
                count = count - 2;
                label2.Text = "Всего в колоде:" + count;
            }
            else if (counterMast1.Text.Contains("8") & (counterMast2.Text.Contains("8")) & (counterMast3.Text.Contains("7")) & (counterMast4.Text.Contains("7")))
            {
                count = count - 2;
                label2.Text = "Всего в колоде:" + count;
            }
            else if (counterMast1.Text.Contains("8") & (counterMast2.Text.Contains("8")) & (counterMast3.Text.Contains("8")) & (counterMast4.Text.Contains("7")))
            {
                count = count - 3;
                label2.Text = "Всего в колоде:" + count;
            }
            else if (counterMast1.Text.Contains("8") & (counterMast2.Text.Contains("8")) & (counterMast3.Text.Contains("7")) & (counterMast4.Text.Contains("8")))
            {
                count = count - 3;
                label2.Text = "Всего в колоде:" + count;
            }
            else if (counterMast1.Text.Contains("8") & (counterMast2.Text.Contains("7")) & (counterMast3.Text.Contains("8")) & (counterMast4.Text.Contains("8")))
            {
                count = count - 3;
                label2.Text = "Всего в колоде:" + count;
            }
            else if (counterMast1.Text.Contains("7") & (counterMast2.Text.Contains("8")) & (counterMast3.Text.Contains("8")) & (counterMast4.Text.Contains("8")))
            {
                count = count - 3;
                label2.Text = "Всего в колоде:" + count;
            }
            else if (counterMast1.Text.Contains("7") & (counterMast2.Text.Contains("7")) & (counterMast3.Text.Contains("7")) & (counterMast4.Text.Contains("7")))
            {
                count = count - 4;
                label2.Text = "Всего в колоде:" + count;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBoxAns1.Visible = false;
            pictureBoxAns2.Visible = false;
            pictureBoxAns3.Visible = false;
            pictureBoxAns4.Visible = false;
            counterMast1.Text = "Черви: 9";
            counterMast2.Text = "Крести: 9";
            counterMast3.Text = "Бубны: 9";
            counterMast4.Text = "Пики: 9";
            label2.Text = "Всего в колоде:36";
            buttonAgain.Visible = false;
            buttonNext.Visible = false;
            Mast1.Enabled = true;
            Mast2.Enabled = true;
            Mast3.Enabled = true;
            Mast4.Enabled = true;
            Data.Error = Data.Error + 1;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            Data.Rang = Data.Rang + 0.7;
            Data.Lvl = Data.Lvl + 1;
            this.Hide();
            Lvl2 lvl2 = new Lvl2();
            lvl2.Show();
        }
    }
}
