using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Http;
using System.IO;

namespace LanApp7_1Web
{
    public partial class MainFormWebClient : Form
    {
        private WebClient webClient;
        private SaveFileDialog dlgSave;
        public MainFormWebClient()
        {
            InitializeComponent();

            webClient = new WebClient();
            webClient.DownloadFileCompleted += WebClient_DownloadFileCompleted;
            
            dlgSave = new SaveFileDialog();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            dlgSave.InitialDirectory = "c:\\";
            if (dlgSave.ShowDialog() == DialogResult.OK)
            {
                webClient.DownloadFileAsync(new Uri(edAddress.Text), dlgSave.FileName);
            }
        }

        private void WebClient_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Download Complete!");
        }

        private async void btnHttpLoad_Click(object sender, EventArgs e)
        {
            // подготовка запроса
            HttpWebRequest httpWebRequest = WebRequest.CreateHttp(edHttpAddress.Text);
            // отправка запроса к ресурсу и получение ответа
            using (HttpWebResponse httpWebResponse = (HttpWebResponse)await httpWebRequest.GetResponseAsync())
            {
                // читаем заголовки HTTP-ответа
                WebHeaderCollection headerCollection = httpWebResponse.Headers;
                for (int i = 0; i < headerCollection.Count; i++)
                {
                    lbHttpHeaders.Items.Add($"{headerCollection.GetKey(i)}: {headerCollection[i]}");
                }

                // читаем ответ в потоке
                StreamReader stream = new StreamReader(httpWebResponse.GetResponseStream());
                edHttpContent.Text = stream.ReadToEnd();

                // закрыть поток после завершения
                stream.Close();
            }

        }
    }
}
