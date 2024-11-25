using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsLibraryMnagementproject
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void txtclose_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
           

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

      

        private void addNewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBooks abs = new AddBooks();
            abs.Show();
        }

        private void viewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewBook ast=new ViewBook();
            ast.Show();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudents ast = new AddStudents();
            ast.Show();
        }

        private void viewStudentDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewStudentInformation ast = new ViewStudentInformation();
            ast.Show();
        }

        private void bookDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           CompleteBookDetails Details=new CompleteBookDetails();
            Details.Show();
        }

        private void issueBookToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close ", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            
                this.Close();
            }

        private void issueBookToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            IssueBook book=new IssueBook();
            book.Show();
        }

        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
           ReturnBook retur=new ReturnBook();
            retur.Show();

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
