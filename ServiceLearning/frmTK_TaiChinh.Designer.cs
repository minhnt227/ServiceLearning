namespace ServiceLearning
{
    partial class frmTK_TaiChinh
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvTK_TC = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateBegin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TK_TC_uef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaiTro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Khac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTK_TC)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTK_TC
            // 
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTK_TC.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTK_TC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTK_TC.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTK_TC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTK_TC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.LHD,
            this.Ten,
            this.DateBegin,
            this.Tong,
            this.TK_TC_uef,
            this.TaiTro,
            this.Khac});
            this.dgvTK_TC.Location = new System.Drawing.Point(12, 99);
            this.dgvTK_TC.Name = "dgvTK_TC";
            this.dgvTK_TC.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.dgvTK_TC.RowHeadersVisible = false;
            this.dgvTK_TC.RowHeadersWidth = 72;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTK_TC.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTK_TC.RowTemplate.Height = 31;
            this.dgvTK_TC.Size = new System.Drawing.Size(1523, 535);
            this.dgvTK_TC.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(557, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 51);
            this.label1.TabIndex = 4;
            this.label1.Text = "Thống kê theo Đối Tác";
            // 
            // stt
            // 
            this.stt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.stt.HeaderText = "STT";
            this.stt.MinimumWidth = 9;
            this.stt.Name = "stt";
            this.stt.Width = 91;
            // 
            // LHD
            // 
            this.LHD.HeaderText = "Loại Hoạt Động";
            this.LHD.MinimumWidth = 9;
            this.LHD.Name = "LHD";
            this.LHD.Width = 125;
            // 
            // Ten
            // 
            this.Ten.HeaderText = "Tên Hoạt Động";
            this.Ten.MinimumWidth = 9;
            this.Ten.Name = "Ten";
            this.Ten.Width = 275;
            // 
            // DateBegin
            // 
            this.DateBegin.HeaderText = "Ngày bắt đầu";
            this.DateBegin.MinimumWidth = 9;
            this.DateBegin.Name = "DateBegin";
            this.DateBegin.Width = 125;
            // 
            // Tong
            // 
            this.Tong.HeaderText = "Tổng Chi Phí";
            this.Tong.MinimumWidth = 9;
            this.Tong.Name = "Tong";
            this.Tong.Width = 175;
            // 
            // TK_TC_uef
            // 
            this.TK_TC_uef.HeaderText = "UEF";
            this.TK_TC_uef.MinimumWidth = 9;
            this.TK_TC_uef.Name = "TK_TC_uef";
            this.TK_TC_uef.Width = 275;
            // 
            // TaiTro
            // 
            this.TaiTro.HeaderText = "Tài Trợ";
            this.TaiTro.MinimumWidth = 9;
            this.TaiTro.Name = "TaiTro";
            this.TaiTro.Width = 175;
            // 
            // Khac
            // 
            this.Khac.HeaderText = "Khác";
            this.Khac.MinimumWidth = 9;
            this.Khac.Name = "Khac";
            this.Khac.Width = 175;
            // 
            // frmTK_TaiChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1547, 777);
            this.Controls.Add(this.dgvTK_TC);
            this.Controls.Add(this.label1);
            this.Name = "frmTK_TaiChinh";
            this.Text = "Thống kê Tài Chính";
            this.Load += new System.EventHandler(this.frmTK_TaiChinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTK_TC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvTK_TC;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn LHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateBegin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TK_TC_uef;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaiTro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Khac;
        private System.Windows.Forms.Label label1;
    }
}