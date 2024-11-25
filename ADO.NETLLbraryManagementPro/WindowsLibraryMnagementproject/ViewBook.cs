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
using static System.Windows.Forms.AxHost;
using System.Xml.Linq;

namespace WindowsLibraryMnagementproject
{
    public partial class ViewBook : Form
    {
        public ViewBook()
        {
            InitializeComponent();
        }

        private void ViewBook_Load(object sender, EventArgs e)
        {
            panel2.Visible= false;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-R4Q3I88;database=Librarysystem;Integrated Security=true;";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select*from AddBook_Table";
            SqlDataAdapter da=new SqlDataAdapter(cmd);
            DataSet ds= new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource= ds.Tables[0];


        }

        private void txtview_Click(object sender, EventArgs e)
        {

        }

        private void txtrefresh_Click(object sender, EventArgs e)
        {

            txtBookName.Clear();
            panel2.Visible= false;
        }
        int bid;
        Int64 rowid;
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value!=null)
            {
                bid=int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            panel2.Visible = true;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-R4Q3I88;database=Librarysystem;Integrated Security=true;";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select*from AddBook_Table where bid="+bid+"";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
           Int64 rowid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
            txtName.Text = ds.Tables[0].Rows[0][1].ToString();
            txtAuthor.Text = ds.Tables[0].Rows[0][2].ToString();
            txtPublication.Text = ds.Tables[0].Rows[0][3].ToString();
            txtPrice.Text = ds.Tables[0].Rows[0][5].ToString();
            txtQuantity.Text = ds.Tables[0].Rows[0][6].ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Do you want to close ", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
                panel2.Visible = false;
            }
           
        }

        private void txtBookName_TextChanged(object sender, EventArgs e)
        {
            if(txtBookName.Text!="")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-R4Q3I88;database=Librarysystem;Integrated Security=true;";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select*from AddBook_Table where bName like'"+txtBookName.Text+"%'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-R4Q3I88;database=Librarysystem;Integrated Security=true;";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select*from AddBook_Table";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }
       
        private void txtUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Date will Be Updated Confirm", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string bName = txtName.Text;
                string bAuthor = txtAuthor.Text;
                string bPublication = txtPublication.Text;
                string bDate = txtDate.Text;
                string bPrice = txtPrice.Text;
                string bQuantity = txtQuantity.Text;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-R4Q3I88;database=Librarysystem;Integrated Security=true;";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "update AddBook_Table set bName='" + bName + "',bAuthor='" + bAuthor + "',bPublication='" + bPublication + "',bDate='" + bDate + "',bPrice='" + bPrice + "',bQuantity='" + bQuantity + "' where bid='" + rowid + "'";

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
            }
        }

        private void txtDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Date will Be Deleted Confirm", "Confirmation Dialog", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-R4Q3I88;database=Librarysystem;Integrated Security=true;";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Delete from AddBook_Table where bid='" + bid + "'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
