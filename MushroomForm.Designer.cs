namespace ByNMushroomApp
{
    partial class MushroomForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MushroomForm));
            panel1 = new Panel();
            panel3 = new Panel();
            btnSubmit = new Button();
            label5 = new Label();
            lblQ3 = new Label();
            cmbRing = new ComboBox();
            cmbForest = new ComboBox();
            cmbCup = new ComboBox();
            pictureBox4 = new PictureBox();
            btnLogout = new Button();
            pictureBox5 = new PictureBox();
            btnBack = new Button();
            panel2 = new Panel();
            lblHeader = new Label();
            pictureBox1 = new PictureBox();
            lblQ2 = new Label();
            lblQ1 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Tan;
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(202, 36);
            panel1.Name = "panel1";
            panel1.Size = new Size(853, 671);
            panel1.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Linen;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(btnSubmit);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(lblQ3);
            panel3.Controls.Add(cmbRing);
            panel3.Controls.Add(cmbForest);
            panel3.Controls.Add(cmbCup);
            panel3.Controls.Add(pictureBox4);
            panel3.Controls.Add(btnLogout);
            panel3.Controls.Add(pictureBox5);
            panel3.Controls.Add(btnBack);
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(lblQ2);
            panel3.Controls.Add(lblQ1);
            panel3.Location = new Point(17, 13);
            panel3.Name = "panel3";
            panel3.Size = new Size(819, 644);
            panel3.TabIndex = 1;
            panel3.Paint += panel3_Paint;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.SteelBlue;
            btnSubmit.Font = new Font("Imprint MT Shadow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubmit.Location = new Point(481, 479);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(198, 64);
            btnSubmit.TabIndex = 18;
            btnSubmit.Text = "SUBMIT";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(437, 17);
            label5.Name = "label5";
            label5.Size = new Size(260, 96);
            label5.TabIndex = 17;
            label5.Text = "Answer The following Questions:";
            // 
            // lblQ3
            // 
            lblQ3.AutoSize = true;
            lblQ3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQ3.Location = new Point(377, 363);
            lblQ3.Name = "lblQ3";
            lblQ3.Size = new Size(370, 25);
            lblQ3.TabIndex = 16;
            lblQ3.Text = "Does your mushroom have a convex cup ?";
            // 
            // cmbRing
            // 
            cmbRing.FormattingEnabled = true;
            cmbRing.Location = new Point(549, 187);
            cmbRing.Name = "cmbRing";
            cmbRing.Size = new Size(179, 28);
            cmbRing.TabIndex = 15;
            // 
            // cmbForest
            // 
            cmbForest.FormattingEnabled = true;
            cmbForest.Location = new Point(549, 288);
            cmbForest.Name = "cmbForest";
            cmbForest.Size = new Size(179, 28);
            cmbForest.TabIndex = 14;
            // 
            // cmbCup
            // 
            cmbCup.FormattingEnabled = true;
            cmbCup.Location = new Point(549, 410);
            cmbCup.Name = "cmbCup";
            cmbCup.Size = new Size(179, 28);
            cmbCup.TabIndex = 13;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Tan;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(172, 560);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(41, 35);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.IndianRed;
            btnLogout.Font = new Font("Imprint MT Shadow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(22, 547);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(198, 64);
            btnLogout.TabIndex = 11;
            btnLogout.Text = "LOGOUT";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Tan;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(33, 456);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(41, 39);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 10;
            pictureBox5.TabStop = false;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Orange;
            btnBack.Font = new Font("Imprint MT Shadow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(22, 444);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(198, 64);
            btnBack.TabIndex = 9;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Tan;
            panel2.Controls.Add(lblHeader);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(12, 17);
            panel2.Name = "panel2";
            panel2.Size = new Size(296, 216);
            panel2.TabIndex = 0;
            // 
            // lblHeader
            // 
            lblHeader.BackColor = Color.Linen;
            lblHeader.Font = new Font("Imprint MT Shadow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.Location = new Point(54, 147);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(186, 59);
            lblHeader.TabIndex = 1;
            lblHeader.Text = "MUSHROOM FINDER";
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(81, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(139, 109);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblQ2
            // 
            lblQ2.AutoSize = true;
            lblQ2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQ2.Location = new Point(377, 250);
            lblQ2.Name = "lblQ2";
            lblQ2.Size = new Size(332, 25);
            lblQ2.TabIndex = 1;
            lblQ2.Text = "Does your mushroom gorw in forest ?";
            // 
            // lblQ1
            // 
            lblQ1.AutoSize = true;
            lblQ1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQ1.Location = new Point(377, 146);
            lblQ1.Name = "lblQ1";
            lblQ1.Size = new Size(302, 25);
            lblQ1.TabIndex = 0;
            lblQ1.Text = "Does your mushroom have a ring?";
            // 
            // MushroomForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 742);
            Controls.Add(panel1);
            Name = "MushroomForm";
            Text = "MushroomForm";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private PictureBox pictureBox4;
        private Button btnLogout;
        private PictureBox pictureBox5;
        private Button btnBack;
        private Panel panel2;
        private Label lblHeader;
        private PictureBox pictureBox1;
        private Label lblQ2;
        private Label lblQ1;
        private ComboBox cmbCup;
        private ComboBox cmbRing;
        private ComboBox cmbForest;
        private Label lblQ3;
        internal Label label5;
        private Button btnSubmit;
    }
}