using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Twilio;

namespace PhoneCallGoogle
{
    public partial class Text : Form
    {
        public Text()
        {
            InitializeComponent();
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            
            // Find your Account Sid and Auth Token at twilio.com/user/account 
            string AccountSid = "ACd80adc88fe6a85be2e789aa0f866b661";
            string AuthToken = "db4cc0d6a7b98e9d42583cbd57d819d2";
            var twilio = new TwilioRestClient(AccountSid, AuthToken);
            try
            {
                var sms = twilio.SendSmsMessage("+15812000231", "+1" + tbx_Number.Text, tbx_Message.Text);
                Console.WriteLine(sms.Sid);
                MessageBox.Show("Text Sent!");
            }
            catch
            {
                MessageBox.Show("Wrong Number Information!");
            }
            
        }
    }
}
