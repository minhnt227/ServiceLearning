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
    public partial class frmTK_TaiTro : Form
    {
        Context db = new Context();

        public frmTK_TaiTro()
        {
            InitializeComponent();
        }

        private void frmTK_TaiTro_Load(object sender, EventArgs e)
        {
            try
            {
                List<string> lstTenTaiTro = new List<string>();
                List<int> IDTaiTro = new List<int>();
                lstTenTaiTro = db.TAI_TRO.Select(x => x.TenTaiTro).ToList();
                IDTaiTro = db.TAI_TRO.Select(x => x.ID_TaiTro).ToList();
                for (int j = 0; j < IDTaiTro.Count; j++)
                {
                    string TenDT = lstTenTaiTro[j];
                    int id = IDTaiTro[j];
                    dgvTK_TaiTro.Rows.Add();
                    dgvTK_TaiTro.Rows[j].Cells[0].Value = j + 1;
                    dgvTK_TaiTro.Rows[j].Cells[1].Value = TenDT;
                    List<string> nguoidaidien = (from s in db.TAI_TRO
                                                 where s.ID_TaiTro == id
                                                 select (s.DaiDien)).ToList();
                    dgvTK_TaiTro.Rows[j].Cells[2].Value = nguoidaidien[0];
                    List<string> SDT = (from s in db.TAI_TRO
                                        where s.ID_TaiTro == id
                                        select (s.SDT)).ToList();
                    dgvTK_TaiTro.Rows[j].Cells[3].Value = SDT[0];
                    List<string> email = (from s in db.TAI_TRO
                                          where s.ID_TaiTro == id
                                          select (s.Email)).ToList();
                    dgvTK_TaiTro.Rows[j].Cells[4].Value = email[0];
                    List<string> lstMaHD = new List<string>();
                    lstMaHD = (from s in db.TAI_TRO
                               join b in db.HD_TAITRO on s.ID_TaiTro equals b.ID_TaiTro
                               where b.ID_TaiTro == id
                               select (b.MaHD)).ToList();
                    if (lstMaHD.Count == 0) dgvTK_TaiTro.Rows[j].Cells[5].Value = "";
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
                        dgvTK_TaiTro.Rows[j].Cells[5].Value = TenHD;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }
}
