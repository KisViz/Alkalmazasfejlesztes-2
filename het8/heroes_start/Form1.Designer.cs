namespace heroes_start
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ageNumericUpDown1 = new NumericUpDown();
            nameTextBox1 = new TextBox();
            heroNameTextBox2 = new TextBox();
            powerTextBox3 = new TextBox();
            cancelButton = new Button();
            adddButton = new Button();
            ((System.ComponentModel.ISupportInitialize)ageNumericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 34);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 93);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 1;
            label2.Text = "Hero Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 147);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 2;
            label3.Text = "Power";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 210);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 3;
            label4.Text = "Age";
            // 
            // ageNumericUpDown1
            // 
            ageNumericUpDown1.Location = new Point(197, 208);
            ageNumericUpDown1.Maximum = new decimal(new int[] { 250, 0, 0, 0 });
            ageNumericUpDown1.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            ageNumericUpDown1.Name = "ageNumericUpDown1";
            ageNumericUpDown1.Size = new Size(120, 23);
            ageNumericUpDown1.TabIndex = 4;
            ageNumericUpDown1.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // nameTextBox1
            // 
            nameTextBox1.Location = new Point(197, 31);
            nameTextBox1.Name = "nameTextBox1";
            nameTextBox1.Size = new Size(100, 23);
            nameTextBox1.TabIndex = 5;
            // 
            // heroNameTextBox2
            // 
            heroNameTextBox2.Location = new Point(197, 90);
            heroNameTextBox2.Name = "heroNameTextBox2";
            heroNameTextBox2.Size = new Size(100, 23);
            heroNameTextBox2.TabIndex = 6;
            // 
            // powerTextBox3
            // 
            powerTextBox3.Location = new Point(197, 139);
            powerTextBox3.Name = "powerTextBox3";
            powerTextBox3.Size = new Size(100, 23);
            powerTextBox3.TabIndex = 7;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(46, 274);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 8;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // adddButton
            // 
            adddButton.Location = new Point(197, 274);
            adddButton.Name = "adddButton";
            adddButton.Size = new Size(75, 23);
            adddButton.TabIndex = 9;
            adddButton.Text = "Add";
            adddButton.UseVisualStyleBackColor = true;
            adddButton.Click += adddButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(adddButton);
            Controls.Add(cancelButton);
            Controls.Add(powerTextBox3);
            Controls.Add(heroNameTextBox2);
            Controls.Add(nameTextBox1);
            Controls.Add(ageNumericUpDown1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Add hero";
            ((System.ComponentModel.ISupportInitialize)ageNumericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private NumericUpDown ageNumericUpDown1;
        private TextBox nameTextBox1;
        private TextBox heroNameTextBox2;
        private TextBox powerTextBox3;
        private Button cancelButton;
        private Button adddButton;
    }
}
