using het6.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace het6
{
    public partial class NewHero : Form
    {
        public NewHero()
        {
            InitializeComponent();
        }

        private void NewHero_Load(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string heroName = heroNameTextBox.Text;
            string power = powerComboBox.SelectedItem.ToString();
            int age = (int)ageNumericUpDown.Value;

            if (name == string.Empty || heroName == string.Empty)
                return; // + hiba kiírása

            Hero hero = new Hero { /* ... */ };
            controller.AddHero(hero);
        }
    }
}
