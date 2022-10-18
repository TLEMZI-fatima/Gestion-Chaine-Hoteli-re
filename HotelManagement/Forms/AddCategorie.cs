using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagement.Data;

namespace HotelManagement.Forms
{
    public partial class AddCategorie : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(
            int nleft,
            int nTop,
            int nRight,
            int nBottom,
            int nWidthEllipse,
            int nHeightEllipse


            );
        public Categorie Categorie = new Categorie();
        public AddCategorie()
        {
            InitializeComponent();
        }

        private void panelTitleBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void placeHolder2_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddCategorie_Load(object sender, EventArgs e)
        {
            Database database = new Database();
            //List<Categorie> Categories = database.Categories.ToList();
            txtName.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txtName.Width, txtName.Height, 10, 10));
            txtPrice.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txtPrice.Width, txtPrice.Height, 10, 10));
            txtDescription.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txtDescription.Width, txtDescription.Height, 10, 10));
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void placeHolder1_TextChanged(object sender, EventArgs e)
        {

        }

        private void placeHolder3_TextChanged(object sender, EventArgs e)
        {

        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            Database database = new Database();
            Categorie categorie = new Categorie();
            categorie.Id = database.Categories.Max(x => x.Id) + 1;
            categorie.Name = txtName.Text;
            categorie.Prix = Int32.Parse(txtPrice.Text);
            categorie.Description = txtDescription.Text;
            database.Categories.Add(categorie);
            database.SaveChanges();
            this.Close();
        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
