namespace Heroes_Core
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
            powerComboBox1 = new ComboBox();
            heroNameTextBox = new TextBox();
            nameTextBox2 = new TextBox();
            ageNumericUpDown1 = new NumericUpDown();
            cancelButton = new Button();
            addButton1 = new Button();
            ((System.ComponentModel.ISupportInitialize)ageNumericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 57);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 117);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 1;
            label2.Text = "Hero Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 182);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 2;
            label3.Text = "Power";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 250);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 3;
            label4.Text = "Age";
            // 
            // powerComboBox1
            // 
            powerComboBox1.FormattingEnabled = true;
            powerComboBox1.Location = new Point(222, 179);
            powerComboBox1.Name = "powerComboBox1";
            powerComboBox1.Size = new Size(208, 23);
            powerComboBox1.TabIndex = 4;
            // 
            // heroNameTextBox
            // 
            heroNameTextBox.Location = new Point(222, 117);
            heroNameTextBox.Name = "heroNameTextBox";
            heroNameTextBox.Size = new Size(208, 23);
            heroNameTextBox.TabIndex = 5;
            // 
            // nameTextBox2
            // 
            nameTextBox2.Location = new Point(222, 57);
            nameTextBox2.Name = "nameTextBox2";
            nameTextBox2.Size = new Size(208, 23);
            nameTextBox2.TabIndex = 6;
            // 
            // ageNumericUpDown1
            // 
            ageNumericUpDown1.Location = new Point(222, 250);
            ageNumericUpDown1.Maximum = new decimal(new int[] { 250, 0, 0, 0 });
            ageNumericUpDown1.Name = "ageNumericUpDown1";
            ageNumericUpDown1.Size = new Size(208, 23);
            ageNumericUpDown1.TabIndex = 7;
            ageNumericUpDown1.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // cancelButton
            // 
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Location = new Point(118, 325);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 8;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // addButton1
            // 
            addButton1.DialogResult = DialogResult.Cancel;
            addButton1.Location = new Point(250, 325);
            addButton1.Name = "addButton1";
            addButton1.Size = new Size(75, 23);
            addButton1.TabIndex = 9;
            addButton1.Text = "Add";
            addButton1.UseVisualStyleBackColor = true;
            addButton1.Click += addHero_Clicl;
            // 
            // NewHero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 397);
            Controls.Add(addButton1);
            Controls.Add(cancelButton);
            Controls.Add(ageNumericUpDown1);
            Controls.Add(nameTextBox2);
            Controls.Add(heroNameTextBox);
            Controls.Add(powerComboBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "NewHero";
            Text = "NewHero";
            ((System.ComponentModel.ISupportInitialize)ageNumericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox powerComboBox1;
        private TextBox heroNameTextBox;
        private TextBox nameTextBox2;
        private NumericUpDown ageNumericUpDown1;
        private Button cancelButton;
        private Button addButton1;
    }
}