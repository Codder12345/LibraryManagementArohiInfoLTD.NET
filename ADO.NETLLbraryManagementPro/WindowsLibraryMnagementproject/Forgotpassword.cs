using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;



namespace WindowsLibraryMnagementproject
{
    public partial class Forgotpassword : Form
    {
        string Randomcode;
        public static string  to;

        public Forgotpassword()
        {
            InitializeComponent();
        }

        private void sendcode_Click(object sender, EventArgs e)
        {
            string from, pass, messageBody;
            Random rand = new Random();
            Randomcode=(rand.Next(999999)).ToString();
            MailMessage message= new MailMessage();
            to =(txtEmail.Text).ToString();
            from="waykarpooja5@gmail.com";
            pass = "9075272433";
            messageBody = "your reset cod is" + Randomcode;
            message.To.Add(to);
            message.From=new MailAddress(from);
           message.Body=messageBody;
            message.Subject = "password reseting code";
            SmtpClient smtp=new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;  
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from,pass);
            try
            {
                smtp.Send(message);
                MessageBox.Show(" code send successfully");


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }

        private void Resendcode_Click(object sender, EventArgs e)
        {
            if(Randomcode==(txtverify.Text).ToString())
            {
                to = txtEmail.Text;
                Resetpassword rp=new Resetpassword();
                this.Hide();
                rp.Show();

            }
            else
            {
                MessageBox.Show("Wrong code");
            }
            
        }
    }
}
