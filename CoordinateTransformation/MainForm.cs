using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CoordinateTransformation
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
           UCCoorSystem ucCoorSystem= new UCCoorSystem();
           ucCoorSystem.Dock = DockStyle.Fill;
           panelCtrl.Controls.Add(ucCoorSystem);
        }

        private void coordBtn_Click(object sender, EventArgs e)
        {
            if ((panelCtrl.Controls[0] as UCCoorSystem) != null) return;
            panelCtrl.Controls.Clear();
            UCCoorSystem ucCoorSystem = new UCCoorSystem();
            ucCoorSystem.Dock = DockStyle.Fill;
            panelCtrl.Controls.Add(ucCoorSystem);   
        }

        private void paraBtn_Click(object sender, EventArgs e)
        {
            if (CommonClass.PWorkspace == null)
            {
                MessageBox.Show("未能找到数据库文件“CoordinateSystem.mdb”！","提示");
                return;
            }
            if ((panelCtrl.Controls[0] as UCParameter) != null) return;
            panelCtrl.Controls.Clear();
            UCParameter ucParameter = new UCParameter();
            ucParameter.Dock = DockStyle.Fill;
            panelCtrl.Controls.Add(ucParameter);   
        }

        private void calcParaBtn_Click(object sender, EventArgs e)
        {
            if ((panelCtrl.Controls[0] as UCCalcPara) != null) return;
            panelCtrl.Controls.Clear();
            UCCalcPara ucCalcPara = new UCCalcPara();
            ucCalcPara.Dock = DockStyle.Fill;
            panelCtrl.Controls.Add(ucCalcPara);   
        }

        private void coordTranBtn_Click(object sender, EventArgs e)
        {
            if ((panelCtrl.Controls[0] as UCCoordTran) != null) return;
            panelCtrl.Controls.Clear();
            UCCoordTran ucCoordTran = new UCCoordTran();
            ucCoordTran.Dock = DockStyle.Fill;
            panelCtrl.Controls.Add(ucCoordTran);   
        }
    }
}
