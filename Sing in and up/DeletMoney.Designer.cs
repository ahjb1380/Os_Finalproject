namespace Sing_in_and_up
{
    partial class DeletMoney
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
            registerButton = new Button();
            registerpageText = new Label();
            usernameText = new TextBox();
            nameText = new Label();
            SuspendLayout();
            // 
            // registerButton
            // 
            registerButton.BackColor = Color.Red;
            registerButton.Cursor = Cursors.Hand;
            registerButton.FlatAppearance.BorderColor = Color.White;
            registerButton.FlatAppearance.BorderSize = 0;
            registerButton.ForeColor = Color.Black;
            registerButton.Location = new Point(112, 170);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(257, 49);
            registerButton.TabIndex = 18;
            registerButton.Text = "Delete";
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += registerButton_Click;
            // 
            // registerpageText
            // 
            registerpageText.AutoSize = true;
            registerpageText.Cursor = Cursors.Hand;
            registerpageText.Font = new Font("Monotype Corsiva", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            registerpageText.ForeColor = Color.FromArgb(116, 84, 174);
            registerpageText.Location = new Point(112, 9);
            registerpageText.Margin = new Padding(4, 0, 4, 0);
            registerpageText.Name = "registerpageText";
            registerpageText.Size = new Size(234, 49);
            registerpageText.TabIndex = 17;
            registerpageText.Text = "Delete Money";
            // 
            // usernameText
            // 
            usernameText.BackColor = Color.Silver;
            usernameText.Cursor = Cursors.Hand;
            usernameText.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            usernameText.Location = new Point(12, 111);
            usernameText.Multiline = true;
            usernameText.Name = "usernameText";
            usernameText.Size = new Size(442, 31);
            usernameText.TabIndex = 12;
            // 
            // nameText
            // 
            nameText.AutoSize = true;
            nameText.Cursor = Cursors.Hand;
            nameText.Font = new Font("Segoe Print", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            nameText.Location = new Point(13, 78);
            nameText.Margin = new Padding(4, 0, 4, 0);
            nameText.Name = "nameText";
            nameText.Size = new Size(63, 30);
            nameText.TabIndex = 11;
            nameText.Text = "Name";
            // 
            // DeletMoney
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 247);
            Controls.Add(registerButton);
            Controls.Add(registerpageText);
            Controls.Add(usernameText);
            Controls.Add(nameText);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DeletMoney";
            Text = "DeletMoney";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button registerButton;
        private Label registerpageText;
        private TextBox usernameText;
        private Label nameText;
    }
}