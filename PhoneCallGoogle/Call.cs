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
    public partial class Call : Form
    {
        public Call()
        {
            InitializeComponent();
        }

        private void btn_Call_Click(object sender, EventArgs e)
        {
            // Find your Account Sid and Auth Token at twilio.com/user/account 
            string AccountSid = "ACd80adc88fe6a85be2e789aa0f866b661";
            string AuthToken = "db4cc0d6a7b98e9d42583cbd57d819d2";
            var twilio = new TwilioRestClient(AccountSid, AuthToken);

            // Build the parameters 
            var options = new CallOptions();
            options.To = "+1"+tbx_Number.Text;
            options.From = "+15812000231";
            options.Url = "https://www.google.ca/?gfe_rd=cr&#38;ei=dBiUVb26IYaN8Qeo0oGABQ";
            options.Method = "GET";
            options.FallbackMethod = "GET";
            options.StatusCallbackMethod = "GET";
            options.Record = false;

            var call = twilio.InitiateOutboundCall(options);
            Console.WriteLine(call.Sid); 
        }
    }
}
