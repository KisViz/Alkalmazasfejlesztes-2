namespace mintaZh2.View
{
    partial class ListEgyed
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            listázásToolStripMenuItem = new ToolStripMenuItem();
            hozzáadásToolStripMenuItem = new ToolStripMenuItem();
            egyedDataGridView1 = new DataGridView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)egyedDataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { listázásToolStripMenuItem, hozzáadásToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // listázásToolStripMenuItem
            // 
            listázásToolStripMenuItem.Name = "listázásToolStripMenuItem";
            listázásToolStripMenuItem.Size = new Size(59, 20);
            listázásToolStripMenuItem.Text = "Listázás";
            listázásToolStripMenuItem.Click += listázásToolStripMenuItem_Click;
            // 
            // hozzáadásToolStripMenuItem
            // 
            hozzáadásToolStripMenuItem.Name = "hozzáadásToolStripMenuItem";
            hozzáadásToolStripMenuItem.Size = new Size(75, 20);
            hozzáadásToolStripMenuItem.Text = "Hozzáadás";
            hozzáadásToolStripMenuItem.Click += hozzáadásToolStripMenuItem_Click;
            // 
            // egyedDataGridView1
            // 
            egyedDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            egyedDataGridView1.Location = new Point(12, 40);
            egyedDataGridView1.Name = "egyedDataGridView1";
            egyedDataGridView1.Size = new Size(776, 398);
            egyedDataGridView1.TabIndex = 1;
            egyedDataGridView1.CellMouseClick += CellMouseClick;
            // 
            // ListEgyed
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(egyedDataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "ListEgyed";
            Text = "ListEgyed";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)egyedDataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem listázásToolStripMenuItem;
        private ToolStripMenuItem hozzáadásToolStripMenuItem;
        private DataGridView egyedDataGridView1;
    }
}