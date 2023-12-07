namespace ServiceLearning
{
    partial class frmTK_GiangVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvTK_GV = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThamGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTK_GV)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTK_GV
            // 
            this.dgvTK_GV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTK_GV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTK_GV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTK_GV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MGV,
            this.HoTen,
            this.Ten,
            this.DonVi,
            this.ThamGia});
            this.dgvTK_GV.Location = new System.Drawing.Point(12, 106);
            this.dgvTK_GV.Name = "dgvTK_GV";
            this.dgvTK_GV.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.dgvTK_GV.RowHeadersVisible = false;
            this.dgvTK_GV.RowHeadersWidth = 72;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTK_GV.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTK_GV.RowTemplate.Height = 31;
            this.dgvTK_GV.Size = new System.Drawing.Size(1366, 446);
            this.dgvTK_GV.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(493, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(498, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thống kê theo Giảng viên";
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 9;
            this.STT.Name = "STT";
            this.STT.Width = 175;
            // 
            // MGV
            // 
            this.MGV.HeaderText = "Mã Giảng Viên";
            this.MGV.MinimumWidth = 9;
            this.MGV.Name = "MGV";
            this.MGV.Width = 175;
            // 
            // HoTen
            // 
            this.HoTen.HeaderText = "Họ và Tên lót";
            this.HoTen.MinimumWidth = 9;
            this.HoTen.Name = "HoTen";
            this.HoTen.Width = 175;
            // 
            // Ten
            // 
            this.Ten.HeaderText = "Tên";
            this.Ten.MinimumWidth = 9;
            this.Ten.Name = "Ten";
            this.Ten.Width = 175;
            // 
            // DonVi
            // 
            this.DonVi.HeaderText = "Đơn Vị";
            this.DonVi.MinimumWidth = 9;
            this.DonVi.Name = "DonVi";
            this.DonVi.Width = 175;
            // 
            // ThamGia
            // 
            this.ThamGia.HeaderText = "HĐ đã tham gia";
            this.ThamGia.MinimumWidth = 9;
            this.ThamGia.Name = "ThamGia";
            this.ThamGia.Width = 175;
            // 
            // frmTK_GiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1390, 645);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTK_GV);
            this.Name = "frmTK_GiangVien";
            this.Text = "Thống Kê Báo Cáo theo Giảng Viên";
            this.Load += new System.EventHandler(this.frmTK_GiangVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTK_GV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvTK_GV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThamGia;
    }
}