namespace ServiceLearning
{
    partial class Form1
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
            this.tabHD = new ComponentFactory.Krypton.Ribbon.KryptonRibbonTab();
            this.kryptonRibbon1 = new ComponentFactory.Krypton.Ribbon.KryptonRibbon();
            this.tabGV = new ComponentFactory.Krypton.Ribbon.KryptonRibbonTab();
            this.TabSV = new ComponentFactory.Krypton.Ribbon.KryptonRibbonTab();
            this.TabDT = new ComponentFactory.Krypton.Ribbon.KryptonRibbonTab();
            this.dgvMain = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.kryptonRibbonGroup1 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple1 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.btnHDAdd = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.btnHDDel = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.btnHDEdit = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupTriple2 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.btnHDDetail = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonRibbon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // tabHD
            // 
            this.tabHD.Groups.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup[] {
            this.kryptonRibbonGroup1});
            this.tabHD.Text = "Hoạt động";
            // 
            // kryptonRibbon1
            // 
            this.kryptonRibbon1.InDesignHelperMode = true;
            this.kryptonRibbon1.Name = "kryptonRibbon1";
            this.kryptonRibbon1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.kryptonRibbon1.RibbonTabs.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonTab[] {
            this.tabHD,
            this.tabGV,
            this.TabSV,
            this.TabDT});
            this.kryptonRibbon1.SelectedTab = this.tabHD;
            this.kryptonRibbon1.Size = new System.Drawing.Size(1406, 214);
            this.kryptonRibbon1.TabIndex = 2;
            this.kryptonRibbon1.SelectedTabChanged += new System.EventHandler(this.kryptonRibbon1_SelectedTabChanged);
            // 
            // tabGV
            // 
            this.tabGV.Text = "Giảng viên";
            // 
            // TabSV
            // 
            this.TabSV.Text = "Sinh Viên";
            // 
            // TabDT
            // 
            this.TabDT.Text = "Đối Tác";
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToOrderColumns = true;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMain.Location = new System.Drawing.Point(0, 214);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.dgvMain.ReadOnly = true;
            this.dgvMain.RowHeadersWidth = 72;
            this.dgvMain.RowTemplate.Height = 31;
            this.dgvMain.Size = new System.Drawing.Size(1406, 525);
            this.dgvMain.TabIndex = 3;
            // 
            // kryptonRibbonGroup1
            // 
            this.kryptonRibbonGroup1.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple1,
            this.kryptonRibbonGroupTriple2});
            // 
            // kryptonRibbonGroupTriple1
            // 
            this.kryptonRibbonGroupTriple1.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.btnHDAdd,
            this.btnHDDel,
            this.btnHDEdit});
            // 
            // btnHDAdd
            // 
            this.btnHDAdd.ImageLarge = global::ServiceLearning.Properties.Resources.icons8_create;
            this.btnHDAdd.ImageSmall = global::ServiceLearning.Properties.Resources.icons8_create;
            this.btnHDAdd.TextLine1 = "New";
            this.btnHDAdd.Click += new System.EventHandler(this.kryptonRibbonGroupButton1_Click);
            // 
            // btnHDDel
            // 
            this.btnHDDel.ImageLarge = global::ServiceLearning.Properties.Resources.icons8_delete;
            this.btnHDDel.ImageSmall = global::ServiceLearning.Properties.Resources.icons8_delete;
            this.btnHDDel.TextLine1 = "Delete";
            this.btnHDDel.Click += new System.EventHandler(this.btnHDDel_Click);
            // 
            // btnHDEdit
            // 
            this.btnHDEdit.ImageLarge = global::ServiceLearning.Properties.Resources.icons8_edit;
            this.btnHDEdit.ImageSmall = global::ServiceLearning.Properties.Resources.icons8_edit;
            this.btnHDEdit.TextLine1 = "Edit";
            this.btnHDEdit.Click += new System.EventHandler(this.kryptonRibbonGroupButton3_Click);
            // 
            // kryptonRibbonGroupTriple2
            // 
            this.kryptonRibbonGroupTriple2.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.btnHDDetail});
            // 
            // btnHDDetail
            // 
            this.btnHDDetail.ImageLarge = global::ServiceLearning.Properties.Resources.icons8_details;
            this.btnHDDetail.ImageSmall = global::ServiceLearning.Properties.Resources.icons8_details;
            this.btnHDDetail.TextLine1 = "Detail";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1406, 739);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.kryptonRibbon1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Hoạt Động";
            this.Activated += new System.EventHandler(this.Form1_Load);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonRibbon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonTab tabHD;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbon kryptonRibbon1;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup kryptonRibbonGroup1;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple1;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton btnHDAdd;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton btnHDDel;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton btnHDEdit;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple2;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton btnHDDetail;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonTab tabGV;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonTab TabSV;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonTab TabDT;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvMain;
    }
}

