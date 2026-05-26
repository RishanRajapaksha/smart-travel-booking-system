using Google.Apis.Auth;
using Google.Apis.Auth.OAuth2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();



        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        public async Task GoogleLogin()
        {
            var clientId = Environment.GetEnvironmentVariable("GOOGLE_LOGIN_CLIENT_ID") ?? "";
            Debug.WriteLine("Client ID   " + clientId);
            var redirectUri = "http://localhost:5000/";

            string url =
                "https://accounts.google.com/o/oauth2/v2/auth?" +
                $"client_id={clientId}" +
                "&response_type=code" +
                $"&redirect_uri={redirectUri}" +
                "&scope=openid%20email%20profile" +
                "&access_type=offline" +
                "&prompt=consent";

            // 1. Start local listener
            HttpListener listener = new HttpListener();
            listener.Prefixes.Add(redirectUri);
            listener.Start();

            // 2. Open browser
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });

            // 3. Wait for Google response
            var context = await listener.GetContextAsync();
            var response = context.Request.QueryString["code"];

            // Send response to browser
            string html = "<h2>Login Success. You can close this window.</h2>";
            byte[] buffer = Encoding.UTF8.GetBytes(html);
            context.Response.OutputStream.Write(buffer, 0, buffer.Length);
            context.Response.Close();
            listener.Stop();

            string authCode = response;

            // 4. Exchange code for token
            var tokenRequest = new System.Net.Http.HttpClient();
            var values = new System.Collections.Generic.Dictionary<string, string>
                                {
                                    { "code", authCode },
                                    { "client_id", clientId },
                                    { "client_secret", Environment.GetEnvironmentVariable("GOOGLE_CLIENT_SECRET") ?? "" },
                                    { "redirect_uri", redirectUri },
                                    { "grant_type", "authorization_code" }
                                };

            var tokenResponse = await tokenRequest.PostAsync(
                "https://oauth2.googleapis.com/token",
                new System.Net.Http.FormUrlEncodedContent(values));

            string json = await tokenResponse.Content.ReadAsStringAsync();

            dynamic obj = Newtonsoft.Json.JsonConvert.DeserializeObject(json);
            string idToken = obj.id_token;

            // 5. Validate token and get user info
            var payload = await GoogleJsonWebSignature.ValidateAsync(idToken);

            Debug.WriteLine("----- USER DETAILS -----");
            Debug.WriteLine("Name: " + payload.Name);
            Debug.WriteLine("Email: " + payload.Email);
            Debug.WriteLine("ID: " + payload.Subject);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GoogleLogin();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
