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
    public partial class hotel_owner_dashboard : Form
    {
        public hotel_owner_dashboard(String email, String password)
        {
            InitializeComponent();


            Debug.WriteLine("Here is the email" + email);
            Debug.WriteLine("Here is the password :" + password);
        }
    }
}
