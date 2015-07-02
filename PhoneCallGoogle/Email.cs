using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace PhoneCallGoogle
{
    public partial class Email : Form
    {

        public string from;
        public string fromName;
        public string password;

        public Email()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var fromAddress = new MailAddress(from, fromName);
            var toAddress = new MailAddress(tbx_To.Text, "Recipient");
            string fromPassword = password;
            string subject = tbx_Subject.Text;
            string body =tbx_Message.Text;

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                try
                {
                    smtp.Send(message);
                    MessageBox.Show("Email Sent!");
                }
                catch
                {
                    MessageBox.Show("Wrong Login/Recipent Information!");
                }
            }

            
        }

        private void Email_Load(object sender, EventArgs e)
        {
            
        }
    }
}
