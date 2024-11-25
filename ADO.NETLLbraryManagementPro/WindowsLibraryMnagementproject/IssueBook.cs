using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsLibraryMnagementproject
{
    public partial class IssueBook : Form
    {
        public IssueBook()
        {
            InitializeComponent();
        }

        private void IssueBook_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=DESKTOP-R4Q3I88;database=Librarysystem;Integrated Security=true;";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Open();

            cmd = new SqlCommand( " select bName from AddBook_Table",conn);
            SqlDataReader rdr = cmd.ExecuteReader();
            while(rdr.Read())
            {
                for (int i = 0; i < rdr.FieldCount; i++)
                {
                    comboBooks.Items.Add(rdr.GetString(i));
                }
            }
            rdr.Close();
            conn.Close();
            } 

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
        int count;
        private void btnsearch_Click(object sender, EventArgs e)
        {
           
           if(txtEnroll.Text !="")
            {
                string edi=txtEnroll.Text;
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "Data Source=DESKTOP-R4Q3I88;database=Librarysystem;Integrated Security=true;";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                conn.Open();

                cmd.CommandText = " select * from AddStudent_Table where studEnroll='"+edi+"'";
               SqlDataAdapter DA=new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                //******************************************************************************
                //code to count how many book has been issued on this enrollment number
                cmd.CommandText = " select count(stud_Enroll)from IssueBook_Table where stud_Enroll='" + edi + "' and book_Return_date is null";
                SqlDataAdapter DA1 = new SqlDataAdapter(cmd);
                DataSet DS1 = new DataSet();
                DA.Fill(DS1);

                count = int.Parse(DS1.Tables[0].Rows[0][0].ToString());

                //******************************************************************************


                if (DS.Tables[0].Rows.Count != 0)
                {
                    txtName.Text = DS.Tables[0].Rows[0][1].ToString();
                    txtDep.Text = DS.Tables[0].Rows[0][3].ToString();
                    txtSem.Text = DS.Tables[0].Rows[0][4].ToString();
                    txtContact.Text = DS.Tables[0].Rows[0][5].ToString();
                    txtEmail.Text = DS.Tables[0].Rows[0][6].ToString();

                }
                else
                {
                    txtContact.Clear();
                    txtName.Clear();
                    txtEnroll.Clear();
                    txtDep.Clear();
                    txtEmail.Clear();
                    txtSem.Clear();
                    MessageBox.Show("Invalid EnrollmentNo ","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Exit", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            
                this.Close();
            }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            txtContact.Clear();
            txtName.Clear();
            txtEnroll.Clear();
            txtDep.Clear();
            txtEmail.Clear();
            txtSem.Clear();
            
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if(txtName.Text !="")
            {
                 if(comboBooks.SelectedIndex !=-1 && count<=2)
                {
                  string Enroll=txtEnroll.Text;
                    string studName = txtName.Text;
                    string studDep = txtDep.Text;
                    string studSem = txtSem.Text;
                    string studContact = txtContact.Text;
                    string studEmail = txtEmail.Text;
                    string bookName = comboBooks.Text;
                    string bookIssuedate = dateTimePicker1.Text;

                    string edi = txtEnroll.Text;
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = "Data Source=DESKTOP-R4Q3I88;database=Librarysystem;Integrated Security=true;";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    conn.Open();

                    cmd.CommandText = "insert into IssueBook_Table (stud_Enroll,stud_Name,stud_Dep,stud_Sem,stud_Contact,stud_Email,book_Name,book_Issue_date)values ('"+Enroll+"','"+studName+"','"+studDep+"','"+studSem+"','"+studContact+"','"+studEmail+"','"+bookName+"','"+bookIssuedate+"')";
                   cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Book Issued","success",MessageBoxButtons.OK,MessageBoxIcon.Information);


                }
                 else
                {
                    MessageBox.Show(" select Book. or maximum numbers of  Book has been  Issued", "No Book Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show(" Enter Invalid Enrollment  No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void comboBooks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtEnroll_TextChanged(object sender, EventArgs e)
        {
            if(txtEnroll.Text =="")
            {
                txtName.Clear();
                txtDep.Clear();
                txtSem.Clear();
                txtContact.Clear();
                txtEmail.Clear();

            }
        }
    }
}
