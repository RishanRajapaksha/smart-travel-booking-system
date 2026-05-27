using Google.Apis.Auth;
using MySql.Data.MySqlClient;
using Mysqlx;
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
               
                if (string.IsNullOrWhiteSpace(name) ||
                    string.IsNullOrWhiteSpace(email) ||
                    string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Please fill all required fields (Name, Email, Password).",
                        "Validation Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

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
                        MessageBox.Show("Successfully Registed!",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Insert failed. No data was saved.",
                            "Warning",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                }
            }
            catch (MySqlException ex)
            {
                string msg;

                switch (ex.Number)
                {
                    case 0:
                        msg = "Cannot connect to database server.";
                        break;

                    case 1042:
                        msg = "Database server is unreachable.";
                        break;

                    case 1045:
                        msg = "Invalid database username or password.";
                        break;

                    case 1049:
                        msg = "Database not found.";
                        break;

                    case 1054:
                        msg = "Invalid column name in SQL query.";
                        break;

                    case 1062:
                        msg = "Email already exists.";
                        break;

                    case 1146:
                        msg = "Table does not exist in database.";
                        break;

                    case 1406:
                        msg = "Data too long for one of the fields.";
                        break;

                    case 1452:
                        msg = "Foreign key constraint failed.";
                        break;

                    case 2003:
                        msg = "Cannot connect to MySQL server.";
                        break;

                    case 2013:
                        msg = "Lost connection to MySQL server during query.";
                        break;

                    default:
                        msg = "Database error occurred:\n" + ex.Message;
                        break;
                }

                MessageBox.Show(msg,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Some required data is missing (null value detected).",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid data format entered.",
                    "Format Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Invalid database operation (connection issue or command issue).",
                    "Operation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected system error:\n" + ex.Message,
                    "System Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
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
                
                if (string.IsNullOrWhiteSpace(email) ||
                    string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Please enter Email and Password.",
                        "Validation Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                conn.Open();

                string query = "SELECT * FROM property_owner WHERE Email=@Email AND Password=@Password";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email.Trim());
                    cmd.Parameters.AddWithValue("@Password", password);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            MessageBox.Show("Login Successful!",
                                "Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Invalid Email or Password.",
                                "Login Failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                string msg;

                switch (ex.Number)
                {
                    case 0:
                        msg = "Cannot connect to database server.";
                        break;

                    case 1042:
                        msg = "Database server is unreachable.";
                        break;

                    case 1045:
                        msg = "Invalid database username or password.";
                        break;

                    case 1049:
                        msg = "Database not found.";
                        break;

                    case 1054:
                        msg = "Column error (Email or Password column missing).";
                        break;

                    case 1146:
                        msg = "Table 'property_owner' does not exist.";
                        break;

                    case 2003:
                        msg = "Cannot connect to MySQL server.";
                        break;

                    case 2013:
                        msg = "Lost connection during login process.";
                        break;

                    default:
                        msg = "Database error:\n" + ex.Message;
                        break;
                }

                MessageBox.Show(msg,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Some required data is missing (null value detected).",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Invalid database operation or connection issue.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input format detected.",
                    "Format Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected system error:\n" + ex.Message,
                    "System Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
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
                    cmd.Parameters.AddWithValue("@phone", 0);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", password);

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Registration Successful!",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No data was inserted. Please try again.",
                            "Warning",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                }
                //8. All Posiable Error handling
                catch (MySqlException ex)
                {
                    string msg;

                    switch (ex.Number)
                    {
                        case 0:
                            msg = "Cannot connect to database server.";
                            break;

                        case 1042:
                            msg = "Database server is unreachable.";
                            break;

                        case 1045:
                            msg = "Invalid database username or password.";
                            break;

                        case 1049:
                            msg = "Database not found.";
                            break;

                        case 1062:
                            msg = "This email already exists. Try another email.";
                            break;

                        case 1054:
                            msg = "Invalid column name in database query.";
                            break;

                        case 1146:
                            msg = "Table does not exist in database.";
                            break;

                        case 1406:
                            msg = "Data too long for one of the fields.";
                            break;

                        case 1452:
                            msg = "Foreign key constraint failed.";
                            break;

                        default:
                            msg = "Database error occurred: " + ex.Message;
                            break;
                    }

                    MessageBox.Show(msg,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Some required fields are missing.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Invalid data format entered.",
                        "Format Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unexpected error occurred:\n" + ex.Message,
                        "System Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                finally
                {
                    if (conn.State == System.Data.ConnectionState.Open)
                    {
                        conn.Close();
                    }
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
                 
                    if (string.IsNullOrWhiteSpace(email) ||
                        string.IsNullOrWhiteSpace(password))
                    {
                        MessageBox.Show("Please enter Email and Password.",
                            "Validation Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }

                    conn.Open();

                    string query = "SELECT * FROM property_owner WHERE Email=@Email AND Password=@Password";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email.Trim());
                        cmd.Parameters.AddWithValue("@Password", password);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                MessageBox.Show("Login Successful! Welcome back 😊",
                                    "Success",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Invalid Email or Password. Please try again.",
                                    "Login Failed",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    string msg;

                    switch (ex.Number)
                    {
                        case 0:
                            msg = "Cannot connect to database server.";
                            break;

                        case 1042:
                            msg = "Database server is unreachable.";
                            break;

                        case 1045:
                            msg = "Database login credentials are incorrect.";
                            break;

                        case 1049:
                            msg = "Database not found.";
                            break;

                        case 1054:
                            msg = "Database column error (Email/Password column missing).";
                            break;

                        case 1146:
                            msg = "Table 'property_owner' does not exist.";
                            break;

                        case 2003:
                            msg = "Cannot connect to MySQL server.";
                            break;

                        case 2013:
                            msg = "Lost connection to database during login.";
                            break;

                        default:
                            msg = "Database error occurred:\n" + ex.Message;
                            break;
                    }

                    MessageBox.Show(msg,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Some required login data is missing.",
                        "Null Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
                catch (InvalidOperationException)
                {
                    MessageBox.Show("Invalid database operation. Please check connection.",
                        "Operation Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Invalid input format detected.",
                        "Format Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unexpected system error:\n" + ex.Message,
                        "System Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                finally
                {
                    if (conn.State == System.Data.ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }


            }



        }
    }

}
