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
    public partial class CompleteBookDetails : Form
    {
        public CompleteBookDetails()
        {
            InitializeComponent();
        }

        private void CompleteBookDetails_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn = new SqlConnection("Data Source=DESKTOP-R4Q3I88;Initial Catalog=Librarysystem;Integrated Security=true");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection=conn;
            cmd.CommandText = "select  * from IssueBook_Table where book_Return_date  IS null";
            SqlDataAdapter DA=new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
           DA.Fill(DS);
            dataGridView1.DataSource= DS.Tables[0];

            cmd.Connection = conn;
            cmd.CommandText = "select * from IssueBook_Table where book_Return_date IS not null";
            SqlDataAdapter DA1 = new SqlDataAdapter(cmd);
            DataSet DS1 = new DataSet();
            DA1.Fill(DS1);
            dataGridView2.DataSource= DS1.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
