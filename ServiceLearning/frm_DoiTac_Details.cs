using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceLearning
{
    public partial class frm_DoiTac_Details : Form
    {
        Int32 id;
        Context db = new Context();
        DOI_TAC DOI_TAC = new DOI_TAC();
        public frm_DoiTac_Details()
        {
            InitializeComponent();
            Load();
            AddBinding();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DOI_TAC dt = new DOI_TAC();//txtName.Text.Trim(),txtRep.Text.Trim(),txtPhone.Text.Trim(),txtMail.Text.Trim());
            db.DOI_TAC.Add(dt);
            db.SaveChanges();
            Load();
        }
        private void AddBinding()
        {
            txtName.DataBindings.Add(   new Binding("Text", dataGridView1.DataSource, "a"));
            txtRep.DataBindings.Add(    new Binding("Text", dataGridView1.DataSource, "b"));
            txtPhone.DataBindings.Add(  new Binding("Text", dataGridView1.DataSource, "d"));
            txtMail.DataBindings.Add(   new Binding("Text", dataGridView1.DataSource, "c"));
            
        }
        private void Load()
        {
            var result = from dt 
                         in db.DOI_TAC 
                         //join
                         //where
                         select new { a = dt.TenDoiTac, b= dt.DaiDien, c=dt.Email,d=dt.SDT,e=dt.ID_DoiTac };
            dataGridView1.DataSource = result.ToList();
            dataGridView1.Columns["a"].HeaderText = "Tên Đối Tác";
            dataGridView1.Columns["b"].HeaderText = "Người Đại Diện";
            dataGridView1.Columns["c"].HeaderText = "Email";
            dataGridView1.Columns["d"].HeaderText = "Số điện thoại";
            dataGridView1.Columns["e"].Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["e"].Value);
            DOI_TAC= db.DOI_TAC.Find(id);
            DOI_TAC.TenDoiTac = txtName.Text.Trim();
            DOI_TAC.DaiDien = txtRep.Text.Trim();
            DOI_TAC.SDT = txtPhone.Text.Trim();
            DOI_TAC.Email = txtMail.Text.Trim();
            db.Entry(DOI_TAC).State = EntityState.Modified;
            db.SaveChanges();
            Load();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["e"].Value);
            DOI_TAC = db.DOI_TAC.Find(id);
            db.DOI_TAC.Remove(DOI_TAC); 
            db.SaveChanges();   
            Load();
        }
    }
}
