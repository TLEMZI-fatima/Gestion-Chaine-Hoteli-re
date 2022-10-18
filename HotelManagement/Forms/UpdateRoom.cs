﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagement.Data;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.Forms
{
    public partial class UpdateRoom : Form
    {
        public Chambre chambre;
        private User user;

        public UpdateRoom(Chambre chambre)
        {
            InitializeComponent();
            this.chambre = chambre;
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            Database database = new Database();
            chambre.NumTel = txtNumTel.Text;
            chambre.Prix = Int32.Parse(txtPrice.Text.ToString());
            int CatId = Int16.Parse(comboBox1.SelectedValue.ToString());
            chambre.CategorieId = CatId;
            int HotId = Int16.Parse(comboBox2.SelectedValue.ToString());
            chambre.HotelId = HotId;
            chambre.Reserved = false;
            database.Chambres.Attach(chambre);
            database.Entry(chambre).State = EntityState.Modified;
            database.SaveChanges();
            this.Close();
        }

        private void UpdateRoom_Load(object sender, EventArgs e)
        {
            txtNumTel.Text = chambre.NumTel;
            txtPrice.Text = chambre.Prix.ToString();
            Database database = new Database();
            List<Categorie> Categories = database.Categories.ToList();
            List<Hotel> Hotels = database.Hotels.ToList();
            comboBox1.DataSource = Categories;
            comboBox1.ValueMember = "Id";
            comboBox1.DisplayMember = "Name";
            comboBox1.SelectedValue = chambre.CategorieId;

            comboBox2.DataSource = Hotels;
            comboBox2.ValueMember = "Id";
            comboBox2.DisplayMember = "Nom";
            comboBox2.SelectedValue = chambre.HotelId;
        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
