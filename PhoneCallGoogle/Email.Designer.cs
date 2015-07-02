namespace PhoneCallGoogle
{
    partial class Email
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Email));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Send = new System.Windows.Forms.Button();
            this.tbx_To = new System.Windows.Forms.TextBox();
            this.tbx_Subject = new System.Windows.Forms.TextBox();
            this.tbx_Message = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "To:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Subject:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Message:";
            // 
            // btn_Send
            // 
            this.btn_Send.Location = new System.Drawing.Point(104, 211);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(75, 23);
            this.btn_Send.TabIndex = 3;
            this.btn_Send.Text = "Send";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbx_To
            // 
            this.tbx_To.Location = new System.Drawing.Point(80, 46);
            this.tbx_To.Name = "tbx_To";
            this.tbx_To.Size = new System.Drawing.Size(168, 20);
            this.tbx_To.TabIndex = 4;
            // 
            // tbx_Subject
            // 
            this.tbx_Subject.Location = new System.Drawing.Point(80, 79);
            this.tbx_Subject.Name = "tbx_Subject";
            this.tbx_Subject.Size = new System.Drawing.Size(168, 20);
            this.tbx_Subject.TabIndex = 5;
            // 
            // tbx_Message
            // 
            this.tbx_Message.Location = new System.Drawing.Point(80, 105);
            this.tbx_Message.Multiline = true;
            this.tbx_Message.Name = "tbx_Message";
            this.tbx_Message.Size = new System.Drawing.Size(168, 100);
            this.tbx_Message.TabIndex = 6;
            // 
            // Email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.tbx_Message);
            this.Controls.Add(this.tbx_Subject);
            this.Controls.Add(this.tbx_To);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Email";
            this.Text = "Email";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Email_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.TextBox tbx_To;
        private System.Windows.Forms.TextBox tbx_Subject;
        private System.Windows.Forms.TextBox tbx_Message;
    }
}