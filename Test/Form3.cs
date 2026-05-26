using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form3 : Form
    {
        string connectionString = "server=localhost;user=root;password=;database=travelDB;port=3306;";

        public Form3()
        {
            InitializeComponent();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT ID, Title FROM District";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                comboBox2.DataSource = dt;

                // What user sees
                comboBox2.DisplayMember = "Title";

                // Actual value
                comboBox2.ValueMember = "ID";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String hotel_name = textBox1.Text;
            String description = textBox2.Text;
            String hotel_type = comboBox1.Text;
            int address = Convert.ToInt32(comboBox2.SelectedValue);
            String hotel_image = textBox4.Text;
            String price_per_person = textBox5.Text;
            String additional_guest_charge = textBox6.Text;

            //Debug.WriteLine(hotel_name);
            //Debug.WriteLine(description);
            //Debug.WriteLine(hotel_type);
            //Debug.WriteLine("Address" + address);
            //Debug.WriteLine(hotel_image);
            //Debug.WriteLine(price_per_person);
            //Debug.WriteLine(additional_guest_charge);

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
                    PictureURL,
                    price_per_one_person,
                    additional_guest_prices
                )
                VALUES
                (
                    @title,
                    @description,
                    @category,
                    @address,
                    @image,
                    @price,
                    @extra
                )";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@title", hotel_name);
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.Parameters.AddWithValue("@category", hotel_type);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@image", hotel_image);
                    cmd.Parameters.AddWithValue("@price", price_per_person);
                    cmd.Parameters.AddWithValue("@extra", additional_guest_charge);

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
