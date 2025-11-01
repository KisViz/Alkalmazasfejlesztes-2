namespace het6
{
    public partial class userName : Form
    {
        public userName()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addHeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new NewHero())
            {
                form.ShowDialog();
            }
        }
    }
}
