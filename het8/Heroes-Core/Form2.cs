using Heroes_Core.Controller;
using Heroes_Core.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heroes_Core
{
    public partial class NewHero : Form
    {
        private readonly HeroesController controller;
        private readonly int heroId;
        private readonly bool isModification;

        public NewHero(HeroesController controller)
        {
            InitializeComponent();

            powerComboBox1.Items.AddRange(new string[] {
                "Maga által készített",
                "Szerzett",
                "Veleszületett"
              });
            powerComboBox1.SelectedIndex = 0;

            this.controller = controller;
        }

        public NewHero (HeroesController controller, Hero hero) : this(controller) 
        {
            isModification = true;

            heroId = hero.ID;
            nameTextBox2.Text = hero.Name;
            heroNameTextBox.Text = hero.HeroName;
            ageNumericUpDown1.Value = hero.Age;
            powerComboBox1.SelectedIndex = powerComboBox1.Items.IndexOf(hero.Power);

            addButton1.Text = "Modify";
        }

        private void addHero_Clicl(object sender, EventArgs e)
        {
            string name = nameTextBox2.Text;
            string heroName = heroNameTextBox.Text;

            string power = powerComboBox1.SelectedItem.ToString();
            int age = (int)ageNumericUpDown1.Value;

            if (name == string.Empty || heroName == string.Empty)
            {
                MessageBox.Show("Kötelező megadni a hős nevét!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.Abort;
                return;
            }

            Hero hero = new Hero
            {
                Name = name,
                HeroName = heroName,
                Age = age,
                Power = power
            };

            bool result = false;
            if (isModification)
            {
                hero.ID = heroId;
                result = controller.ModifyHero(hero);
            } 
            else
            {
                result = controller.AddHero(hero);
            }

            if (!result)
            {
                MessageBox.Show("Probléma merült fel a műveletnél!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.Abort;
            }
        }
    }
}
