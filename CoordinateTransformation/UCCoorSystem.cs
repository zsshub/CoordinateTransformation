using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ESRI.ArcGIS.Framework;
using ESRI.ArcGIS.CartoUI;
using ESRI.ArcGIS.Geometry;
using DevExpress.XtraTreeList.Nodes;

namespace CoordinateTransformation
{
    public partial class UCCoorSystem : UserControl
    {
        public UCCoorSystem()
        {
            InitializeComponent();
            InitTreelist();
        }
        void InitTreelist()
        {            
            treeList1.DataSource = CommonClass.CoorSystemTable;
            treeList1.KeyFieldName = "ID";
            treeList1.ParentFieldName = "PARID";         
            treeList1.Columns["TYPE"].Visible = false;
            treeList1.Columns["WKID"].Visible = false;
            treeList1.Columns["ORGANIZATION"].Visible = false;
            treeList1.Columns["DEFINITION"].Visible = false;
            treeList1.Columns["DESCRIPTION"].Visible = false;
            treeList1.Text = "";
            treeList1.CloseEditor();
            treeList1.BestFitColumns(true);
        }        

        private void treeList1_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            TreeListNode currNode = treeList1.FocusedNode;
            if (currNode == null || currNode.HasChildren) return;

            coorInfoCtrl.Text = string.Empty;
            string coorInfor = currNode.GetValue("DEFINITION").ToString();
            if (string.IsNullOrEmpty(coorInfor)) return;
           
            string wkid = currNode.GetValue("WKID").ToString();
            string org = currNode.GetValue("ORGANIZATION").ToString();
            coorInfor = coorInfor.Replace("[", "").Replace("]", "");

            //地理坐标系
            if ((int)currNode.GetValue("PARID") == 1)
            {
                string[] separator = { "GEOGCS", "DATUM", "SPHEROID", "PRIMEM", "UNIT" };
                string[] info = coorInfor.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                string[] name = { "Geographic Coordinate System: ", "Datum: ", "Spheroid: ", "Prime Meridian: ", "Angular Unit: " };

                coorInfoCtrl.Text = name[0] + info[0].Remove(info[0].Length - 1) + "\t\n" + "WKID: " + wkid + "\t\nOrganization: " + org + "\t\n\n";

                for (int i = 1; i < 5; i++)
                {
                    if (info[i].EndsWith(","))
                        info[i] = info[i].Remove(info[i].Length - 1);
                    coorInfoCtrl.Text += name[i] + info[i] + "\t\n";
                }

            }
            //投影坐标系统
            if ((int)currNode.GetValue("PARID") == 2)
            {
                string[] separator = { "PROJCS", "GEOGCS", "DATUM", "SPHEROID", "PRIMEM", "UNIT", "PROJECTION", "PARAMETER" };
                string[] info = coorInfor.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                string[] name ={"Projected Coordinate System: ","Geographic Coordinate System: ","Datum: ","Spheroid: ",
                                   "Prime Meridian: ","Angular Unit: ","Projection: ","False_Easting: ","False_Northing: ",
                                   "Central_Meridian: ","Scale_Factor: ","Latitude_Of_Origin: ","Linear Unit: "};


                coorInfoCtrl.Text = name[0] + info[0].Remove(info[0].Length - 1) + "\t\n" + "WKID: " + wkid + "\t\nOrganization: " + org + "\t\n\n";

                for (int i = 6; i < 13; i++)
                {
                    if (info[i].EndsWith(","))
                        info[i] = info[i].Remove(info[i].Length - 1);

                    if (i == 6 || i == 12)
                        coorInfoCtrl.Text += name[i] + info[i] + "\t\n";
                    else
                        coorInfoCtrl.Text += name[i] + info[i].Split(',')[1] + "\t\n";
                }

                coorInfoCtrl.Text += "\t\n";
                for (int i = 1; i < 6; i++)
                {
                    if (info[i].EndsWith(","))
                        info[i] = info[i].Remove(info[i].Length - 1);

                    coorInfoCtrl.Text += name[i] + info[i] + "\t\n";
                }
            }

        }
    }
}
