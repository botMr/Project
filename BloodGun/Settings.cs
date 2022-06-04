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
    public partial class Settings : Form
    { 
        public Settings()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu mainMenu = new Menu();
            mainMenu.Show();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Data.Nick = textBoxNick.Text;
            Data.Name = textBoxName.Text;
            Data.Group = textBoxGroup.Text;
        }
    }
}
