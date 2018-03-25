using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace CoordinateTransformation
{
    public partial class FormCoordPara : Form
    {
        DataRow focusRow = null;
        public FormCoordPara(DataRow currRow)
        {
            InitializeComponent();
            focusRow = currRow;   
        }    

        private void saveBtn_Click(object sender, EventArgs e)
        {
            CheckBeforeSave();

            object CoorTranName = tranNameTxtEdit.Text,
            Accuracy = AccurCalcEdit.EditValue,
            WKID = WKIDCalcEdit.EditValue,
            AreaofUse = useAreaTxtEdit.Text,
            Method = tranMethodTxtEdit.Text,

            MaximumLatitude = maxLatCalcEdit.EditValue,
            MinimumLatitude = minLatCalcEdit.EditValue,
            MaximumLongitude = maxLonCalcEdit.EditValue,
            MinimumLongitude = minLonCalcEdit.EditValue,

            dx = dxCalcEdit.EditValue,
            dy = dyCalcEdit.EditValue,
            dz = dzCalcEdit.EditValue,
            rx = rxCalcEdit.EditValue = rxCalcEdit.Enabled ? rxCalcEdit.EditValue : "null",
            ry = ryCalcEdit.EditValue = ryCalcEdit.Enabled ? ryCalcEdit.EditValue : "null",
            rz = rzCalcEdit.EditValue = rzCalcEdit.Enabled ? rzCalcEdit.EditValue : "null",
            ds = dsCalcEdit.EditValue = dsCalcEdit.Enabled ? dsCalcEdit.EditValue : "null",
            X0 = X0CalcEdit.EditValue = X0CalcEdit.Enabled ? X0CalcEdit.EditValue : "null",
            Y0 = Y0CalcEdit.EditValue = Y0CalcEdit.Enabled ? Y0CalcEdit.EditValue : "null",
            Z0 = Z0CalcEdit.EditValue = Z0CalcEdit.Enabled ? Z0CalcEdit.EditValue : "null";
            try
            {
                string sqlStr = "";
                if (this.Text.Contains("新增"))
                {
                    object maxId = AccessHelper.ExecuteScalar("select max(id) from CoordinatePara", null);
                   
                    sqlStr = string.Format("INSERT INTO CoordinatePara (CoorTranName,Accuracy,WKID,AreaofUse,Method,MaximumLatitude,MinimumLatitude,MaximumLongitude,MinimumLongitude,dx,dy,dz,rx,ry,rz,ds,X0,Y0,Z0,Defined,ID)"
                          + "VALUES('{0}',{1},{2},'{3}','{4}',{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19},{20})",
                          CoorTranName, Accuracy, WKID, AreaofUse, Method, MaximumLatitude, MinimumLatitude, MaximumLongitude, MinimumLongitude, dx, dy, dz, rx, ry, rz, ds, X0, Y0, Z0, true, Convert.ToInt32(maxId) + 1);
                  
                }
                if (this.Text.Contains("编辑"))
                {
                    sqlStr = string.Format("UPDATE CoordinatePara SET CoorTranName = '{0}'," +
                     "Accuracy = {1}," +
                     "WKID = {2}," +
                     "AreaofUse =  = '{3}'," +
                     "Method =  = '{4}'," +
                     "MaximumLatitude = {5}," +
                     "MinimumLatitude = {6}," +
                     "MaximumLongitude = {7}," +
                     "MinimumLongitude = {8}," +
                     "dx = {9}," +
                     "dy = {10}," +
                     "dz = {11}," +
                     "rx = {12}," +
                     "ry = {13}," +
                     "rz = {14}," +
                     "ds = {15}," +
                     "X0 = {16}," +
                     "Y0 = {17}," +
                     "Z0 = {18} " +
                     "WHERE ID={19}",
                      CoorTranName, Accuracy, WKID, AreaofUse, Method, MaximumLatitude, MinimumLatitude, MaximumLongitude, MinimumLongitude, dx, dy, dz, rx, ry, rz, ds, X0, Y0, Z0, focusRow["ID"]);
                }
                if (AccessHelper.ExecuteNonQuery(sqlStr,null) == 1)
                    MessageBox.Show("保存成功！", "提示");
                else
                    MessageBox.Show("保存失败！", "提示");
               
            }
            catch (Exception err)
            {
                MessageBox.Show("保存失败！\t\n"+err.Message, "提示"); 
               
            }            
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Form frm = this.Owner as Form;
            this.Close();
        }

        private void paraTypeCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (paraTypeCmb.SelectedIndex == 0)
            {
                rxCalcEdit.Enabled = false; ryCalcEdit.Enabled = false; rzCalcEdit.Enabled = false; dsCalcEdit.Enabled = false;
                X0CalcEdit.Enabled = false; Y0CalcEdit.Enabled = false; Z0CalcEdit.Enabled = false;
            }

            if (paraTypeCmb.SelectedIndex == 1)
            {
                rxCalcEdit.Enabled = true; ryCalcEdit.Enabled = true; rzCalcEdit.Enabled = true; dsCalcEdit.Enabled = true;
                X0CalcEdit.Enabled = false; Y0CalcEdit.Enabled = false; Z0CalcEdit.Enabled = false;
            }
            if (paraTypeCmb.SelectedIndex == 2)
            {
                rxCalcEdit.Enabled = true; ryCalcEdit.Enabled = true; rzCalcEdit.Enabled = true; dsCalcEdit.Enabled = true;
                X0CalcEdit.Enabled = true; Y0CalcEdit.Enabled = true; Z0CalcEdit.Enabled = true;
            }
        }


        private void CheckBeforeSave()
        {
            foreach (Control ctrl in groupBox1.Controls)
            {
                if ((ctrl is TextEdit) && string.IsNullOrEmpty((ctrl as TextEdit).Text))
                {
                    MessageBox.Show("参数不得为空值！", "提示");
                    return;
                }

                if ((ctrl is CalcEdit) && (ctrl as CalcEdit).EditValue == null)
                {
                    MessageBox.Show("参数不得为空值！", "提示");
                    return;
                }
            }

            foreach (Control ctrl in groupBox2.Controls)
            {
                if ((ctrl is CalcEdit) && ctrl.Enabled == true)
                {
                    if ((ctrl as CalcEdit).EditValue == null)
                    {
                        MessageBox.Show("参数不得为空值！", "提示");
                        return;
                    }
                }
            }
        }

        private void FormCoordPara_Load(object sender, EventArgs e)
        {
            FormLoad();
        }
        void FormLoad()
        {
            //参数类型绑定值
            string[] typeName = { "三参", "七参", "十参" };
            paraTypeCmb.Properties.Items.AddRange(typeName);
            paraTypeCmb.SelectedIndex = 0;

            object ds = null; 
            object z0 = null;

            if (this.Text.Contains("编辑"))
            {
                foreach (DataColumn colum in focusRow.Table.Columns)
                {
                    foreach (Control control in this.Controls)
                    {
                        if (control.HasChildren)
                        {
                            foreach (Control item in control.Controls)
                            {
                                if (item.Tag != null && item.Tag.ToString().Equals(colum.ColumnName))
                                {
                                    if (item is TextEdit)
                                        (item as TextEdit).EditValue = focusRow[colum.ColumnName];
                                    if (item is CalcEdit)
                                        (item as CalcEdit).EditValue = focusRow[colum.ColumnName];

                                    if (colum.ColumnName.Equals("ds"))
                                        ds = focusRow[colum.ColumnName];
                                    if (colum.ColumnName.Equals("Z0"))
                                        z0 = focusRow[colum.ColumnName];
                                }
                            }
                        }

                    }

                }
                if (!(ds is System.DBNull || ds is System.DBNull))
                    paraTypeCmb.SelectedIndex = 1;
                if (!(ds is System.DBNull) && (ds is System.DBNull))
                    paraTypeCmb.SelectedIndex = 2;
            }
            if (this.Text.Contains("查看"))
            {
                foreach (DataColumn colum in focusRow.Table.Columns)
                {
                    foreach (Control control in this.Controls)
                    {
                        if (control.HasChildren)
                        {
                            foreach (Control item in control.Controls)
                            {
                                if (item.Tag != null && item.Tag.ToString().Equals(colum.ColumnName))
                                {
                                    if (item is TextEdit)
                                    {
                                        (item as TextEdit).EditValue = focusRow[colum.ColumnName];
                                        (item as TextEdit).Properties.ReadOnly = true;
                                    }
                                    if (item is CalcEdit)
                                    {
                                        (item as CalcEdit).EditValue = focusRow[colum.ColumnName];
                                        (item as CalcEdit).Properties.ReadOnly = true;
                                    }

                                    if (colum.ColumnName.Equals("ds"))
                                        ds = focusRow[colum.ColumnName];
                                    if (colum.ColumnName.Equals("Z0"))
                                        z0 = focusRow[colum.ColumnName];
                                    
                                }
                            }
                        }

                    }

                }
                if (!(ds is System.DBNull || ds is System.DBNull))
                    paraTypeCmb.SelectedIndex = 1;
                if (!(ds is System.DBNull) && (ds is System.DBNull))
                    paraTypeCmb.SelectedIndex = 2;

                paraTypeCmb.Properties.ReadOnly = true;
                saveBtn.Enabled = false;
            }
        }
    }
}
