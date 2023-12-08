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
    public partial class frmKhoaDetails : Form
    {
        public bool isCreate = true;
        public frmKhoaDetails()
        {
            InitializeComponent();
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            if(isCreate)
            {
                AddNewKh();
            }
            else
            {
                EditKh();
            }
        }
        private void AddNewKh()
        {
            try
            {
                using (Context db = new Context())
                {
                    KHOA KH = new KHOA();
                    KH.MaKhoa = txtMaKh.Text.Trim();
                    KH.Hide = false;
                    KH.TenKhoa = txtTenK.Text.Trim();
                    KH.SDT = txtSdtK.Text.Trim();
                    KH.Email = txtEmailK.Text.Trim();
                    KH.NgayThanhLap = dtpKhBegin.Value;
                    db.KHOAs.Add(KH);
                    db.SaveChanges();
                    MessageBox.Show("Thêm thành công");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi, xin hãy báo lại với admin \n\n***************************************** \n\n" + ex.Message.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditKh()
        {
            try
            {
                using (Context db = new Context())
                {
                    KHOA KH = db.KHOAs.Find(txtMaKh.Text);
                    if (KH == null)
                        return;
                    KH.Hide = false;
                    KH.TenKhoa = txtTenK.Text.Trim();
                    KH.SDT = txtSdtK.Text.Trim();
                    KH.Email = txtEmailK.Text.Trim();
                    KH.NgayThanhLap = dtpKhBegin.Value;
                    db.Entry(KH).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    MessageBox.Show("Sửa thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi, xin hãy báo lại với admin \n\n*****************************************\n\n " + ex.Message.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadFrmEditKhoa(string MaKhoa)
        {
            try
            {
                using (Context db = new Context())
                {
                    KHOA KH = db.KHOAs.Find(MaKhoa);
                    if (KH == null)
                        Close();
                    txtMaKh.Text = MaKhoa; txtMaKh.ReadOnly = true;
                    txtTenK.Text = KH.TenKhoa;
                    txtSdtK.Text = KH.SDT;
                    txtEmailK.Text = KH.Email;
                    dtpKhBegin.Value = (KH.NgayThanhLap == null)? DateTime.Today: (DateTime)KH.NgayThanhLap;
                    btnManage.Text = "Sửa";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi, xin hãy báo lại với admin \n\n*****************************************\n\n " + ex.Message.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
