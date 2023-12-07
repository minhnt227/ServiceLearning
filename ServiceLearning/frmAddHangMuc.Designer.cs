namespace ServiceLearning
{
    partial class frmAddHangMuc
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
            this.txtHM_Ten = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd_HM = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // txtHM_Ten
            // 
            this.txtHM_Ten.Location = new System.Drawing.Point(174, 59);
            this.txtHM_Ten.Name = "txtHM_Ten";
            this.txtHM_Ten.Size = new System.Drawing.Size(561, 29);
            this.txtHM_Ten.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên Hạng Mục";
            // 
            // btnAdd_HM
            // 
            this.btnAdd_HM.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Alternate;
            this.btnAdd_HM.Location = new System.Drawing.Point(282, 150);
            this.btnAdd_HM.Name = "btnAdd_HM";
            this.btnAdd_HM.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.btnAdd_HM.Size = new System.Drawing.Size(165, 48);
            this.btnAdd_HM.TabIndex = 2;
            this.btnAdd_HM.Values.Text = "Tạo";
            this.btnAdd_HM.Click += new System.EventHandler(this.btnAdd_HM_Click);
            // 
            // frmAddHangMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 228);
            this.Controls.Add(this.btnAdd_HM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHM_Ten);
            this.Name = "frmAddHangMuc";
            this.Text = "Thêm Hạng Mục";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHM_Ten;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAdd_HM;
    }
}