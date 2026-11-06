using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ByNMushroomApp
{
    public partial class BycicleForm : Form
    {
        public BycicleForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ChooseForm chooseForm = new ChooseForm();
            chooseForm.Show();
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            {
                // 1. Validate inputs are integers[span_8](start_span)[span_8](end_span)
                if (int.TryParse(txtStartTime.Text, out int startHour) &&
                    int.TryParse(txtEndTime.Text, out int endHour))
                {
                    // 2. Enforce lab range constraints[span_9](start_span)[span_9](end_span)
                    if (startHour < 0 || startHour > 23 || endHour < 1 || endHour > 24)
                    {
                        MessageBox.Show("Start time must be between 0 and 23. End time must be between 1 and 24.",
                                        "Range Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                        return;
                    }

                    if (startHour >= endHour)
                    {
                        MessageBox.Show("The starting time must be strictly less than the ending time.",
                                        "Validation Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                        return;
                    }

                    // 3. Calculate cost hour-by-hour[span_10](start_span)[span_10](end_span)
                    int totalCost = 0;

                    for (int hour = startHour; hour < endHour; hour++)
                    {
                        if ((hour >= 0 && hour < 7) || (hour >= 21 && hour < 24))
                        {
                            totalCost += 500;  // 500 RWF per hour[span_11](start_span)[span_11](end_span)
                        }
                        else if ((hour >= 7 && hour < 14) || (hour >= 19 && hour < 21))
                        {
                            totalCost += 1000; // 1000 RWF per hour[span_12](start_span)[span_12](end_span)
                        }
                        else if (hour >= 14 && hour < 19)
                        {
                            totalCost += 1500; // 1500 RWF per hour[span_13](start_span)[span_13](end_span)
                        }
                    }

                    // 4. Output final results via MessageBox[span_14](start_span)[span_14](end_span)[span_15](start_span)[span_15](end_span)
                    MessageBox.Show($"Bicycle Rental Calculated Successfully!\n\n" +
                                    $"Rental Period: {startHour}:00 to {endHour}:00\n" +
                                    $"Total Amount to Pay: {totalCost} RWF",
                                    "Rental Cost Result",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                else
                {
                    // Error handling for empty or non-integer inputs[span_16](start_span)[span_16](end_span)
                    MessageBox.Show("Please enter valid whole numbers for start and end times. Decimal numbers or letters are not accepted.",
                                    "Input Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }



        }
    }
}
