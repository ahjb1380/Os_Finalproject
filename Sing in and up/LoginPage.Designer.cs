namespace Sing_in_and_up
{
    partial class LoginPage
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
            label6 = new Label();
            checkboxShowPass = new CheckBox();
            button1 = new Button();
            label5 = new Label();
            registerButton = new Button();
            passwordText = new TextBox();
            usernameText = new TextBox();
            label3 = new Label();
            label2 = new Label();
            registerpageText = new Label();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.Location = new Point(163, 574);
            label6.Name = "label6";
            label6.Size = new Size(339, 30);
            label6.TabIndex = 24;
            label6.Text = "Dont have Account ? Create Account.";
            label6.Click += label6_Click;
            // 
            // checkboxShowPass
            // 
            checkboxShowPass.AutoSize = true;
            checkboxShowPass.Cursor = Cursors.Hand;
            checkboxShowPass.Location = new Point(455, 356);
            checkboxShowPass.Name = "checkboxShowPass";
            checkboxShowPass.Size = new Size(170, 34);
            checkboxShowPass.TabIndex = 23;
            checkboxShowPass.Text = "Show Password";
            checkboxShowPass.UseVisualStyleBackColor = true;
            checkboxShowPass.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Cursor = Cursors.Hand;
            button1.ForeColor = Color.FromArgb(116, 86, 174);
            button1.Location = new Point(30, 509);
            button1.Name = "button1";
            button1.Size = new Size(595, 49);
            button1.TabIndex = 22;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = false;
            button1.Click += clearButten;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.Hand;
            label5.Location = new Point(141, 509);
            label5.Name = "label5";
            label5.Size = new Size(0, 30);
            label5.TabIndex = 20;
            // 
            // registerButton
            // 
            registerButton.BackColor = Color.FromArgb(116, 86, 174);
            registerButton.Cursor = Cursors.Hand;
            registerButton.FlatAppearance.BorderColor = Color.White;
            registerButton.FlatAppearance.BorderSize = 0;
            registerButton.ForeColor = Color.White;
            registerButton.Location = new Point(30, 433);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(595, 53);
            registerButton.TabIndex = 18;
            registerButton.Text = "Login";
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += registerButton_Click;
            // 
            // passwordText
            // 
            passwordText.BackColor = Color.Silver;
            passwordText.Cursor = Cursors.Hand;
            passwordText.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            passwordText.Location = new Point(30, 274);
            passwordText.Multiline = true;
            passwordText.Name = "passwordText";
            passwordText.Size = new Size(595, 42);
            passwordText.TabIndex = 17;
            // 
            // usernameText
            // 
            usernameText.BackColor = Color.Silver;
            usernameText.Cursor = Cursors.Hand;
            usernameText.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            usernameText.Location = new Point(30, 167);
            usernameText.Multiline = true;
            usernameText.Name = "usernameText";
            usernameText.Size = new Size(595, 38);
            usernameText.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(32, 227);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(109, 35);
            label3.TabIndex = 15;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(30, 129);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(113, 35);
            label2.TabIndex = 14;
            label2.Text = "Username";
            // 
            // registerpageText
            // 
            registerpageText.AutoSize = true;
            registerpageText.Cursor = Cursors.Hand;
            registerpageText.Font = new Font("Monotype Corsiva", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            registerpageText.ForeColor = Color.FromArgb(116, 84, 174);
            registerpageText.Location = new Point(256, 9);
            registerpageText.Margin = new Padding(4, 0, 4, 0);
            registerpageText.Name = "registerpageText";
            registerpageText.Size = new Size(120, 49);
            registerpageText.TabIndex = 13;
            registerpageText.Text = "Log in";
            registerpageText.Click += registerpageText_Click;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(11F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 640);
            Controls.Add(label6);
            Controls.Add(checkboxShowPass);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(registerButton);
            Controls.Add(passwordText);
            Controls.Add(usernameText);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(registerpageText);
            Cursor = Cursors.Hand;
            Font = new Font("Segoe Print", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "LoginPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginPage";
            Load += LoginPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private CheckBox checkboxShowPass;
        private Button button1;
        private Label label5;
        private Button registerButton;
        private TextBox passwordText;
        private TextBox usernameText;
        private Label label3;
        private Label label2;
        private Label registerpageText;
    }
}