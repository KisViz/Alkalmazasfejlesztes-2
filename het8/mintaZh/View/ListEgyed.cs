using mintaZh.Controller;
using mintaZh.DAO;
using mintaZh.Model;

namespace mintaZh.View
{
    public partial class ListEgyed : Form
    {
        private EgyedController controller;
        public ListEgyed()
        {
            InitializeComponent();

            var dao = new EgyedDao();
            controller = new EgyedController(dao);
        }

        private void addEgyedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using var window = new AddEgyed(controller);
            window.ShowDialog();
        }

        private void listEgyedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            egyedDataGridView1.DataSource = null;
            egyedDataGridView1.DataSource = controller.GetEgyeds();
            egyedDataGridView1.Visible = true;
        }

        private void CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!(egyedDataGridView1.CurrentRow.DataBoundItem is Egyed egyed))
            {
                return;
            }

            using var window = new AddEgyed(controller, egyed);
            window.ShowDialog();
        }
    }
}
