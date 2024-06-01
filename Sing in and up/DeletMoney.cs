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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sing_in_and_up
{
    public partial class DeletMoney : Form
    {
        public DeletMoney()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "DELETE FROM Mymoneys WHERE name='" + usernameText.Text+ "'";
                SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Os Home2\Sing in and up\Sing in and up\Database1.mdf"";Integrated Security=True");
                sqlConnection.Open();
                SqlCommand command = new SqlCommand(query, sqlConnection);
                int i = command.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("DELETE OK");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Nashod");
                    this.Hide();
                }
                    
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        
    }
}
