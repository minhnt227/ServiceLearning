namespace ServiceLearning
{
    partial class frmTK_TaiTro
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
            this.dgvTK_TaiTro = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoiTac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nguoidd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTK_TaiTro)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTK_TaiTro
            // 
            this.dgvTK_TaiTro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTK_TaiTro.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTK_TaiTro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTK_TaiTro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.DoiTac,
            this.Nguoidd,
            this.SDT,
            this.Email,
            this.NoiDung});
            this.dgvTK_TaiTro.Location = new System.Drawing.Point(6, 106);
            this.dgvTK_TaiTro.Name = "dgvTK_TaiTro";
            this.dgvTK_TaiTro.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.dgvTK_TaiTro.RowHeadersVisible = false;
            this.dgvTK_TaiTro.RowHeadersWidth = 72;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTK_TaiTro.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTK_TaiTro.RowTemplate.Height = 31;
            this.dgvTK_TaiTro.Size = new System.Drawing.Size(1429, 460);
            this.dgvTK_TaiTro.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(461, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(523, 51);
            this.label1.TabIndex = 5;
            this.label1.Text = "Thống kê theo Nhà Tài Trợ";
            // 
            // stt
            // 
            this.stt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.stt.HeaderText = "STT";
            this.stt.MinimumWidth = 9;
            this.stt.Name = "stt";
            this.stt.Width = 91;
            // 
            // DoiTac
            // 
            this.DoiTac.HeaderText = "Nhà Tài Trợ";
            this.DoiTac.MinimumWidth = 9;
            this.DoiTac.Name = "DoiTac";
            this.DoiTac.Width = 250;
            // 
            // Nguoidd
            // 
            this.Nguoidd.HeaderText = "Người Đại Diện";
            this.Nguoidd.MinimumWidth = 9;
            this.Nguoidd.Name = "Nguoidd";
            this.Nguoidd.Width = 175;
            // 
            // SDT
            // 
            this.SDT.HeaderText = "SĐT";
            this.SDT.MinimumWidth = 9;
            this.SDT.Name = "SDT";
            this.SDT.Width = 125;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 9;
            this.Email.Name = "Email";
            this.Email.Width = 175;
            // 
            // NoiDung
            // 
            this.NoiDung.HeaderText = "Nội Dung Hợp Tác";
            this.NoiDung.MinimumWidth = 9;
            this.NoiDung.Name = "NoiDung";
            this.NoiDung.Width = 275;
            // 
            // frmTK_TaiTro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1441, 700);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTK_TaiTro);
            this.Name = "frmTK_TaiTro";
            this.Text = "Thống kê theo Nhà Tài Trợ";
            this.Load += new System.EventHandler(this.frmTK_TaiTro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTK_TaiTro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvTK_TaiTro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoiTac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nguoidd;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoiDung;
    }
}