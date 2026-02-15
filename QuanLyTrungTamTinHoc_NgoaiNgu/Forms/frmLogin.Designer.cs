namespace QuanLyTrungTamTinHoc_NgoaiNgu.Forms
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            pictureBox2 = new PictureBox();
            txtTenDN = new TextBox();
            panel2 = new Panel();
            panel1 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            txtMatKhau = new TextBox();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            btnLogin = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-13, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(843, 556);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AllowDrop = true;
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(546, 60);
            label1.Name = "label1";
            label1.Size = new Size(204, 28);
            label1.TabIndex = 2;
            label1.Text = "WELCOME TO VIBEX";
            // 
            // nightControlBox1
            // 
            nightControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nightControlBox1.BackColor = Color.Transparent;
            nightControlBox1.CloseHoverColor = Color.FromArgb(199, 80, 80);
            nightControlBox1.CloseHoverForeColor = Color.White;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.EnableCloseColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMaximizeButton = true;
            nightControlBox1.EnableMaximizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.Location = new Point(691, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 5;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(259, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(29, 30);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // txtTenDN
            // 
            txtTenDN.BorderStyle = BorderStyle.None;
            txtTenDN.Location = new Point(3, 10);
            txtTenDN.Name = "txtTenDN";
            txtTenDN.Size = new Size(250, 20);
            txtTenDN.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(128, 128, 255);
            panel2.Location = new Point(0, 36);
            panel2.Name = "panel2";
            panel2.Size = new Size(292, 5);
            panel2.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(txtTenDN);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(509, 177);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 44);
            panel1.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(txtMatKhau);
            panel3.Controls.Add(pictureBox3);
            panel3.Location = new Point(509, 255);
            panel3.Name = "panel3";
            panel3.Size = new Size(292, 44);
            panel3.TabIndex = 6;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(128, 128, 255);
            panel4.Location = new Point(0, 36);
            panel4.Name = "panel4";
            panel4.Size = new Size(292, 5);
            panel4.TabIndex = 5;
            // 
            // txtMatKhau
            // 
            txtMatKhau.BorderStyle = BorderStyle.None;
            txtMatKhau.Location = new Point(3, 10);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(250, 20);
            txtMatKhau.TabIndex = 1;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(259, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(29, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(509, 151);
            label2.Name = "label2";
            label2.Size = new Size(87, 23);
            label2.TabIndex = 7;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(509, 229);
            label3.Name = "label3";
            label3.Size = new Size(80, 23);
            label3.TabIndex = 8;
            label3.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(128, 128, 255);
            btnLogin.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(509, 352);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(292, 53);
            btnLogin.TabIndex = 9;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(37, 107, 201);
            label4.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(94, 324);
            label4.Name = "label4";
            label4.Size = new Size(160, 62);
            label4.TabIndex = 10;
            label4.Text = "VIBEX";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(830, 526);
            Controls.Add(label4);
            Controls.Add(btnLogin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel3);
            Controls.Add(nightControlBox1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLogin";
            Load += frmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private PictureBox pictureBox2;
        private TextBox txtTenDN;
        private Panel panel2;
        private Panel panel1;
        private Panel panel3;
        private Panel panel4;
        private TextBox txtMatKhau;
        private PictureBox pictureBox3;
        private Label label2;
        private Label label3;
        private Button btnLogin;
        private Label label4;
    }
}