using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net;

namespace LanApp8_1
{
    public partial class FormHttpClient : Form
    {
        // клиент для обработки запорсов к серверу по протоколу Http
        private static HttpClient httpClient = new HttpClient();
        public FormHttpClient()
        {
            InitializeComponent();
        }

        private async void btnHttpLoad_Click(object sender, EventArgs e)
        {
            lbHttpHeaders.Items.Clear();

            Uri uri = null;
            try
            {
                uri = new Uri(edHttpAddress.Text);
            }
            catch
            {
                MessageBox.Show("error address!");
                return;
            }

            // для получения cookie, создаем контейнер
            CookieContainer cookieContainer = new CookieContainer();

            // формирование запроса к серверу
            using (HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri))
            {
                // добавляем заголовки, при необходимости
                //httpRequestMessage.Headers.Add()
                httpRequestMessage.Headers.Add("User-Agent", "Chrome/51.0.2704.103 Safari/537.36 (Windows NT 6.1; Win64; x64; rv:47.0)");

                // отправка запроса
                using (HttpResponseMessage httpResponse = await httpClient.SendAsync(httpRequestMessage))
                {
                    lbHttpHeaders.Items.Add($"IsSuccessStatusCode: {httpResponse.IsSuccessStatusCode}");
                    lbHttpHeaders.Items.Add($"StatusCode: {httpResponse.StatusCode}");
                    lbHttpHeaders.Items.Add($"ReasonPhrase: {httpResponse.ReasonPhrase}");
                    lbHttpHeaders.Items.Add("");
                    lbHttpHeaders.Items.Add("Headers: ");

                    // обработка заголовков
                    foreach (var header in httpResponse.Headers)
                    {
                        lbHttpHeaders.Items.Add(header.Key);
                        foreach (var headerValue in header.Value)
                        {
                            lbHttpHeaders.Items.Add(headerValue);
                        }
                        lbHttpHeaders.Items.Add("------------------------------------");
                    }

                    // заполнить контейнер cookie
                    foreach (var cookieHeader in httpResponse.Headers.GetValues("Set-Cookie"))
                    {
                        cookieContainer.SetCookies(uri, cookieHeader);
                    }

                    // отобразить cookie
                    lbHttpHeaders.Items.Add("");
                    lbHttpHeaders.Items.Add("Cookie: ");
                    foreach (Cookie cookie in cookieContainer.GetCookies(uri))
                    {
                        lbHttpHeaders.Items.Add($"{cookie.Name}: {cookie.Value}");
                        lbHttpHeaders.Items.Add($"Cookie Domain: {cookie.Domain}");
                    }

                    // отображаем контент
                    edHttpContent.Text = await httpResponse.Content.ReadAsStringAsync();
                }
            }
        }
    }
}
