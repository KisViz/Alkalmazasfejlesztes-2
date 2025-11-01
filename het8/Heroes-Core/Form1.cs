using Heroes_Core.Controller;
using Heroes_Core.DAO;
using Heroes_Core.Model;
using Heroes_Core.ViewModel;

namespace Heroes_Core
{
    public partial class HeroesApp : Form
    {
        private readonly HeroesController controller;
        public HeroesApp()
        {
            InitializeComponent();

            controller = new HeroesController(new HeroesMemoryDao());
        }

        private void addHeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using var addHeroForm = new NewHero(controller);
            addHeroForm.ShowDialog();
        }

        private void listHeroesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var items = controller.GetHeroes();
            //var viewmodels = new List<HeroViewModel>();

            //foreach (var item in items)
            //{
            //    viewmodels.Add(new HeroViewModel
            //    {
            //        Age = item.Age,
            //        HeroName = item.HeroName,
            //        Name = item.HeroName,
            //        Power = item.Power
            //    });
            //}

            heroesDataGridView1.DataSource = null;
            //heroesDataGridView1.DataSource = viewmodels;
            heroesDataGridView1.DataSource = items;
            heroesDataGridView1.Visible = true;
        }

        private void itemClicked(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!(heroesDataGridView1.CurrentRow.DataBoundItem is Hero hero))
            {
                return;
            }

            using var addHeroForm = new NewHero(controller, hero);
            addHeroForm.ShowDialog();
        }
    }
}
