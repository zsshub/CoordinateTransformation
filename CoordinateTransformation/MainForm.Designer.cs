namespace CoordinateTransformation
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.paraBtn = new DevExpress.XtraEditors.SimpleButton();
            this.calcParaBtn = new DevExpress.XtraEditors.SimpleButton();
            this.coordTranBtn = new DevExpress.XtraEditors.SimpleButton();
            this.panelCtrl = new DevExpress.XtraEditors.PanelControl();
            this.coordBtn = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelCtrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("宋体", 20.25F);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelControl1.Location = new System.Drawing.Point(12, 48);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(216, 27);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "坐标系统转换工具";
            // 
            // paraBtn
            // 
            this.paraBtn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.paraBtn.Image = ((System.Drawing.Image)(resources.GetObject("paraBtn.Image")));
            this.paraBtn.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.paraBtn.Location = new System.Drawing.Point(0, 176);
            this.paraBtn.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.paraBtn.LookAndFeel.UseDefaultLookAndFeel = false;
            this.paraBtn.Name = "paraBtn";
            this.paraBtn.Size = new System.Drawing.Size(98, 90);
            this.paraBtn.TabIndex = 3;
            this.paraBtn.Text = "simpleButton1";
            this.paraBtn.Click += new System.EventHandler(this.paraBtn_Click);
            // 
            // calcParaBtn
            // 
            this.calcParaBtn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.calcParaBtn.Image = ((System.Drawing.Image)(resources.GetObject("calcParaBtn.Image")));
            this.calcParaBtn.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.calcParaBtn.Location = new System.Drawing.Point(0, 266);
            this.calcParaBtn.Name = "calcParaBtn";
            this.calcParaBtn.Size = new System.Drawing.Size(98, 90);
            this.calcParaBtn.TabIndex = 3;
            this.calcParaBtn.Text = "simpleButton1";
            this.calcParaBtn.Click += new System.EventHandler(this.calcParaBtn_Click);
            // 
            // coordTranBtn
            // 
            this.coordTranBtn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.coordTranBtn.Image = ((System.Drawing.Image)(resources.GetObject("coordTranBtn.Image")));
            this.coordTranBtn.Location = new System.Drawing.Point(0, 356);
            this.coordTranBtn.Name = "coordTranBtn";
            this.coordTranBtn.Size = new System.Drawing.Size(98, 90);
            this.coordTranBtn.TabIndex = 3;
            this.coordTranBtn.Text = "simpleButton1";
            this.coordTranBtn.Click += new System.EventHandler(this.coordTranBtn_Click);
            // 
            // panelCtrl
            // 
            this.panelCtrl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCtrl.Location = new System.Drawing.Point(99, 86);
            this.panelCtrl.Name = "panelCtrl";
            this.panelCtrl.Size = new System.Drawing.Size(653, 447);
            this.panelCtrl.TabIndex = 4;
            // 
            // coordBtn
            // 
            this.coordBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.coordBtn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.coordBtn.Image = ((System.Drawing.Image)(resources.GetObject("coordBtn.Image")));
            this.coordBtn.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.coordBtn.Location = new System.Drawing.Point(0, 86);
            this.coordBtn.Name = "coordBtn";
            this.coordBtn.Size = new System.Drawing.Size(98, 90);
            this.coordBtn.TabIndex = 3;
            this.coordBtn.Text = "simpleButton1";
            this.coordBtn.Click += new System.EventHandler(this.coordBtn_Click);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureEdit1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureEdit1.Location = new System.Drawing.Point(0, 0);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureEdit1.Properties.InitialImage")));
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(755, 85);
            this.pictureEdit1.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(24, 159);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 14);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "坐标系统";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(24, 250);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 14);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "转换参数";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(24, 339);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(48, 14);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "参数结算";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(24, 429);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(48, 14);
            this.labelControl5.TabIndex = 5;
            this.labelControl5.Text = "数据转换";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 535);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.panelCtrl);
            this.Controls.Add(this.coordTranBtn);
            this.Controls.Add(this.calcParaBtn);
            this.Controls.Add(this.paraBtn);
            this.Controls.Add(this.coordBtn);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.pictureEdit1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.panelCtrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton coordBtn;
        private DevExpress.XtraEditors.SimpleButton paraBtn;
        private DevExpress.XtraEditors.SimpleButton calcParaBtn;
        private DevExpress.XtraEditors.SimpleButton coordTranBtn;
        private DevExpress.XtraEditors.PanelControl panelCtrl;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
    }
}