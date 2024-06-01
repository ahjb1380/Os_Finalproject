using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sing_in_and_up
{
    public partial class WelcomPage : Form
    {
        public WelcomPage()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            RegisterPage reg = new RegisterPage();
            reg.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginPage reg = new LoginPage();
            reg.Show();
            this.Hide();

        }
    }
}
