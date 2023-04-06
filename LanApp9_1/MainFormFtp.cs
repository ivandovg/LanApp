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
        private List<FtpItem> ftpItems;
        private SaveFileDialog saveFile;
        public MainFormFtp()
        {
            ftpItems = new List<FtpItem>();
            saveFile = new SaveFileDialog()
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            };

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
            ftpItems.Clear();
            lbFiles.Items.Clear();
            try
            {
                FtpWebResponse response = (FtpWebResponse)await request.GetResponseAsync();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string line;
                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    FtpItem item = new FtpItem(line);
                    ftpItems.Add(item);
                    lbFiles.Items.Add(item.ToString());
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

        private async void lbFiles_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lbFiles.SelectedIndex == ListBox.NoMatches)
                return;

            int id = lbFiles.SelectedIndex;
            FtpItem ftpItem = ftpItems[id];
            saveFile.FileName = ftpItem.ShortPath;

            if (ftpItem.IsDirectory)
            {
                edAddress.Text = $"{edAddress.Text}/{ftpItem.ShortPath}";
                btnGetFiles_Click(null, null);
            }
            else if (saveFile.ShowDialog() == DialogResult.OK)
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create($"{edAddress.Text}/{ftpItem.ShortPath}");
                request.Method = WebRequestMethods.Ftp.DownloadFile;
                request.EnableSsl = cbEnableSsl.Checked;
                if (!string.IsNullOrEmpty(edLogin.Text) && !string.IsNullOrEmpty(edPassword.Text))
                {
                    request.Credentials = new NetworkCredential(edLogin.Text, edPassword.Text);
                }
                btnGetFiles.Enabled = false;
                lbFiles.Enabled = false;
                
                try
                {
                    FtpWebResponse response = (FtpWebResponse)await request.GetResponseAsync();
                    Stream stream = response.GetResponseStream();
                    FileStream file = (FileStream)saveFile.OpenFile();

                    byte[] data = new byte[1024];
                    int size;
                    while ((size = stream.Read(data, 0, data.Length)) > 0)
                    {
                        await file.WriteAsync(data, 0, size);
                    }
                    
                    await file.FlushAsync();

                    file.Close();
                    stream.Close();
                    response.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    btnGetFiles.Enabled = true;
                    lbFiles.Enabled = true;
                }
            }
        }
    }
}
