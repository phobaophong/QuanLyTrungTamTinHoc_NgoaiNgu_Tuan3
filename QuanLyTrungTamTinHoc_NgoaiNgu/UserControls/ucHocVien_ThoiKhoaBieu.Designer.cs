namespace QuanLyTrungTamTinHoc_NgoaiNgu.UserControls
{
    partial class ucHocVien_ThoiKhoaBieu
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
            btnTuanTruoc = new Button();
            btnTuanSau = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            dataGridView = new DataGridView();
            colCa = new DataGridViewTextBoxColumn();
            colT2 = new DataGridViewTextBoxColumn();
            colT3 = new DataGridViewTextBoxColumn();
            colT4 = new DataGridViewTextBoxColumn();
            colT5 = new DataGridViewTextBoxColumn();
            colT6 = new DataGridViewTextBoxColumn();
            colT7 = new DataGridViewTextBoxColumn();
            colCN = new DataGridViewTextBoxColumn();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
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
            cboTuan.SelectedIndexChanged += cboTuan_SelectedIndexChanged;
            // 
            // btnTuanTruoc
            // 
            btnTuanTruoc.Location = new Point(3, 3);
            btnTuanTruoc.Name = "btnTuanTruoc";
            btnTuanTruoc.Size = new Size(118, 29);
            btnTuanTruoc.TabIndex = 1;
            btnTuanTruoc.Text = "◀ Tuần Trước";
            btnTuanTruoc.UseVisualStyleBackColor = true;
            btnTuanTruoc.Click += btnTuanTruoc_Click;
            // 
            // btnTuanSau
            // 
            btnTuanSau.Location = new Point(316, 3);
            btnTuanSau.Name = "btnTuanSau";
            btnTuanSau.Size = new Size(118, 29);
            btnTuanSau.TabIndex = 2;
            btnTuanSau.Text = "Tuần Sau ▶";
            btnTuanSau.UseVisualStyleBackColor = true;
            btnTuanSau.Click += btnTuanSau_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnTuanTruoc);
            flowLayoutPanel1.Controls.Add(cboTuan);
            flowLayoutPanel1.Controls.Add(btnTuanSau);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(952, 38);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { colCa, colT2, colT3, colT4, colT5, colT6, colT7, colCN });
            dataGridView.Location = new Point(3, 38);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView.Size = new Size(949, 439);
            dataGridView.TabIndex = 4;
            // 
            // colCa
            // 
            colCa.HeaderText = "Ca / Thứ";
            colCa.MinimumWidth = 6;
            colCa.Name = "colCa";
            colCa.Width = 80;
            // 
            // colT2
            // 
            colT2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colT2.HeaderText = "Thứ 2";
            colT2.MinimumWidth = 6;
            colT2.Name = "colT2";
            // 
            // colT3
            // 
            colT3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colT3.HeaderText = "Thứ 3";
            colT3.MinimumWidth = 6;
            colT3.Name = "colT3";
            // 
            // colT4
            // 
            colT4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colT4.HeaderText = "Thứ 4";
            colT4.MinimumWidth = 6;
            colT4.Name = "colT4";
            // 
            // colT5
            // 
            colT5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colT5.HeaderText = "Thứ 5";
            colT5.MinimumWidth = 6;
            colT5.Name = "colT5";
            // 
            // colT6
            // 
            colT6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colT6.HeaderText = "Thứ 6";
            colT6.MinimumWidth = 6;
            colT6.Name = "colT6";
            // 
            // colT7
            // 
            colT7.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colT7.HeaderText = "Thứ 7";
            colT7.MinimumWidth = 6;
            colT7.Name = "colT7";
            // 
            // colCN
            // 
            colCN.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCN.HeaderText = "Chủ Nhật";
            colCN.MinimumWidth = 6;
            colCN.Name = "colCN";
            // 
            // ucHocVien_ThoiKhoaBieu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView);
            Controls.Add(flowLayoutPanel1);
            Name = "ucHocVien_ThoiKhoaBieu";
            Size = new Size(952, 478);
            Load += ucThoiKhoaBieu_HocVien_Load;
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cboTuan;
        private Button btnTuanTruoc;
        private Button btnTuanSau;
        private FlowLayoutPanel flowLayoutPanel1;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn colCa;
        private DataGridViewTextBoxColumn colT2;
        private DataGridViewTextBoxColumn colT3;
        private DataGridViewTextBoxColumn colT4;
        private DataGridViewTextBoxColumn colT5;
        private DataGridViewTextBoxColumn colT6;
        private DataGridViewTextBoxColumn colT7;
        private DataGridViewTextBoxColumn colCN;
    }
}
