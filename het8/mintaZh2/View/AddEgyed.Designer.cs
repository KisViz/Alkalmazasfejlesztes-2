namespace mintaZh2.View
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
            tomegNumericUpDown1 = new NumericUpDown();
            femaleRadioButton1 = new RadioButton();
            maleRadioButton1 = new RadioButton();
            nevTextBox1 = new TextBox();
            button1 = new Button();
            okButton2 = new Button();
            ((System.ComponentModel.ISupportInitialize)eletkorNumericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tomegNumericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 42);
            label1.Name = "label1";
            label1.Size = new Size(22, 15);
            label1.TabIndex = 0;
            label1.Text = "Faj";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 96);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 1;
            label2.Text = "Életkor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 158);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 2;
            label3.Text = "Tömeg";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 219);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 3;
            label4.Text = "Nem";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 268);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 4;
            label5.Text = "Név";
            // 
            // fajComboBox1
            // 
            fajComboBox1.FormattingEnabled = true;
            fajComboBox1.Location = new Point(145, 39);
            fajComboBox1.Name = "fajComboBox1";
            fajComboBox1.Size = new Size(242, 23);
            fajComboBox1.TabIndex = 5;
            // 
            // eletkorNumericUpDown1
            // 
            eletkorNumericUpDown1.Location = new Point(145, 94);
            eletkorNumericUpDown1.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
            eletkorNumericUpDown1.Name = "eletkorNumericUpDown1";
            eletkorNumericUpDown1.Size = new Size(242, 23);
            eletkorNumericUpDown1.TabIndex = 6;
            // 
            // tomegNumericUpDown1
            // 
            tomegNumericUpDown1.DecimalPlaces = 1;
            tomegNumericUpDown1.Location = new Point(145, 156);
            tomegNumericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            tomegNumericUpDown1.Name = "tomegNumericUpDown1";
            tomegNumericUpDown1.Size = new Size(242, 23);
            tomegNumericUpDown1.TabIndex = 7;
            tomegNumericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // femaleRadioButton1
            // 
            femaleRadioButton1.AutoSize = true;
            femaleRadioButton1.Checked = true;
            femaleRadioButton1.Location = new Point(145, 219);
            femaleRadioButton1.Name = "femaleRadioButton1";
            femaleRadioButton1.Size = new Size(63, 19);
            femaleRadioButton1.TabIndex = 8;
            femaleRadioButton1.TabStop = true;
            femaleRadioButton1.Text = "Female";
            femaleRadioButton1.UseVisualStyleBackColor = true;
            // 
            // maleRadioButton1
            // 
            maleRadioButton1.AutoSize = true;
            maleRadioButton1.Location = new Point(254, 219);
            maleRadioButton1.Name = "maleRadioButton1";
            maleRadioButton1.Size = new Size(51, 19);
            maleRadioButton1.TabIndex = 9;
            maleRadioButton1.Text = "Male";
            maleRadioButton1.UseVisualStyleBackColor = true;
            // 
            // nevTextBox1
            // 
            nevTextBox1.Location = new Point(145, 265);
            nevTextBox1.Name = "nevTextBox1";
            nevTextBox1.Size = new Size(242, 23);
            nevTextBox1.TabIndex = 10;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.Cancel;
            button1.Location = new Point(78, 326);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 11;
            button1.Text = "Mégse";
            button1.UseVisualStyleBackColor = true;
            // 
            // okButton2
            // 
            okButton2.Location = new Point(239, 326);
            okButton2.Name = "okButton2";
            okButton2.Size = new Size(75, 23);
            okButton2.TabIndex = 12;
            okButton2.Text = "Ok";
            okButton2.UseVisualStyleBackColor = true;
            okButton2.Click += okButton2_Click;
            // 
            // AddEgyed
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 380);
            Controls.Add(okButton2);
            Controls.Add(button1);
            Controls.Add(nevTextBox1);
            Controls.Add(maleRadioButton1);
            Controls.Add(femaleRadioButton1);
            Controls.Add(tomegNumericUpDown1);
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
            ((System.ComponentModel.ISupportInitialize)tomegNumericUpDown1).EndInit();
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
        private NumericUpDown tomegNumericUpDown1;
        private RadioButton femaleRadioButton1;
        private RadioButton maleRadioButton1;
        private TextBox nevTextBox1;
        private Button button1;
        private Button okButton2;
    }
}