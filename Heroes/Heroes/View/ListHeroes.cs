using Heroes.Controller;
using Heroes.DAO;
using Heroes.Model;

namespace Heroes.View
{
    public partial class ListHeroes : Form
    {
        private HeroesController controller;
        public ListHeroes()
        {
            InitializeComponent();

            var dao = new HeroesAdoDao();
            controller = new HeroesController(dao);
        }

        private void addMenuItem_Click(object sender, EventArgs e)
        {
            using var window = new AddHero(controller);
            window.ShowDialog();
        }

        private void listMenuItem_Click(object sender, EventArgs e)
        {
            heroesGridView.DataSource = null;
            heroesGridView.DataSource = controller.GetHeroes();
            heroesGridView.Visible = true;
        }

        private void editHero(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!(heroesGridView.CurrentRow.DataBoundItem is Hero hero))
                return;

            using var window = new AddHero(controller, hero);
            window.ShowDialog();
        }
    }
}
