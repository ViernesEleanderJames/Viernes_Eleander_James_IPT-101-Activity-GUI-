using Viernes_Eleander_James_Act_GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Viernes_Eleander_James_Act_GUI
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
            // Mock Student Data
            StudentNameLabel.Text = "Viernes, Eleander James S.";
            StudentAgeLabel.Text = "20";
            StudentAddressLabel.Text = "San Pedro Ili Alcala Pangasinan";
            StudentContactLabel.Text = "09151508557";
            StudentEmailLabel.Text = "e.j.viernes@gmail.com";
            StudentCourseYearLabel.Text = "BSIT Third";
            ParentNameLabel.Text = "Romel Viernes";
            ParentContactLabel.Text = "09123457789";
            HobbiesLabel.Text = "Gaming/Basketball";
            NicknameLabel.Text = "Der/Pats";

        }

        private void AddImageBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add Image functionality is not implemented.", "Feature Not Available", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ChangeImageBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Change Image functionality is not implemented.", "Feature Not Available", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void EditUpdateBtn_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm(this);
            this.Hide();
            editForm.Show();
        }

    }
}