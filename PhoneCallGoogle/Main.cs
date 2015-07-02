using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Twilio;

using System.Net;
using System.Net.Mail;


namespace PhoneCallGoogle
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

           
                Instruction newMDIChild = new Instruction();
                // Set the Parent Form of the Child window.
                newMDIChild.MdiParent = this;
                // Display the new form.
                newMDIChild.Show();



                

                

            }
          


            

        

        private void textToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Text newMDIChild = new Text();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
        }

        private void callToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Call newMDIChild = new Call();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void emailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginIn newMDIChild = new LoginIn();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
        }

    }
}
