using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sing_in_and_up
{
    public partial class Addmoney : Form
    {
        public Addmoney()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
           

        }

        private void registerButton_Click_1(object sender, EventArgs e)
        {
            if (usernameText.Text == "" && textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("Is empty.", "Register faild", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                string query = "INSERT INTO Mymoneys (name,amount,price)" +
                    "VALUES ('" + usernameText.Text + "','" + textBox1.Text + "','" + textBox2.Text + "')";
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Os Home2\Sing in and up\Sing in and up\Database1.mdf"";Integrated Security=True");
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Insert OK");
                    usernameText.Text = textBox1.Text = textBox2.Text = "";
                }
                else
                    MessageBox.Show("Nashod");
                con.Close();
                MessageBox.Show("Your Money Added.", "Add Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                Dashboard.dashboardPage.refresh();
            }
        }
    }

}
