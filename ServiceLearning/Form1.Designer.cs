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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabHD = new ComponentFactory.Krypton.Ribbon.KryptonRibbonTab();
            this.kryptonRibbonGroup1 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple1 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.btnHDAdd = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.btnHDDel = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.btnHDEdit = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupTriple2 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.btnHDDetail = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbon1 = new ComponentFactory.Krypton.Ribbon.KryptonRibbon();
            this.tabGV = new ComponentFactory.Krypton.Ribbon.KryptonRibbonTab();
            this.TabSV = new ComponentFactory.Krypton.Ribbon.KryptonRibbonTab();
            this.TabDT = new ComponentFactory.Krypton.Ribbon.KryptonRibbonTab();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonRibbon1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(0, 260);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1406, 466);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1406, 466);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabHD
            // 
            this.tabHD.Groups.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup[] {
            this.kryptonRibbonGroup1});
            this.tabHD.Text = "Hoạt động";
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
            this.btnHDAdd.TextLine1 = "New";
            this.btnHDAdd.Click += new System.EventHandler(this.kryptonRibbonGroupButton1_Click);
            // 
            // btnHDDel
            // 
            this.btnHDDel.TextLine1 = "Delete";
            this.btnHDDel.Click += new System.EventHandler(this.btnHDDel_Click);
            // 
            // btnHDEdit
            // 
            this.btnHDEdit.ImageLarge = ((System.Drawing.Image)(resources.GetObject("btnHDEdit.ImageLarge")));
            this.btnHDEdit.ImageSmall = ((System.Drawing.Image)(resources.GetObject("btnHDEdit.ImageSmall")));
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
            this.btnHDDetail.TextLine1 = "Detail";
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
            this.kryptonRibbon1.SelectedContext = null;
            this.kryptonRibbon1.SelectedTab = this.TabDT;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1406, 739);
            this.Controls.Add(this.kryptonRibbon1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Load);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonRibbon1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
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
    }
}

