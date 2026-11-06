using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ByNMushroomApp
{
    public partial class MushroomForm : Form
    {
        public MushroomForm()
        {
            InitializeComponent();


            cmbRing.Items.Clear();
            cmbRing.Items.Add("-- Select --"); // Prompt / Default display
            cmbRing.Items.Add("Yes");
            cmbRing.Items.Add("No");
            cmbRing.SelectedIndex = 0; // Selects the prompt by default

            // Populate cmbForest options
            cmbForest.Items.Clear();
            cmbForest.Items.Add("-- Select --");
            cmbForest.Items.Add("Yes");
            cmbForest.Items.Add("No");
            cmbForest.SelectedIndex = 0;

            cmbCup.Items.Clear();
            cmbCup.Items.Add("-- Select --");
            cmbCup.Items.Add("Yes");
            cmbCup.Items.Add("No");
            cmbCup.SelectedIndex = 0;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ChooseForm chooseForm = new ChooseForm();
            chooseForm.Show();
            this.Close();



        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // 1. Validate that all three ComboBoxes have valid selections[span_19](start_span)[span_19](end_span)
            if (cmbRing.SelectedIndex <= 0 || cmbForest.SelectedIndex <= 0 || cmbCup.SelectedIndex <= 0)
            {
                MessageBox.Show("Please answer all questions before submitting.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // 2. Read values from dropdown choices
            bool hasRing = cmbRing.SelectedItem.ToString() == "Yes";
            bool growsInForest = cmbForest.SelectedItem.ToString() == "Yes";
            bool hasConvexCup = cmbCup.SelectedItem.ToString() == "Yes";

            string identifiedMushroom = "";

            // 3. Decision Tree Logic matching problem rules
            if (hasRing)
            {
                if (growsInForest)
                {
                    identifiedMushroom = "Amanite tue-mouche";
                }
                else // Grows in meadows
                {
                    if (hasConvexCup)
                        identifiedMushroom = "Agaric jaunissant";
                    else
                        identifiedMushroom = "Coprin chevelu";
                }
            }
            else // Does not have a ring
            {
                if (growsInForest && !hasConvexCup)
                {
                    identifiedMushroom = "Cepe de bordeaux"; // Has pores / no gills
                }
                else if (growsInForest && hasConvexCup)
                {
                    identifiedMushroom = "Girolle";
                }
                else if (hasConvexCup)
                {
                    identifiedMushroom = "Pied bleu";
                }
                else
                {
                    identifiedMushroom = "Girolle";
                }
            }

            // 4. Output final results via MessageBox[span_20](start_span)[span_20](end_span)[span_21](start_span)[span_21](end_span)
            MessageBox.Show($"The identified mushroom is:\n\n🍄 {identifiedMushroom}",
                            "Mushroom Result",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

        }

        private void lblHeader_Click(object sender, EventArgs e)
        {

        }
    }
}
