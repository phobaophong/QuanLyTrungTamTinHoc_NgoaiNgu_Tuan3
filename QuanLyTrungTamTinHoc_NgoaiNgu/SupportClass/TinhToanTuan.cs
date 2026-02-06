using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyTrungTamTinHoc_NgoaiNgu.SupportClass
{
    internal class TinhToanTuan
    {
        public static DateTime LayThuHai(DateTime date)
        {
            int diff = (7 + (date.DayOfWeek - DayOfWeek.Monday)) % 7;
            return date.AddDays(-diff).Date;
        }
    }
}
