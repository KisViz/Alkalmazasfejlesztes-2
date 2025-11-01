namespace Heroes.View
{
    partial class AddHero
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
            nameTextBox = new TextBox();
            heroNameTextBox = new TextBox();
            powerComboBox = new ComboBox();
            ageNumericUpDown = new NumericUpDown();
            cancelButton = new Button();
            okButton = new Button();
            ((System.ComponentModel.ISupportInitialize)ageNumericUpDown).BeginInit();
            SuspendLayout();
            //
            // label1
            //
            label1.AutoSize = true;
            label1.Location = new Point(46, 25);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            //
            // label2
            //
            label2.AutoSize = true;
            label2.Location = new Point(12, 64);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 1;
            label2.Text = "Hero name:";
            //
            // label3
            //
            label3.AutoSize = true;
            label3.Location = new Point(46, 108);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 2;
            label3.Text = "Power:";
            //
            // label4
            //
            label4.AutoSize = true;
            label4.Location = new Point(59, 152);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 3;
            label4.Text = "Age:";
            //
            // nameTextBox
            //
            nameTextBox.Location = new Point(104, 25);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(190, 27);
            nameTextBox.TabIndex = 4;
            //
            // heroNameTextBox
            //
            heroNameTextBox.Location = new Point(104, 64);
            heroNameTextBox.Name = "heroNameTextBox";
            heroNameTextBox.Size = new Size(190, 27);
            heroNameTextBox.TabIndex = 5;
            //
            // powerComboBox
            //
            powerComboBox.FormattingEnabled = true;
            powerComboBox.Location = new Point(104, 105);
            powerComboBox.Name = "powerComboBox";
            powerComboBox.Size = new Size(190, 28);
            powerComboBox.TabIndex = 6;
            //
            // ageNumericUpDown
            //
            ageNumericUpDown.Location = new Point(104, 145);
            ageNumericUpDown.Minimum = new decimal(new int[] { 16, 0, 0, 0 });
            ageNumericUpDown.Name = "ageNumericUpDown";
            ageNumericUpDown.Size = new Size(190, 27);
            ageNumericUpDown.TabIndex = 7;
            ageNumericUpDown.Value = new decimal(new int[] { 16, 0, 0, 0 });
            //
            // cancelButton
            //
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Location = new Point(104, 192);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(94, 29);
            cancelButton.TabIndex = 8;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            //
            // okButton
            //
            okButton.Location = new Point(204, 193);
            okButton.Name = "okButton";
            okButton.Size = new Size(94, 29);
            okButton.TabIndex = 9;
            okButton.Text = "Save";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += save_Click;
            //
            // AddHero
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(327, 246);
            Controls.Add(okButton);
            Controls.Add(cancelButton);
            Controls.Add(ageNumericUpDown);
            Controls.Add(powerComboBox);
            Controls.Add(heroNameTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddHero";
            Text = "AddHero";
            ((System.ComponentModel.ISupportInitialize)ageNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox nameTextBox;
        private TextBox heroNameTextBox;
        private ComboBox powerComboBox;
        private NumericUpDown ageNumericUpDown;
        private Button cancelButton;
        private Button okButton;
    }
}
