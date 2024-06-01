namespace Sing_in_and_up
{
    partial class Dashboard
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
            button1 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            Money = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // registerpageText
            // 
            registerpageText.AutoSize = true;
            registerpageText.Cursor = Cursors.Hand;
            registerpageText.Font = new Font("Monotype Corsiva", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            registerpageText.ForeColor = Color.FromArgb(116, 84, 174);
            registerpageText.Location = new Point(147, 9);
            registerpageText.Margin = new Padding(4, 0, 4, 0);
            registerpageText.Name = "registerpageText";
            registerpageText.Size = new Size(188, 49);
            registerpageText.TabIndex = 2;
            registerpageText.Text = "My Profile";
            // 
            // button1
            // 
            button1.BackColor = Color.Firebrick;
            button1.Location = new Point(243, 397);
            button1.Name = "button1";
            button1.Size = new Size(136, 52);
            button1.TabIndex = 3;
            button1.Text = "Delet";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.ForestGreen;
            button2.Location = new Point(385, 397);
            button2.Name = "button2";
            button2.Size = new Size(136, 52);
            button2.TabIndex = 4;
            button2.Text = "Add ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Money, Amount, Price });
            dataGridView1.Location = new Point(4, 76);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(530, 319);
            dataGridView1.TabIndex = 5;
            // 
            // Money
            // 
            Money.DataPropertyName = "name";
            Money.HeaderText = "Money";
            Money.MinimumWidth = 6;
            Money.Name = "Money";
            Money.ReadOnly = true;
            Money.Width = 125;
            // 
            // Amount
            // 
            Amount.DataPropertyName = "amount";
            Amount.HeaderText = "Amount";
            Amount.MinimumWidth = 6;
            Amount.Name = "Amount";
            Amount.ReadOnly = true;
            Amount.Width = 125;
            // 
            // Price
            // 
            Price.DataPropertyName = "price";
            Price.HeaderText = "Price";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.ReadOnly = true;
            Price.Width = 125;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(11F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 589);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(registerpageText);
            Font = new Font("Segoe Print", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label registerpageText;
        private Button button1;
        private Button button2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Money;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn Price;
    }
}