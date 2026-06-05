using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Test
{
    public partial class hotel_owner_dashboard : Form
    {
        string connectionString = "server=localhost;user=root;password=;database=travelDB;port=3306;";
        private string ownerEmail;
        private string ownerPassword;

        public hotel_owner_dashboard(string email, string password)
        {
            InitializeComponent();

            ownerEmail = email;
            ownerPassword = password;

            LoadProperties();
        }

        private void LoadProperties()
        {
            int hotelOwnerID = GetHotelOwnerID();

            if (hotelOwnerID == -1)
                return;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                        SELECT 
                            p.ID,
                            p.Title,
                            p.LongDescription,
                            p.PropertyCategory,
                            p.Address,
                            d.Title AS District,
                            p.PictureURL,
                            p.price_per_one_person,
                            p.additional_guest_prices
                        FROM Property p
                        LEFT JOIN District d ON p.DistrictID = d.ID
                        WHERE p.HotelOwnerID = @HotelOwnerID";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@HotelOwnerID", hotelOwnerID);

                    DataTable dt = new DataTable();

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dt);

                    dataGridView1.AutoGenerateColumns = true;
                    dataGridView1.DataSource = dt;

                    if (dt.Rows.Count > 0)
                    {
                        dataGridView1.Columns["ID"].HeaderText = "Property ID";
                        dataGridView1.Columns["Title"].HeaderText = "Property Name";
                        dataGridView1.Columns["LongDescription"].HeaderText = "Description";
                        dataGridView1.Columns["PropertyCategory"].HeaderText = "Category";
                        dataGridView1.Columns["Address"].HeaderText = "Address";
                        dataGridView1.Columns["District"].HeaderText = "District";
                        dataGridView1.Columns["PictureURL"].HeaderText = "Image URL";
                        dataGridView1.Columns["price_per_one_person"].HeaderText = "Price Per Person";
                        dataGridView1.Columns["additional_guest_prices"].HeaderText = "Additional Guest Price";

                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                    else
                    {
                        MessageBox.Show("No properties found for this hotel owner.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading properties: " + ex.Message);
            }
        }

        private int GetHotelOwnerID()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                        SELECT HotelOwnerID
                        FROM hotel_owner
                        WHERE Email = @Email
                        AND Password = @Password";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@Email", ownerEmail);
                    cmd.Parameters.AddWithValue("@Password", ownerPassword);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }

                    MessageBox.Show("Hotel owner not found.");
                    return -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching Hotel Owner ID: " + ex.Message);
                return -1;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void hotel_owner_dashboard_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form hotel_registration_form = new hotel_registration_form();
            hotel_registration_form.Show();
        }
    }
}