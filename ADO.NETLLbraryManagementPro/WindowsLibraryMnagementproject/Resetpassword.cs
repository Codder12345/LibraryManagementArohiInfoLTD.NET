using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace WindowsLibraryMnagementproject
{
    public partial class Resetpassword : Form
    {
        string username = Forgotpassword.to;

        public Resetpassword()
        {
            InitializeComponent();
        }

        private void txtReset_Click(object sender, EventArgs e)
        {
            if(txtnewpass.Text==txtverifypass.Text)
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-R4Q3I88;database=Librarysystem;Integrated Security=true");
                SqlCommand cmd = new SqlCommand("UPDATE [dbo].[Login_Table]  SET [pass] = '"+txtverifypass.Text+ "' WHERE  username='"+username+"',conn");
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("reset successfully ");
            }
            else
            {
                MessageBox.Show("the new passsword do not match so enter same password");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure cancel.", "Conformation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK) ;
            {
                this.Close();
            }
        }
    }
}
