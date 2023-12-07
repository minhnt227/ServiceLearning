namespace ServiceLearning
{
    partial class frmTK_Khoa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTK_1 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.btnExport = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTK_1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(359, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(831, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thống kê số lượng Sinh viên theo mỗi Khoa";
            // 
            // dgvTK_1
            // 
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTK_1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTK_1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTK_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTK_1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.HD});
            this.dgvTK_1.Location = new System.Drawing.Point(13, 107);
            this.dgvTK_1.Name = "dgvTK_1";
            this.dgvTK_1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.dgvTK_1.RowHeadersVisible = false;
            this.dgvTK_1.RowHeadersWidth = 72;
            this.dgvTK_1.RowTemplate.Height = 31;
            this.dgvTK_1.Size = new System.Drawing.Size(1485, 428);
            this.dgvTK_1.TabIndex = 1;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(1073, 579);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(218, 49);
            this.btnExport.TabIndex = 2;
            this.btnExport.Values.Text = "Xuất Excel";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 9;
            this.STT.Name = "STT";
            this.STT.Width = 91;
            // 
            // HD
            // 
            this.HD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.HD.HeaderText = "Hoạt Động";
            this.HD.MinimumWidth = 9;
            this.HD.Name = "HD";
            this.HD.Width = 160;
            // 
            // frmTK_Khoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1510, 666);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.dgvTK_1);
            this.Controls.Add(this.label1);
            this.Name = "frmTK_Khoa";
            this.Text = "Thống Kê";
            this.Load += new System.EventHandler(this.frmTK_Khoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTK_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvTK_1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnExport;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn HD;
    }
}