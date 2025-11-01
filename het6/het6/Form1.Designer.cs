namespace het6
{
    partial class userName
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
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { addHeroToolStripMenuItem, listHeroesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 6;
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
            // 
            // userName
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "userName";
            Text = "Heroes App";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem addHeroToolStripMenuItem;
        private ToolStripMenuItem listHeroesToolStripMenuItem;
    }
}
