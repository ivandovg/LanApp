using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanApp9_1
{
    public partial class MainFormFtp : Form
    {
        public MainFormFtp()
        {
            InitializeComponent();
        }

        private async void btnGetFiles_Click(object sender, EventArgs e)
        {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(edAddress.Text);
            //request.Method = WebRequestMethods.Ftp.ListDirectory;
            request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
            request.EnableSsl = cbEnableSsl.Checked;
            if(!string.IsNullOrEmpty(edLogin.Text) && !string.IsNullOrEmpty(edPassword.Text))
            {
                request.Credentials = new NetworkCredential(edLogin.Text, edPassword.Text);
            }
            btnGetFiles.Enabled = false;
            lbFiles.Items.Clear();
            try
            {
                FtpWebResponse response = (FtpWebResponse)await request.GetResponseAsync();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string line;
                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    lbFiles.Items.Add(line);
                }
                reader.Close();
                response.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                btnGetFiles.Enabled = true;
            }
        }
    }
}
