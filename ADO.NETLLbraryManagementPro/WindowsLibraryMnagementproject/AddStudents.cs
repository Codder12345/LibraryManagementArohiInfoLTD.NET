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
    public partial class AddStudents : Form
    {
        public AddStudents()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("do you want cancel close", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtEnrollment.Clear();
            txtDep.Clear();
            txtsem.Clear();
            txtcontact.Clear();
            txtemail.Clear();
            
        }

        private void saveinfo_Click(object sender, EventArgs e)
        {
            string name=txtName.Text;
            string enrollment=txtEnrollment.Text;
            string dep=txtDep.Text;
            string sem=txtsem.Text;
            string contact=txtcontact.Text;
            string email=txtemail.Text;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=;Initial Catalog=Librarysystem;integrated Security=true";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            con.Open();
            cmd.CommandText = "insert into AddStudent_Table(studName,studEnroll,studDep,studSem,studContact,studEmail)values('" + name + "','" + enrollment + "','" + dep + "','" + sem + "','" + contact + "','"+email+"')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Saved","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void AddStudents_Load(object sender, EventArgs e)
        {
           
        }
    }
}
