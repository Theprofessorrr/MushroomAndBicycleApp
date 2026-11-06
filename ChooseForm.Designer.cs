namespace ByNMushroomApp
{
    partial class ChooseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseForm));
            panel3 = new Panel();
            label4 = new Label();
            panel5 = new Panel();
            label3 = new Label();
            pictureBox4 = new PictureBox();
            panel4 = new Panel();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            btnMushroom = new Button();
            btnBicycle = new Button();
            panel2 = new Panel();
            lblWelcome = new Label();
            panel1 = new Panel();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.Linen;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(label4);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(btnMushroom);
            panel3.Controls.Add(btnBicycle);
            panel3.Controls.Add(panel2);
            panel3.Location = new Point(12, 13);
            panel3.Name = "panel3";
            panel3.Size = new Size(816, 643);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // label4
            // 
            label4.BackColor = Color.Black;
            label4.Location = new Point(68, 577);
            label4.Name = "label4";
            label4.Size = new Size(680, 10);
            label4.TabIndex = 13;
            label4.Text = "label4";
            // 
            // panel5
            // 
            panel5.BackColor = Color.Tan;
            panel5.Controls.Add(label3);
            panel5.Controls.Add(pictureBox4);
            panel5.Location = new Point(526, 260);
            panel5.Name = "panel5";
            panel5.Size = new Size(222, 156);
            panel5.TabIndex = 12;
            // 
            // label3
            // 
            label3.BackColor = Color.Linen;
            label3.Font = new Font("Imprint MT Shadow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(36, 90);
            label3.Name = "label3";
            label3.Size = new Size(158, 55);
            label3.TabIndex = 1;
            label3.Text = "MUSHROOM FINDER";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(79, 28);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(72, 50);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.SteelBlue;
            panel4.Controls.Add(label2);
            panel4.Controls.Add(pictureBox2);
            panel4.Location = new Point(107, 260);
            panel4.Name = "panel4";
            panel4.Size = new Size(214, 156);
            panel4.TabIndex = 11;
            // 
            // label2
            // 
            label2.BackColor = Color.Linen;
            label2.Font = new Font("Imprint MT Shadow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(50, 90);
            label2.Name = "label2";
            label2.Size = new Size(125, 50);
            label2.TabIndex = 1;
            label2.Text = "BICYCLE RENTING";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(78, 28);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(67, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // btnMushroom
            // 
            btnMushroom.BackColor = Color.Tan;
            btnMushroom.Font = new Font("Imprint MT Shadow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMushroom.Location = new Point(484, 413);
            btnMushroom.Name = "btnMushroom";
            btnMushroom.Size = new Size(161, 82);
            btnMushroom.TabIndex = 10;
            btnMushroom.Text = "CLICK ME !";
            btnMushroom.UseVisualStyleBackColor = false;
            btnMushroom.Click += buttonMushroom_Click;
            // 
            // btnBicycle
            // 
            btnBicycle.BackColor = Color.SteelBlue;
            btnBicycle.Font = new Font("Imprint MT Shadow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBicycle.Location = new Point(196, 413);
            btnBicycle.Name = "btnBicycle";
            btnBicycle.Size = new Size(164, 82);
            btnBicycle.TabIndex = 9;
            btnBicycle.Text = "CLICK ME !";
            btnBicycle.UseVisualStyleBackColor = false;
            btnBicycle.Click += btnBicycle_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Tan;
            panel2.Controls.Add(lblWelcome);
            panel2.Location = new Point(184, 20);
            panel2.Name = "panel2";
            panel2.Size = new Size(445, 179);
            panel2.TabIndex = 0;
            // 
            // lblWelcome
            // 
            lblWelcome.BackColor = Color.Linen;
            lblWelcome.Font = new Font("Imprint MT Shadow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(95, 26);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(270, 118);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Welcome";
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Tan;
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(165, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(844, 674);
            panel1.TabIndex = 3;
            // 
            // ChooseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1236, 708);
            Controls.Add(panel1);
            Name = "ChooseForm";
            Text = "Choose";
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Panel panel2;
        private Label lblWelcome;
        private Panel panel1;
        private Button btnMushroom;
        private Button btnBicycle;
        private Panel panel4;
        private Label label2;
        private PictureBox pictureBox2;
        private Panel panel5;
        private Label label3;
        private PictureBox pictureBox4;
        private Label label4;
    }
}