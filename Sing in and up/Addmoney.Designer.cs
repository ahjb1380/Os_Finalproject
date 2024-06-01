namespace Sing_in_and_up
{
    partial class Addmoney
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
            nameText = new Label();
            usernameText = new TextBox();
            pricetext = new Label();
            amountText = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            registerpageText = new Label();
            registerButton = new Button();
            SuspendLayout();
            // 
            // nameText
            // 
            nameText.AutoSize = true;
            nameText.Cursor = Cursors.Hand;
            nameText.Font = new Font("Segoe Print", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            nameText.Location = new Point(13, 75);
            nameText.Margin = new Padding(4, 0, 4, 0);
            nameText.Name = "nameText";
            nameText.Size = new Size(63, 30);
            nameText.TabIndex = 2;
            nameText.Text = "Name";
            nameText.Click += label2_Click;
            // 
            // usernameText
            // 
            usernameText.BackColor = Color.Silver;
            usernameText.Cursor = Cursors.Hand;
            usernameText.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            usernameText.Location = new Point(12, 108);
            usernameText.Multiline = true;
            usernameText.Name = "usernameText";
            usernameText.Size = new Size(442, 31);
            usernameText.TabIndex = 4;
            // 
            // pricetext
            // 
            pricetext.AutoSize = true;
            pricetext.Cursor = Cursors.Hand;
            pricetext.Font = new Font("Segoe Print", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            pricetext.Location = new Point(12, 209);
            pricetext.Margin = new Padding(4, 0, 4, 0);
            pricetext.Name = "pricetext";
            pricetext.Size = new Size(57, 30);
            pricetext.TabIndex = 5;
            pricetext.Text = "Price";
            // 
            // amountText
            // 
            amountText.AutoSize = true;
            amountText.Cursor = Cursors.Hand;
            amountText.Font = new Font("Segoe Print", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            amountText.Location = new Point(12, 142);
            amountText.Margin = new Padding(4, 0, 4, 0);
            amountText.Name = "amountText";
            amountText.Size = new Size(82, 30);
            amountText.TabIndex = 6;
            amountText.Text = "Amount";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Silver;
            textBox1.Cursor = Cursors.Hand;
            textBox1.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(12, 175);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(442, 31);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Silver;
            textBox2.Cursor = Cursors.Hand;
            textBox2.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(12, 242);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(442, 31);
            textBox2.TabIndex = 8;
            // 
            // registerpageText
            // 
            registerpageText.AutoSize = true;
            registerpageText.Cursor = Cursors.Hand;
            registerpageText.Font = new Font("Monotype Corsiva", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            registerpageText.ForeColor = Color.FromArgb(116, 84, 174);
            registerpageText.Location = new Point(149, 9);
            registerpageText.Margin = new Padding(4, 0, 4, 0);
            registerpageText.Name = "registerpageText";
            registerpageText.Size = new Size(199, 49);
            registerpageText.TabIndex = 9;
            registerpageText.Text = "Add Money";
            // 
            // registerButton
            // 
            registerButton.BackColor = Color.FromArgb(116, 86, 174);
            registerButton.Cursor = Cursors.Hand;
            registerButton.FlatAppearance.BorderColor = Color.White;
            registerButton.FlatAppearance.BorderSize = 0;
            registerButton.ForeColor = Color.White;
            registerButton.Location = new Point(112, 291);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(257, 49);
            registerButton.TabIndex = 10;
            registerButton.Text = "Add";
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += registerButton_Click_1;
            // 
            // Addmoney
            // 
            AutoScaleDimensions = new SizeF(10F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 367);
            Controls.Add(registerButton);
            Controls.Add(registerpageText);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(amountText);
            Controls.Add(pricetext);
            Controls.Add(usernameText);
            Controls.Add(nameText);
            Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Addmoney";
            Text = "Addmoney";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameText;
        private TextBox usernameText;
        private Label pricetext;
        private Label amountText;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label registerpageText;
        private Button registerButton;
    }
}