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
    public partial class frmTK_Khoa : Form
    {
        Context db = new Context();
        public frmTK_Khoa()
        {
            InitializeComponent();
        }

        private void frmTK_Khoa_Load(object sender, EventArgs e)
        {
            try
            {
                List<string> lstTenKhoa = new List<string>();
                lstTenKhoa = db.KHOAs.Select(x => x.TenKhoa).ToList();

                for (int i = 0; i < lstTenKhoa.Count; i++)
                {
                    dgvTK_1.Columns.Add(lstTenKhoa[i], lstTenKhoa[i]);
                }
                dgvTK_1.Columns.Add("Total", "Tổng");
                List<string> lstMaHD = new List<string>();
                List<string> lstTenHD = new List<string>();
                lstMaHD = db.HOAT_DONG.Select(x => x.MaHD).ToList();
                lstTenHD = db.HOAT_DONG.Select(x => x.TenHoatDong).ToList();
                for (int j = 0; j < lstMaHD.Count; j++)
                {

                    string MaHD = lstMaHD[j];
                    string TenHD = lstTenHD[j];
                    dgvTK_1.Rows.Add();
                    dgvTK_1.Rows[j].Cells[0].Value = j + 1;
                    dgvTK_1.Rows[j].Cells[1].Value = TenHD;
                    List<string> lstKhoa = new List<string>();
                    lstKhoa = db.KHOAs.Select(x => x.MaKhoa).ToList();
                    int total = 0;
                    for (int i = 0; i < lstKhoa.Count; i++)
                    {
                        List<string> list = new List<string>();
                        string maKhoa = lstKhoa[i];
                        list = (from s in db.SINH_VIEN
                                join b in db.HD_SINHVIEN on s.MSSV equals b.MSSV
                                join c in db.HOAT_DONG on b.MaHD equals c.MaHD
                                where (s.Khoa == maKhoa && b.MaHD == MaHD)
                                select (s.MSSV)).ToList();
                        int tong = (from gv in db.SINH_VIEN
                                    where list.Contains(gv.MSSV)
                                    select gv.MSSV).ToList().Count;
                        dgvTK_1.Rows[j].Cells[i + 2].Value = tong;
                        total = total + tong;
                    }
                    dgvTK_1.Rows[j].Cells[lstKhoa.Count + 2].Value = total;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx|Excel 2003 (*.xls)|*.xls" })
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        ToExcel(dgvTK_1, sfd.FileName);
                    }
            }   
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ToExcel(DataGridView dtg, string fileName)
        {
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;
            try
            {
                //Tạo đối tượng COM.
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;
                //tạo mới một Workbooks bằng phương thức add()
                workbook = excel.Workbooks.Add(Type.Missing);
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
                //đặt tên cho sheet
                worksheet.Name = "Quản lý sinh viên tham gia";

                // export header trong DataGridView
                for (int i = 0; i < dtg.ColumnCount; i++)
                {
                    worksheet.Cells[1, i + 1] = dtg.Columns[i].HeaderText;
                }
                // export nội dung trong DataGridView
                for (int i = 0; i < dtg.RowCount; i++)
                {
                    for (int j = 0; j < dtg.ColumnCount; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dtg.Rows[i].Cells[j].Value;
                    }
                }
                excel.Columns.AutoFit();
                // sử dụng phương thức SaveAs() để lưu workbook với filename
                workbook.SaveAs(fileName);
                //đóng workbook
                workbook.Close();
                excel.Quit();
                MessageBox.Show("Xuất dữ liệu ra Excel thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                workbook = null;
                worksheet = null;
            }
        }
    }
}
