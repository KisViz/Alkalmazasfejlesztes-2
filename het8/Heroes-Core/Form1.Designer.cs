namespace Heroes_Core
{
    partial class HeroesApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            addHeroToolStripMenuItem = new ToolStripMenuItem();
            listHeroesToolStripMenuItem = new ToolStripMenuItem();
            heroesDataGridView1 = new DataGridView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)heroesDataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { addHeroToolStripMenuItem, listHeroesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // addHeroToolStripMenuItem
            // 
            addHeroToolStripMenuItem.Name = "addHeroToolStripMenuItem";
            addHeroToolStripMenuItem.Size = new Size(70, 20);
            addHeroToolStripMenuItem.Text = "Add Hero";
            addHeroToolStripMenuItem.Click += addHeroToolStripMenuItem_Click;
            // 
            // listHeroesToolStripMenuItem
            // 
            listHeroesToolStripMenuItem.Name = "listHeroesToolStripMenuItem";
            listHeroesToolStripMenuItem.Size = new Size(77, 20);
            listHeroesToolStripMenuItem.Text = "List Heroes";
            listHeroesToolStripMenuItem.Click += listHeroesToolStripMenuItem_Click;
            // 
            // heroesDataGridView1
            // 
            heroesDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            heroesDataGridView1.Location = new Point(12, 63);
            heroesDataGridView1.Name = "heroesDataGridView1";
            heroesDataGridView1.ReadOnly = true;
            heroesDataGridView1.Size = new Size(776, 375);
            heroesDataGridView1.TabIndex = 1;
            heroesDataGridView1.CellMouseClick += itemClicked;
            // 
            // HeroesApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(heroesDataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "HeroesApp";
            RightToLeftLayout = true;
            Text = "Heroes App";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)heroesDataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem addHeroToolStripMenuItem;
        private ToolStripMenuItem listHeroesToolStripMenuItem;
        private DataGridView heroesDataGridView1;
    }
}
