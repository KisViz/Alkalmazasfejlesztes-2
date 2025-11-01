namespace het8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            // username, pw
            string username = userNameTextBox.Text;
            string password = passwordTextBox.Text;

            MessageBox.Show($"{username}, {password}");
        }

        private void loginButton_Click2(object sender, EventArgs e)
        {
            // username, pw
            string username = userNameTextBox.Text;
            string password = passwordTextBox.Text;

            MessageBox.Show($"{password}, {username}");
        }

        private void cencelButton_kilep(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
