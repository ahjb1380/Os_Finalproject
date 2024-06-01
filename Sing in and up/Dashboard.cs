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
    public partial class Dashboard : Form
    {

        public DataGridView test;
        public static Dashboard dashboardPage;
        public Dashboard()
        {
            InitializeComponent();
            dashboardPage = this;
        }



        //Load:

        private void Dashboard_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\Os Home2\\Sing in and up\\Sing in and up\\Database1.mdf\";Integrated Security=True");
            con.Open();

            SqlDataAdapter adpter = new SqlDataAdapter("SELECT * FROM Mymoneys", con);
            DataTable dtb = new DataTable();
            adpter.Fill(dtb);


            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dtb;
            test = dataGridView1;


            con.Close();
        }


        //DeletButten:

        private void button1_Click(object sender, EventArgs e)
        {
            DeletMoney del = new DeletMoney();
            del.Show();

        }

        //Add butten:

        private void button2_Click(object sender, EventArgs e)
        {
            Addmoney add = new Addmoney();
            add.Show();

        }
        public void refresh() {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\Os Home2\\Sing in and up\\Sing in and up\\Database1.mdf\";Integrated Security=True");
            con.Open();

            SqlDataAdapter adpter = new SqlDataAdapter("SELECT * FROM Mymoneys", con);
            DataTable dtb = new DataTable();
            adpter.Fill(dtb);


            test.AutoGenerateColumns = false;
            test.DataSource = dtb;


            con.Close();
        }
        
    }
}
