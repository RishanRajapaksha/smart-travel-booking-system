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

namespace Test
{
    public partial class Form2 : Form
    {
        public Form2(String output)
        {
            InitializeComponent();
            String output_of_AI = output;

            string city = output_of_AI.Split('\n')[0].Split(':')[1].Trim();
            int persons_stay = int.Parse(output_of_AI.Split('\n')[1].Split(':')[1].Trim());
            int nights_stay = int.Parse(output_of_AI.Split('\n')[2].Split(':')[1].Trim());

            Debug.WriteLine(city);
            Debug.WriteLine(persons_stay);
            Debug.WriteLine(nights_stay);

            sri_lankan_city.Text = city;
            persons.Text = persons_stay.ToString();
            nights.Text = nights_stay.ToString();



        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
