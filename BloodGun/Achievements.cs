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
    public partial class Achievements : Form
    {
        public Achievements()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu Menu = new Menu();
            Menu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            labelName.Text = "Имя:" + Data.Name;
            labelNick.Text = "Ник:" + Data.Nick;
            labelGroup.Text = "Групаа" + Data.Group;
            labelComplete.Text = "Пройдено:" + Data.Complete;
            labelRestart.Text = "Перезапуски:" + Data.Restart;
            labelRate.Text = "Рейтинг:" + Data.Rate;
        }
    }
}
