using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace LanApp8_2Smtp
{
    public partial class MainFormSendMail : Form
    {
        public MainFormSendMail()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            MailAddress fromAddress = new MailAddress(edLogin.Text);
            MailAddress toAddress = new MailAddress(edTo.Text);

            MailMessage message = new MailMessage(fromAddress, toAddress);
            message.Subject = edSubject.Text;
            message.Body = edContent.Text;
            message.IsBodyHtml = cbIsHtml.Checked;
            //message.Attachments.Add(new Attachment("file.txt"));

            SmtpClient smtp = new SmtpClient(edServer.Text, (int)edPort.Value);
            smtp.EnableSsl = true;
            smtp.Credentials = new NetworkCredential(edLogin.Text, edPassword.Text);
            btnSend.Enabled = false;
            try
            {
                smtp.Send(message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                btnSend.Enabled = true;
            }
        }
    }
}
