using ComponentFactory.Krypton.Ribbon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceLearning
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadGridHD();
        }
        public void LoadGridHD()
        {
            using (Context db = new Context())
            {
                var _event = from ev in db.HOAT_DONG
                             where ev.Hide == false
                             select new
                             {
                                 a = ev.MaHD,
                                 b = ev.TenHoatDong,
                                 c = ev.Loai,
                                 d = ev.NgayBatDau,
                                 e = ev.NgayKetThuc,
                                 f = ev.CreatedDate,
                             };
                dataGridView1.DataSource = _event.ToList();
                FormatGridViewHD();
            }
        }
        public void FormatGridViewHD()
        {
            dataGridView1.Columns["d"].DefaultCellStyle.Format = "dd-MM-yyyy";
            dataGridView1.Columns["e"].DefaultCellStyle.Format = "dd-MM-yyyy";
            dataGridView1.Columns["f"].DefaultCellStyle.Format = "dd-MM-yyyy";
            dataGridView1.Columns["a"].HeaderText = "Mã HĐ";
            dataGridView1.Columns["b"].HeaderText = "Tên Hoạt Động";
            dataGridView1.Columns["c"].HeaderText = "Loại";
            dataGridView1.Columns["d"].HeaderText = "Ngày BĐ";
            dataGridView1.Columns["e"].HeaderText = "Ngày KT";
            dataGridView1.Columns["f"].HeaderText = "Created Date";
            
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["c"].Index
            && e.Value != null)
            {
                int i = (int)e.Value;
                e.Value = GetLoai(i);
            }
            else return;
        }
        public static string ConvertDMY(DateTime? dt)
        {
            return dt == null ? "N/A" : ((DateTime)dt).ToString("dd-MM-yyyy");
        }
        public string GetLoai(int i)
        {
            switch (i)
            {
                case 0: return "Sự kiện";
                case 1: return "Dự án";
                case 2: return "Môn học";
                default: return "N/A";
            }
        }

        private void kryptonRibbonGroupButton1_Click(object sender, EventArgs e)
        {
            frmAddHoatDong New = new frmAddHoatDong();
            New.ShowDialog();
        }

        private void kryptonRibbonGroupButton3_Click(object sender, EventArgs e)
        {
            string EventID = dataGridView1.CurrentRow.Cells["a"].Value.ToString();
            frmAddHoatDong Update = new frmAddHoatDong();
            Update.LoadFormUpdate(EventID);
            Update.ShowDialog();
        }

        private void btnHDDel_Click(object sender, EventArgs e)
        {
            using (Context db = new Context())
            {
                string EventID = dataGridView1.CurrentRow.Cells["a"].Value.ToString();
                HOAT_DONG DelHD =  db.HOAT_DONG.Find(EventID);
                if (DelHD == null) return;
                else
                {
                    DelHD.Hide = true;
                    db.Entry(DelHD).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    MessageBox.Show("Xóa Hoạt Động thành công!","Thành công",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        //private void kryptonRibbonTab1_PropertyChanged(object sender, PropertyChangedEventArgs e)
        //{
        //    dataGridView1.Rows.Clear();
        //    dataGridView1.Columns.Clear();
        //    dataGridView1.Refresh();
        //    using (Context db = new Context())
        //    {
        //        var _gv = (from gv in db.GIANG_VIEN
        //                     where gv.Hide == false
        //                     select new
        //                     {
        //                         a = gv.MaGV,
        //                         b = gv.HoTenLot,
        //                         c = gv.Ten,
        //                         d = gv.DonVi,
        //                         e = gv.KHOA1.TenKhoa,
        //                     }).ToList();
        //        dataGridView1.DataSource = _gv;
        //    }
        //}

        private void kryptonRibbon1_SelectedTabChanged(object sender, EventArgs e)
        {
            KryptonRibbon Rib = sender as KryptonRibbon;
            string Tname = Rib.SelectedTab.Text;
            if(e.ToString() == null || Tname == null) return;
             
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            if (Tname == "Hoạt động")
            {
                LoadGridHD();
            }
            else
                if (Tname == "Giảng viên")
            {
                LoadGridGV();
            }
            else
                if (Tname == "Sinh Viên")
            {
                LoadGridSV();
            }
            else
                if (Tname == "Đối Tác")
            {
                LoadGridDT();
            }

        }
        private void LoadGridGV()
        {
            using (Context db = new Context())
            {
                var _gv = (from gv in db.GIANG_VIEN
                           where gv.Hide == false
                           select new
                           {
                               a = gv.MaGV,
                               b = gv.HoTenLot,
                               c = gv.Ten,
                               d = gv.DonVi,
                               e = gv.KHOA1.TenKhoa,
                           }).ToList();
                if (_gv == null) return;
                dataGridView1.DataSource = _gv;
            }
        }
        private void LoadGridSV()
        {
            using (Context db = new Context())
            {
                var _sv = (from gv in db.SINH_VIEN
                           where gv.Hide == false
                           select new
                           {
                               MSSV = gv.MSSV,
                               HoTen = gv.HoTen,
                               Khoa = gv.KHOA1.TenKhoa,
                           }).ToList();
                if (_sv == null) return;
                dataGridView1.DataSource = _sv;
            }
        }
        private void LoadGridDT()
        {
            using (Context db = new Context())
            {
                var _gv = (from gv in db.DOI_TAC
                           where gv.Hide == false
                           select new
                           {
                               ID = gv.ID_DoiTac,
                               Ten = gv.TenDoiTac,
                               DaiDien = gv.DaiDien,
                               SDT = gv.SDT,
                               Email = gv.Email,
                           }).ToList();
                if (_gv == null) return;
                dataGridView1.DataSource = _gv;
            }
        }
    }
}
