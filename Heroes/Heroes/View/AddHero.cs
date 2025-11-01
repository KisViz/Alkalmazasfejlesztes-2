using Heroes.Controller;
using Heroes.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heroes.View
{
    public partial class AddHero : Form
    {
        private HeroesController controller;
        private Hero? hero = null;

        public AddHero(HeroesController controller, Hero? hero = null)
        {
            InitializeComponent();
            this.controller = controller;
            this.hero = hero;

            powerComboBox.Items.AddRange(new object[]
            {
                "Maga által készített",
                "Szerzett",
                "Veleszületett"
            });
            powerComboBox.SelectedIndex = 0;

            if (hero != null)
            {
                nameTextBox.Text = hero.Name;
                heroNameTextBox.Text = hero.HeroName;
                powerComboBox.Text = hero.Power;
                ageNumericUpDown.Value = hero.Age;
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string heroname = heroNameTextBox.Text;
            string power = powerComboBox.Text;
            int age = (int)ageNumericUpDown.Value;

            if (name == string.Empty || heroname == string.Empty)
            {
                MessageBox.Show("Kötelező megadni a hős nevét és a fantázianevét is!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool modification = hero != null;
            if (hero == null)
                hero = new Hero();

            hero.Name = name;
            hero.HeroName = heroname;
            hero.Power = power;
            hero.Age = age;

            bool success = false;
            if (modification)
                success = controller.ModifyHero(hero);
            else
                success = controller.AddHero(hero);

            if (!success)
            {
                MessageBox.Show("Probléma merült fel a műveletnél!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.Abort;
            }

            DialogResult = DialogResult.OK;
        }
    }
}
