using mintaZh2.Controller;
using mintaZh2.Model;

namespace mintaZh2.View
{
    public partial class AddEgyed : Form
    {
        private EgyedController controller;
        private Egyed? egyed = null;
        public AddEgyed(EgyedController controller, Egyed? egyed = null)
        {
            InitializeComponent();
            this.controller = controller;
            this.egyed = egyed;


            fajComboBox1.Items.AddRange(new object[]
            {
                "gímszarvas",
                "muflon",
                "őz",
                "dámszarvas",
                "vaddisznó",
                "aranysakál",
                "róka",
                "rétisas"
            });
            fajComboBox1.SelectedIndex = 0;

            if (egyed != null)
            {
                fajComboBox1.Text = egyed.Species;
                eletkorNumericUpDown1.Value = egyed.Age;
                tomegNumericUpDown1.Value = egyed.Weight;
                femaleRadioButton1.Checked = egyed.Gender == "Female" ? true : false;
                maleRadioButton1.Checked = egyed.Gender == "Female" ? false : true;
                nevTextBox1.Text = egyed.Name;
            }
        }

        private void okButton2_Click(object sender, EventArgs e)
        {
            string faj = fajComboBox1.Text;
            int eletkor = (int)eletkorNumericUpDown1.Value;
            decimal tomeg = tomegNumericUpDown1.Value;
            string nem = femaleRadioButton1.Checked ? "Female" : "Male";
            string nev = nevTextBox1.Text;

            if (nev == string.Empty)
            {
                MessageBox.Show("Kötelező megadni a nevet!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool modification = egyed != null;
            if (egyed == null)
                egyed = new Egyed();

            egyed.Species = faj;
            egyed.Age = eletkor;
            egyed.Weight = tomeg;
            egyed.Gender = nem;
            egyed.Name = nev;

            bool success = false;
            if (modification)
                success = controller.ModifyEgyed(egyed);
            else
                success = controller.AddEgyed(egyed);

            if (!success)
            {
                MessageBox.Show("Probléma merült fel a műveletnél!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.Abort;
            }

            DialogResult = DialogResult.OK;
        }
    }
}