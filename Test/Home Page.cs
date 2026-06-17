using System;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Test
{
    public partial class home_page : Form
    {
        private static readonly HttpClient client = new HttpClient();

        public home_page()
        {
            InitializeComponent();


        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string apiKey = Environment.GetEnvironmentVariable("GROQ_API_KEY") ?? "";
                String Query = textBox1.Text;
                var requestBody = new
                {
                    model = "openai/gpt-oss-120b",
                    input = $"""
                                        {Query}
                                        
                                        In this phrase, Just extract 
                                        Sri Lankan City : 
                                        Persons : 
                                        Nights :


                                        Give me the response in exact same structure I have mentioned above. 
                                        Just Give me the answer. No need anything else
                    """
                };

                string json = JsonSerializer.Serialize(requestBody);

                var request = new HttpRequestMessage(HttpMethod.Post,
                    "https://api.groq.com/openai/v1/responses");

                request.Headers.Add("Authorization", $"Bearer {apiKey}");
                request.Content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.SendAsync(request);

                string result = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    // Extract output_text from JSON
                    using JsonDocument doc = JsonDocument.Parse(result);
                    string output = doc.RootElement
                        .GetProperty("output")[1]
                        .GetProperty("content")[0]
                        .GetProperty("text")
                        .GetString();

                    //Debug.WriteLine(output);


                    Form form2 = new best_matching_hotels_page(output);
                    form2.Show();



                }
                else
                {
                    MessageBox.Show("Error: " + result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void reg_as_hotel_owner_Click(object sender, EventArgs e)
        {
            Form form4 = new hotel_owner_form();
            form4.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}