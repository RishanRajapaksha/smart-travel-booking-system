using Google.Apis.Auth;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using System.Net;
using System.Text;

namespace Test
{
    public partial class Form4 : Form
    {
        string connectionString = "server=localhost;user=root;password=;database=travelDB;port=3306;";


        public Form4()
        {
            InitializeComponent();
        }


        private void Form4_Load(object sender, EventArgs e)
        {

        }


        //👆🏾 "Register with Google" Button == button1
        private void button1_Click(object sender, EventArgs e)
        {


            Google GoogleUser = new Google(connectionString);
            //In here, I have created "An Instant" of Google class.
            //"connectionString" need to parse, Because, It is necesary to work with the Database

            GoogleUser.GoogleUserRegistration();
            // and Here I have classed "GoogleUserRegistration()" function
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        //👆🏾 "Register" Button = button2
        private void button2_Click(object sender, EventArgs e)
        {
            var name = textBox1.Text;
            var phone_number = textBox2.Text;
            var email = textBox3.Text;
            var password = textBox4.Text;



            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {

                {
                    conn.Open();

                    string query = @"INSERT INTO property_owner
                            (Name, Phone, Email, Password)
                            VALUES
                            (@name, @phone, @email, @password)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@phone", phone_number);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@password", password);

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Data inserted successfully!",
                                "Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Insert failed!",
                                "Warning",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {

                if (ex.Number == 1062)
                {
                    MessageBox.Show("Email already exists!",
                        "Duplicate Entry",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Database Error: " + ex.Message,
                        "SQL Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected Error: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }











        //👆🏾 "Login" button =  = button4
        private void button4_Click(object sender, EventArgs e)
        {
            //Saving TextBox Values to variables
            String email = textBox7.Text;
            String password = textBox6.Text;


            //Reading "emails" and "passwords" details from the "property owner" table to check whether the entered data is correct?
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();

                string query = "SELECT * FROM property_owner WHERE Email=@Email AND Password=@Password";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    MessageBox.Show("Login Success!");

                }
                else
                {
                    MessageBox.Show("Invalid Email or Password");
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }



        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }




        //👆🏾 "Login with Google" Button
        private void button3_Click(object sender, EventArgs e)
        {

            Google GoogleUser = new Google(connectionString);
            //In here, I have created "An Instant" of Google class.
            //"connectionString" need to parse, Because, It is necesary to work with the Database


            GoogleUser.GoogleUserLogin();
            // and Here I have classed "GoogleUserLogin()" function
        }



















        //This is the "Google User" Registration and Login Handling Class
        class Google(String connectionString)
        {




            //This function handles the "Google User Registration" Part
            public async Task GoogleUserRegistration()
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


                //6. Printing the Infomation of the user
                Debug.WriteLine("----- USER DETAILS -----");
                Debug.WriteLine("Name: " + payload.Name);
                Debug.WriteLine("Email: " + payload.Email);
                Debug.WriteLine("ID: " + payload.Subject);

                //6. Saving all the User's information to variables
                var name = payload.Name;
                var email = payload.Email;
                var password = payload.Subject;


                //7.Adding GoogleUser Informations to the Database
                MySqlConnection conn = new MySqlConnection(connectionString);
                try
                {

                    conn.Open();

                    string query = @"INSERT INTO property_owner
            (Name, Phone, Email, Password)
            VALUES
            (@name, @phone, @email, @password)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@phone", 0000000000);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", password);

                    cmd.ExecuteNonQuery();

                    Debug.WriteLine("Inserted Successfully");
                    MessageBox.Show("Registration Successfull !");
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
                finally
                {
                    conn.Close();
                }


            }









            //This function handles the "Google User Registration" Part    
            public async Task GoogleUserLogin()
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


                //6. Printing the Infomation of the user
                Debug.WriteLine("----- USER DETAILS -----");
                Debug.WriteLine("Name: " + payload.Name);
                Debug.WriteLine("Email: " + payload.Email);
                Debug.WriteLine("ID: " + payload.Subject);

                //6. Saving all the User's information to variables
                var name = payload.Name;
                var email = payload.Email;
                var password = payload.Subject;

                //07. Reading "emails" and "passwords" details from the "property owner" table to check whether the entered data is correct?
                MySqlConnection conn = new MySqlConnection(connectionString);
                try
                {
                    conn.Open();

                    string query = "SELECT * FROM property_owner WHERE Email=@Email AND Password=@Password";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        MessageBox.Show("Login Success!");

                    }
                    else
                    {
                        MessageBox.Show("Invalid Email or Password");
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }


            }



        }
    }

}
