using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Net.NetworkInformation;

namespace Sing_in_and_up
{
    public partial class LoginPage : Form
    {

        public LoginPage()
        {
            InitializeComponent();
        }

        //LoginButten:
        private void registerButton_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM users WHERE username='" + usernameText.Text + "' And password='" + passwordText.Text + "'";
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Os Home2\Sing in and up\Sing in and up\Database1.mdf"";Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                Dashboard dash = new Dashboard();
                dash.Show();
                this.Close();
            }
            else {
                MessageBox.Show("Error,Username or Password is Wrong.");

            }
            clear();
            con.Close();


           
            
        }


        //ClearButten:
        private void clearButten(object sender, EventArgs e)
        {
            clear();
            usernameText.Focus();
        }

        //Check box show password:

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxShowPass.Checked)
            {
                passwordText.PasswordChar = '\0';

            }
            else
            {
                passwordText.PasswordChar = '0';
            }
        }

        //go to registrepage:
        private void label6_Click(object sender, EventArgs e)
        {
            RegisterPage reg=new RegisterPage();
            reg.Show();
            //this.Close();
        }

        private void clear()
        {
            usernameText.Text = "";
            passwordText.Text = "";
        }




        private void registerpageText_Click(object sender, EventArgs e)
        {

        }

      
        private void LoginPage_Load(object sender, EventArgs e)
        {

        }


    }
}
