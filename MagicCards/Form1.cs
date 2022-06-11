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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login levels = new Login();
            levels.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            // Filling csv after exit
            Competences.fill_csv();

            Application.Exit();
        }

        private void buttonAboutGame_Click(object sender, EventArgs e)
        {
            // Competences 
            Competences.mc_change_completion("Check_info", Competences.records[0]);
            Competences.mc_change_completion("Check_info", Competences.records[1]);

            this.Hide();
            AboutGame about = new AboutGame();
            about.Show();
        }
    }
}
