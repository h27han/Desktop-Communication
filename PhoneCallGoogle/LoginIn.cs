using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PhoneCallGoogle
{
    public partial class LoginIn : Form
    {
        public LoginIn()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Email newMDIChild2 = new Email();
            newMDIChild2.from = tbx_Account.Text;
            newMDIChild2.password = tbx_Password.Text;
            newMDIChild2.fromName = tbx_Name.Text;
            // Set the Parent Form of the Child window.
            newMDIChild2.MdiParent = this.MdiParent;
            // Display the new form.
            newMDIChild2.Show();
        }
    }
}
