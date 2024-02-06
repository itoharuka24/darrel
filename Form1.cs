using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sample_user_login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
          string username = txtUsername.Text;
          string password = txtPassword.Text;

                
          if (username == "admin" && password == "123")
          {
                dashboard dashboardForm = new dashboard();
                dashboardForm.Show();
                this.Hide();
                MessageBox.Show("Login successful");   
          }
         else
          {
           MessageBox.Show("Invalid username or password");
          }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        { 
          this.Close(); 
        }
    }
}
