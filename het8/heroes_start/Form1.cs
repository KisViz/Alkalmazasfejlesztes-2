namespace heroes_start
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void adddButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox1.Text;
            string hero_name = heroNameTextBox2.Text;
            try
            {
                int power = int.Parse(powerTextBox3.Text);

            } catch { }
            decimal age = ageNumericUpDown1.Value;

            //MessageBox.Show($"{name},{hero_name}, {power}, {age}");

            using var form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
