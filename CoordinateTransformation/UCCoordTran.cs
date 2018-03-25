using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ESRI.ArcGIS.Geometry;

namespace CoordinateTransformation
{
    public partial class UCCoordTran : UserControl
    {
        public UCCoordTran()
        {
            InitializeComponent();
        }

        private void transBtn_Click(object sender, EventArgs e)
        {




        }
        private void CustomGT()
        {

            // Initialize a new spatial reference environment.

            // SpatialReferenceEnvironment is a singleton object and needs to use the Activator class.

            Type factoryType = Type.GetTypeFromProgID("esriGeometry.SpatialReferenceEnvironment");

            System.Object obj = Activator.CreateInstance(factoryType);

            ISpatialReferenceFactory2 pSRF = obj as ISpatialReferenceFactory2;

            // Initialize and create the input and output coordinate systems.

            IProjectedCoordinateSystem2 pPCSin = new ESRI.ArcGIS.Geometry.ProjectedCoordinateSystemClass();

            IProjectedCoordinateSystem2 pPCSout = new ESRI.ArcGIS.Geometry.ProjectedCoordinateSystemClass();

            pPCSin = (IProjectedCoordinateSystem2)pSRF.CreateProjectedCoordinateSystem((int)esriSRProjCSType.esriSRProjCS_Abidjan1987UTM_30N);

            pPCSout = (IProjectedCoordinateSystem2)pSRF.CreateProjectedCoordinateSystem((int)esriSRProjCSType.esriSRProjCS_WGS1984UTM_30N);

            // Retrieve the geographic coordinate systems from the two projected

            // coordinate systems.

            IGeographicCoordinateSystem2 pGCSto = (IGeographicCoordinateSystem2) pPCSout.GeographicCoordinateSystem;

            IGeographicCoordinateSystem2 pGCSfrom = (IGeographicCoordinateSystem2)pPCSin.GeographicCoordinateSystem;

            // Initialize and create an appropriate geographic transformation.

            ICoordinateFrameTransformation pCFT = new CoordinateFrameTransformationClass();

            pCFT.PutParameters(1.234, -2.345, 658.3, 4.3829, -2.48591, 2.18943, 2.48585);

            pCFT.PutSpatialReferences(pGCSfrom, pGCSto);

            pCFT.Name = "Custom GeoTran";

            // The SpatialReferenceEnvironment has a GeoTransformationOperationSet that you

            // can use to maintain a list of active geographic transformations.

            // Once you add a geographic transformation to the operation set, many operations

            // can access the transformations.

            // Add the transformation to the operation set.

            IGeoTransformationOperationSet pGTSet = pSRF.GeoTransformationDefaults;

            // Always add a geographic transformation in both directions.

            pGTSet.Set(esriTransformDirection.esriTransformForward, pCFT);

            pGTSet.Set(esriTransformDirection.esriTransformReverse, pCFT);

        }
        public void Test()
        {

            //Create source spatial reference.

            Type factoryType = Type.GetTypeFromProgID("esriGeometry.SpatialReferenceEnvironment");

            System.Object obj = Activator.CreateInstance(factoryType);

            ISpatialReferenceFactory3 spatialReferenceFactory = obj as ISpatialReferenceFactory3;



            ISpatialReference spatialReference =spatialReferenceFactory.CreateGeographicCoordinateSystem((int)

                esriSRGeoCSType.esriSRGeoCS_WGS1984);

            spatialReference.SetFalseOriginAndUnits(-80.0000000232831, 39.9999999767169, 42949672.9);

            //Create an envelope and define its spatial reference.

            IEnvelope envelope = new EnvelopeClass();

            envelope.PutCoords(-68.6076204314651, 49.6186709634653, -68.5531907607304, 49.6530789785679);

            envelope.SpatialReference = spatialReference;

            //Destination spatial reference.

            ISpatialReference projectedCoordinateSystem = spatialReferenceFactory.CreateProjectedCoordinateSystem((int)

                esriSRProjCSType.esriSRProjCS_NAD1927UTM_19N);

            //Define the XYDomain equivalent to SetFalseOriginAndUnits.

            projectedCoordinateSystem.SetDomain(500000, 600000, 5300000, 5600000);

            String report = "Print envelope coordinates before projection:\n" +

                envelope.XMin + " , " + envelope.YMin + " , " + envelope.XMax + " , " +

                envelope.YMax + "\n\n\n";

            //Project envelope.

            IGeometry geometry = envelope as IGeometry2;

            geometry.Project(projectedCoordinateSystem as ISpatialReference);

            report = report + "Print envelope coordinates after projection:\n" +

                envelope.XMin + " , " + envelope.YMin + " , " + envelope.XMax + " , " +

                envelope.YMax;

            System.Windows.Forms.MessageBox.Show(report);

        }

        public void ChangeCoordinateSystem1()
        {

            ISpatialReferenceFactory2 spatialReferenceFactory = new SpatialReferenceEnvironmentClass();

            IGeoTransformationOperationSet geoTransformationOperationSet = spatialReferenceFactory.GeoTransformationDefaults;

            //NAD 1927 to WGS 1984 30.

            IGeoTransformation geoTransformation = spatialReferenceFactory.CreateGeoTransformation((int)

                esriSRGeoTransformationType.esriSRGeoTransformation_NAD1927_To_WGS1984_12) as IGeoTransformation;

            geoTransformationOperationSet.Set(esriTransformDirection.esriTransformForward, geoTransformation);

            geoTransformationOperationSet.Set(esriTransformDirection.esriTransformReverse, geoTransformation);

            //Amersfoort to WGS 1984.

            geoTransformation = spatialReferenceFactory.CreateGeoTransformation(8012) as IGeoTransformation;

            geoTransformationOperationSet.Set(esriTransformDirection.esriTransformForward, geoTransformation);

            geoTransformationOperationSet.Set(esriTransformDirection.esriTransformReverse, geoTransformation);



            ESRI.ArcGIS.Geoprocessor.Geoprocessor GP = new ESRI.ArcGIS.Geoprocessor.Geoprocessor();

            //ESRI.ArcGIS.DataManagementTools.Project pro = new ESRI.ArcGIS.DataManagementTools.Project();
            //GP.OverwriteOutput = true;
            //pro.in_dataset = layer.FeatureClass;
            //pro.in_coor_system = pSpatialReference;
            //pro.out_coor_system = prjPath;
            //pro.out_dataset = outputPath;
            
            //GP.Execute(pro, null);
        }
    }
}
