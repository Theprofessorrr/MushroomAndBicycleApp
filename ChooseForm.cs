using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ByNMushroomApp
{
    public partial class ChooseForm : Form
    {
        public ChooseForm()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        

        private void btnBicycle_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to The Bicycle Rent Calculator!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BycicleForm bycicleForm = new BycicleForm();
            bycicleForm.Show();
            this.Hide();
        }

        private void buttonMushroom_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to the Mushroom Finder!", " Mushroom Finder", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MushroomForm mushroomForm = new MushroomForm();
            mushroomForm.Show();
            this.Hide();
        }
    }
}
