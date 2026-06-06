using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Test
{
    public partial class hotel_registration_form : Form
    {
        string connectionString = "server=localhost;user=root;password=;database=travelDB;port=3306;";
        private int hotelOwnerID;

        public hotel_registration_form(int HotelOwnerID)
        {
            InitializeComponent();
            hotelOwnerID = HotelOwnerID;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT ID, Title FROM District";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                comboBox2.DataSource = dt;
                comboBox2.DisplayMember = "Title";
                comboBox2.ValueMember = "ID";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void textBox6_TextChanged(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            String hotel_name = textBox1.Text;
            String description = textBox2.Text;
            String hotel_type = comboBox1.Text;
            String address = textBox3.Text;
            int district = Convert.ToInt32(comboBox2.SelectedValue);
            String hotel_image = textBox4.Text;
            String price_per_person = textBox5.Text;
            String additional_guest_charge = textBox6.Text;
            

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                        INSERT INTO Property
                        (
                            Title,
                            LongDescription,
                            PropertyCategory,
                            Address,
                            DistrictID,
                            PictureURL,
                            price_per_one_person,
                            additional_guest_prices,
                            HotelOwnerID
                        )
                        VALUES
                        (
                            @title,
                            @description,
                            @category,
                            @address,
                            @district,
                            @image,
                            @price,
                            @extra,
                            @HotelOwnerID
                        );";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@title", hotel_name);
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.Parameters.AddWithValue("@category", hotel_type);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@district", district);
                    cmd.Parameters.AddWithValue("@image", hotel_image);
                    cmd.Parameters.AddWithValue("@price", price_per_person);
                    cmd.Parameters.AddWithValue("@extra", additional_guest_charge);
                    cmd.Parameters.AddWithValue("@HotelOwnerID", hotelOwnerID);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Hotel added successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}