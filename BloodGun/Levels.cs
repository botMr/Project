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
    public partial class Levels : Form
    {
        public Levels()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu mainMenu = new Menu();
            mainMenu.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Settings settings = new Settings();
            settings.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Level1 level1 = new Level1();
            level1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Level2 level2 = new Level2();
            level2.Show();
        }
    }
}
