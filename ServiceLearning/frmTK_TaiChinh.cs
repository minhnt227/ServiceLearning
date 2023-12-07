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
    public partial class frmTK_TaiChinh : Form
    {
        Context db = new Context();

        public frmTK_TaiChinh()
        {
            InitializeComponent();
        }

        private void frmTK_TaiChinh_Load(object sender, EventArgs e)
        {
            try
            {
                List<int> lstID = new List<int>();
                lstID = db.TAI_CHINH.Select(x => x.ID_TaiChinh).ToList();
                for (int j = 0; j < lstID.Count; j++)
                {
                    dgvTK_TC.Rows.Add();
                    dgvTK_TC.Rows[j].Cells[0].Value = j + 1;
                    int ID = lstID[j];
                    List<string> MaHD = (from s in db.TAI_CHINH
                                         where s.ID_TaiChinh == ID
                                         select (s.MaHD)).ToList();
                    string MHD = MaHD[0];
                    List<string> loai = (from s in db.HOAT_DONG
                                         where s.MaHD == MHD
                                         select (s.Loai)).ToList();
                    dgvTK_TC.Rows[j].Cells[1].Value = loai[0];

                    List<string> TenHD = (from s in db.HOAT_DONG
                                          where s.MaHD == MHD
                                          select (s.TenHoatDong)).ToList();
                    dgvTK_TC.Rows[j].Cells[2].Value = TenHD[0];


                    List<DateTime?> thoigian = (from s in db.HOAT_DONG
                                                where s.MaHD == MHD
                                                select (s.NgayBatDau)).ToList();
                    dgvTK_TC.Rows[j].Cells[3].Value = thoigian[0];

                    List<decimal?> UEF = (from s in db.TAI_CHINH
                                          where s.ID_TaiChinh == ID
                                          select (s.UEF)).ToList();
                    dgvTK_TC.Rows[j].Cells[5].Value = UEF[0];

                    List<decimal?> taitro = (from s in db.TAI_CHINH
                                             where s.ID_TaiChinh == ID
                                             select (s.TaiTro)).ToList();
                    dgvTK_TC.Rows[j].Cells[6].Value = taitro[0];
                    int tong = (int)UEF[0] + (int)taitro[0];
                    dgvTK_TC.Rows[j].Cells[4].Value = tong;
                    List<string> khac = (from s in db.TAI_CHINH
                                         where s.ID_TaiChinh == ID
                                         select (s.Khac)).ToList();
                    dgvTK_TC.Rows[j].Cells[7].Value = khac[0];


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
