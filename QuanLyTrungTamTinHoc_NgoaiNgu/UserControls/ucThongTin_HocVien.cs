using QuanLyTrungTamTinHoc_NgoaiNgu.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyTrungTamTinHoc_NgoaiNgu.UserControls
{
    public partial class ucThongTin_HocVien : UserControl
    {
        public ucThongTin_HocVien()
        {
            InitializeComponent();
        }

        private void ucThongTin_Load(object sender, EventArgs e)
        {

        }

        public void LoadData(HocVien hv)
        {
            if (hv != null)
            {
                //Gán hình
                if (hv.GioiTinh == "Nam")
                {
                    picAvatar.Image = Properties.Resources.nam_avatar;
                }
                else
                {
                    picAvatar.Image = Properties.Resources.nu_avatar;
                }

                //Họ tên, mã số học viên
                lblHoTen.Text = "Họ tên: " + hv.HoTenHV.ToString();
                lblMaHV.Text  = "Mã số:  " + hv.MaHV;
                //Ngày sinh
                if (hv.NgaySinh != null)
                {
                    lblNgaySinh.Text = "Ngày sinh: " + hv.NgaySinh.Value.ToString("dd/MM/yyyy");
                }
                else
                {
                    lblNgaySinh.Text = "Ngày sinh: Chưa Cập Nhật!";
                }
                //Số điện thoại
                if (hv.SoDienThoaiHV != null)
                {
                    lblSoDienThoai.Text = "Số điện thoại: " + hv.SoDienThoaiHV.ToString();
                }
                else
                {
                    lblSoDienThoai.Text = "Số điện thoại: Chưa cập nhật!";
                }
                //Giới tính, địa chỉ, email
                if(hv.GioiTinh != null)
                {
                    lblGioiTinh.Text = "Giới tính: " + hv.GioiTinh;
                }
                else
                {
                    lblGioiTinh.Text = "Giới tính: Chưa cập nhât!";
                }
                //Địa chỉ
                if (hv.DiaChi != null)
                {
                    lblDiaChi.Text = "Địa chỉ: " + hv.DiaChi;
                }
                else
                {
                    lblDiaChi.Text = "Địa chỉ: Chưa cập nhật!";
                }
                //Email
                if(hv.EmailHV != null)
                {
                    lblEmail.Text = "Email: " + hv.EmailHV;
                }
                else
                {
                    lblEmail.Text = "Email: Chưa cập nhật!";
                }
                //Lớp học + khóa học
                if (hv.LopHoc != null && hv.LopHoc.KhoaHoc != null)
                {
                    lblLop.Text = "Lớp: " + hv.LopHoc.TenLop
                        + " | Tên khóa: " + hv.LopHoc.KhoaHoc.TenKH;
                }
                else
                {
                    lblLop.Text = "Lớp: hiện chưa đăng ký lớp, " +
                                  "vui lòng liên hệ Phòng Nhân Sự để được đăng ký trong thời gian sớm nhất!";
                }

            }
        }
    }
}
