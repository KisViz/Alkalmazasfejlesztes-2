namespace het8
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
            userNameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            CancelButton = new Button();
            loginButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 61);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 0;
            label1.Text = "Felhazsnálónév";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 106);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(37, 15);
            label2.TabIndex = 1;
            label2.Text = "Jelszó";
            label2.Click += label2_Click;
            // 
            // userNameTextBox
            // 
            userNameTextBox.Location = new Point(146, 58);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(100, 23);
            userNameTextBox.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(146, 103);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '&';
            passwordTextBox.Size = new Size(100, 23);
            passwordTextBox.TabIndex = 3;
            // 
            // CancelButton
            // 
            CancelButton.DialogResult = DialogResult.Cancel;
            CancelButton.Location = new Point(36, 159);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(75, 23);
            CancelButton.TabIndex = 4;
            CancelButton.Text = "Mégsem";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += cencelButton_kilep;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(146, 159);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(92, 23);
            loginButton.TabIndex = 5;
            loginButton.Text = "Bejelentkezés";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            loginButton.Click += loginButton_Click2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(783, 430);
            Controls.Add(loginButton);
            Controls.Add(CancelButton);
            Controls.Add(passwordTextBox);
            Controls.Add(userNameTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "6. Hét";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox userNameTextBox;
        internal TextBox passwordTextBox;
        private Button CancelButton;
        private Button loginButton;
    }
}
