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
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            NewLogin newLog = new NewLogin();
            this.Hide();
            newLog.Show();

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=DESKTOP-R4Q3I88;database=Librarysystem;Integrated Security=true;";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection= conn;
            cmd.CommandText = " select *from Login_Table where username='" + textusername.Text + "' and pass='" + txtpassword.Text + "'";
            SqlDataAdapter da=new SqlDataAdapter(cmd);
            DataSet ds=new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count > 0)
            {
                this.Hide();
                Dashboard dsa = new Dashboard();
                dsa.Show();
            }
            else
            {
                MessageBox.Show("wrong user ID or Password","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void beClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtusername_MouseEnter(object sender, EventArgs e)
        {
            if(textusername.Text=="UserName")
            {
                textusername.Clear();
            }

        }

        private void txtpassword_MouseEnter(object sender, EventArgs e)
        {
            if (txtpassword.Text == "Password")
            {
                txtpassword.Clear();
                txtpassword.PasswordChar = '*';
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void picturefacebook_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("A==");

        }

        private void pictureyoutube_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.youtube.com/@poojawaykar7905");

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureinstagram_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://instagram.com/codder_1234?igshid=OGQ5ZDc2ODk2ZA==");

        }

        private void label1_Click(object sender, EventArgs e)
        {
               Forgotpassword fog=new Forgotpassword();
            this.Hide();
            fog.Show();
        }
    }
}
