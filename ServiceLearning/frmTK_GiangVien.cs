using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceLearning
{
    public partial class frmTK_GiangVien : Form
    {
        Context db = new Context();
        public frmTK_GiangVien()
        {
            InitializeComponent();
        }

        private void frmTK_GiangVien_Load(object sender, EventArgs e)
        {
            try
            {
                List<string> lstMaGV = new List<string>();
                List<string> lstTenGV = new List<string>();
                List<string> lstHoTenLotGV = new List<string>();
                lstMaGV = db.GIANG_VIEN.Select(x => x.MaGV).ToList();
                lstTenGV = db.GIANG_VIEN.Select(x => x.Ten).ToList();
                lstHoTenLotGV = db.GIANG_VIEN.Select(x => x.HoTenLot).ToList();
                for (int j = 0; j < lstMaGV.Count; j++)
                {
                    string MaGV = lstMaGV[j];
                    string tenGV = lstTenGV[j];
                    string HoTenLotGV = lstHoTenLotGV[j];
                    dgvTK_GV.Rows.Add();
                    dgvTK_GV.Rows[j].Cells[0].Value = j + 1;
                    dgvTK_GV.Rows[j].Cells[1].Value = MaGV;
                    dgvTK_GV.Rows[j].Cells[2].Value = HoTenLotGV;
                    dgvTK_GV.Rows[j].Cells[3].Value = tenGV;
                    List<string> donvi = (from s in db.GIANG_VIEN
                                          where s.MaGV == MaGV
                                          select (s.KHOA1.TenKhoa)).ToList();
                    dgvTK_GV.Rows[j].Cells[4].Value = donvi[0];
                    List<string> lstMaHD = new List<string>();
                    lstMaHD = (from s in db.GIANG_VIEN
                               join b in db.HD_GIANGVIEN on s.MaGV equals b.MaGV
                               where s.MaGV == MaGV
                               select (b.MaHD)).ToList();
                    if (lstMaHD.Count == 0) dgvTK_GV.Rows[j].Cells[5].Value = "";
                    else
                    {
                        string TenHD = "- ";
                        string MaHD = lstMaHD[0];
                        List<string> NameHD = (from s in db.HOAT_DONG
                                               where s.MaHD == MaHD
                                               select (s.TenHoatDong)).ToList();
                        TenHD = TenHD + NameHD[0];
                        for (int i = 1; i < lstMaHD.Count; i++)
                        {
                            MaHD = lstMaHD[i];
                            List<string> TenHoat = (from s in db.HOAT_DONG
                                                    where s.MaHD == MaHD
                                                    select (s.TenHoatDong)).ToList();
                            TenHD = TenHD + "\n- " + TenHoat[0];
                        }
                        dgvTK_GV.Rows[j].Cells[5].Value = TenHD;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }
}
