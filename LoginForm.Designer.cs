namespace ByNMushroomApp
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            panel1 = new Panel();
            panel3 = new Panel();
            btnLogin = new Button();
            panel2 = new Panel();
            lblHeader = new Label();
            pictureBox1 = new PictureBox();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            lblPassword = new Label();
            lblUsername = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Tan;
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(171, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(853, 671);
            panel1.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Linen;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(btnLogin);
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(txtPassword);
            panel3.Controls.Add(txtUsername);
            panel3.Controls.Add(lblPassword);
            panel3.Controls.Add(lblUsername);
            panel3.Location = new Point(17, 13);
            panel3.Name = "panel3";
            panel3.Size = new Size(819, 644);
            panel3.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Orange;
            btnLogin.Font = new Font("Imprint MT Shadow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(311, 510);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(189, 60);
            btnLogin.TabIndex = 11;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Tan;
            panel2.Controls.Add(lblHeader);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(246, 33);
            panel2.Name = "panel2";
            panel2.Size = new Size(303, 226);
            panel2.TabIndex = 0;
            // 
            // lblHeader
            // 
            lblHeader.BackColor = Color.Linen;
            lblHeader.Font = new Font("Imprint MT Shadow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.Location = new Point(65, 147);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(186, 59);
            lblHeader.TabIndex = 1;
            lblHeader.Text = "Login";
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
            // txtPassword
            // 
            txtPassword.BackColor = Color.Tan;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(351, 423);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Enter Password";
            txtPassword.Size = new Size(193, 24);
            txtPassword.TabIndex = 3;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.Tan;
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(351, 304);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Enter Username";
            txtUsername.Size = new Size(193, 24);
            txtUsername.TabIndex = 2;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(216, 422);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(102, 25);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password :";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(216, 304);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(107, 25);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username :";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1290, 693);
            Controls.Add(panel1);
            Name = "LoginForm";
            Text = "LoginForm";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Button btnLogin;
        private Panel panel2;
        private Label lblHeader;
        private PictureBox pictureBox1;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label lblPassword;
        private Label lblUsername;
    }
}