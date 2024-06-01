using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.Xml.Linq;

namespace Sing_in_and_up
{
    public partial class RegisterPage : Form
    {


        public RegisterPage()
        {
            InitializeComponent();

        }
        private void registerButton_Click(object sender, EventArgs e)
        {
      

            if (usernameText.Text == "" && passwordText.Text == "" && confirmPassword.Text == "")
            {
                MessageBox.Show("Is empty.", "Register faild", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (passwordText.Text == confirmPassword.Text)
            {
                string query = "INSERT INTO users (username,password)" +
                    "VALUES ('" + usernameText.Text + "','" + passwordText.Text + "')";
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Os Home2\Sing in and up\Sing in and up\Database1.mdf"";Integrated Security=True");
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Insert OK");
                    usernameText.Text =passwordText.Text  = "";
                    clear();
                }
                else
                    MessageBox.Show("Nashod");
                con.Close();

               
                MessageBox.Show("Your Account Created.", "Register Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {
                MessageBox.Show("Password dont match,please Try Again,", "Register failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clear();
                
                passwordText.Focus();
            }
        }




        //CHECKBOx SHOW PASSWORD:
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxShowPass.Checked)
            {
                passwordText.PasswordChar = '\0';
                confirmPassword.PasswordChar = '\0';

            }
            else
            {
                passwordText.PasswordChar = '0';
                confirmPassword.PasswordChar = '0';
            }
        }

        //Clear Butten:
        private void button1_Click(object sender, EventArgs e)
        {
            clear();
            usernameText.Focus();
        }
        private void clear() {
            usernameText.Text = "";
            passwordText.Text = "";
            confirmPassword.Text = "";
        }


        private void label6_Click(object sender, EventArgs e)
        {

            LoginPage log =new LoginPage();
            log.Show();
            this.Hide();
        }





































        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void registerpageText_Click(object sender, EventArgs e)
        {

        }

        private void RegisterPage_Load(object sender, EventArgs e)
        {

        }

       
    }
}