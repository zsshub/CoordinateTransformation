namespace CoordinateTransformation
{
    partial class UCCoorSystem
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
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.coorInfoCtrl = new DevExpress.XtraRichEdit.RichEditControl();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeList1
            // 
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList1.Location = new System.Drawing.Point(0, 0);
            this.treeList1.Name = "treeList1";
            this.treeList1.OptionsBehavior.Editable = false;
            this.treeList1.OptionsFind.FindDelay = 100;
            this.treeList1.OptionsFind.FindFilterColumns = "CoorName";
            this.treeList1.OptionsMenu.EnableColumnMenu = false;
            this.treeList1.OptionsView.ShowColumns = false;
            this.treeList1.Size = new System.Drawing.Size(245, 447);
            this.treeList1.TabIndex = 0;
            this.treeList1.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.treeList1_FocusedNodeChanged);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.treeList1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.coorInfoCtrl);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(653, 447);
            this.splitContainerControl1.SplitterPosition = 245;
            this.splitContainerControl1.TabIndex = 1;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // coorInfoCtrl
            // 
            this.coorInfoCtrl.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.coorInfoCtrl.Appearance.Text.Font = new System.Drawing.Font("仿宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.coorInfoCtrl.Appearance.Text.Options.UseFont = true;
            this.coorInfoCtrl.Appearance.Text.Options.UseTextOptions = true;
            this.coorInfoCtrl.Appearance.Text.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coorInfoCtrl.Appearance.Text.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.coorInfoCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.coorInfoCtrl.Location = new System.Drawing.Point(0, 0);
            this.coorInfoCtrl.Name = "coorInfoCtrl";
            this.coorInfoCtrl.Options.Fields.UseCurrentCultureDateTimeFormat = false;
            this.coorInfoCtrl.Options.MailMerge.KeepLastParagraph = false;
            this.coorInfoCtrl.Options.VerticalScrollbar.Visibility = DevExpress.XtraRichEdit.RichEditScrollbarVisibility.Hidden;
            this.coorInfoCtrl.Size = new System.Drawing.Size(403, 447);
            this.coorInfoCtrl.TabIndex = 0;
            // 
            // UCCoorSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "UCCoorSystem";
            this.Size = new System.Drawing.Size(653, 447);
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraRichEdit.RichEditControl coorInfoCtrl;
    }
}
