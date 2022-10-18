﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement.Views
{
    public partial class EmployeeDashboard : Form
    {

        //Fields
        private Button currentButton;
        private Form activeForm;
        public EmployeeDashboard()
        {
            InitializeComponent();
            btnCloseChildForm.Visible = false;
        }

        private void EmployeeDashboard_Load(object sender, EventArgs e)
        {
            
        }
        //Methods
        private Color SelectThemeColor()
        {
            return ColorTranslator.FromHtml("#BBE1FA");
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.Black;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panel1.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(27, 38, 44);
                    previousBtn.ForeColor = Color.White;
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
            btnCloseChildForm.Visible = true;
        }
        private void OpenChildForm_1(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
            btnCloseChildForm.Visible = true;
        }
        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "HOME";
            panelTitleBar.BackColor = Color.FromArgb(27, 38, 44);
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelTitleBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.consumptions(), sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.customers(), sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.reservations(), sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.bills(), sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.checkout(), sender);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            this.Hide();
            homePage.Show();
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void roundedButton4_Click(object sender, EventArgs e)
        {
            OpenChildForm_1(new Forms.reservations(), sender);
        }

        private void roundedButton5_Click(object sender, EventArgs e)
        {
            OpenChildForm_1(new Forms.customers(), sender);
        }

        private void roundedButton6_Click(object sender, EventArgs e)
        {
            OpenChildForm_1(new Forms.consumptions(), sender);
        }

        private void roundedButton7_Click(object sender, EventArgs e)
        {
            OpenChildForm_1(new Forms.bills(), sender);
        }

        private void roundedButton8_Click(object sender, EventArgs e)
        {
            OpenChildForm_1(new Forms.checkout(), sender);
        }
    }
}
