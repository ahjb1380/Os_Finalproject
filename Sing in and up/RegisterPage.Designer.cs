
namespace Sing_in_and_up
{
    partial class RegisterPage
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
            registerpageText = new Label();
            label2 = new Label();
            label3 = new Label();
            usernameText = new TextBox();
            passwordText = new TextBox();
            registerButton = new Button();
            label4 = new Label();
            label5 = new Label();
            confirmPassword = new TextBox();
            button1 = new Button();
            checkboxShowPass = new CheckBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // registerpageText
            // 
            registerpageText.AutoSize = true;
            registerpageText.Cursor = Cursors.Hand;
            registerpageText.Font = new Font("Monotype Corsiva", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            registerpageText.ForeColor = Color.FromArgb(116, 84, 174);
            registerpageText.Location = new Point(286, 9);
            registerpageText.Margin = new Padding(4, 0, 4, 0);
            registerpageText.Name = "registerpageText";
            registerpageText.Size = new Size(156, 49);
            registerpageText.TabIndex = 0;
            registerpageText.Text = "Register ";
            registerpageText.Click += registerpageText_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(77, 119);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(113, 35);
            label2.TabIndex = 1;
            label2.Text = "Username";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(77, 219);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(109, 35);
            label3.TabIndex = 2;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // usernameText
            // 
            usernameText.BackColor = Color.Silver;
            usernameText.Cursor = Cursors.Hand;
            usernameText.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            usernameText.Location = new Point(77, 157);
            usernameText.Multiline = true;
            usernameText.Name = "usernameText";
            usernameText.Size = new Size(544, 38);
            usernameText.TabIndex = 3;
            usernameText.TextChanged += textBox1_TextChanged;
            // 
            // passwordText
            // 
            passwordText.BackColor = Color.Silver;
            passwordText.Cursor = Cursors.Hand;
            passwordText.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            passwordText.Location = new Point(77, 257);
            passwordText.Multiline = true;
            passwordText.Name = "passwordText";
            passwordText.Size = new Size(544, 42);
            passwordText.TabIndex = 4;
            // 
            // registerButton
            // 
            registerButton.BackColor = Color.FromArgb(116, 86, 174);
            registerButton.Cursor = Cursors.Hand;
            registerButton.FlatAppearance.BorderColor = Color.White;
            registerButton.FlatAppearance.BorderSize = 0;
            registerButton.ForeColor = Color.White;
            registerButton.Location = new Point(77, 490);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(544, 49);
            registerButton.TabIndex = 5;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += registerButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(77, 326);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(198, 35);
            label4.TabIndex = 6;
            label4.Text = "Confirm Password";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.Hand;
            label5.Location = new Point(141, 499);
            label5.Name = "label5";
            label5.Size = new Size(0, 30);
            label5.TabIndex = 7;
            // 
            // confirmPassword
            // 
            confirmPassword.BackColor = Color.Silver;
            confirmPassword.Cursor = Cursors.Hand;
            confirmPassword.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            confirmPassword.Location = new Point(77, 373);
            confirmPassword.Multiline = true;
            confirmPassword.Name = "confirmPassword";
            confirmPassword.Size = new Size(544, 36);
            confirmPassword.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Cursor = Cursors.Hand;
            button1.ForeColor = Color.FromArgb(116, 86, 174);
            button1.Location = new Point(77, 545);
            button1.Name = "button1";
            button1.Size = new Size(544, 49);
            button1.TabIndex = 9;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // checkboxShowPass
            // 
            checkboxShowPass.AutoSize = true;
            checkboxShowPass.Location = new Point(451, 431);
            checkboxShowPass.Name = "checkboxShowPass";
            checkboxShowPass.Size = new Size(170, 34);
            checkboxShowPass.TabIndex = 11;
            checkboxShowPass.Text = "Show Password";
            checkboxShowPass.UseVisualStyleBackColor = true;
            checkboxShowPass.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(213, 597);
            label6.Name = "label6";
            label6.Size = new Size(271, 30);
            label6.TabIndex = 12;
            label6.Text = "Already Back to Login Page ?";
            label6.Click += label6_Click;
            // 
            // RegisterPage
            // 
            AutoScaleDimensions = new SizeF(11F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(725, 718);
            Controls.Add(label6);
            Controls.Add(checkboxShowPass);
            Controls.Add(button1);
            Controls.Add(confirmPassword);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(registerButton);
            Controls.Add(passwordText);
            Controls.Add(usernameText);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(registerpageText);
            Font = new Font("Segoe Print", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "RegisterPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += RegisterPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label registerpageText;
        private Label label2;
        private Label label3;
        private TextBox usernameText;
        private TextBox passwordText;
        private Button registerButton;
        private Label label4;
        private Label label5;
        private TextBox confirmPassword;
        private Button button1;
        private CheckBox checkboxShowPass;
        private Label label6;
    }
}