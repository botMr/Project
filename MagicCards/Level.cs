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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lvl1 lvl1 = new Lvl1();
            lvl1.Show();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Data.Name = textBoxName.Text;
            Data.Last = textBoxLast.Text;
        }
    }
}
