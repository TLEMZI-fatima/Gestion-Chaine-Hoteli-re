using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagement.Forms;
using HotelManagement.Data;

namespace HotelManagement.Forms
{
    public partial class customers : Form
    {
        public customers()
        {
            InitializeComponent();
        }

        private void customers_Load(object sender, EventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void lblRole_Click(object sender, EventArgs e)
        {
            Database database = new Database();
            List<Client> Clients = database.Clients.ToList();
        }
    }
}