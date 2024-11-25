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
    public partial class ReturnBook : Form
    {
        public ReturnBook()
        {
            InitializeComponent();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
             SqlConnection conn=new SqlConnection();
            conn.ConnectionString = "Data Source=DESKTOP-R4Q3I88;database=Librarysystem;Integrated Security=true;";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
           
            cmd.CommandText = " select * from IssueBook_Table where stud_Enroll='" + txtEnroll.Text + "' and book_Return_date IS NULL";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            if (DS.Tables[0].Rows.Count != 0)
            {
                dataGridView1.DataSource = DS.Tables[0];
            }
            else
            {
                MessageBox.Show("Invalid ID or NO Book Issued","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
           
           
        }

        private void ReturnBook_Load(object sender, EventArgs e)
        {
            panel1.Visible=false;
            txtEnroll.Clear();
        }
        string bname;
        string bdate;
        Int64 rowid;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel1.Visible = true;
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value!=null)
            {
                rowid = Int64.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

                bname =dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();

                bdate = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            }
            txtBookname.Text = bname;
            txtIssuedate.Text = bdate;
        }

        private void txtReturn_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=DESKTOP-R4Q3I88;database=Librarysystem;Integrated Security=true;";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandText = "Update IssueBook_Table set book_Return_date='"+dateTimePicker1.Text+"' where  stud_Enroll='"+txtEnroll.Text+"' and ID='"+rowid+"'";
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Return Successful","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
            ReturnBook_Load(this, null);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Exit", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)

                this.Close();
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            txtEnroll.Clear();
            
        }

        private void txtCancel_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void txtBookname_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtEnroll_TextChanged(object sender, EventArgs e)
        {
            if(txtEnroll.Text=="")
            {
                panel1.Visible = false;
                dataGridView1.DataSource = null;
            }
        }
    }
}
