using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceLearning
{
    public partial class frmTTDetails : Form
    {
        public int IDtt = -1;
        public bool isCreate = true;
        public frmTTDetails()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            if (isCreate)
            {
                AddNewTT();
            }
            else
            {
                EditTT();
            }
        }
        private bool isEmpty(string a)
        {
            return a.Length == 0;
        }
        private bool isValidated()
        {
            if (isEmpty(txtTT_name.Text.Trim()))
                return false;
            return true;
        }
        private void AddNewTT()
        {
            if (!isValidated()) { 
                return; 
            }
            try
            {
                using (Context db = new Context())
                {
                    TAI_TRO TT= new TAI_TRO();
                    TT.TenTaiTro = txtTT_name.Text.Trim();
                    TT.DaiDien = txtTT_rep.Text.Trim();
                    TT.SDT = txtTT_sdt.Text.Trim();
                    TT.Email = txtTT_email.Text.Trim();
                    TT.Hide = false;
                    db.TAI_TRO.Add(TT);
                    db.SaveChanges();
                    MessageBox.Show("Thêm thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi, xin hãy báo lại với admin \n\n***************************************** \n\n" + ex.Message.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditTT()
        {
            if (!isValidated())
            {
                return;
            }
            try
            {
                using (Context db = new Context())
                {
                    TAI_TRO TT = db.TAI_TRO.Find(IDtt);
                    if (TT == null)
                        return;
                    TT.TenTaiTro = txtTT_name.Text.Trim();
                    TT.DaiDien = txtTT_rep.Text.Trim();
                    TT.SDT = txtTT_sdt.Text.Trim();
                    TT.Email = txtTT_email.Text.Trim();
                    TT.Hide = false;
                    db.Entry(TT).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    MessageBox.Show("Sửa thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi, xin hãy báo lại với admin \n\n***************************************** \n\n" + ex.Message.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadFrmEditTT()
        {
            try
            {
                using (Context db = new Context())
                {
                    TAI_TRO TT = db.TAI_TRO.Find(IDtt);
                    if (TT == null)
                        Close();
                    txtTT_name.Text = TT.TenTaiTro.Trim();
                    txtTT_rep.Text = TT.DaiDien.Trim();
                    txtTT_sdt.Text = TT.SDT.Trim();
                    txtTT_email.Text = TT.Email.Trim();
                    btnTTManage.Text = "Sửa";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi, xin hãy báo lại với admin \n\n*****************************************\n\n " + ex.Message.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
