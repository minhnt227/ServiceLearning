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
            this.kryptonRibbon1.SelectedTab = tabHD;
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
                dgvMain.DataSource = _event.ToList();
                FormatGridViewHD();
            }
        }
        public void FormatGridViewHD()
        {
            dgvMain.Columns["d"].DefaultCellStyle.Format = "dd-MM-yyyy";
            dgvMain.Columns["e"].DefaultCellStyle.Format = "dd-MM-yyyy";
            dgvMain.Columns["f"].DefaultCellStyle.Format = "dd-MM-yyyy";
            dgvMain.Columns["a"].HeaderText = "Mã HĐ";
            dgvMain.Columns["b"].HeaderText = "Tên Hoạt Động";
            dgvMain.Columns["c"].HeaderText = "Loại";
            dgvMain.Columns["d"].HeaderText = "Ngày BĐ";
            dgvMain.Columns["e"].HeaderText = "Ngày KT";
            dgvMain.Columns["f"].HeaderText = "Created Date";
            
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgvMain.Columns["c"].Index
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

        private void btnHD_Edit_Click(object sender, EventArgs e)
        {
            string EventID = dgvMain.CurrentRow.Cells["a"].Value.ToString();
            frmAddHoatDong Update = new frmAddHoatDong();
            Update.LoadFormUpdate(EventID);
            Update.ShowDialog();
        }

        private void btnHDDel_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có chắc muốn xóa hoạt động này không?", "Cảnh báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                try
                {
                    using (Context db = new Context())
                    {
                        string EventID = dgvMain.CurrentRow.Cells["a"].Value.ToString();
                        HOAT_DONG DelHD = db.HOAT_DONG.Find(EventID);
                        if (DelHD == null) return;
                        else
                        {
                            DelHD.Hide = true;
                            db.Entry(DelHD).State = System.Data.Entity.EntityState.Modified;
                            db.SaveChanges();
                            MessageBox.Show("Xóa Hoạt Động thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch  (Exception ex)
                {
                    MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
                return;
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
            if(Rib.SelectedTab == null) return;
            string Tname = Rib.SelectedTab.Text;
            if(e.ToString() == null || Tname == null) return;
             
            dgvMain.DataSource = null;
            dgvMain.Refresh();
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
            }else
                if (Tname == "Hạng Mục ĐG")
            {
                LoadGridHM();
            }

        }

        private void LoadGridHM()
        {
            using (Context db = new Context())
            {
                var _hm = (from hm in db.HANG_MUC
                           where hm.Hide == false
                           select new
                           {
                               STT = hm.ID,
                               Ten = hm.TenHangMuc,
                           }).ToList();
                if (_hm == null) return;
                dgvMain.DataSource = _hm;
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
                               d = gv.KHOA1.TenKhoa,
                           }).ToList();
                if (_gv == null) return;
                dgvMain.DataSource = _gv;
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
                dgvMain.DataSource = _sv;
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
                dgvMain.DataSource = _gv;
            }
        }

        private void dgvMain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string Tname = this.kryptonRibbon1.SelectedTab.Text;
            if (Tname == "Hoạt động")
            {
                btnHDEdit.PerformClick();
            }
            else
                return;
        }

        private void btnHM_New_Click(object sender, EventArgs e)
        {
            frmAddHangMuc frmNewHM = new frmAddHangMuc();
            frmNewHM.ShowDialog();
        }

        private void btnHM_Edit_Click(object sender, EventArgs e)
        {
            frmAddHangMuc frmEditHM = new frmAddHangMuc();
            if (dgvMain.CurrentRow == null)
                return;
            frmEditHM.ID = (int)dgvMain.CurrentRow.Cells["STT"].Value;
            frmEditHM.loadUpdateForm();
            frmEditHM.ShowDialog();
        }

        private void btnHM_Del_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có chắc muốn xóa hoạt động này không?", "Cảnh báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                try
                {
                    using (Context db = new Context())
                    {
                        string ID = dgvMain.CurrentRow.Cells["STT"].Value.ToString();
                        HOAT_DONG DelHD = db.HOAT_DONG.Find(ID);
                        if (DelHD == null) return;
                        else
                        {
                            DelHD.Hide = true;
                            db.Entry(DelHD).State = System.Data.Entity.EntityState.Modified;
                            db.SaveChanges();
                            MessageBox.Show("Xóa Hạng Mục thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                return;
        }

        private void btnTK_Khoa_Click(object sender, EventArgs e)
        {
            frmTK_Khoa TK_Khoa = new frmTK_Khoa();
            TK_Khoa.Show();
        }

        private void btnTK_GV_Click(object sender, EventArgs e)
        {
            frmTK_GiangVien TK = new frmTK_GiangVien();
            TK.Show();
        }

        private void btnTK_DT_Click(object sender, EventArgs e)
        {
            frmTK_DoiTac tK_DoiTac = new frmTK_DoiTac();
            tK_DoiTac.Show();
        }

        private void btnTK_TT_Click(object sender, EventArgs e)
        {
            frmTK_TaiTro TK = new frmTK_TaiTro();
            TK.Show();
        }

        private void btnTK_TC_Click(object sender, EventArgs e)
        {
            frmTK_TaiChinh TK = new frmTK_TaiChinh();
            TK.Show();
        }
    }
}
