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
   
    public partial class AddBooks : Form
    {
        public AddBooks()
        {
            InitializeComponent();
        }
         SqlConnection conn = new SqlConnection();
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void AddBook_Click(object sender, EventArgs e)
        {

        }

        private void AddBooks_Load(object sender, EventArgs e)
        {

        }

        private void BookQuantity_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtBookName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {

                conn = new SqlConnection("Data Source=DESKTOP-R4Q3I88;Initial Catalog=Librarysystem;Integrated Security=true");
                conn.Open();
                SqlCommand cmd = new SqlCommand("Insert into  AddBook_Table values (@bName,@bAuthor,@bPublication,@bDate,@bPrice,@bQuantity)", conn);
                cmd.Parameters.AddWithValue("@bName", txtBookName.Text);
                cmd.Parameters.AddWithValue("@bAuthor", txtAuthor.Text);
                cmd.Parameters.AddWithValue("@bPublication", txtPublication.Text);
                cmd.Parameters.AddWithValue("@bDate", txtPublicationDate.Text);
                cmd.Parameters.AddWithValue("@bPrice", txtBookPrice.Text);
                cmd.Parameters.AddWithValue("@bQuantity", txtBookQuantity.Text);

                int x = cmd.ExecuteNonQuery(); //1 on success 0 or fail

                if (x > 0)
                {
                    MessageBox.Show("Inserted Successfully");
                    txtBookName.Text = "";
                    txtAuthor.Text = "";
                    txtPublication.Text = "";
                    txtPublicationDate.Text = "";
                    txtBookPrice.Text = "";
                    txtBookQuantity.Text = "";
                    

                }
                else
                {
                    MessageBox.Show("Something Went Wrong");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do you want to Cancel unsaved Book") ;
            this.Close();
        }
    }
}
