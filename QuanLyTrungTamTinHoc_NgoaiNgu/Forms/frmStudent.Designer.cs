namespace QuanLyTrungTamTinHoc_NgoaiNgu.Forms
{
    partial class frmStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudent));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2 = new Panel();
            btnThongTin = new Button();
            panel3 = new Panel();
            btnThoiKhoaBieu = new Button();
            panel4 = new Panel();
            btnLichThi = new Button();
            panel5 = new Panel();
            btnKetQuaHocTap = new Button();
            panel6 = new Panel();
            btnHocPhi = new Button();
            panel7 = new Panel();
            btnDangXuat = new Button();
            pnlContent = new Panel();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(nightControlBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1203, 37);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(55, 3);
            label1.Name = "label1";
            label1.Size = new Size(174, 28);
            label1.TabIndex = 1;
            label1.Text = "BẢNG ĐIỀU KHIỂN";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(23, 24, 29);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Controls.Add(panel4);
            flowLayoutPanel1.Controls.Add(panel5);
            flowLayoutPanel1.Controls.Add(panel6);
            flowLayoutPanel1.Controls.Add(panel7);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.ForeColor = SystemColors.ControlText;
            flowLayoutPanel1.Location = new Point(0, 37);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(250, 640);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnThongTin);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(243, 69);
            panel2.TabIndex = 3;
            // 
            // btnThongTin
            // 
            btnThongTin.BackColor = Color.FromArgb(23, 24, 29);
            btnThongTin.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThongTin.ForeColor = Color.White;
            btnThongTin.Image = (Image)resources.GetObject("btnThongTin.Image");
            btnThongTin.ImageAlign = ContentAlignment.MiddleLeft;
            btnThongTin.Location = new Point(-21, -14);
            btnThongTin.Name = "btnThongTin";
            btnThongTin.Padding = new Padding(25, 0, 0, 0);
            btnThongTin.Size = new Size(306, 94);
            btnThongTin.TabIndex = 4;
            btnThongTin.Text = "          Thông tin cá nhân";
            btnThongTin.TextAlign = ContentAlignment.MiddleLeft;
            btnThongTin.UseVisualStyleBackColor = false;
            btnThongTin.Click += btnThongTin_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnThoiKhoaBieu);
            panel3.Location = new Point(3, 78);
            panel3.Name = "panel3";
            panel3.Size = new Size(243, 69);
            panel3.TabIndex = 4;
            // 
            // btnThoiKhoaBieu
            // 
            btnThoiKhoaBieu.BackColor = Color.FromArgb(23, 24, 29);
            btnThoiKhoaBieu.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThoiKhoaBieu.ForeColor = Color.White;
            btnThoiKhoaBieu.Image = (Image)resources.GetObject("btnThoiKhoaBieu.Image");
            btnThoiKhoaBieu.ImageAlign = ContentAlignment.MiddleLeft;
            btnThoiKhoaBieu.Location = new Point(-21, -14);
            btnThoiKhoaBieu.Name = "btnThoiKhoaBieu";
            btnThoiKhoaBieu.Padding = new Padding(25, 0, 0, 0);
            btnThoiKhoaBieu.Size = new Size(306, 94);
            btnThoiKhoaBieu.TabIndex = 4;
            btnThoiKhoaBieu.Text = "          Thời Khóa biểu";
            btnThoiKhoaBieu.TextAlign = ContentAlignment.MiddleLeft;
            btnThoiKhoaBieu.UseVisualStyleBackColor = false;
            btnThoiKhoaBieu.Click += btnThoiKhoaBieu_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnLichThi);
            panel4.Location = new Point(3, 153);
            panel4.Name = "panel4";
            panel4.Size = new Size(243, 69);
            panel4.TabIndex = 5;
            // 
            // btnLichThi
            // 
            btnLichThi.BackColor = Color.FromArgb(23, 24, 29);
            btnLichThi.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLichThi.ForeColor = Color.White;
            btnLichThi.Image = (Image)resources.GetObject("btnLichThi.Image");
            btnLichThi.ImageAlign = ContentAlignment.MiddleLeft;
            btnLichThi.Location = new Point(-21, -14);
            btnLichThi.Name = "btnLichThi";
            btnLichThi.Padding = new Padding(25, 0, 0, 0);
            btnLichThi.Size = new Size(306, 94);
            btnLichThi.TabIndex = 4;
            btnLichThi.Text = "          Lịch thi";
            btnLichThi.TextAlign = ContentAlignment.MiddleLeft;
            btnLichThi.UseVisualStyleBackColor = false;
            btnLichThi.Click += btnLichThi_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnKetQuaHocTap);
            panel5.Location = new Point(3, 228);
            panel5.Name = "panel5";
            panel5.Size = new Size(243, 69);
            panel5.TabIndex = 6;
            // 
            // btnKetQuaHocTap
            // 
            btnKetQuaHocTap.BackColor = Color.FromArgb(23, 24, 29);
            btnKetQuaHocTap.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnKetQuaHocTap.ForeColor = Color.White;
            btnKetQuaHocTap.Image = (Image)resources.GetObject("btnKetQuaHocTap.Image");
            btnKetQuaHocTap.ImageAlign = ContentAlignment.MiddleLeft;
            btnKetQuaHocTap.Location = new Point(-21, -14);
            btnKetQuaHocTap.Name = "btnKetQuaHocTap";
            btnKetQuaHocTap.Padding = new Padding(25, 0, 0, 0);
            btnKetQuaHocTap.Size = new Size(306, 94);
            btnKetQuaHocTap.TabIndex = 4;
            btnKetQuaHocTap.Text = "          Kết quả học tập";
            btnKetQuaHocTap.TextAlign = ContentAlignment.MiddleLeft;
            btnKetQuaHocTap.UseVisualStyleBackColor = false;
            btnKetQuaHocTap.Click += btnKetQuaHocTap_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnHocPhi);
            panel6.Location = new Point(3, 303);
            panel6.Name = "panel6";
            panel6.Size = new Size(243, 69);
            panel6.TabIndex = 7;
            // 
            // btnHocPhi
            // 
            btnHocPhi.BackColor = Color.FromArgb(23, 24, 29);
            btnHocPhi.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHocPhi.ForeColor = Color.White;
            btnHocPhi.Image = (Image)resources.GetObject("btnHocPhi.Image");
            btnHocPhi.ImageAlign = ContentAlignment.MiddleLeft;
            btnHocPhi.Location = new Point(-21, -14);
            btnHocPhi.Name = "btnHocPhi";
            btnHocPhi.Padding = new Padding(25, 0, 0, 0);
            btnHocPhi.Size = new Size(306, 94);
            btnHocPhi.TabIndex = 4;
            btnHocPhi.Text = "          Học phí";
            btnHocPhi.TextAlign = ContentAlignment.MiddleLeft;
            btnHocPhi.UseVisualStyleBackColor = false;
            btnHocPhi.Click += btnHocPhi_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(btnDangXuat);
            panel7.Location = new Point(3, 378);
            panel7.Name = "panel7";
            panel7.Size = new Size(243, 69);
            panel7.TabIndex = 8;
            // 
            // btnDangXuat
            // 
            btnDangXuat.BackColor = Color.FromArgb(23, 24, 29);
            btnDangXuat.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDangXuat.ForeColor = Color.White;
            btnDangXuat.Image = (Image)resources.GetObject("btnDangXuat.Image");
            btnDangXuat.ImageAlign = ContentAlignment.MiddleLeft;
            btnDangXuat.Location = new Point(-21, -14);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Padding = new Padding(25, 0, 0, 0);
            btnDangXuat.Size = new Size(306, 94);
            btnDangXuat.TabIndex = 4;
            btnDangXuat.Text = "          Đăng xuất";
            btnDangXuat.TextAlign = ContentAlignment.MiddleLeft;
            btnDangXuat.UseVisualStyleBackColor = false;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.White;
            pnlContent.Location = new Point(250, 37);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(953, 640);
            pnlContent.TabIndex = 2;
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
            nightControlBox1.Location = new Point(1064, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 6;
            // 
            // frmStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1203, 677);
            Controls.Add(pnlContent);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmStudent";
            Text = "frmHocVien";
            FormClosed += frmStudent_FormClosed;
            Load += frmHocVien_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
        private Button btnThongTin;
        private Panel panel3;
        private Button btnThoiKhoaBieu;
        private Panel panel4;
        private Button btnLichThi;
        private Panel panel5;
        private Button btnKetQuaHocTap;
        private Panel panel6;
        private Button btnHocPhi;
        private Panel panel7;
        private Button btnDangXuat;
        private Panel pnlContent;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
    }
}