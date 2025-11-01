namespace het6
{
    partial class NewHero
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            nameBox = new TextBox();
            heroNameBox = new TextBox();
            powerBox = new TextBox();
            numericUpDown1 = new NumericUpDown();
            cancelButton = new Button();
            addButton = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 48);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 109);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 1;
            label2.Text = "Hero Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 182);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 2;
            label3.Text = "Power";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 255);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 3;
            label4.Text = "Age";
            // 
            // nameBox
            // 
            nameBox.Location = new Point(204, 45);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(129, 23);
            nameBox.TabIndex = 4;
            // 
            // heroNameBox
            // 
            heroNameBox.Location = new Point(204, 106);
            heroNameBox.Name = "heroNameBox";
            heroNameBox.Size = new Size(129, 23);
            heroNameBox.TabIndex = 5;
            // 
            // powerBox
            // 
            powerBox.Location = new Point(204, 179);
            powerBox.Name = "powerBox";
            powerBox.Size = new Size(129, 23);
            powerBox.TabIndex = 6;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(213, 253);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 8;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(91, 359);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 9;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(237, 359);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 10;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // NewHero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(addButton);
            Controls.Add(cancelButton);
            Controls.Add(numericUpDown1);
            Controls.Add(powerBox);
            Controls.Add(heroNameBox);
            Controls.Add(nameBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "NewHero";
            Text = "NewHero";
            Load += NewHero_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox nameBox;
        private TextBox heroNameBox;
        private TextBox powerBox;
        private NumericUpDown numericUpDown1;
        private Button cancelButton;
        private Button addButton;
    }
}