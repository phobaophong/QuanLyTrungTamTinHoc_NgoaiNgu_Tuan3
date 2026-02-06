namespace QuanLyTrungTamTinHoc_NgoaiNgu.UserControls
{
    partial class ucThoiKhoaBieu_HocVien
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cboTuan = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            dataGridView1 = new DataGridView();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // cboTuan
            // 
            cboTuan.FormattingEnabled = true;
            cboTuan.Location = new Point(127, 3);
            cboTuan.Name = "cboTuan";
            cboTuan.Size = new Size(183, 28);
            cboTuan.TabIndex = 0;
            cboTuan.Text = "Tuần 3 (18/03 - 24/03)";
            // 
            // button1
            // 
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(118, 29);
            button1.TabIndex = 1;
            button1.Text = "◀ Tuần Trước";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(316, 3);
            button2.Name = "button2";
            button2.Size = new Size(118, 29);
            button2.TabIndex = 2;
            button2.Text = "Tuần Sau ▶";
            button2.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(cboTuan);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(963, 38);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 38);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(663, 236);
            dataGridView1.TabIndex = 4;
            // 
            // ucThoiKhoaBieu_HocVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(flowLayoutPanel1);
            Name = "ucThoiKhoaBieu_HocVien";
            Size = new Size(963, 507);
            Load += ucThoiKhoaBieu_HocVien_Load;
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cboTuan;
        private Button button1;
        private Button button2;
        private FlowLayoutPanel flowLayoutPanel1;
        private DataGridView dataGridView1;
    }
}
