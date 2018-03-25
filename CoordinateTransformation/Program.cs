using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ESRI.ArcGIS.esriSystem;


namespace CoordinateTransformation
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            AoInitialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            
        }
        public static void AoInitialize()
        {
            ESRI.ArcGIS.RuntimeManager.Bind(ESRI.ArcGIS.ProductCode.EngineOrDesktop);
            IAoInitialize pAoInitialize = new AoInitializeClass();
            if (pAoInitialize == null) { throw new Exception("AO Initialize failed"); }

            esriLicenseStatus status = pAoInitialize.IsProductCodeAvailable(esriLicenseProductCode.esriLicenseProductCodeAdvanced);
            if (status == esriLicenseStatus.esriLicenseAvailable)
            {
                pAoInitialize.Initialize(esriLicenseProductCode.esriLicenseProductCodeAdvanced);
            }
            else if (status == esriLicenseStatus.esriLicenseUnavailable) { throw new Exception("esriLicenseProductCodeAdvanced is unavailable"); }

            status = pAoInitialize.IsExtensionCodeAvailable(esriLicenseProductCode.esriLicenseProductCodeAdvanced, esriLicenseExtensionCode.esriLicenseExtensionCodeSpatialAnalyst);
            if (status == esriLicenseStatus.esriLicenseAvailable)
            {
                status = pAoInitialize.CheckOutExtension(esriLicenseExtensionCode.esriLicenseExtensionCodeSpatialAnalyst);
                if (status == esriLicenseStatus.esriLicenseNotInitialized) { throw new Exception("esriLicenseExtensionCodeSpatialAnalyst is not initialized"); }
            }
            else if (status == esriLicenseStatus.esriLicenseNotLicensed) { throw new Exception("esriLicenseExtensionCodeSpatialAnalyst is not licensed"); }
            else if (status == esriLicenseStatus.esriLicenseUnavailable) { throw new Exception("esriLicenseExtensionCodeSpatialAnalyst is  unavailable"); }
        }

    }
}
