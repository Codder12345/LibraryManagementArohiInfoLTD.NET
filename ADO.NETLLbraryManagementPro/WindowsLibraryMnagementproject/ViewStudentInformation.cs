using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsLibraryMnagementproject
{
    public partial class ViewStudentInformation : Form
    {
        public ViewStudentInformation()
        {
            InitializeComponent();
        }

        private void ViewStudentInformation_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-R4Q3I88;database=Librarysystem;Integrated Security=true";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from AddStudent_Table";
            SqlDataAdapter da=new SqlDataAdapter(cmd);
            DataSet ds= new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Dou you want to cancel","are you sure",MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Date will Be Deleted Confirm", "Confirmation Dialog", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-R4Q3I88;database=Librarysystem;Integrated Security=true;";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Delete from AddStudent_Table where studID='" + studID + "'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }
        int studID;

        private void Updat_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Date will Be Updated Confirm", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                string studName = txtName.Text;
                string studEnroll = txtEnroll.Text;
                string studDep = txtDep.Text;
                string studSem = txtSem.Text;
                Int64 studContact = Int64.Parse( txtContact.Text);
                string studEmail = txtEmail.Text;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-R4Q3I88;database=Librarysystem;Integrated Security=true;";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "update AddStudent_Table set StudName='" + studName + "',studEnroll='" + studEnroll + "',studDep='" + studDep + "',studSem='" + studSem + "',studContact='" + studContact + "',studEmail='" + studEmail + "' where studID='" + studID + "'";

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                ViewStudentInformation_Load(this, null);
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            ViewStudentInformation_Load(this, null);
            
        }
        int rowid;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtEnrollNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                studID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            panel2.Visible = true;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-R4Q3I88;database=Librarysystem;Integrated Security=true;";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select*from AddStudent_Table where studID=" + studID + "";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            Int64 rowid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
            txtName.Text = ds.Tables[0].Rows[0][1].ToString();
            txtEnroll.Text = ds.Tables[0].Rows[0][2].ToString();
            txtDep.Text = ds.Tables[0].Rows[0][3].ToString();
            txtSem.Text = ds.Tables[0].Rows[0][4].ToString();
            txtContact.Text = ds.Tables[0].Rows[0][5].ToString();
            txtEmail.Text = ds.Tables[0].Rows[0][6].ToString();
        }

        private void txtEnrollNo_TextChanged_1(object sender, EventArgs e)
        {
            if(txtEnrollNo.Text !="")
            {
                label1.Visible = false;
                Image image = Image.FromFile("C:/Users/HI/Pictures/myscreenshot/mvc/8puiO.gif");
                pictureBox1.Image = image;
               
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-R4Q3I88;database=Librarysystem;Integrated Security=true";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from AddStudent_Table where studEnroll like '"+txtEnrollNo.Text+"%'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                label1.Visible = true;
                Image image = Image.FromFile("C:/Users/HI/Pictures/myscreenshot/mvc/searchview.gif");
                pictureBox1.Image = image;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-R4Q3I88;database=Librarysystem;Integrated Security=true";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from AddStudent_Table";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }
    }
    }


