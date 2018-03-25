namespace CoordinateTransformation
{
    partial class UCParameter
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.paraGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.AreaofUse = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CoorTranName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Defined = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.countryNameCmb = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.paraTypeCmb = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.resetBtn = new DevExpress.XtraEditors.SimpleButton();
            this.searchBtn = new DevExpress.XtraEditors.SimpleButton();
            this.addBtn = new DevExpress.XtraEditors.SimpleButton();
            this.editBtn = new DevExpress.XtraEditors.SimpleButton();
            this.delBtn = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.paraCountLbl = new DevExpress.XtraEditors.LabelControl();
            this.btnView = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.paraGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countryNameCmb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paraTypeCmb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // paraGridControl
            // 
            this.paraGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paraGridControl.Location = new System.Drawing.Point(2, 22);
            this.paraGridControl.MainView = this.gridView1;
            this.paraGridControl.Name = "paraGridControl";
            this.paraGridControl.Size = new System.Drawing.Size(643, 347);
            this.paraGridControl.TabIndex = 9;
            this.paraGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.AreaofUse,
            this.CoorTranName,
            this.Defined});
            this.gridView1.GridControl = this.paraGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // AreaofUse
            // 
            this.AreaofUse.Caption = "国家名称";
            this.AreaofUse.FieldName = "AreaofUse";
            this.AreaofUse.Name = "AreaofUse";
            this.AreaofUse.Visible = true;
            this.AreaofUse.VisibleIndex = 0;
            // 
            // CoorTranName
            // 
            this.CoorTranName.Caption = "转换参数名称";
            this.CoorTranName.FieldName = "CoorTranName";
            this.CoorTranName.Name = "CoorTranName";
            this.CoorTranName.Visible = true;
            this.CoorTranName.VisibleIndex = 1;
            // 
            // Defined
            // 
            this.Defined.Caption = "是否自定义";
            this.Defined.FieldName = "Defined";
            this.Defined.Name = "Defined";
            this.Defined.Visible = true;
            this.Defined.VisibleIndex = 2;
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.countryNameCmb);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.paraTypeCmb);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.resetBtn);
            this.panelControl1.Controls.Add(this.searchBtn);
            this.panelControl1.Location = new System.Drawing.Point(3, 1);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(647, 40);
            this.panelControl1.TabIndex = 8;
            // 
            // countryNameCmb
            // 
            this.countryNameCmb.Location = new System.Drawing.Point(75, 10);
            this.countryNameCmb.Name = "countryNameCmb";
            this.countryNameCmb.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.countryNameCmb.Size = new System.Drawing.Size(177, 20);
            this.countryNameCmb.TabIndex = 11;
            this.countryNameCmb.EditValueChanged += new System.EventHandler(this.countryNameCmb_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(17, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 14);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "国家名称:";
            // 
            // paraTypeCmb
            // 
            this.paraTypeCmb.Location = new System.Drawing.Point(337, 10);
            this.paraTypeCmb.Name = "paraTypeCmb";
            this.paraTypeCmb.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.paraTypeCmb.Size = new System.Drawing.Size(123, 20);
            this.paraTypeCmb.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(271, 13);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 14);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "参数类型：";
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(560, 7);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(66, 23);
            this.resetBtn.TabIndex = 2;
            this.resetBtn.Text = "重置";
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(479, 7);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(66, 23);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "筛选";
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addBtn.Location = new System.Drawing.Point(574, 419);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 7;
            this.addBtn.Text = "新增";
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.editBtn.Location = new System.Drawing.Point(388, 419);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(75, 23);
            this.editBtn.TabIndex = 6;
            this.editBtn.Text = "编辑";
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.delBtn.Location = new System.Drawing.Point(481, 419);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(75, 23);
            this.delBtn.TabIndex = 5;
            this.delBtn.Text = "删除";
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.paraGridControl);
            this.groupControl1.Location = new System.Drawing.Point(3, 42);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(647, 371);
            this.groupControl1.TabIndex = 10;
            this.groupControl1.Text = "转换参数列表";
            // 
            // paraCountLbl
            // 
            this.paraCountLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.paraCountLbl.Location = new System.Drawing.Point(5, 421);
            this.paraCountLbl.Name = "paraCountLbl";
            this.paraCountLbl.Size = new System.Drawing.Size(70, 14);
            this.paraCountLbl.TabIndex = 11;
            this.paraCountLbl.Text = "labelControl3";
            // 
            // btnView
            // 
            this.btnView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnView.Location = new System.Drawing.Point(287, 419);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 5;
            this.btnView.Text = "查看";
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // UCParameter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.paraCountLbl);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.delBtn);
            this.Name = "UCParameter";
            this.Size = new System.Drawing.Size(653, 447);
            ((System.ComponentModel.ISupportInitialize)(this.paraGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countryNameCmb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paraTypeCmb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl paraGridControl;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit paraTypeCmb;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton searchBtn;
        private DevExpress.XtraEditors.SimpleButton addBtn;
        private DevExpress.XtraEditors.SimpleButton editBtn;
        private DevExpress.XtraEditors.SimpleButton delBtn;
        private DevExpress.XtraEditors.ComboBoxEdit countryNameCmb;
        private DevExpress.XtraGrid.Columns.GridColumn AreaofUse;
        private DevExpress.XtraGrid.Columns.GridColumn Defined;
        private DevExpress.XtraGrid.Columns.GridColumn CoorTranName;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton resetBtn;
        private DevExpress.XtraEditors.LabelControl paraCountLbl;
        private DevExpress.XtraEditors.SimpleButton btnView;
    }
}
