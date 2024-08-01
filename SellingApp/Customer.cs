using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SellingApp
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-11VRTA1\SQLEXPRESS;Initial Catalog=CRUD;Integrated Security=True");

        private void Customer_Load(object sender, EventArgs e)
        {
          
        }

        private void Customer_Load_1(object sender, EventArgs e)
        {

        }
    }
}
