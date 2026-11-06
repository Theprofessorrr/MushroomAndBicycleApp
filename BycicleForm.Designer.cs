namespace ByNMushroomApp
{
    partial class BycicleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BycicleForm));
            panel1 = new Panel();
            panel3 = new Panel();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            btnCalculate = new Button();
            pictureBox4 = new PictureBox();
            btnLogout = new Button();
            pictureBox5 = new PictureBox();
            btnBack = new Button();
            panel2 = new Panel();
            lblHeader = new Label();
            pictureBox1 = new PictureBox();
            txtEndTime = new TextBox();
            txtStartTime = new TextBox();
            lblEndTime = new Label();
            lblSartTime = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            panel1.Location = new Point(195, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(853, 671);
            panel1.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Linen;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(label4);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(btnCalculate);
            panel3.Controls.Add(pictureBox4);
            panel3.Controls.Add(btnLogout);
            panel3.Controls.Add(pictureBox5);
            panel3.Controls.Add(btnBack);
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(txtEndTime);
            panel3.Controls.Add(txtStartTime);
            panel3.Controls.Add(lblEndTime);
            panel3.Controls.Add(lblSartTime);
            panel3.Location = new Point(17, 13);
            panel3.Name = "panel3";
            panel3.Size = new Size(819, 644);
            panel3.TabIndex = 1;
            panel3.Paint += panel3_Paint;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(405, 40);
            label4.Name = "label4";
            label4.Size = new Size(299, 121);
            label4.TabIndex = 15;
            label4.Text = "Enter Renting Time Information:";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Tan;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(664, 398);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 39);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.Firebrick;
            btnCalculate.Font = new Font("Imprint MT Shadow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCalculate.Location = new Point(494, 386);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(210, 64);
            btnCalculate.TabIndex = 13;
            btnCalculate.Text = "CALCULATE";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Tan;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(184, 508);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(41, 35);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Orange;
            btnLogout.Font = new Font("Imprint MT Shadow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(34, 495);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(198, 60);
            btnLogout.TabIndex = 11;
            btnLogout.Text = "LOGOUT";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Tan;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(45, 398);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(41, 39);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 10;
            pictureBox5.TabStop = false;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.LightSeaGreen;
            btnBack.Font = new Font("Imprint MT Shadow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(34, 386);
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
            lblHeader.Location = new Point(55, 147);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(186, 59);
            lblHeader.TabIndex = 1;
            lblHeader.Text = "BYCICLE RENTING";
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            lblHeader.Click += label1_Click;
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
            // txtEndTime
            // 
            txtEndTime.BackColor = Color.Tan;
            txtEndTime.BorderStyle = BorderStyle.None;
            txtEndTime.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEndTime.Location = new Point(540, 317);
            txtEndTime.Name = "txtEndTime";
            txtEndTime.PlaceholderText = "1-24";
            txtEndTime.Size = new Size(193, 24);
            txtEndTime.TabIndex = 3;
            // 
            // txtStartTime
            // 
            txtStartTime.BackColor = Color.Tan;
            txtStartTime.BorderStyle = BorderStyle.None;
            txtStartTime.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStartTime.Location = new Point(540, 198);
            txtStartTime.Name = "txtStartTime";
            txtStartTime.PlaceholderText = "0-23";
            txtStartTime.Size = new Size(193, 24);
            txtStartTime.TabIndex = 2;
            // 
            // lblEndTime
            // 
            lblEndTime.AutoSize = true;
            lblEndTime.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEndTime.Location = new Point(405, 316);
            lblEndTime.Name = "lblEndTime";
            lblEndTime.Size = new Size(101, 25);
            lblEndTime.TabIndex = 1;
            lblEndTime.Text = "End Time :";
            // 
            // lblSartTime
            // 
            lblSartTime.AutoSize = true;
            lblSartTime.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSartTime.Location = new Point(405, 198);
            lblSartTime.Name = "lblSartTime";
            lblSartTime.Size = new Size(111, 25);
            lblSartTime.TabIndex = 0;
            lblSartTime.Text = "Start Time :";
            // 
            // BycicleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1243, 731);
            Controls.Add(panel1);
            Name = "BycicleForm";
            Text = "BycicleForm";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Label lblHeader;
        private PictureBox pictureBox1;
        private TextBox txtEndTime;
        private TextBox txtStartTime;
        private Label lblEndTime;
        private Label lblSartTime;
        private PictureBox pictureBox4;
        private Button btnLogout;
        private PictureBox pictureBox5;
        private Button btnBack;
        private Button btnCalculate;
        private Label label4;
        private PictureBox pictureBox2;
    }
}