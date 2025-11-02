namespace mintaZh.View
{
    partial class AddEgyed
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
            label5 = new Label();
            fajComboBox1 = new ComboBox();
            eletkorNumericUpDown1 = new NumericUpDown();
            tomegNumericUpDown2 = new NumericUpDown();
            nostenyRadioButton1 = new RadioButton();
            himRradioButton1 = new RadioButton();
            button1 = new Button();
            okButton2 = new Button();
            nevTextBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)eletkorNumericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tomegNumericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 50);
            label1.Name = "label1";
            label1.Size = new Size(22, 15);
            label1.TabIndex = 0;
            label1.Text = "Faj";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 100);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 1;
            label2.Text = "Életkor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 150);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 2;
            label3.Text = "Tömeg";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 203);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 3;
            label4.Text = "Nem";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 256);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 4;
            label5.Text = "Név";
            // 
            // fajComboBox1
            // 
            fajComboBox1.FormattingEnabled = true;
            fajComboBox1.Location = new Point(134, 47);
            fajComboBox1.Name = "fajComboBox1";
            fajComboBox1.Size = new Size(202, 23);
            fajComboBox1.TabIndex = 5;
            // 
            // eletkorNumericUpDown1
            // 
            eletkorNumericUpDown1.Location = new Point(134, 98);
            eletkorNumericUpDown1.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
            eletkorNumericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            eletkorNumericUpDown1.Name = "eletkorNumericUpDown1";
            eletkorNumericUpDown1.Size = new Size(202, 23);
            eletkorNumericUpDown1.TabIndex = 6;
            eletkorNumericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // tomegNumericUpDown2
            // 
            tomegNumericUpDown2.DecimalPlaces = 1;
            tomegNumericUpDown2.Location = new Point(134, 148);
            tomegNumericUpDown2.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            tomegNumericUpDown2.Name = "tomegNumericUpDown2";
            tomegNumericUpDown2.Size = new Size(202, 23);
            tomegNumericUpDown2.TabIndex = 7;
            tomegNumericUpDown2.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nostenyRadioButton1
            // 
            nostenyRadioButton1.AutoSize = true;
            nostenyRadioButton1.Checked = true;
            nostenyRadioButton1.Location = new Point(134, 203);
            nostenyRadioButton1.Name = "nostenyRadioButton1";
            nostenyRadioButton1.Size = new Size(69, 19);
            nostenyRadioButton1.TabIndex = 8;
            nostenyRadioButton1.TabStop = true;
            nostenyRadioButton1.Text = "Nőstény";
            nostenyRadioButton1.UseVisualStyleBackColor = true;
            // 
            // himRradioButton1
            // 
            himRradioButton1.AutoSize = true;
            himRradioButton1.Location = new Point(232, 203);
            himRradioButton1.Name = "himRradioButton1";
            himRradioButton1.Size = new Size(48, 19);
            himRradioButton1.TabIndex = 9;
            himRradioButton1.TabStop = true;
            himRradioButton1.Text = "Hím";
            himRradioButton1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.Cancel;
            button1.Location = new Point(112, 345);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "Mégse";
            button1.UseVisualStyleBackColor = true;
            // 
            // okButton2
            // 
            okButton2.Location = new Point(243, 345);
            okButton2.Name = "okButton2";
            okButton2.Size = new Size(75, 23);
            okButton2.TabIndex = 11;
            okButton2.Text = "Ok";
            okButton2.UseVisualStyleBackColor = true;
            okButton2.Click += okButton2_Click;
            // 
            // nevTextBox1
            // 
            nevTextBox1.Location = new Point(134, 253);
            nevTextBox1.Name = "nevTextBox1";
            nevTextBox1.Size = new Size(202, 23);
            nevTextBox1.TabIndex = 12;
            // 
            // AddEgyed
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 386);
            Controls.Add(nevTextBox1);
            Controls.Add(okButton2);
            Controls.Add(button1);
            Controls.Add(himRradioButton1);
            Controls.Add(nostenyRadioButton1);
            Controls.Add(tomegNumericUpDown2);
            Controls.Add(eletkorNumericUpDown1);
            Controls.Add(fajComboBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddEgyed";
            Text = "AddEgyed";
            ((System.ComponentModel.ISupportInitialize)eletkorNumericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tomegNumericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox fajComboBox1;
        private NumericUpDown eletkorNumericUpDown1;
        private NumericUpDown tomegNumericUpDown2;
        private RadioButton nostenyRadioButton1;
        private RadioButton himRradioButton1;
        private Button button1;
        private Button okButton2;
        private TextBox nevTextBox1;
    }
}