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
    public partial class AboutGame : Form
    {
        public AboutGame()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Data.Rang = Data.Rang + 0.1;
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }
    }
}
