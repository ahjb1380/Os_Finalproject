namespace Sing_in_and_up
{
    partial class WelcomPage
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
            registerpageText = new Label();
            registerButton = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // registerpageText
            // 
            registerpageText.AutoSize = true;
            registerpageText.Cursor = Cursors.Hand;
            registerpageText.Font = new Font("Monotype Corsiva", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            registerpageText.ForeColor = Color.FromArgb(116, 84, 174);
            registerpageText.Location = new Point(323, 18);
            registerpageText.Margin = new Padding(4, 0, 4, 0);
            registerpageText.Name = "registerpageText";
            registerpageText.Size = new Size(306, 49);
            registerpageText.TabIndex = 1;
            registerpageText.Text = "Welcom to Iwallet";
            // 
            // registerButton
            // 
            registerButton.BackColor = Color.FromArgb(116, 86, 174);
            registerButton.Cursor = Cursors.Hand;
            registerButton.FlatAppearance.BorderColor = Color.White;
            registerButton.FlatAppearance.BorderSize = 0;
            registerButton.ForeColor = Color.White;
            registerButton.Location = new Point(219, 234);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(544, 49);
            registerButton.TabIndex = 6;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += registerButton_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Cursor = Cursors.Hand;
            button1.ForeColor = Color.FromArgb(116, 86, 174);
            button1.Location = new Point(219, 318);
            button1.Name = "button1";
            button1.Size = new Size(544, 49);
            button1.TabIndex = 10;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // WelcomPage
            // 
            AutoScaleDimensions = new SizeF(10F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 585);
            Controls.Add(button1);
            Controls.Add(registerButton);
            Controls.Add(registerpageText);
            Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "WelcomPage";
            Text = "WelcomPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label registerpageText;
        private Button registerButton;
        private Button button1;
    }
}