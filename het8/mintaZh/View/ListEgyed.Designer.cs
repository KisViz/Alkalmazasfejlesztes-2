namespace mintaZh.View
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
            egyedDataGridView1 = new DataGridView();
            menuStrip1 = new MenuStrip();
            addEgyedToolStripMenuItem = new ToolStripMenuItem();
            listEgyedToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)egyedDataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // egyedDataGridView1
            // 
            egyedDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            egyedDataGridView1.Location = new Point(12, 46);
            egyedDataGridView1.Name = "egyedDataGridView1";
            egyedDataGridView1.ReadOnly = true;
            egyedDataGridView1.Size = new Size(753, 384);
            egyedDataGridView1.TabIndex = 0;
            egyedDataGridView1.CellMouseClick += CellMouseClick;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { addEgyedToolStripMenuItem, listEgyedToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // addEgyedToolStripMenuItem
            // 
            addEgyedToolStripMenuItem.Name = "addEgyedToolStripMenuItem";
            addEgyedToolStripMenuItem.Size = new Size(76, 20);
            addEgyedToolStripMenuItem.Text = "Add Egyed";
            addEgyedToolStripMenuItem.Click += addEgyedToolStripMenuItem_Click;
            // 
            // listEgyedToolStripMenuItem
            // 
            listEgyedToolStripMenuItem.Name = "listEgyedToolStripMenuItem";
            listEgyedToolStripMenuItem.Size = new Size(72, 20);
            listEgyedToolStripMenuItem.Text = "List Egyed";
            listEgyedToolStripMenuItem.Click += listEgyedToolStripMenuItem_Click;
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
            ((System.ComponentModel.ISupportInitialize)egyedDataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView egyedDataGridView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem addEgyedToolStripMenuItem;
        private ToolStripMenuItem listEgyedToolStripMenuItem;
    }
}