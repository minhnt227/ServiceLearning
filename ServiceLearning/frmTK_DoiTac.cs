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
    public partial class frmTK_DoiTac : Form
    {
        public frmTK_DoiTac()
        {
            InitializeComponent();
        }

        Context db = new Context();
        private void frmTK_DoiTac_Load(object sender, EventArgs e)
        {
            try
            {
                dgvTK_DoiTac.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
                List<string> lstTenDoiTac = new List<string>();
                List<int> IDDoiTac = new List<int>();
                lstTenDoiTac = db.DOI_TAC.Select(x => x.TenDoiTac).ToList();
                IDDoiTac = db.DOI_TAC.Select(x => x.ID_DoiTac).ToList();
                for (int j = 0; j < IDDoiTac.Count; j++)
                {
                    string TenDT = lstTenDoiTac[j];
                    int id = IDDoiTac[j];
                    dgvTK_DoiTac.Rows.Add();
                    dgvTK_DoiTac.Rows[j].Cells[0].Value = j + 1;
                    dgvTK_DoiTac.Rows[j].Cells[1].Value = TenDT;
                    List<string> nguoidaidien = (from s in db.DOI_TAC
                                                 where s.ID_DoiTac == id
                                                 select (s.DaiDien)).ToList();
                    dgvTK_DoiTac.Rows[j].Cells[2].Value = nguoidaidien[0];
                    List<string> SDT = (from s in db.DOI_TAC
                                        where s.ID_DoiTac == id
                                        select (s.SDT)).ToList();
                    dgvTK_DoiTac.Rows[j].Cells[3].Value = SDT[0];
                    List<string> email = (from s in db.DOI_TAC
                                          where s.ID_DoiTac == id
                                          select (s.Email)).ToList();
                    dgvTK_DoiTac.Rows[j].Cells[4].Value = email[0];
                    List<string> lstMaHD = new List<string>();
                    lstMaHD = (from s in db.DOI_TAC
                               join b in db.HD_DOITAC on s.ID_DoiTac equals b.ID_DoiTac
                               where b.ID_DoiTac == id
                               select (b.MaHD)).ToList();
                    if (lstMaHD.Count == 0) dgvTK_DoiTac.Rows[j].Cells[5].Value = "";
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
                        dgvTK_DoiTac.Rows[j].Cells[5].Value = TenHD;
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
