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
            lbHttpHeaders.Items.Clear();

            // подготовка запроса
            HttpWebRequest httpWebRequest = WebRequest.CreateHttp(edHttpAddress.Text);
            //httpWebRequest.Headers.Add("Content-Encoding", "utf-8");
            httpWebRequest.CookieContainer = new CookieContainer();
            //httpWebRequest.CookieContainer.Add(new Cookie("user", "admin"));
            try
            {
                // отправка запроса к ресурсу и получение ответа
                using (HttpWebResponse httpWebResponse = (HttpWebResponse)await httpWebRequest.GetResponseAsync())
                {
                    // статус-код говорит про успешность выполнения запроса
                    lbHttpHeaders.Items.Add($"StatusCode: {httpWebResponse.StatusCode}");
                    string statusAnswer = httpWebResponse.StatusDescription;
                    if (!string.IsNullOrEmpty(statusAnswer))
                        lbHttpHeaders.Items.Add($"StatusDescription: {httpWebResponse.StatusDescription}");

                    // читаем заголовки HTTP-ответа
                    WebHeaderCollection headerCollection = httpWebResponse.Headers;
                    for (int i = 0; i < headerCollection.Count; i++)
                    {
                        lbHttpHeaders.Items.Add($"{headerCollection.GetKey(i)}: {headerCollection[i]}");
                    }

                    // читаем установленные cookie
                    lbHttpHeaders.Items.Add("");
                    lbHttpHeaders.Items.Add("Cookie");
                    foreach (Cookie cookie in httpWebResponse.Cookies)
                    {
                        lbHttpHeaders.Items.Add($"{cookie.Name}: {cookie.Value}");
                        lbHttpHeaders.Items.Add($"Cookie Domain: {cookie.Domain}");
                    }

                    // читаем ответ в потоке
                    StreamReader stream = new StreamReader(httpWebResponse.GetResponseStream());
                    edHttpContent.Text = stream.ReadToEnd();

                    // закрыть поток после завершения
                    stream.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
            

        }
    }
}
