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

namespace WindowsLibraryMnagementproject
{
    public partial class NewLogin : Form
    {
        public NewLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=DESKTOP-R4Q3I88;database=Librarysystem;Integrated Security=true;";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = " insert into Login_Table(username,pass) values('" + txtuserName.Text + "','" +txtpassword.Text + "')";
            conn.Open();
            int x = cmd.ExecuteNonQuery(); //1 on success 0 or fail

            if (x > 0)
            {
                MessageBox.Show("Registration Successfully");
                txtuserName.Text = "";
                txtpassword.Text = "";
                Form1 form=new Form1();
                form.Show();
            }
            else
            {
                MessageBox.Show(" please Enter UserName and password");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure cancel.", "Conformation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK) ;
            {
                this.Close();
                Form1 form=new Form1();
                form.Show();
            }
        }
    }
}
