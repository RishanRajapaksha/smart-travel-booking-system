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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MySql.Data.MySqlClient;

namespace Test
{
    public partial class Form2 : Form
    {
        string connectionString = "server=localhost;user=root;password=;database=travelDB;port=3306;";
        public Form2(String output)
        {

            InitializeComponent();
            String output_of_AI = output;

            string city = output_of_AI.Split('\n')[0].Split(':')[1].Trim();
            int persons_stay = int.Parse(output_of_AI.Split('\n')[1].Split(':')[1].Trim());
            int nights_stay = int.Parse(output_of_AI.Split('\n')[2].Split(':')[1].Trim());


            sri_lankan_city.Text = city;
            persons.Text = persons_stay.ToString();
            nights.Text = nights_stay.ToString();


            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                        SELECT 
                            p.ID,
                            p.Title,
                            p.PropertyCategory,
                            p.Address,
                            d.Title AS District
                        FROM Property p
                        INNER JOIN District d ON p.DistrictID = d.ID";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();

                    adapter.Fill(dt);


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void address_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }
    }
}
