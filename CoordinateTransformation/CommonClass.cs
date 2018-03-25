using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ESRI.ArcGIS.Geodatabase;
using System.Windows.Forms;
using System.Data;

namespace CoordinateTransformation
{
   public class CommonClass
   {
        ////国家名称绑定值
        //    countryNameTable = AccessHelper.ExecuteDataTable("select NAME from CountryName", null);
       private static DataTable coorSystemTable;
       public static DataTable CoorSystemTable
       {
           get
           {
               if (coorSystemTable == null)
               {
                   coorSystemTable = AccessHelper.ExecuteDataTable("select * from CoordinateSystem", null);
               }
               return coorSystemTable;
           }
       }
       private static IFeatureWorkspace pWorkspace;
       public static IFeatureWorkspace PWorkspace
       {
           get
           {
               if (pWorkspace == null)
               {
                   pWorkspace = GetAeWorkspace(Application.StartupPath + "\\CoordinateSystem.mdb");
               }
               return CommonClass.pWorkspace;
           }
           
       }
       private static ITable coorParaTable;
       public static ITable CoorParaTable
       {
           get
           {
               if (coorParaTable == null && PWorkspace != null)
               {
                   coorParaTable = PWorkspace.OpenTable("CoordinatePara");
                   //coorParaTable.OIDFieldName
               }
               return CommonClass.coorParaTable;
           }
       }
       private static ITable countryNameTable;
       public static ITable CountryNameTable
       {
           get
           {
               if (countryNameTable == null && PWorkspace != null)
               {
                   countryNameTable = PWorkspace.OpenTable("CountryName");
                   IFieldEdit pFieldEdit = countryNameTable.Fields.get_Field(countryNameTable.Fields.FindField("ID")) as IFieldEdit;
                   pFieldEdit.Type_2 = esriFieldType.esriFieldTypeOID;
               }
               return countryNameTable;
           }
       }

       /// <summary>
       /// 打开mdb数据库
       /// </summary>
       /// <param name="mdbFile"></param>
       /// <returns></returns>
       private static ESRI.ArcGIS.Geodatabase.IFeatureWorkspace GetAeWorkspace(string mdbFile)
       {
           ESRI.ArcGIS.Geodatabase.IFeatureWorkspace featureWorkspace;
           ESRI.ArcGIS.Geodatabase.IWorkspaceFactory workspaceFactory = new ESRI.ArcGIS.DataSourcesGDB.AccessWorkspaceFactoryClass();
           featureWorkspace = workspaceFactory.OpenFromFile(mdbFile, 0) as ESRI.ArcGIS.Geodatabase.IFeatureWorkspace;
           System.Runtime.InteropServices.Marshal.ReleaseComObject(workspaceFactory);
           return featureWorkspace;
       }


   }
}
