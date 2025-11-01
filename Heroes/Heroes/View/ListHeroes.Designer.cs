namespace Heroes.View
{
    partial class ListHeroes
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
            addToolStripMenuItem = new ToolStripMenuItem();
            addToolStripMenuItem1 = new ToolStripMenuItem();
            listToolStripMenuItem = new ToolStripMenuItem();
            heroesGridView = new DataGridView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)heroesGridView).BeginInit();
            SuspendLayout();
            //
            // menuStrip1
            //
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { addToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            //
            // addToolStripMenuItem
            //
            addToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addToolStripMenuItem1, listToolStripMenuItem });
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(70, 24);
            addToolStripMenuItem.Text = "Heroes";
            //
            // addToolStripMenuItem1
            //
            addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            addToolStripMenuItem1.Size = new Size(120, 26);
            addToolStripMenuItem1.Text = "Add";
            addToolStripMenuItem1.Click += addMenuItem_Click;
            //
            // listToolStripMenuItem
            //
            listToolStripMenuItem.Name = "listToolStripMenuItem";
            listToolStripMenuItem.Size = new Size(120, 26);
            listToolStripMenuItem.Text = "List";
            listToolStripMenuItem.Click += listMenuItem_Click;
            //
            // heroesGridView
            //
            heroesGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            heroesGridView.Location = new Point(12, 31);
            heroesGridView.Name = "heroesGridView";
            heroesGridView.ReadOnly = true;
            heroesGridView.RowHeadersWidth = 51;
            heroesGridView.Size = new Size(776, 407);
            heroesGridView.TabIndex = 1;
            heroesGridView.CellMouseClick += editHero;
            //
            // ListHeroes
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(heroesGridView);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "ListHeroes";
            Text = "Superhero register";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)heroesGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem1;
        private ToolStripMenuItem listToolStripMenuItem;
        private DataGridView heroesGridView;
    }
}
