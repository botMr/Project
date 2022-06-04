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
    public partial class Achiv : Form
    {        
        public Achiv()
        {
           
            InitializeComponent();
        }
        private void Achiv_Load(object sender, EventArgs e)
        {

        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            labelName.Text = "Имя: " + Data.Name;
            labelLast.Text = "Фамилия: " + Data.Last;
            labelSave.Text = "Пройдено уровней: " + Data.Lvl;
            labelEror.Text = "Количество ошибок: " + Data.Error;
            labelRt.Text = "Итог: " + Data.Rang;
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }
    }
}
