using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections;

namespace ServiceLearning
{
    public partial class frmAddHoatDong : Form
    {
        public bool isCreate = true;
        public frmAddHoatDong()
        {
            InitializeComponent();
        }
        public void LoadFormUpdate(string idHD)
        {
            LoadKhoaCB();
            using (Context db = new Context())
            {
                HOAT_DONG hD = db.HOAT_DONG.Find(idHD);
                lblHeader.Text = "Sửa Hoạt Động";
                txtMaHD.Text = hD.MaHD; txtMaHD.ReadOnly = true;
                txtTenHD.Text = hD.TenHoatDong;
                cbLoai.Text = hD.Loai == null? "" : hD.Loai;
                dtpNgayBD.Value = hD.NgayBatDau == null ? DateTime.Now : (DateTime)hD.NgayBatDau;
                dtpNgayKT.Value = hD.NgayKetThuc == null ? DateTime.Now : (DateTime)hD.NgayKetThuc;
                LoadHD_SinhVien(hD);
                LoadHD_GV(hD);
                btnAddHD.Text = "Sửa Hoạt Động";
                isCreate = false;
            }
            
        }
        private void LoadHD_SinhVien(HOAT_DONG hD)
        {
            List<HD_SINHVIEN> SVList = hD.HD_SINHVIEN.ToList();
            foreach (HD_SINHVIEN SV in SVList)
            {
                DataGridViewRow row = new DataGridViewRow();
                dgvSinhVien.Rows.Add(SV.MSSV, SV.SINH_VIEN.HoTen, SV.SINH_VIEN.KHOA1.TenKhoa, SV.VaiTro, SV.GhiChu, SV.SINH_VIEN.Khoa, SV.VaiTro);
            }
        }
        
        private void LoadHD_GV(HOAT_DONG hD)
        {    //MaGV,HoTenLot,Ten,GVKhoa,GV_DonVi,GVKHoa_DB
            List<HD_GIANGVIEN> List = hD.HD_GIANGVIEN.ToList();
            foreach (HD_GIANGVIEN GV in List)
            {
                DataGridViewRow row = new DataGridViewRow();
                dgv_GV.Rows.Add(GV.MaGV, GV.GIANG_VIEN.HoTenLot, GV.GIANG_VIEN.Ten, GV.GIANG_VIEN.KHOA1.TenKhoa, GV.GIANG_VIEN.DonVi, GV.GIANG_VIEN.Khoa);
            }
        }
        private void frmAddHoatDong_Load(object sender, EventArgs e)
        {
            if (!isCreate) return;
            LoadKhoaCB();
            btnShowSV.PerformClick();
        }
        //private void LoadLoaiCB()
        //{
        //    cbLoai.DataSource = new Dictionary<int, string>()
        //    {
        //        {0, "Sự kiện"},
        //        {1, "Dự Án"},
        //        {2, "Môn học"},
        //    }.ToList();
        //    cbLoai.DisplayMember = "Value";
        //    cbLoai.ValueMember = "Key";
        //    cbLoai.SelectedIndex = -1;
        //}private void LoadVaiTroCB()
        //{
        //    cbRole.DataSource = new Dictionary<int, string>()
        //    {
        //        {0, "Tham gia"},
        //        {1, "Tổ chức"},
        //    }.ToList();
        //    cbRole.DisplayMember = "Value";
        //    cbRole.ValueMember = "Key";
        //    cbRole.SelectedIndex = -1;
        //}

        private void LoadKhoaCB()
        {
            using (Context db = new Context())
            {
                var khoa = from k in db.KHOAs
                           where ( k.Hide == false)
                           select new
                           {
                               MaKH = k.MaKhoa,
                               Ten = k.TenKhoa,
                           };
                cbKhoa.DataSource = khoa.ToList();
                cbKhoa.DisplayMember = "Ten";
                cbKhoa.ValueMember = "MaKH";
                cbKhoa.SelectedIndex = -1;

                cbGV_Khoa.DataSource = khoa.ToList();
                cbGV_Khoa.DisplayMember = "Ten";
                cbGV_Khoa.ValueMember = "MaKH";
                cbGV_Khoa.SelectedIndex = -1;
            }    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (gbSinhVien.Visible)
            {
                gbSinhVien.Visible = false;
            }
            else
            {
                gbSinhVien.Visible = true;
            }
        }

        private void gbSinhVien_VisibleChanged(object sender, EventArgs e)
        {
            if (gbSinhVien.Visible){
                btnShowSV.Text = "Ẩn";
                gbSVList.Location = new Point(gbSinhVien.Location.X, gbSinhVien.Location.Y*2);
            }
            else { 
                btnShowSV.Text = "Hiện";
                gbSVList.Location = new Point(gbSinhVien.Location.X, gbSinhVien.Location.Y);
            }
        }

        private void btnAddSV_Click(object sender, EventArgs e)
        {
            if (ValidateSV())
            { //MSSV,HoTenSV,Khoa,Role,Notes_SV,DB_Khoa, DB_Role
                dgvSinhVien.Rows.Add(txtMSSV.Text, txtSVHoTen.Text, cbKhoa.Text, cbRole.Text, txtSVNotes.Text, cbKhoa.SelectedValue, cbRole.SelectedValue);
                clearSVFields();
            }
            else return;
        }

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvSinhVien.CurrentRow;
            if (row != null)
            {
                txtMSSV.Text = row.Cells["MSSV"].Value.ToString();
                txtMSSV.ReadOnly = true;
                txtSVHoTen.Text = row.Cells["HoTenSV"].Value.ToString();
                cbKhoa.SelectedValue = row.Cells["DB_Khoa"].Value != null? row.Cells["DB_Khoa"].Value : -1;
                cbRole.Text = row.Cells["Role"].Value.ToString() != null ? row.Cells["Role"].Value.ToString() : "";
                txtSVNotes.Text = row.Cells["Notes_SV"].Value.ToString();
            }
            else
                return;
            
        }

        private void kryptonBtnEdit_Click(object sender, EventArgs e)
        {
            if(txtMSSV.ReadOnly == false|| dgvSinhVien.CurrentRow == null) return;
            dgvSinhVien.CurrentRow.Cells["HoTenSV"].Value = txtSVHoTen.Text;
            dgvSinhVien.CurrentRow.Cells["Khoa"].Value = cbKhoa.Text;
            dgvSinhVien.CurrentRow.Cells["Role"].Value = cbRole.Text;
            dgvSinhVien.CurrentRow.Cells["Notes_SV"].Value = txtSVNotes.Text;
            dgvSinhVien.CurrentRow.Cells["DB_Khoa"].Value = cbKhoa.SelectedValue;
            dgvSinhVien.CurrentRow.Cells["DB_Role"].Value = cbRole.SelectedValue;
            clearSVFields();
        }
        public void clearSVFields()
        {
            txtMSSV.Clear();
            txtSVHoTen.Clear();
            cbKhoa.SelectedIndex = -1;
            cbRole.SelectedIndex = -1;
            txtSVNotes.Clear();
            txtMSSV.ReadOnly = false;
        }
        public bool ValidateSV()
        {
            if(txtMSSV.Text.Length == 0) 
            {
                MessageBox.Show("MSSV Đang Trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else 
            if (FindDuplicateMSSV())
            {
                MessageBox.Show("MSSV Đang Bị Trùng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false; 
            }else
            return true;
        }
        public bool FindDuplicateMSSV()
        {
            foreach (DataGridViewRow row in dgvSinhVien.Rows)
            {
                if (row == null) return false;
                else
                {
                    if (row.Cells["MSSV"].Value.ToString() == txtMSSV.Text)
                    {
                        return true;
                    }
                    else continue;
                }
            }
            return false;
        }

        private void btnSVClear_Click(object sender, EventArgs e)
        {
            clearSVFields();
        }

        private void btnSVDel_Click(object sender, EventArgs e)
        {
            clearSVFields();
            if (dgvSinhVien.Rows.Count == 0 || dgvSinhVien.CurrentRow.Index < 0) return;  
            dgvSinhVien.Rows.RemoveAt(dgvSinhVien.CurrentRow.Index);
        }

        private void btnAddHD_Click(object sender, EventArgs e)
        {
            //if (this.isCreate)
                SaveHDToDB();
           // else return;
        }
        private void SaveHDToDB()
        {
            try
            {
                using (Context db = new Context())
                {
                    HOAT_DONG hoatDong = isCreate? new HOAT_DONG() : db.HOAT_DONG.Find(txtMaHD.Text);
                    hoatDong.MaHD = txtMaHD.Text;
                    hoatDong.TenHoatDong = txtTenHD.Text;
                    hoatDong.Loai = cbLoai.Text;
                    hoatDong.NgayBatDau = dtpNgayBD.Value;
                    hoatDong.NgayKetThuc = dtpNgayKT.Value;
                    hoatDong.CreatedDate = DateTime.Now;
                    hoatDong.Hide = false;
                    AddOrUpdateHD_SinhVien(hoatDong,db);
                    AddOrUpdateHD_GV(hoatDong,db);

            
                    if (db.HOAT_DONG.Find(hoatDong.MaHD) != null)
                    {
                        db.Entry(hoatDong).State = EntityState.Modified;
                        db.SaveChanges();
                        MessageBox.Show("Sửa đổi thành công", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        db.HOAT_DONG.Add(hoatDong);
                        db.SaveChanges();
                        MessageBox.Show("Tạo mới thành công","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    Close();
                }    
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void AddOrUpdateHD_SinhVien(HOAT_DONG hd, Context db)
        {
                foreach (DataGridViewRow dr in dgvSinhVien.Rows)
                {
                    HD_SINHVIEN SVList = db.HD_SINHVIEN.Find(txtMaHD.Text, dr.Cells["MSSV"].Value.ToString());
                    if (SVList == null)
                    {
                        SVList = new HD_SINHVIEN();
                        SVList.MaHD = txtMaHD.Text;
                        SVList.MSSV = dr.Cells["MSSV"].Value.ToString().Trim();
                        SVList.VaiTro = dr.Cells["Role"].Value.ToString().Trim();
                        SVList.GhiChu = dr.Cells["Notes_SV"].Value.ToString().Trim();
                        AddOrUpdateSV(SVList, db, dr);
                        hd.HD_SINHVIEN.Add(SVList);
                    }
                    else
                    {
                        SVList.VaiTro = dr.Cells["Role"].Value.ToString().Trim();
                        SVList.GhiChu = dr.Cells["Notes_SV"].Value.ToString().Trim();
                        AddOrUpdateSV(SVList, db, dr);
                        db.Entry(SVList).State = EntityState.Modified;
                        db.SaveChanges();
                    }
                }  
        }
        private void AddOrUpdateSV(HD_SINHVIEN lst, Context db, DataGridViewRow dr)
        {
            if (db.SINH_VIEN.Find(dr.Cells["MSSV"].Value.ToString()) != null)
            {
                SINH_VIEN sv = db.SINH_VIEN.Find(lst.MSSV);
                sv.HoTen = dr.Cells["HoTenSV"].Value.ToString().Trim();
                sv.Khoa = dr.Cells["DB_Khoa"].Value.ToString().Trim();
                sv.Hide = false;
                db.Entry(sv).State = EntityState.Modified;
                db.SaveChanges();
            }
            else
            {
                lst.SINH_VIEN = new SINH_VIEN();
                lst.SINH_VIEN.MSSV = dr.Cells["MSSV"].Value.ToString().Trim();
                lst.SINH_VIEN.HoTen = dr.Cells["HoTenSV"].Value.ToString().Trim();
                lst.SINH_VIEN.Khoa = dr.Cells["DB_Khoa"].Value.ToString().Trim();
                lst.SINH_VIEN.Hide = false;

            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSVFind_Click(object sender, EventArgs e)
        {
            using (Context db = new Context())
            {
                SINH_VIEN sv = db.SINH_VIEN.Find(txtMSSV.Text);
                if (sv != null)
                {
                    txtSVHoTen.Text = sv.HoTen.ToString();
                    cbKhoa.SelectedValue = sv.Khoa;
                }
                else 
                    return;
            }
        }

        private void dtpNgayKT_ValueChanged(object sender, EventArgs e)
        {
            if(dtpNgayBD.Value>dtpNgayKT.Value)
            {
                MessageBox.Show("Lỗi chọn ngày!","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                dtpNgayKT.Value = dtpNgayBD.Value = DateTime.Now ;
            }
        }

        private void btnAddGV_Click(object sender, EventArgs e)
        {
            //MaGV,HoTenLot,Ten,GVKhoa,GV_DonVi,GVKHoa_DB
            if (ValidateGV())
            { 
                dgv_GV.Rows.Add(txtMaGV.Text, txtGVHoTenLot.Text, txtTenGV.Text, cbGV_Khoa.Text,txtDonvi.Text , cbGV_Khoa.SelectedValue);
                ClearGVFields();
            }
            else return;
        }
        private bool ValidateGV()
        {
            if (txtMaGV.Text.Length == 0)
            {
                MessageBox.Show("Mã Giảng Viên Đang Trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            if (FindDupMaGV())
            {
                MessageBox.Show("Mã Giảng Viên Đang Bị Trùng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
                return true;
        }
        private bool FindDupMaGV()
        {
            foreach (DataGridViewRow row in dgv_GV.Rows)
            {
                if (row == null) return false;
                else
                {
                    if (row.Cells["MaGV"].Value.ToString() == txtMaGV.Text)
                    {
                        return true;
                    }
                    else continue;
                }
            }
            return false;
        }
        private void ClearGVFields()
        {
            txtMaGV.Clear();
            txtGVHoTenLot.Clear();
            cbGV_Khoa.SelectedIndex = -1;
            txtTenGV.Clear();
            txtDonvi.Clear();
            txtMaGV.ReadOnly = false;
        }

        private void btnGVShow_Click(object sender, EventArgs e)
        {
            if (gbHD_GV.Visible)
            {
                gbHD_GV.Visible = false;
                btnGVShow.Text = "Hiện";
            }
            else
            {
                gbHD_GV.Visible = true;
                btnGVShow.Text = "Ẩn";
            }
        }

        private void dgv_GV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgv_GV.CurrentRow;
            if (row != null) //MaGV,HoTenLot,Ten,GVKhoa,GV_DonVi,GVKHoa_DB
            {
                txtMaGV.Text = row.Cells["MaGV"].Value.ToString();
                txtMaGV.ReadOnly = true;
                txtGVHoTenLot.Text = row.Cells["HoTenLot"].Value.ToString();
                txtTenGV.Text = row.Cells["Ten"].Value.ToString();
                cbGV_Khoa.SelectedValue = row.Cells["GVKHoa_DB"].Value != null ? row.Cells["GVKHoa_DB"].Value : -1;
                txtDonvi.Text = row.Cells["GV_DonVi"].Value.ToString();
            }
            else
                return;
        }

        private void btnClearGV_Click(object sender, EventArgs e)
        {
            ClearGVFields();
        }

        private void btnEditGV_Click(object sender, EventArgs e)
        {
            if (txtMaGV.ReadOnly == false || dgv_GV.CurrentRow == null) return;
            dgv_GV.CurrentRow.Cells["HoTenLot"].Value = txtGVHoTenLot.Text;
            dgv_GV.CurrentRow.Cells["Ten"].Value = txtTenGV.Text;
            dgv_GV.CurrentRow.Cells["GVKhoa"].Value = cbGV_Khoa.Text;
            dgv_GV.CurrentRow.Cells["GV_DonVi"].Value = txtDonvi.Text;
            dgv_GV.CurrentRow.Cells["GVKHoa_DB"].Value = cbGV_Khoa.SelectedValue;
            ClearGVFields();
        }

        private void btnDelGV_Click(object sender, EventArgs e)
        {
            ClearGVFields();
            if (dgv_GV.Rows.Count == 0 || dgv_GV.CurrentRow.Index < 0) return;
            dgv_GV.Rows.RemoveAt(dgv_GV.CurrentRow.Index);
        }

        private void AddOrUpdateHD_GV(HOAT_DONG hd, Context db)
        {
            foreach (DataGridViewRow dr in dgv_GV.Rows)
            {
                HD_GIANGVIEN HD_GV = db.HD_GIANGVIEN.Find(txtMaHD.Text, dr.Cells["MaGV"].Value.ToString());
                if (HD_GV == null)
                {
                    HD_GV = new HD_GIANGVIEN();
                    HD_GV.MaHD = txtMaHD.Text;
                    HD_GV.MaGV = dr.Cells["MaGV"].Value.ToString().Trim();
                    AddOrUpdateGV(HD_GV, db, dr);
                    hd.HD_GIANGVIEN.Add(HD_GV);
                }
                else
                {
                    AddOrUpdateGV(HD_GV, db, dr);
                    db.Entry(HD_GV).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
        }

        private void AddOrUpdateGV(HD_GIANGVIEN HD_GV, Context db, DataGridViewRow dr)
        {
            if (db.GIANG_VIEN.Find(HD_GV.MaGV) != null)
            {
                GIANG_VIEN gv = db.GIANG_VIEN.Find(HD_GV.MaGV);
                gv.HoTenLot = dr.Cells["HoTenLot"].Value.ToString().Trim();
                gv.Ten = dr.Cells["Ten"].Value.ToString().Trim();
                gv.Khoa = dr.Cells["GVKHoa_DB"].Value.ToString().Trim();
                gv.DonVi = dr.Cells["GV_DonVi"].Value.ToString().Trim();
                gv.Hide = false;
                db.Entry(gv).State = EntityState.Modified;
                db.SaveChanges();
            }
            else
            {
                HD_GV.GIANG_VIEN = new GIANG_VIEN();
                HD_GV.GIANG_VIEN.MaGV = HD_GV.MaGV;
                HD_GV.GIANG_VIEN.HoTenLot = dr.Cells["HoTenLot"].Value.ToString().Trim();
                HD_GV.GIANG_VIEN.Ten = dr.Cells["Ten"].Value.ToString().Trim();
                HD_GV.GIANG_VIEN.Khoa = dr.Cells["GVKHoa_DB"].Value.ToString().Trim();
                HD_GV.GIANG_VIEN.DonVi = dr.Cells["GV_DonVi"].Value.ToString().Trim();
                HD_GV.GIANG_VIEN.Hide = false;
            }
        }

    }
}
