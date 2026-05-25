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
using System.Drawing;

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

            DataTable dt = new DataTable(); 

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
                                d.Title AS District,
                                p.price_per_one_person,
                                p.additional_guest_prices
                            FROM Property p
                            INNER JOIN District d ON p.DistrictID = d.ID;
                            ";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    dt = new DataTable();

                    adapter.Fill(dt);


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }



            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow row = dt.Rows[i];


                Panel card = new Panel();
                card.Width = 1000;
                card.Height = 220;
                card.BorderStyle = BorderStyle.FixedSingle;

                // Picture
                PictureBox pic = new PictureBox();
                pic.Width = 278;
                pic.Height = 156;
                pic.Left = 20;
                pic.Top = 30;
                pic.SizeMode = PictureBoxSizeMode.StretchImage;

                // Example image
                pic.Image = Image.FromFile(@"C:\Users\Rishan_Rajapaksha\Downloads\images.jpg");

                // Hotel Name
                Label title = new Label();
                title.Text = row["Title"].ToString();
                title.Font = new Font("Arial", 20, FontStyle.Bold);
                title.Left = 300;
                title.Top = 30;
                title.AutoSize = true;

                //Property category
                Label pc = new Label();
                pc.Text = row["PropertyCategory"].ToString();
                pc.Font = new Font("Segoe UI Emoji", 12);
                pc.Left = 300;
                pc.Top = 80;
                pc.AutoSize = true;
                card.Controls.Add(pc);


                //Address
                Label address = new Label();
                address.Text = "📍 " + row["Address"].ToString(); ;
                address.Font = new Font("Segoe UI Emoji", 12);
                address.Left = 300;
                address.Top = 110;
                address.AutoSize = true;
                card.Controls.Add(address);



                // Price
                //Total Price = (price_per_one_person × Nights ) + Additional Guest Prices
                Label price = new Label();

                Decimal price_per_one_person = Convert.ToDecimal(row["price_per_one_person"].ToString());
                Decimal additional_guest_prices = Convert.ToDecimal(row["additional_guest_prices"].ToString());
                Decimal total;

                if (persons_stay > 1)
                {
                     total = (price_per_one_person * nights_stay) + (additional_guest_prices * persons_stay);
                }
                else {
                     total = (price_per_one_person * nights_stay);
                }



                price.Text = total.ToString();
                price.ForeColor = Color.Red;
                price.Font = new Font("Arial", 16, FontStyle.Bold);
                price.Left = 750;
                price.Top = 40;
                price.AutoSize = true;

                //Book the hotel button
                System.Windows.Forms.Button btn = new System.Windows.Forms.Button();
                btn.BackColor = Color.Blue;
                btn.ForeColor = Color.White;
                btn.Text = "Book the hotel";
                btn.Left = 750;
                btn.Top = 80;
                btn.Width = 157;
                btn.Height = 51;
                card.Controls.Add(btn);


                // Add controls to card
                card.Controls.Add(pic);
                card.Controls.Add(title);
             
                card.Controls.Add(price);
                //card.Controls.Add(btn);

                // Add card to FlowLayoutPanel
                flowLayoutPanel1.Controls.Add(card);
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
