using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using LiquidTechnologies.Viewer.Net40;
using SampleApp.Model;
using SampleApp.DAL;
using System.Collections.Generic;
using LiquidTechnologies.Runtime.Net40;
using System.IO;
using System.Globalization;
using System.Text;
using CsvHelper;
using System.Xml.Linq;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;
using Npgsql;
using ns33;
using ns52;
using ns53;
using SampleApp.Class;
using System.Configuration;
using Microsoft.VisualBasic.FileIO;
using static System.Windows.Forms.LinkLabel;
//using System.Web.UI.WebControls;

namespace LiquidTechnologies.Test
{
    /// <summary>
    /// Summary description for SampleApp.
    /// </summary>
    public class SampleApp : System.Windows.Forms.Form
    {
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ListBox lstFiles;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private Button button1;
        private Button button2;
        public DateTimePicker dateTimeGetter;
        private Button buttonLoad;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        #region btnLoad_Click - Opens the selected file - (THIS IS A GOOD PLACE TO START)
        // When an item is selected from the ListBox, this event handler is called.
        // 
        // If you specified Sample files in the Liquid XML wizard then they will be listed
        // in the switch statement.
        // If you did not specify Samples then there are 2 routes foward. You can either
        // use the "Browse for a File to Load", this will load the sample using a generic load
        // method. Alternatively you can run one of the SimpleTestXXXXX("<filename>") methods
        // This will load the file into the correct object, and display it in the viewer.
        private void btnLoad_Click(object sender, System.EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            switch (lstFiles.SelectedIndex)
            {
                case 0:
                    if (openFileDialog.ShowDialog(this) == DialogResult.OK)
                        SimpleTestLoadAnyXmlDocument(openFileDialog.FileName);
                    break;
            };
            #region UNCOMMENT CODE IN THIS REGION TO LOAD YOUR SAMPLE XML FILES
            /* ---------------------------------------------------------------------------------
             * This function can be used to open an XML document with a document element 
             * (the first element in the file) named 'assignment_info' 
             * e.g. 
             *
             * <?xml version="1.0" encoding="UTF-8"?>
             * <assignment_info>
             *     ...
             * </assignment_info>
             * --------------------------------------------------------------------------------- */
            // SimpleTestns52Assignment_info(@"<UNCOMMENT & INSERT A SAMPLE XML FILENAME HERE>");

            /* ---------------------------------------------------------------------------------
             * This function can be used to open an XML document with a document element 
             * (the first element in the file) named 'BirthCertificate' 
             * e.g. 
             *
             * <?xml version="1.0" encoding="UTF-8"?>
             * <BirthCertificate>
             *     ...
             * </BirthCertificate>
             * --------------------------------------------------------------------------------- */
            // SimpleTestns54BirthCertificate(@"<UNCOMMENT & INSERT A SAMPLE XML FILENAME HERE>");

            /* ---------------------------------------------------------------------------------
             * This function can be used to open an XML document with a document element 
             * (the first element in the file) named 'BirthDate' 
             * e.g. 
             *
             * <?xml version="1.0" encoding="UTF-8"?>
             * <BirthDate>
             *     ...
             * </BirthDate>
             * --------------------------------------------------------------------------------- */
            // SimpleTestns53BirthDate(@"<UNCOMMENT & INSERT A SAMPLE XML FILENAME HERE>");

            /* ---------------------------------------------------------------------------------
             * This function can be used to open an XML document with a document element 
             * (the first element in the file) named 'categoryID' 
             * e.g. 
             *
             * <?xml version="1.0" encoding="UTF-8"?>
             * <categoryID>
             *     ...
             * </categoryID>
             * --------------------------------------------------------------------------------- */
            // SimpleTestns52CategoryID(@"<UNCOMMENT & INSERT A SAMPLE XML FILENAME HERE>");

            /* ---------------------------------------------------------------------------------
             * This function can be used to open an XML document with a document element 
             * (the first element in the file) named 'data' 
             * e.g. 
             *
             * <?xml version="1.0" encoding="UTF-8"?>
             * <data>
             *     ...
             * </data>
             * --------------------------------------------------------------------------------- */
            // SimpleTestns55Data(@"<UNCOMMENT & INSERT A SAMPLE XML FILENAME HERE>");

            /* ---------------------------------------------------------------------------------
             * This function can be used to open an XML document with a document element 
             * (the first element in the file) named 'dateFinish' 
             * e.g. 
             *
             * <?xml version="1.0" encoding="UTF-8"?>
             * <dateFinish>
             *     ...
             * </dateFinish>
             * --------------------------------------------------------------------------------- */
            // SimpleTestns52DateFinish(@"<UNCOMMENT & INSERT A SAMPLE XML FILENAME HERE>");

            /* ---------------------------------------------------------------------------------
             * This function can be used to open an XML document with a document element 
             * (the first element in the file) named 'dateStart' 
             * e.g. 
             *
             * <?xml version="1.0" encoding="UTF-8"?>
             * <dateStart>
             *     ...
             * </dateStart>
             * --------------------------------------------------------------------------------- */
            // SimpleTestns52DateStart(@"<UNCOMMENT & INSERT A SAMPLE XML FILENAME HERE>");

            /* ---------------------------------------------------------------------------------
             * This function can be used to open an XML document with a document element 
             * (the first element in the file) named 'decision_date' 
             * e.g. 
             *
             * <?xml version="1.0" encoding="UTF-8"?>
             * <decision_date>
             *     ...
             * </decision_date>
             * --------------------------------------------------------------------------------- */
            // SimpleTestns52Decision_date(@"<UNCOMMENT & INSERT A SAMPLE XML FILENAME HERE>");

            /* ---------------------------------------------------------------------------------
             * This function can be used to open an XML document with a document element 
             * (the first element in the file) named 'FamilyName' 
             * e.g. 
             *
             * <?xml version="1.0" encoding="UTF-8"?>
             * <FamilyName>
             *     ...
             * </FamilyName>
             * --------------------------------------------------------------------------------- */
            // SimpleTestns33FamilyName(@"<UNCOMMENT & INSERT A SAMPLE XML FILENAME HERE>");

            /* ---------------------------------------------------------------------------------
             * This function can be used to open an XML document with a document element 
             * (the first element in the file) named 'FirstName' 
             * e.g. 
             *
             * <?xml version="1.0" encoding="UTF-8"?>
             * <FirstName>
             *     ...
             * </FirstName>
             * --------------------------------------------------------------------------------- */
            // SimpleTestns33FirstName(@"<UNCOMMENT & INSERT A SAMPLE XML FILENAME HERE>");

            /* ---------------------------------------------------------------------------------
             * This function can be used to open an XML document with a document element 
             * (the first element in the file) named 'Gender' 
             * e.g. 
             *
             * <?xml version="1.0" encoding="UTF-8"?>
             * <Gender>
             *     ...
             * </Gender>
             * --------------------------------------------------------------------------------- */
            // SimpleTestns53Gender(@"<UNCOMMENT & INSERT A SAMPLE XML FILENAME HERE>");

            /* ---------------------------------------------------------------------------------
             * This function can be used to open an XML document with a document element 
             * (the first element in the file) named 'ID' 
             * e.g. 
             *
             * <?xml version="1.0" encoding="UTF-8"?>
             * <ID>
             *     ...
             * </ID>
             * --------------------------------------------------------------------------------- */
            // SimpleTestns52ID(@"<UNCOMMENT & INSERT A SAMPLE XML FILENAME HERE>");

            /* ---------------------------------------------------------------------------------
             * This function can be used to open an XML document with a document element 
             * (the first element in the file) named 'IdentityDoc' 
             * e.g. 
             *
             * <?xml version="1.0" encoding="UTF-8"?>
             * <IdentityDoc>
             *     ...
             * </IdentityDoc>
             * --------------------------------------------------------------------------------- */
            // SimpleTestns53IdentityDoc(@"<UNCOMMENT & INSERT A SAMPLE XML FILENAME HERE>");

            /* ---------------------------------------------------------------------------------
             * This function can be used to open an XML document with a document element 
             * (the first element in the file) named 'LMSZID' 
             * e.g. 
             *
             * <?xml version="1.0" encoding="UTF-8"?>
             * <LMSZID>
             *     ...
             * </LMSZID>
             * --------------------------------------------------------------------------------- */
            // SimpleTestns52LMSZID(@"<UNCOMMENT & INSERT A SAMPLE XML FILENAME HERE>");

            /* ---------------------------------------------------------------------------------
             * This function can be used to open an XML document with a document element 
             * (the first element in the file) named 'MSZ_receiver' 
             * e.g. 
             *
             * <?xml version="1.0" encoding="UTF-8"?>
             * <MSZ_receiver>
             *     ...
             * </MSZ_receiver>
             * --------------------------------------------------------------------------------- */
            // SimpleTestns52MSZ_receiver(@"<UNCOMMENT & INSERT A SAMPLE XML FILENAME HERE>");

            /* ---------------------------------------------------------------------------------
             * This function can be used to open an XML document with a document element 
             * (the first element in the file) named 'needsCriteria' 
             * e.g. 
             *
             * <?xml version="1.0" encoding="UTF-8"?>
             * <needsCriteria>
             *     ...
             * </needsCriteria>
             * --------------------------------------------------------------------------------- */
            // SimpleTestns52NeedsCriteria(@"<UNCOMMENT & INSERT A SAMPLE XML FILENAME HERE>");

            /* ---------------------------------------------------------------------------------
             * This function can be used to open an XML document with a document element 
             * (the first element in the file) named 'OSZCode' 
             * e.g. 
             *
             * <?xml version="1.0" encoding="UTF-8"?>
             * <OSZCode>
             *     ...
             * </OSZCode>
             * --------------------------------------------------------------------------------- */
            // SimpleTestns52OSZCode(@"<UNCOMMENT & INSERT A SAMPLE XML FILENAME HERE>");

            /* ---------------------------------------------------------------------------------
             * This function can be used to open an XML document with a document element 
             * (the first element in the file) named 'package' 
             * e.g. 
             *
             * <?xml version="1.0" encoding="UTF-8"?>
             * <package>
             *     ...
             * </package>
             * --------------------------------------------------------------------------------- */
            // SimpleTestns51Package(@"<UNCOMMENT & INSERT A SAMPLE XML FILENAME HERE>");

            /* ---------------------------------------------------------------------------------
             * This function can be used to open an XML document with a document element 
             * (the first element in the file) named 'PassportRF' 
             * e.g. 
             *
             * <?xml version="1.0" encoding="UTF-8"?>
             * <PassportRF>
             *     ...
             * </PassportRF>
             * --------------------------------------------------------------------------------- */
            // SimpleTestns54PassportRF(@"<UNCOMMENT & INSERT A SAMPLE XML FILENAME HERE>");

            /* ---------------------------------------------------------------------------------
             * This function can be used to open an XML document with a document element 
             * (the first element in the file) named 'Patronymic' 
             * e.g. 
             *
             * <?xml version="1.0" encoding="UTF-8"?>
             * <Patronymic>
             *     ...
             * </Patronymic>
             * --------------------------------------------------------------------------------- */
            // SimpleTestns33Patronymic(@"<UNCOMMENT & INSERT A SAMPLE XML FILENAME HERE>");

            /* ---------------------------------------------------------------------------------
             * This function can be used to open an XML document with a document element 
             * (the first element in the file) named 'prsnInfo' 
             * e.g. 
             *
             * <?xml version="1.0" encoding="UTF-8"?>
             * <prsnInfo>
             *     ...
             * </prsnInfo>
             * --------------------------------------------------------------------------------- */
            // SimpleTestns53PrsnInfo(@"<UNCOMMENT & INSERT A SAMPLE XML FILENAME HERE>");

            /* ---------------------------------------------------------------------------------
             * This function can be used to open an XML document with a document element 
             * (the first element in the file) named 'reason_persons' 
             * e.g. 
             *
             * <?xml version="1.0" encoding="UTF-8"?>
             * <reason_persons>
             *     ...
             * </reason_persons>
             * --------------------------------------------------------------------------------- */
            // SimpleTestns52Reason_persons(@"<UNCOMMENT & INSERT A SAMPLE XML FILENAME HERE>");

            /* ---------------------------------------------------------------------------------
             * This function can be used to open an XML document with a document element 
             * (the first element in the file) named 'SNILS' 
             * e.g. 
             *
             * <?xml version="1.0" encoding="UTF-8"?>
             * <SNILS>
             *     ...
             * </SNILS>
             * --------------------------------------------------------------------------------- */
            // SimpleTestns53SNILS(@"<UNCOMMENT & INSERT A SAMPLE XML FILENAME HERE>");

            #endregion
            this.Cursor = Cursors.Default;
        }
        #endregion

        #region Sample Functions Demonstrating Reading from an XML File
        #region SimpleTestns52Assignment_info - Demo for documents with a root <assignment_info>
        // Shows a simple example of how the class Assignment_info
        // can be used. This class can be used to load documents whose 
        // root (document) element is <assignment_info>.
        private void SimpleTestns52Assignment_info(string filename)
        {
            try
            {
                // create an instance of the class to load the XML file into
                ns52.Assignment_info elm = new ns52.Assignment_info();

                // load the xml from a file into the object (the root element in the
                // xml document must be <assignment_info>.
                elm.FromXmlFile(filename);

                // This will open up a viewer, allowing you to navigate the classes
                // that have been generated. 
                // Note the veiwer can be used to modify properties, and provides a listing of
                // the code required to create the document it is displaying.
                SimpleViewer sv = new SimpleViewer(elm);
                sv.ShowDialog();

                // You can then add code to navigate the data held in the class.
                // When navigating this object model you should refer to the documentation
                // generated in the directory:
                // C:\Users\peter\Documents\Visual Studio 2017\Projects\egisso_\schema0.xsd.Output\DocumentationCS\.
                // The help should be compiled into a chm before being used, (use build.bat)
                //- HTML Help Workshop is required to perform this,
                // and can be downloaded from Microsoft. The path to the help compiler (hhc.exe) 
                // may need adjusting in build.bat

                // ...

                ////////////////////////////////////////////////////////////////////				
                // The Xml can be extracted from the class using one of 3 methods; //
                ////////////////////////////////////////////////////////////////////

                // This method will extract the xml into a string. The string is always encoded 
                // using Unicode, there a number of options allowing the headers, 
                // end of line & indenting to be set.
                string strXml = elm.ToXml();
                Console.WriteLine(strXml);

                // This method will extract the xml into a file. This method provides options
                // for changing the encoding (UTF-8, UTF-16) as well as headers, 
                // end of line and indenting.
                elm.ToXmlFile(filename + ".testouput.xml");

                // This method will extract the xml into a stream. This method provides options
                // for changing the encoding (UTF-8, UTF-16) as well as headers, 
                // end of line and indenting.
                // This method is useful when a specific encoding is required (typically
                // UTF-8), in order to transmit it over an 8-bit connection, smtp etc
                // without the need to write the xml to file first.
                System.IO.Stream stmXml = elm.ToXmlStream();

            }
            catch (Exception e)
            {
                DisplayError(e);
            }
        }
        #endregion
        #region SimpleTestns54BirthCertificate - Demo for documents with a root <BirthCertificate>
        // Shows a simple example of how the class BirthCertificate
        // can be used. This class can be used to load documents whose 
        // root (document) element is <BirthCertificate>.
        private void SimpleTestns54BirthCertificate(string filename)
        {
            try
            {
                // create an instance of the class to load the XML file into
                ns54.BirthCertificate elm = new ns54.BirthCertificate();

                // load the xml from a file into the object (the root element in the
                // xml document must be <BirthCertificate>.
                elm.FromXmlFile(filename);

                // This will open up a viewer, allowing you to navigate the classes
                // that have been generated. 
                // Note the veiwer can be used to modify properties, and provides a listing of
                // the code required to create the document it is displaying.
                SimpleViewer sv = new SimpleViewer(elm);
                sv.ShowDialog();

                // You can then add code to navigate the data held in the class.
                // When navigating this object model you should refer to the documentation
                // generated in the directory:
                // C:\Users\peter\Documents\Visual Studio 2017\Projects\egisso_\schema0.xsd.Output\DocumentationCS\.
                // The help should be compiled into a chm before being used, (use build.bat)
                //- HTML Help Workshop is required to perform this,
                // and can be downloaded from Microsoft. The path to the help compiler (hhc.exe) 
                // may need adjusting in build.bat

                // ...

                ////////////////////////////////////////////////////////////////////				
                // The Xml can be extracted from the class using one of 3 methods; //
                ////////////////////////////////////////////////////////////////////

                // This method will extract the xml into a string. The string is always encoded 
                // using Unicode, there a number of options allowing the headers, 
                // end of line & indenting to be set.
                string strXml = elm.ToXml();
                Console.WriteLine(strXml);

                // This method will extract the xml into a file. This method provides options
                // for changing the encoding (UTF-8, UTF-16) as well as headers, 
                // end of line and indenting.
                elm.ToXmlFile(filename + ".testouput.xml");

                // This method will extract the xml into a stream. This method provides options
                // for changing the encoding (UTF-8, UTF-16) as well as headers, 
                // end of line and indenting.
                // This method is useful when a specific encoding is required (typically
                // UTF-8), in order to transmit it over an 8-bit connection, smtp etc
                // without the need to write the xml to file first.
                System.IO.Stream stmXml = elm.ToXmlStream();

            }
            catch (Exception e)
            {
                DisplayError(e);
            }
        }
        #endregion
        #region SimpleTestns53BirthDate - Demo for documents with a root <BirthDate>
        // Shows a simple example of how the class BirthDate
        // can be used. This class can be used to load documents whose 
        // root (document) element is <BirthDate>.
        private void SimpleTestns53BirthDate(string filename)
        {
            try
            {
                // create an instance of the class to load the XML file into
                ns53.BirthDate elm = new ns53.BirthDate();

                // load the xml from a file into the object (the root element in the
                // xml document must be <BirthDate>.
                elm.FromXmlFile(filename);

                // This will open up a viewer, allowing you to navigate the classes
                // that have been generated. 
                // Note the veiwer can be used to modify properties, and provides a listing of
                // the code required to create the document it is displaying.
                SimpleViewer sv = new SimpleViewer(elm);
                sv.ShowDialog();

                // You can then add code to navigate the data held in the class.
                // When navigating this object model you should refer to the documentation
                // generated in the directory:
                // C:\Users\peter\Documents\Visual Studio 2017\Projects\egisso_\schema0.xsd.Output\DocumentationCS\.
                // The help should be compiled into a chm before being used, (use build.bat)
                //- HTML Help Workshop is required to perform this,
                // and can be downloaded from Microsoft. The path to the help compiler (hhc.exe) 
                // may need adjusting in build.bat

                // ...

                ////////////////////////////////////////////////////////////////////				
                // The Xml can be extracted from the class using one of 3 methods; //
                ////////////////////////////////////////////////////////////////////

                // This method will extract the xml into a string. The string is always encoded 
                // using Unicode, there a number of options allowing the headers, 
                // end of line & indenting to be set.
                string strXml = elm.ToXml();
                Console.WriteLine(strXml);

                // This method will extract the xml into a file. This method provides options
                // for changing the encoding (UTF-8, UTF-16) as well as headers, 
                // end of line and indenting.
                elm.ToXmlFile(filename + ".testouput.xml");

                // This method will extract the xml into a stream. This method provides options
                // for changing the encoding (UTF-8, UTF-16) as well as headers, 
                // end of line and indenting.
                // This method is useful when a specific encoding is required (typically
                // UTF-8), in order to transmit it over an 8-bit connection, smtp etc
                // without the need to write the xml to file first.
                System.IO.Stream stmXml = elm.ToXmlStream();

            }
            catch (Exception e)
            {
                DisplayError(e);
            }
        }
        #endregion
        #region SimpleTestns52CategoryID - Demo for documents with a root <categoryID>
        // Shows a simple example of how the class CategoryID
        // can be used. This class can be used to load documents whose 
        // root (document) element is <categoryID>.
        private void SimpleTestns52CategoryID(string filename)
        {
            try
            {
                // create an instance of the class to load the XML file into
                ns52.CategoryID elm = new ns52.CategoryID();

                // load the xml from a file into the object (the root element in the
                // xml document must be <categoryID>.
                elm.FromXmlFile(filename);

                // This will open up a viewer, allowing you to navigate the classes
                // that have been generated. 
                // Note the veiwer can be used to modify properties, and provides a listing of
                // the code required to create the document it is displaying.
                SimpleViewer sv = new SimpleViewer(elm);
                sv.ShowDialog();

                // You can then add code to navigate the data held in the class.
                // When navigating this object model you should refer to the documentation
                // generated in the directory:
                // C:\Users\peter\Documents\Visual Studio 2017\Projects\egisso_\schema0.xsd.Output\DocumentationCS\.
                // The help should be compiled into a chm before being used, (use build.bat)
                //- HTML Help Workshop is required to perform this,
                // and can be downloaded from Microsoft. The path to the help compiler (hhc.exe) 
                // may need adjusting in build.bat

                // ...

                ////////////////////////////////////////////////////////////////////				
                // The Xml can be extracted from the class using one of 3 methods; //
                ////////////////////////////////////////////////////////////////////

                // This method will extract the xml into a string. The string is always encoded 
                // using Unicode, there a number of options allowing the headers, 
                // end of line & indenting to be set.
                string strXml = elm.ToXml();
                Console.WriteLine(strXml);

                // This method will extract the xml into a file. This method provides options
                // for changing the encoding (UTF-8, UTF-16) as well as headers, 
                // end of line and indenting.
                elm.ToXmlFile(filename + ".testouput.xml");

                // This method will extract the xml into a stream. This method provides options
                // for changing the encoding (UTF-8, UTF-16) as well as headers, 
                // end of line and indenting.
                // This method is useful when a specific encoding is required (typically
                // UTF-8), in order to transmit it over an 8-bit connection, smtp etc
                // without the need to write the xml to file first.
                System.IO.Stream stmXml = elm.ToXmlStream();

            }
            catch (Exception e)
            {
                DisplayError(e);
            }
        }
        #endregion
        #region SimpleTestns55Data - Demo for documents with a root <data>
        // Shows a simple example of how the class Data
        // can be used. This class can be used to load documents whose 
        // root (document) element is <data>.
        private void SimpleTestns55Data(string filename)
        {
            try
            {
                // create an instance of the class to load the XML file into
                ns55.Data elm = new ns55.Data();

                // load the xml from a file into the object (the root element in the
                // xml document must be <data>.
                elm.FromXmlFile(filename);

                // This will open up a viewer, allowing you to navigate the classes
                // that have been generated. 
                // Note the veiwer can be used to modify properties, and provides a listing of
                // the code required to create the document it is displaying.
                SimpleViewer sv = new SimpleViewer(elm);
                sv.ShowDialog();

                // You can then add code to navigate the data held in the class.
                // When navigating this object model you should refer to the documentation
                // generated in the directory:
                // C:\Users\peter\Documents\Visual Studio 2017\Projects\egisso_\schema0.xsd.Output\DocumentationCS\.
                // The help should be compiled into a chm before being used, (use build.bat)
                //- HTML Help Workshop is required to perform this,
                // and can be downloaded from Microsoft. The path to the help compiler (hhc.exe) 
                // may need adjusting in build.bat

                // ...

                ////////////////////////////////////////////////////////////////////				
                // The Xml can be extracted from the class using one of 3 methods; //
                ////////////////////////////////////////////////////////////////////

                // This method will extract the xml into a string. The string is always encoded 
                // using Unicode, there a number of options allowing the headers, 
                // end of line & indenting to be set.
                string strXml = elm.ToXml();
                Console.WriteLine(strXml);

                // This method will extract the xml into a file. This method provides options
                // for changing the encoding (UTF-8, UTF-16) as well as headers, 
                // end of line and indenting.
                elm.ToXmlFile(filename + ".testouput.xml");

                // This method will extract the xml into a stream. This method provides options
                // for changing the encoding (UTF-8, UTF-16) as well as headers, 
                // end of line and indenting.
                // This method is useful when a specific encoding is required (typically
                // UTF-8), in order to transmit it over an 8-bit connection, smtp etc
                // without the need to write the xml to file first.
                System.IO.Stream stmXml = elm.ToXmlStream();

            }
            catch (Exception e)
            {
                DisplayError(e);
            }
        }
        #endregion
        #region SimpleTestns52DateFinish - Demo for documents with a root <dateFinish>
        // Shows a simple example of how the class DateFinish
        // can be used. This class can be used to load documents whose 
        // root (document) element is <dateFinish>.
        private void SimpleTestns52DateFinish(string filename)
        {
            try
            {
                // create an instance of the class to load the XML file into
                ns52.DateFinish elm = new ns52.DateFinish();

                // load the xml from a file into the object (the root element in the
                // xml document must be <dateFinish>.
                elm.FromXmlFile(filename);

                // This will open up a viewer, allowing you to navigate the classes
                // that have been generated. 
                // Note the veiwer can be used to modify properties, and provides a listing of
                // the code required to create the document it is displaying.
                SimpleViewer sv = new SimpleViewer(elm);
                sv.ShowDialog();

                // You can then add code to navigate the data held in the class.
                // When navigating this object model you should refer to the documentation
                // generated in the directory:
                // C:\Users\peter\Documents\Visual Studio 2017\Projects\egisso_\schema0.xsd.Output\DocumentationCS\.
                // The help should be compiled into a chm before being used, (use build.bat)
                //- HTML Help Workshop is required to perform this,
                // and can be downloaded from Microsoft. The path to the help compiler (hhc.exe) 
                // may need adjusting in build.bat

                // ...

                ////////////////////////////////////////////////////////////////////				
                // The Xml can be extracted from the class using one of 3 methods; //
                ////////////////////////////////////////////////////////////////////

                // This method will extract the xml into a string. The string is always encoded 
                // using Unicode, there a number of options allowing the headers, 
                // end of line & indenting to be set.
                string strXml = elm.ToXml();
                Console.WriteLine(strXml);

                // This method will extract the xml into a file. This method provides options
                // for changing the encoding (UTF-8, UTF-16) as well as headers, 
                // end of line and indenting.
                elm.ToXmlFile(filename + ".testouput.xml");

                // This method will extract the xml into a stream. This method provides options
                // for changing the encoding (UTF-8, UTF-16) as well as headers, 
                // end of line and indenting.
                // This method is useful when a specific encoding is required (typically
                // UTF-8), in order to transmit it over an 8-bit connection, smtp etc
                // without the need to write the xml to file first.
                System.IO.Stream stmXml = elm.ToXmlStream();

            }
            catch (Exception e)
            {
                DisplayError(e);
            }
        }
        #endregion
        #region SimpleTestns52DateStart - Demo for documents with a root <dateStart>
        // Shows a simple example of how the class DateStart
        // can be used. This class can be used to load documents whose 
        // root (document) element is <dateStart>.
        private void SimpleTestns52DateStart(string filename)
        {
            try
            {
                // create an instance of the class to load the XML file into
                ns52.DateStart elm = new ns52.DateStart();

                // load the xml from a file into the object (the root element in the
                // xml document must be <dateStart>.
                elm.FromXmlFile(filename);

                // This will open up a viewer, allowing you to navigate the classes
                // that have been generated. 
                // Note the veiwer can be used to modify properties, and provides a listing of
                // the code required to create the document it is displaying.
                SimpleViewer sv = new SimpleViewer(elm);
                sv.ShowDialog();

                // You can then add code to navigate the data held in the class.
                // When navigating this object model you should refer to the documentation
                // generated in the directory:
                // C:\Users\peter\Documents\Visual Studio 2017\Projects\egisso_\schema0.xsd.Output\DocumentationCS\.
                // The help should be compiled into a chm before being used, (use build.bat)
                //- HTML Help Workshop is required to perform this,
                // and can be downloaded from Microsoft. The path to the help compiler (hhc.exe) 
                // may need adjusting in build.bat

                // ...

                ////////////////////////////////////////////////////////////////////				
                // The Xml can be extracted from the class using one of 3 methods; //
                ////////////////////////////////////////////////////////////////////

                // This method will extract the xml into a string. The string is always encoded 
                // using Unicode, there a number of options allowing the headers, 
                // end of line & indenting to be set.
                string strXml = elm.ToXml();
                Console.WriteLine(strXml);

                // This method will extract the xml into a file. This method provides options
                // for changing the encoding (UTF-8, UTF-16) as well as headers, 
                // end of line and indenting.
                elm.ToXmlFile(filename + ".testouput.xml");

                // This method will extract the xml into a stream. This method provides options
                // for changing the encoding (UTF-8, UTF-16) as well as headers, 
                // end of line and indenting.
                // This method is useful when a specific encoding is required (typically
                // UTF-8), in order to transmit it over an 8-bit connection, smtp etc
                // without the need to write the xml to file first.
                System.IO.Stream stmXml = elm.ToXmlStream();

            }
            catch (Exception e)
            {
                DisplayError(e);
            }
        }
        #endregion
        #region SimpleTestns52Decision_date - Demo for documents with a root <decision_date>
        // Shows a simple example of how the class Decision_date
        // can be used. This class can be used to load documents whose 
        // root (document) element is <decision_date>.
        private void SimpleTestns52Decision_date(string filename)
        {
            try
            {
                // create an instance of the class to load the XML file into
                ns52.Decision_date elm = new ns52.Decision_date();

                // load the xml from a file into the object (the root element in the
                // xml document must be <decision_date>.
                elm.FromXmlFile(filename);

                // This will open up a viewer, allowing you to navigate the classes
                // that have been generated. 
                // Note the veiwer can be used to modify properties, and provides a listing of
                // the code required to create the document it is displaying.
                SimpleViewer sv = new SimpleViewer(elm);
                sv.ShowDialog();

                // You can then add code to navigate the data held in the class.
                // When navigating this object model you should refer to the documentation
                // generated in the directory:
                // C:\Users\peter\Documents\Visual Studio 2017\Projects\egisso_\schema0.xsd.Output\DocumentationCS\.
                // The help should be compiled into a chm before being used, (use build.bat)
                //- HTML Help Workshop is required to perform this,
                // and can be downloaded from Microsoft. The path to the help compiler (hhc.exe) 
                // may need adjusting in build.bat

                // ...

                ////////////////////////////////////////////////////////////////////				
                // The Xml can be extracted from the class using one of 3 methods; //
                ////////////////////////////////////////////////////////////////////

                // This method will extract the xml into a string. The string is always encoded 
                // using Unicode, there a number of options allowing the headers, 
                // end of line & indenting to be set.
                string strXml = elm.ToXml();
                Console.WriteLine(strXml);

                // This method will extract the xml into a file. This method provides options
                // for changing the encoding (UTF-8, UTF-16) as well as headers, 
                // end of line and indenting.
                elm.ToXmlFile(filename + ".testouput.xml");

                // This method will extract the xml into a stream. This method provides options
                // for changing the encoding (UTF-8, UTF-16) as well as headers, 
                // end of line and indenting.
                // This method is useful when a specific encoding is required (typically
                // UTF-8), in order to transmit it over an 8-bit connection, smtp etc
                // without the need to write the xml to file first.
                System.IO.Stream stmXml = elm.ToXmlStream();

            }
            catch (Exception e)
            {
                DisplayError(e);
            }
        }
        #endregion
        #region SimpleTestns33FamilyName - Demo for documents with a root <FamilyName>
        // Shows a simple example of how the class FamilyName
        // can be used. This class can be used to load documents whose 
        // root (document) element is <FamilyName>.
        private void SimpleTestns33FamilyName(string filename)
        {
            try
            {
                // create an instance of the class to load the XML file into
                ns33.FamilyName elm = new ns33.FamilyName();

                // load the xml from a file into the object (the root element in the
                // xml document must be <FamilyName>.
                elm.FromXmlFile(filename);

                // This will open up a viewer, allowing you to navigate the classes
                // that have been generated. 
                // Note the veiwer can be used to modify properties, and provides a listing of
                // the code required to create the document it is displaying.
                SimpleViewer sv = new SimpleViewer(elm);
                sv.ShowDialog();

                // You can then add code to navigate the data held in the class.
                // When navigating this object model you should refer to the documentation
                // generated in the directory:
                // C:\Users\peter\Documents\Visual Studio 2017\Projects\egisso_\schema0.xsd.Output\DocumentationCS\.
                // The help should be compiled into a chm before being used, (use build.bat)
                //- HTML Help Workshop is required to perform this,
                // and can be downloaded from Microsoft. The path to the help compiler (hhc.exe) 
                // may need adjusting in build.bat

                // ...

                ////////////////////////////////////////////////////////////////////				
                // The Xml can be extracted from the class using one of 3 methods; //
                ////////////////////////////////////////////////////////////////////

                // This method will extract the xml into a string. The string is always encoded 
                // using Unicode, there a number of options allowing the headers, 
                // end of line & indenting to be set.
                string strXml = elm.ToXml();
                Console.WriteLine(strXml);

                // This method will extract the xml into a file. This method provides options
                // for changing the encoding (UTF-8, UTF-16) as well as headers, 
                // end of line and indenting.
                elm.ToXmlFile(filename + ".testouput.xml");

                // This method will extract the xml into a stream. This method provides options
                // for changing the encoding (UTF-8, UTF-16) as well as headers, 
                // end of line and indenting.
                // This method is useful when a specific encoding is required (typically
                // UTF-8), in order to transmit it over an 8-bit connection, smtp etc
                // without the need to write the xml to file first.
                System.IO.Stream stmXml = elm.ToXmlStream();

            }
            catch (Exception e)
            {
                DisplayError(e);
            }
        }
        #endregion
        #region SimpleTestns33FirstName - Demo for documents with a root <FirstName>
        // Shows a simple example of how the class FirstName
        // can be used. This class can be used to load documents whose 
        // root (document) element is <FirstName>.
        private void SimpleTestns33FirstName(string filename)
        {
            try
            {
                // create an instance of the class to load the XML file into
                ns33.FirstName elm = new ns33.FirstName();

                // load the xml from a file into the object (the root element in the
                // xml document must be <FirstName>.
                elm.FromXmlFile(filename);

                // This will open up a viewer, allowing you to navigate the classes
                // that have been generated. 
                // Note the veiwer can be used to modify properties, and provides a listing of
                // the code required to create the document it is displaying.
                SimpleViewer sv = new SimpleViewer(elm);
                sv.ShowDialog();

                // You can then add code to navigate the data held in the class.
                // When navigating this object model you should refer to the documentation
                // generated in the directory:
                // C:\Users\peter\Documents\Visual Studio 2017\Projects\egisso_\schema0.xsd.Output\DocumentationCS\.
                // The help should be compiled into a chm before being used, (use build.bat)
                //- HTML Help Workshop is required to perform this,
                // and can be downloaded from Microsoft. The path to the help compiler (hhc.exe) 
                // may need adjusting in build.bat

                // ...

                ////////////////////////////////////////////////////////////////////				
                // The Xml can be extracted from the class using one of 3 methods; //
                ////////////////////////////////////////////////////////////////////

                // This method will extract the xml into a string. The string is always encoded 
                // using Unicode, there a number of options allowing the headers, 
                // end of line & indenting to be set.
                string strXml = elm.ToXml();
                Console.WriteLine(strXml);

                // This method will extract the xml into a file. This method provides options
                // for changing the encoding (UTF-8, UTF-16) as well as headers, 
                // end of line and indenting.
                elm.ToXmlFile(filename + ".testouput.xml");

                // This method will extract the xml into a stream. This method provides options
                // for changing the encoding (UTF-8, UTF-16) as well as headers, 
                // end of line and indenting.
                // This method is useful when a specific encoding is required (typically
                // UTF-8), in order to transmit it over an 8-bit connection, smtp etc
                // without the need to write the xml to file first.
                System.IO.Stream stmXml = elm.ToXmlStream();

            }
            catch (Exception e)
            {
                DisplayError(e);
            }
        }
        #endregion
        #region SimpleTestns53Gender - Demo for documents with a root <Gender>
        // Shows a simple example of how the class Gender
        // can be used. This class can be used to load documents whose 
        // root (document) element is <Gender>.
        private void SimpleTestns53Gender(string filename)
        {
            try
            {
                // create an instance of the class to load the XML file into
                ns53.Gender elm = new ns53.Gender();

                // load the xml from a file into the object (the root element in the
                // xml document must be <Gender>.
                elm.FromXmlFile(filename);

                // This will open up a viewer, allowing you to navigate the classes
                // that have been generated. 
                // Note the veiwer can be used to modify properties, and provides a listing of
                // the code required to create the document it is displaying.
                SimpleViewer sv = new SimpleViewer(elm);
                sv.ShowDialog();

                // You can then add code to navigate the data held in the class.
                // When navigating this object model you should refer to the documentation
                // generated in the directory:
                // C:\Users\peter\Documents\Visual Studio 2017\Projects\egisso_\schema0.xsd.Output\DocumentationCS\.
                // The help should be compiled into a chm before being used, (use build.bat)
                //- HTML Help Workshop is required to perform this,
                // and can be downloaded from Microsoft. The path to the help compiler (hhc.exe) 
                // may need adjusting in build.bat

                // ...

                ////////////////////////////////////////////////////////////////////				
                // The Xml can be extracted from the class using one of 3 methods; //
                ////////////////////////////////////////////////////////////////////

                // This method will extract the xml into a string. The string is always encoded 
                // using Unicode, there a number of options allowing the headers, 
                // end of line & indenting to be set.
                string strXml = elm.ToXml();
                Console.WriteLine(strXml);

                // This method will extract the xml into a file. This method provides options
                // for changing the encoding (UTF-8, UTF-16) as well as headers, 
                // end of line and indenting.
                elm.ToXmlFile(filename + ".testouput.xml");

                // This method will extract the xml into a stream. This method provides options
                // for changing the encoding (UTF-8, UTF-16) as well as headers, 
                // end of line and indenting.
                // This method is useful when a specific encoding is required (typically
                // UTF-8), in order to transmit it over an 8-bit connection, smtp etc
                // without the need to write the xml to file first.
                System.IO.Stream stmXml = elm.ToXmlStream();

            }
            catch (Exception e)
            {
                DisplayError(e);
            }
        }
        #endregion
        #region SimpleTestns52ID - Demo for documents with a root <ID>
        // Shows a simple example of how the class ID
        // can be used. This class can be used to load documents whose 
        // root (document) element is <ID>.
        private void SimpleTestns52ID(string filename)
        {
            try
            {
                // create an instance of the class to load the XML file into
                ns52.ID elm = new ns52.ID();

                // load the xml from a file into the object (the root element in the
                // xml document must be <ID>.
                elm.FromXmlFile(filename);

                // This will open up a viewer, allowing you to navigate the classes
                // that have been generated. 
                // Note the veiwer can be used to modify properties, and provides a listing of
                // the code required to create the document it is displaying.
                SimpleViewer sv = new SimpleViewer(elm);
                sv.ShowDialog();

                // You can then add code to navigate the data held in the class.
                // When navigating this object model you should refer to the documentation
                // generated in the directory:
                // C:\Users\peter\Documents\Visual Studio 2017\Projects\egisso_\schema0.xsd.Output\DocumentationCS\.
                // The help should be compiled into a chm before being used, (use build.bat)
                //- HTML Help Workshop is required to perform this,
                // and can be downloaded from Microsoft. The path to the help compiler (hhc.exe) 
                // may need adjusting in build.bat

                // ...

                ////////////////////////////////////////////////////////////////////				
                // The Xml can be extracted from the class using one of 3 methods; //
                ////////////////////////////////////////////////////////////////////

                // This method will extract the xml into a string. The string is always encoded 
                // using Unicode, there a number of options allowing the headers, 
                // end of line & indenting to be set.
                string strXml = elm.ToXml();
                Console.WriteLine(strXml);

                // This method will extract the xml into a file. This method provides options
                // for changing the encoding (UTF-8, UTF-16) as well as headers, 
                // end of line and indenting.
                elm.ToXmlFile(filename + ".testouput.xml");

                // This method will extract the xml into a stream. This method provides options
                // for changing the encoding (UTF-8, UTF-16) as well as headers, 
                // end of line and indenting.
                // This method is useful when a specific encoding is required (typically
                // UTF-8), in order to transmit it over an 8-bit connection, smtp etc
                // without the need to write the xml to file first.
                System.IO.Stream stmXml = elm.ToXmlStream();

            }
            catch (Exception e)
            {
                DisplayError(e);
            }
        }
        #endregion
        #region SimpleTestns53IdentityDoc - Demo for documents with a root <IdentityDoc>
        // Shows a simple example of how the class IdentityDoc
        // can be used. This class can be used to load documents whose 
        // root (document) element is <IdentityDoc>.
        private void SimpleTestns53IdentityDoc(string filename)
        {
            try
            {
                // create an instance of the class to load the XML file into
                ns53.IdentityDoc elm = new ns53.IdentityDoc();

                // load the xml from a file into the object (the root element in the
                // xml document must be <IdentityDoc>.
                elm.FromXmlFile(filename);

                // This will open up a viewer, allowing you to navigate the classes
                // that have been generated. 
                // Note the veiwer can be used to modify properties, and provides a listing of
                // the code required to create the document it is displaying.
                SimpleViewer sv = new SimpleViewer(elm);
                sv.ShowDialog();

                // You can then add code to navigate the data held in the class.
                // When navigating this object model you should refer to the documentation
                // generated in the directory:
                // C:\Users\peter\Documents\Visual Studio 2017\Projects\egisso_\schema0.xsd.Output\DocumentationCS\.
                // The help should be compiled into a chm before being used, (use build.bat)
                //- HTML Help Workshop is required to perform this,
                // and can be downloaded from Microsoft. The path to the help compiler (hhc.exe) 
                // may need adjusting in build.bat

                // ...

                ////////////////////////////////////////////////////////////////////				
                // The Xml can be extracted from the class using one of 3 methods; //
                ////////////////////////////////////////////////////////////////////

                // This method will extract the xml into a string. The string is always encoded 
                // using Unicode, there a number of options allowing the headers, 
                // end of line & indenting to be set.
                string strXml = elm.ToXml();
                Console.WriteLine(strXml);

                // This method will extract the xml into a file. This method provides options
                // for changing the encoding (UTF-8, UTF-16) as well as headers, 
                // end of line and indenting.
                elm.ToXmlFile(filename + ".testouput.xml");

                // This method will extract the xml into a stream. This method provides options
                // for changing the encoding (UTF-8, UTF-16) as well as headers, 
                // end of line and indenting.
                // This method is useful when a specific encoding is required (typically
                // UTF-8), in order to transmit it over an 8-bit connection, smtp etc
                // without the need to write the xml to file first.
                System.IO.Stream stmXml = elm.ToXmlStream();

            }
            catch (Exception e)
            {
                DisplayError(e);
            }
        }
        #endregion
        #region SimpleTestns52LMSZID - Demo for documents with a root <LMSZID>
        // Shows a simple example of how the class LMSZID
        // can be used. This class can be used to load documents whose 
        // root (document) element is <LMSZID>.
        private void SimpleTestns52LMSZID(string filename)
        {
            try
            {
                // create an instance of the class to load the XML file into
                ns52.LMSZID elm = new ns52.LMSZID();

                // load the xml from a file into the object (the root element in the
                // xml document must be <LMSZID>.
                elm.FromXmlFile(filename);

                // This will open up a viewer, allowing you to navigate the classes
                // that have been generated. 
                // Note the veiwer can be used to modify properties, and provides a listing of
                // the code required to create the document it is displaying.
                SimpleViewer sv = new SimpleViewer(elm);
                sv.ShowDialog();

                // You can then add code to navigate the data held in the class.
                // When navigating this object model you should refer to the documentation
                // generated in the directory:
                // C:\Users\peter\Documents\Visual Studio 2017\Projects\egisso_\schema0.xsd.Output\DocumentationCS\.
                // The help should be compiled into a chm before being used, (use build.bat)
                //- HTML Help Workshop is required to perform this,
                // and can be downloaded from Microsoft. The path to the help compiler (hhc.exe) 
                // may need adjusting in build.bat

                // ...

                ////////////////////////////////////////////////////////////////////				
                // The Xml can be extracted from the class using one of 3 methods; //
                ////////////////////////////////////////////////////////////////////

                // This method will extract the xml into a string. The string is always encoded 
                // using Unicode, there a number of options allowing the headers, 
                // end of line & indenting to be set.
                string strXml = elm.ToXml();
                Console.WriteLine(strXml);

                // This method will extract the xml into a file. This method provides options
                // for changing the encoding (UTF-8, UTF-16) as well as headers, 
                // end of line and indenting.
                elm.ToXmlFile(filename + ".testouput.xml");

                // This method will extract the xml into a stream. This method provides options
                // for changing the encoding (UTF-8, UTF-16) as well as headers, 
                // end of line and indenting.
                // This method is useful when a specific encoding is required (typically
                // UTF-8), in order to transmit it over an 8-bit connection, smtp etc
                // without the need to write the xml to file first.
                System.IO.Stream stmXml = elm.ToXmlStream();

            }
            catch (Exception e)
            {
                DisplayError(e);
            }
        }
        #endregion
        #region SimpleTestns52MSZ_receiver - Demo for documents with a root <MSZ_receiver>
        // Shows a simple example of how the class MSZ_receiver
        // can be used. This class can be used to load documents whose 
        // root (document) element is <MSZ_receiver>.
        private void SimpleTestns52MSZ_receiver(string filename)
        {
            try
            {
                // create an instance of the class to load the XML file into
                ns52.MSZ_receiver elm = new ns52.MSZ_receiver();

                // load the xml from a file into the object (the root element in the
                // xml document must be <MSZ_receiver>.
                elm.FromXmlFile(filename);

                // This will open up a viewer, allowing you to navigate the classes
                // that have been generated. 
                // Note the veiwer can be used to modify properties, and provides a listing of
                // the code required to create the document it is displaying.
                SimpleViewer sv = new SimpleViewer(elm);
                sv.ShowDialog();

                // You can then add code to navigate the data held in the class.
                // When navigating this object model you should refer to the documentation
                // generated in the directory:
                // C:\Users\peter\Documents\Visual Studio 2017\Projects\egisso_\schema0.xsd.Output\DocumentationCS\.
                // The help should be compiled into a chm before being used, (use build.bat)
                //- HTML Help Workshop is required to perform this,
                // and can be downloaded from Microsoft. The path to the help compiler (hhc.exe) 
                // may need adjusting in build.bat

                // ...

                ////////////////////////////////////////////////////////////////////				
                // The Xml can be extracted from the class using one of 3 methods; //
                ////////////////////////////////////////////////////////////////////

                // This method will extract the xml into a string. The string is always encoded 
                // using Unicode, there a number of options allowing the headers, 
                // end of line & indenting to be set.
                string strXml = elm.ToXml();
                Console.WriteLine(strXml);

                // This method will extract the xml into a file. This method provides options
                // for changing the encoding (UTF-8, UTF-16) as well as headers, 
                // end of line and indenting.
                elm.ToXmlFile(filename + ".testouput.xml");

                // This method will extract the xml into a stream. This method provides options
                // for changing the encoding (UTF-8, UTF-16) as well as headers, 
                // end of line and indenting.
                // This method is useful when a specific encoding is required (typically
                // UTF-8), in order to transmit it over an 8-bit connection, smtp etc
                // without the need to write the xml to file first.
                System.IO.Stream stmXml = elm.ToXmlStream();

            }
            catch (Exception e)
            {
                DisplayError(e);
            }
        }
        #endregion
        #region SimpleTestns52NeedsCriteria - Demo for documents with a root <needsCriteria>
        // Shows a simple example of how the class NeedsCriteria
        // can be used. This class can be used to load documents whose 
        // root (document) element is <needsCriteria>.
        private void SimpleTestns52NeedsCriteria(string filename)
        {
            try
            {
                // create an instance of the class to load the XML file into
                ns52.NeedsCriteria elm = new ns52.NeedsCriteria();

                // load the xml from a file into the object (the root element in the
                // xml document must be <needsCriteria>.
                elm.FromXmlFile(filename);

                // This will open up a viewer, allowing you to navigate the classes
                // that have been generated. 
                // Note the veiwer can be used to modify properties, and provides a listing of
                // the code required to create the document it is displaying.
                SimpleViewer sv = new SimpleViewer(elm);
                sv.ShowDialog();

                // You can then add code to navigate the data held in the class.
                // When navigating this object model you should refer to the documentation
                // generated in the directory:
                // C:\Users\peter\Documents\Visual Studio 2017\Projects\egisso_\schema0.xsd.Output\DocumentationCS\.
                // The help should be compiled into a chm before being used, (use build.bat)
                //- HTML Help Workshop is required to perform this,
                // and can be downloaded from Microsoft. The path to the help compiler (hhc.exe) 
                // may need adjusting in build.bat

                // ...

                ////////////////////////////////////////////////////////////////////				
                // The Xml can be extracted from the class using one of 3 methods; //
                ////////////////////////////////////////////////////////////////////

                // This method will extract the xml into a string. The string is always encoded 
                // using Unicode, there a number of options allowing the headers, 
                // end of line & indenting to be set.
                string strXml = elm.ToXml();
                Console.WriteLine(strXml);

                // This method will extract the xml into a file. This method provides options
                // for changing the encoding (UTF-8, UTF-16) as well as headers, 
                // end of line and indenting.
                elm.ToXmlFile(filename + ".testouput.xml");

                // This method will extract the xml into a stream. This method provides options
                // for changing the encoding (UTF-8, UTF-16) as well as headers, 
                // end of line and indenting.
                // This method is useful when a specific encoding is required (typically
                // UTF-8), in order to transmit it over an 8-bit connection, smtp etc
                // without the need to write the xml to file first.
                System.IO.Stream stmXml = elm.ToXmlStream();

            }
            catch (Exception e)
            {
                DisplayError(e);
            }
        }
        #endregion
        #region SimpleTestns52OSZCode - Demo for documents with a root <OSZCode>
        // Shows a simple example of how the class OSZCode
        // can be used. This class can be used to load documents whose 
        // root (document) element is <OSZCode>.
        private void SimpleTestns52OSZCode(string filename)
        {
            try
            {
                // create an instance of the class to load the XML file into
                ns52.OSZCode elm = new ns52.OSZCode();

                // load the xml from a file into the object (the root element in the
                // xml document must be <OSZCode>.
                elm.FromXmlFile(filename);

                // This will open up a viewer, allowing you to navigate the classes
                // that have been generated. 
                // Note the veiwer can be used to modify properties, and provides a listing of
                // the code required to create the document it is displaying.
                SimpleViewer sv = new SimpleViewer(elm);
                sv.ShowDialog();

                // You can then add code to navigate the data held in the class.
                // When navigating this object model you should refer to the documentation
                // generated in the directory:
                // C:\Users\peter\Documents\Visual Studio 2017\Projects\egisso_\schema0.xsd.Output\DocumentationCS\.
                // The help should be compiled into a chm before being used, (use build.bat)
                //- HTML Help Workshop is required to perform this,
                // and can be downloaded from Microsoft. The path to the help compiler (hhc.exe) 
                // may need adjusting in build.bat

                // ...

                ////////////////////////////////////////////////////////////////////				
                // The Xml can be extracted from the class using one of 3 methods; //
                ////////////////////////////////////////////////////////////////////

                // This method will extract the xml into a string. The string is always encoded 
                // using Unicode, there a number of options allowing the headers, 
                // end of line & indenting to be set.
                string strXml = elm.ToXml();
                Console.WriteLine(strXml);

                // This method will extract the xml into a file. This method provides options
                // for changing the encoding (UTF-8, UTF-16) as well as headers, 
                // end of line and indenting.
                elm.ToXmlFile(filename + ".testouput.xml");

                // This method will extract the xml into a stream. This method provides options
                // for changing the encoding (UTF-8, UTF-16) as well as headers, 
                // end of line and indenting.
                // This method is useful when a specific encoding is required (typically
                // UTF-8), in order to transmit it over an 8-bit connection, smtp etc
                // without the need to write the xml to file first.
                System.IO.Stream stmXml = elm.ToXmlStream();

            }
            catch (Exception e)
            {
                DisplayError(e);
            }
        }
        #endregion
        #region SimpleTestns51Package - Demo for documents with a root <package>
        // Shows a simple example of how the class Package
        // can be used. This class can be used to load documents whose 
        // root (document) element is <package>.
        private void SimpleTestns51Package(string filename)
        {
            try
            {
                // create an instance of the class to load the XML file into
                ns51.Package elm = new ns51.Package();

                // load the xml from a file into the object (the root element in the
                // xml document must be <package>.
                elm.FromXmlFile(filename);

                // This will open up a viewer, allowing you to navigate the classes
                // that have been generated. 
                // Note the veiwer can be used to modify properties, and provides a listing of
                // the code required to create the document it is displaying.
                SimpleViewer sv = new SimpleViewer(elm);
                sv.ShowDialog();

                // You can then add code to navigate the data held in the class.
                // When navigating this object model you should refer to the documentation
                // generated in the directory:
                // C:\Users\peter\Documents\Visual Studio 2017\Projects\egisso_\schema0.xsd.Output\DocumentationCS\.
                // The help should be compiled into a chm before being used, (use build.bat)
                //- HTML Help Workshop is required to perform this,
                // and can be downloaded from Microsoft. The path to the help compiler (hhc.exe) 
                // may need adjusting in build.bat

                // ...

                ////////////////////////////////////////////////////////////////////				
                // The Xml can be extracted from the class using one of 3 methods; //
                ////////////////////////////////////////////////////////////////////

                // This method will extract the xml into a string. The string is always encoded 
                // using Unicode, there a number of options allowing the headers, 
                // end of line & indenting to be set.
                string strXml = elm.ToXml();
                Console.WriteLine(strXml);

                // This method will extract the xml into a file. This method provides options
                // for changing the encoding (UTF-8, UTF-16) as well as headers, 
                // end of line and indenting.
                elm.ToXmlFile(filename + ".testouput.xml");

                // This method will extract the xml into a stream. This method provides options
                // for changing the encoding (UTF-8, UTF-16) as well as headers, 
                // end of line and indenting.
                // This method is useful when a specific encoding is required (typically
                // UTF-8), in order to transmit it over an 8-bit connection, smtp etc
                // without the need to write the xml to file first.
                System.IO.Stream stmXml = elm.ToXmlStream();

            }
            catch (Exception e)
            {
                DisplayError(e);
            }
        }
        #endregion
        #region SimpleTestns54PassportRF - Demo for documents with a root <PassportRF>
        // Shows a simple example of how the class PassportRF
        // can be used. This class can be used to load documents whose 
        // root (document) element is <PassportRF>.
        private void SimpleTestns54PassportRF(string filename)
        {
            try
            {
                // create an instance of the class to load the XML file into
                ns54.PassportRF elm = new ns54.PassportRF();

                // load the xml from a file into the object (the root element in the
                // xml document must be <PassportRF>.
                elm.FromXmlFile(filename);

                // This will open up a viewer, allowing you to navigate the classes
                // that have been generated. 
                // Note the veiwer can be used to modify properties, and provides a listing of
                // the code required to create the document it is displaying.
                SimpleViewer sv = new SimpleViewer(elm);
                sv.ShowDialog();

                // You can then add code to navigate the data held in the class.
                // When navigating this object model you should refer to the documentation
                // generated in the directory:
                // C:\Users\peter\Documents\Visual Studio 2017\Projects\egisso_\schema0.xsd.Output\DocumentationCS\.
                // The help should be compiled into a chm before being used, (use build.bat)
                //- HTML Help Workshop is required to perform this,
                // and can be downloaded from Microsoft. The path to the help compiler (hhc.exe) 
                // may need adjusting in build.bat

                // ...

                ////////////////////////////////////////////////////////////////////				
                // The Xml can be extracted from the class using one of 3 methods; //
                ////////////////////////////////////////////////////////////////////

                // This method will extract the xml into a string. The string is always encoded 
                // using Unicode, there a number of options allowing the headers, 
                // end of line & indenting to be set.
                string strXml = elm.ToXml();
                Console.WriteLine(strXml);

                // This method will extract the xml into a file. This method provides options
                // for changing the encoding (UTF-8, UTF-16) as well as headers, 
                // end of line and indenting.
                elm.ToXmlFile(filename + ".testouput.xml");

                // This method will extract the xml into a stream. This method provides options
                // for changing the encoding (UTF-8, UTF-16) as well as headers, 
                // end of line and indenting.
                // This method is useful when a specific encoding is required (typically
                // UTF-8), in order to transmit it over an 8-bit connection, smtp etc
                // without the need to write the xml to file first.
                System.IO.Stream stmXml = elm.ToXmlStream();

            }
            catch (Exception e)
            {
                DisplayError(e);
            }
        }
        #endregion
        #region SimpleTestns33Patronymic - Demo for documents with a root <Patronymic>
        // Shows a simple example of how the class Patronymic
        // can be used. This class can be used to load documents whose 
        // root (document) element is <Patronymic>.
        private void SimpleTestns33Patronymic(string filename)
        {
            try
            {
                // create an instance of the class to load the XML file into
                ns33.Patronymic elm = new ns33.Patronymic();

                // load the xml from a file into the object (the root element in the
                // xml document must be <Patronymic>.
                elm.FromXmlFile(filename);

                // This will open up a viewer, allowing you to navigate the classes
                // that have been generated. 
                // Note the veiwer can be used to modify properties, and provides a listing of
                // the code required to create the document it is displaying.
                SimpleViewer sv = new SimpleViewer(elm);
                sv.ShowDialog();

                // You can then add code to navigate the data held in the class.
                // When navigating this object model you should refer to the documentation
                // generated in the directory:
                // C:\Users\peter\Documents\Visual Studio 2017\Projects\egisso_\schema0.xsd.Output\DocumentationCS\.
                // The help should be compiled into a chm before being used, (use build.bat)
                //- HTML Help Workshop is required to perform this,
                // and can be downloaded from Microsoft. The path to the help compiler (hhc.exe) 
                // may need adjusting in build.bat

                // ...

                ////////////////////////////////////////////////////////////////////				
                // The Xml can be extracted from the class using one of 3 methods; //
                ////////////////////////////////////////////////////////////////////

                // This method will extract the xml into a string. The string is always encoded 
                // using Unicode, there a number of options allowing the headers, 
                // end of line & indenting to be set.
                string strXml = elm.ToXml();
                Console.WriteLine(strXml);

                // This method will extract the xml into a file. This method provides options
                // for changing the encoding (UTF-8, UTF-16) as well as headers, 
                // end of line and indenting.
                elm.ToXmlFile(filename + ".testouput.xml");

                // This method will extract the xml into a stream. This method provides options
                // for changing the encoding (UTF-8, UTF-16) as well as headers, 
                // end of line and indenting.
                // This method is useful when a specific encoding is required (typically
                // UTF-8), in order to transmit it over an 8-bit connection, smtp etc
                // without the need to write the xml to file first.
                System.IO.Stream stmXml = elm.ToXmlStream();

            }
            catch (Exception e)
            {
                DisplayError(e);
            }
        }
        #endregion
        #region SimpleTestns53PrsnInfo - Demo for documents with a root <prsnInfo>
        // Shows a simple example of how the class PrsnInfo
        // can be used. This class can be used to load documents whose 
        // root (document) element is <prsnInfo>.
        private void SimpleTestns53PrsnInfo(string filename)
        {
            try
            {
                // create an instance of the class to load the XML file into
                ns53.PrsnInfo elm = new ns53.PrsnInfo();

                // load the xml from a file into the object (the root element in the
                // xml document must be <prsnInfo>.
                elm.FromXmlFile(filename);

                // This will open up a viewer, allowing you to navigate the classes
                // that have been generated. 
                // Note the veiwer can be used to modify properties, and provides a listing of
                // the code required to create the document it is displaying.
                SimpleViewer sv = new SimpleViewer(elm);
                sv.ShowDialog();

                // You can then add code to navigate the data held in the class.
                // When navigating this object model you should refer to the documentation
                // generated in the directory:
                // C:\Users\peter\Documents\Visual Studio 2017\Projects\egisso_\schema0.xsd.Output\DocumentationCS\.
                // The help should be compiled into a chm before being used, (use build.bat)
                //- HTML Help Workshop is required to perform this,
                // and can be downloaded from Microsoft. The path to the help compiler (hhc.exe) 
                // may need adjusting in build.bat

                // ...

                ////////////////////////////////////////////////////////////////////				
                // The Xml can be extracted from the class using one of 3 methods; //
                ////////////////////////////////////////////////////////////////////

                // This method will extract the xml into a string. The string is always encoded 
                // using Unicode, there a number of options allowing the headers, 
                // end of line & indenting to be set.
                string strXml = elm.ToXml();
                Console.WriteLine(strXml);

                // This method will extract the xml into a file. This method provides options
                // for changing the encoding (UTF-8, UTF-16) as well as headers, 
                // end of line and indenting.
                elm.ToXmlFile(filename + ".testouput.xml");

                // This method will extract the xml into a stream. This method provides options
                // for changing the encoding (UTF-8, UTF-16) as well as headers, 
                // end of line and indenting.
                // This method is useful when a specific encoding is required (typically
                // UTF-8), in order to transmit it over an 8-bit connection, smtp etc
                // without the need to write the xml to file first.
                System.IO.Stream stmXml = elm.ToXmlStream();

            }
            catch (Exception e)
            {
                DisplayError(e);
            }
        }
        #endregion
        #region SimpleTestns52Reason_persons - Demo for documents with a root <reason_persons>
        // Shows a simple example of how the class Reason_persons
        // can be used. This class can be used to load documents whose 
        // root (document) element is <reason_persons>.
        private void SimpleTestns52Reason_persons(string filename)
        {
            try
            {
                // create an instance of the class to load the XML file into
                ns52.Reason_persons elm = new ns52.Reason_persons();

                // load the xml from a file into the object (the root element in the
                // xml document must be <reason_persons>.
                elm.FromXmlFile(filename);

                // This will open up a viewer, allowing you to navigate the classes
                // that have been generated. 
                // Note the veiwer can be used to modify properties, and provides a listing of
                // the code required to create the document it is displaying.
                SimpleViewer sv = new SimpleViewer(elm);
                sv.ShowDialog();

                // You can then add code to navigate the data held in the class.
                // When navigating this object model you should refer to the documentation
                // generated in the directory:
                // C:\Users\peter\Documents\Visual Studio 2017\Projects\egisso_\schema0.xsd.Output\DocumentationCS\.
                // The help should be compiled into a chm before being used, (use build.bat)
                //- HTML Help Workshop is required to perform this,
                // and can be downloaded from Microsoft. The path to the help compiler (hhc.exe) 
                // may need adjusting in build.bat

                // ...

                ////////////////////////////////////////////////////////////////////				
                // The Xml can be extracted from the class using one of 3 methods; //
                ////////////////////////////////////////////////////////////////////

                // This method will extract the xml into a string. The string is always encoded 
                // using Unicode, there a number of options allowing the headers, 
                // end of line & indenting to be set.
                string strXml = elm.ToXml();
                Console.WriteLine(strXml);

                // This method will extract the xml into a file. This method provides options
                // for changing the encoding (UTF-8, UTF-16) as well as headers, 
                // end of line and indenting.
                elm.ToXmlFile(filename + ".testouput.xml");

                // This method will extract the xml into a stream. This method provides options
                // for changing the encoding (UTF-8, UTF-16) as well as headers, 
                // end of line and indenting.
                // This method is useful when a specific encoding is required (typically
                // UTF-8), in order to transmit it over an 8-bit connection, smtp etc
                // without the need to write the xml to file first.
                System.IO.Stream stmXml = elm.ToXmlStream();

            }
            catch (Exception e)
            {
                DisplayError(e);
            }
        }
        #endregion
        #region SimpleTestns53SNILS - Demo for documents with a root <SNILS>
        // Shows a simple example of how the class SNILS
        // can be used. This class can be used to load documents whose 
        // root (document) element is <SNILS>.
        private void SimpleTestns53SNILS(string filename)
        {
            try
            {
                // create an instance of the class to load the XML file into
                ns53.SNILS elm = new ns53.SNILS();

                // load the xml from a file into the object (the root element in the
                // xml document must be <SNILS>.
                elm.FromXmlFile(filename);

                // This will open up a viewer, allowing you to navigate the classes
                // that have been generated. 
                // Note the veiwer can be used to modify properties, and provides a listing of
                // the code required to create the document it is displaying.
                SimpleViewer sv = new SimpleViewer(elm);
                sv.ShowDialog();

                // You can then add code to navigate the data held in the class.
                // When navigating this object model you should refer to the documentation
                // generated in the directory:
                // C:\Users\peter\Documents\Visual Studio 2017\Projects\egisso_\schema0.xsd.Output\DocumentationCS\.
                // The help should be compiled into a chm before being used, (use build.bat)
                //- HTML Help Workshop is required to perform this,
                // and can be downloaded from Microsoft. The path to the help compiler (hhc.exe) 
                // may need adjusting in build.bat

                // ...

                ////////////////////////////////////////////////////////////////////				
                // The Xml can be extracted from the class using one of 3 methods; //
                ////////////////////////////////////////////////////////////////////

                // This method will extract the xml into a string. The string is always encoded 
                // using Unicode, there a number of options allowing the headers, 
                // end of line & indenting to be set.
                string strXml = elm.ToXml();
                Console.WriteLine(strXml);

                // This method will extract the xml into a file. This method provides options
                // for changing the encoding (UTF-8, UTF-16) as well as headers, 
                // end of line and indenting.
                elm.ToXmlFile(filename + ".testouput.xml");

                // This method will extract the xml into a stream. This method provides options
                // for changing the encoding (UTF-8, UTF-16) as well as headers, 
                // end of line and indenting.
                // This method is useful when a specific encoding is required (typically
                // UTF-8), in order to transmit it over an 8-bit connection, smtp etc
                // without the need to write the xml to file first.
                System.IO.Stream stmXml = elm.ToXmlStream();

            }
            catch (Exception e)
            {
                DisplayError(e);
            }
        }
        #endregion

        #region SimpleTestLoadAnyXmlDocument
        // Shows a generic way to load up an XML document.
        private void SimpleTestLoadAnyXmlDocument(string filename)
        {
            try
            {
                // load the xml from a file into the object (the root element in the
                // xml document must be <ElmBaseElement>.
                LiquidTechnologies.Runtime.Net40.XmlObjectBase elm = schemaEgisso.ClassFactory.FromXmlFile(filename);

                // This will open up a viewer, allowing you to navigate the classes
                // that have been generated. 
                // Note the veiwer can be used to modify properties, and provides a listing of
                // the code required to create the document it is displaying.
                SimpleViewer sv = new SimpleViewer(elm);
                sv.ShowDialog();

                // You can then add code to navigate the data held in the class.
                // When navigating this object model you should refer to the documentation
                // generated in the directory:
                // C:\Users\peter\Documents\Visual Studio 2017\Projects\egisso_\schema0.xsd.Output\DocumentationCS\.
                // The help should be compiled into a chm before being used, (use build.bat)
                //- HTML Help Workshop is required to perform this,
                // and can be downloaded from Microsoft. The path to the help compiler (hhc.exe) 
                // may need adjusting in build.bat

                // ...

                ////////////////////////////////////////////////////////////////////				
                // The Xml can be extracted from the class using one of 3 methods; //
                ////////////////////////////////////////////////////////////////////

                // This method will extract the xml into a string. The string is always encoded 
                // using Unicode, there a number of options allowing the headers, 
                // end of line & indenting to be set.
                string strXml = elm.ToXml();
                Console.WriteLine(strXml);

                // This method will extract the xml into a file. This method provides options
                // for changing the encoding (UTF-8, UTF-16) as well as headers, 
                // end of line and indenting.
                elm.ToXmlFile(filename + ".testouput.xml");

                // This method will extract the xml into a stream. This method provides options
                // for changing the encoding (UTF-8, UTF-16) as well as headers, 
                // end of line and indenting.
                // This method is useful when a specific encoding is required (typically
                // UTF-8), in order to transmit it over an 8-bit connection, smtp etc
                // without the need to write the xml to file first.
                System.IO.Stream stmXml = elm.ToXmlStream();

            }
            catch (Exception e)
            {
                DisplayError(e);
            }
        }
        #endregion
        #endregion

        #region Error Handler
        private void DisplayError(Exception ex)
        {
            string errText = "Error - \n";
            // Note : exceptions are likely to contain inner exceptions
            // that provide further detail about the error.
            while (ex != null)
            {
                errText += ex.Message + "\n";
                ex = ex.InnerException;
            }
            MessageBox.Show(this, errText, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion

        #region Basic Form Plumbing
        #region SampleApp - Constructor
        public SampleApp()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }
        #endregion

        #region Dispose
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
        #endregion

        #region Main
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.Run(new SampleApp());
        }
        #endregion

        #region SampleApp_Load - Populates the list box
        private void SampleApp_Load(object sender, System.EventArgs e)
        {
            lblInfo.Text = "";
            lstFiles.Items.AddRange(new object[] {
                                                    "Browse for a File to Load"
                                                    });
            lstFiles.SelectedIndex = 0;
        }
        #endregion

        #region btnClose_Click
        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
        #endregion
        #endregion

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lstFiles = new System.Windows.Forms.ListBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimeGetter = new System.Windows.Forms.DateTimePicker();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(344, 174);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(96, 23);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Загрузить";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(344, 203);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(96, 24);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Закрыть";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.Location = new System.Drawing.Point(16, 16);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(424, 72);
            this.lblInfo.TabIndex = 0;
            // 
            // lstFiles
            // 
            this.lstFiles.HorizontalScrollbar = true;
            this.lstFiles.Location = new System.Drawing.Point(8, 174);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.Size = new System.Drawing.Size(328, 56);
            this.lstFiles.TabIndex = 1;
            this.lstFiles.DoubleClick += new System.EventHandler(this.btnLoad_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "xml";
            this.openFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(324, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "XML для ОФЛ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(324, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 40);
            this.button2.TabIndex = 5;
            this.button2.Text = "XML для Капремонта";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTimeGetter
            // 
            this.dateTimeGetter.CustomFormat = "MMMM yyyy";
            this.dateTimeGetter.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeGetter.Location = new System.Drawing.Point(32, 37);
            this.dateTimeGetter.Name = "dateTimeGetter";
            this.dateTimeGetter.Size = new System.Drawing.Size(164, 20);
            this.dateTimeGetter.TabIndex = 6;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(32, 91);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(116, 47);
            this.buttonLoad.TabIndex = 7;
            this.buttonLoad.Text = "Загрузка из файла";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // SampleApp
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(448, 246);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.dateTimeGetter);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstFiles);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLoad);
            this.Name = "SampleApp";
            this.Text = "ЕГИССО Агентство Субсидий РС(Я)";
            this.Load += new System.EventHandler(this.SampleApp_Load);
            this.ResumeLayout(false);

        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            //Это как должно быть пример
            //-----------------------------------------------------------------------------------------------------------
            //ns55.Data rt = new ns55.Data();
            //rt.Package = new schemaEgisso.Package();
            //rt.Package.PackageID = "7deea631-8d9d-46d6-83fe-fd88cda3267a";
            //rt.Package.Elements = new ns51.Elements();
            //ns51.Fact fact = new ns51.Fact();
            //rt.Package.Elements.Fact.Add(fact);
            //fact.ID = "0bdea799-f6ca-4abf-bb62-4cc60f26e012";
            //fact.OSZCode = "2472.000001";
            //fact.MSZ_receiver = new schemaEgisso.MSZ_receiver();
            //fact.MSZ_receiver.SNILS = "11111111111";
            //fact.MSZ_receiver.FamilyName = "Григорьева";
            //fact.MSZ_receiver.FirstName = "Нина";
            //fact.MSZ_receiver.Patronymic = "Степановна";
            //fact.MSZ_receiver.Gender = "Female";
            //fact.MSZ_receiver.BirthDate = new XmlParser().Parse("1935-01-01");
            //fact.MSZ_receiver.IdentityDoc = new schemaEgisso.IdentityDoc();
            //fact.MSZ_receiver.IdentityDoc.PassportRF = new schemaEgisso.PassportRF();
            //fact.MSZ_receiver.IdentityDoc.PassportRF.Series = "4305";
            //fact.MSZ_receiver.IdentityDoc.PassportRF.Number = "335638";
            //fact.MSZ_receiver.IdentityDoc.PassportRF.IssueDate = new XmlParser().Parse("2003-08-06");
            //fact.MSZ_receiver.IdentityDoc.PassportRF.Issuer = "Котельниковским о-м Люберецкого УВД МО";

            //fact.LMSZID = "4a382da4-6075-4500-8671-fc327c640275";
            //fact.CategoryID = "efd64fa2-cda9-45a7-90a1-bcfd600a03ff";
            //fact.Decision_date = new XmlParser().Parse("2018-01-01");
            //fact.DateStart = new XmlParser().Parse("2018-01-01");
            //fact.DateFinish = new XmlParser().Parse("2018-06-01");
            //fact.NeedsCriteria = new schemaEgisso.NeedsCriteria();
            //fact.NeedsCriteria.UsingSign = false;
            //fact.NeedsCriteria.Criteria = "";
            //fact.Assignment_info = new schemaEgisso.Assignment_info();

            //fact.Assignment_info.Monetary_form = new ns52.Monetary_form();
            //fact.Assignment_info.Monetary_form.Amount = "81,14";
            //fact.LastChanging = new XmlParser().ParseIso("2018-11-19T16:12:22");
            //ns51.Fact fact1 = new ns51.Fact();
            //rt.Package.Elements.Fact.Add(fact1);
            //fact1.ID = "e6dc8a5a-469b-479a-9c93-209c83f35bd4";
            //fact1.OSZCode = "2472.000001";
            //fact1.MSZ_receiver = new schemaEgisso.MSZ_receiver();
            //fact1.MSZ_receiver.SNILS = "22222222222";
            //fact1.MSZ_receiver.FamilyName = "Герасименко";
            //fact1.MSZ_receiver.FirstName = "Наталия";
            //fact1.MSZ_receiver.Patronymic = "Ивановна";
            //fact1.MSZ_receiver.Gender = "Female";
            //fact1.MSZ_receiver.BirthDate = new XmlParser().Parse("1965-06-28");
            //fact1.MSZ_receiver.IdentityDoc = new schemaEgisso.IdentityDoc();
            //fact1.MSZ_receiver.IdentityDoc.PassportRF = new schemaEgisso.PassportRF();
            //fact1.MSZ_receiver.IdentityDoc.PassportRF.Series = "4656";
            //fact1.MSZ_receiver.IdentityDoc.PassportRF.Number = "125979";
            //fact1.MSZ_receiver.IdentityDoc.PassportRF.IssueDate = new XmlParser().Parse("2011-07-09");
            //fact1.MSZ_receiver.IdentityDoc.PassportRF.Issuer = "ТП в г.Котельники ОУФМС России по Московской обл. в Люберецком районе";

            //fact1.LMSZID = "4a382da4-6075-4500-8671-fc327c640275";
            //fact1.CategoryID = "efd64fa2-cda9-45a7-90a1-bcfd600a03ff";
            //fact1.Decision_date = new XmlParser().Parse("2018-01-01");
            //fact1.DateStart = new XmlParser().Parse("2018-01-01");
            //fact1.DateFinish = new XmlParser().Parse("2018-07-01");
            //fact1.NeedsCriteria = new schemaEgisso.NeedsCriteria();
            //fact1.NeedsCriteria.UsingSign = false;
            //fact1.NeedsCriteria.Criteria = "";
            //fact1.Assignment_info = new schemaEgisso.Assignment_info();

            //fact1.Assignment_info.Monetary_form = new ns52.Monetary_form();
            //fact1.Assignment_info.Monetary_form.Amount = "1045,58";
            //fact1.LastChanging = new XmlParser().ParseIso("2018-11-19T16:12:22");
            //ns51.Fact fact2 = new ns51.Fact();
            //rt.Package.Elements.Fact.Add(fact2);
            //fact2.ID = "8f4d3384-99f3-4f16-befb-7190c065e9af";
            //fact2.OSZCode = "2472.000001";
            //fact2.MSZ_receiver = new schemaEgisso.MSZ_receiver();
            //fact2.MSZ_receiver.SNILS = "33333333333";
            //fact2.MSZ_receiver.FamilyName = "Крутой";
            //fact2.MSZ_receiver.FirstName = "Игорь";
            //fact2.MSZ_receiver.Patronymic = "Эдуардович";
            //fact2.MSZ_receiver.Gender = "Male";
            //fact2.MSZ_receiver.BirthDate = new XmlParser().Parse("1939-07-18");
            //fact2.MSZ_receiver.IdentityDoc = new schemaEgisso.IdentityDoc();
            //fact2.MSZ_receiver.IdentityDoc.PassportRF = new schemaEgisso.PassportRF();
            //fact2.MSZ_receiver.IdentityDoc.PassportRF.Series = "4471";
            //fact2.MSZ_receiver.IdentityDoc.PassportRF.Number = "654897";
            //fact2.MSZ_receiver.IdentityDoc.PassportRF.IssueDate = new XmlParser().Parse("2001-10-20");
            //fact2.MSZ_receiver.IdentityDoc.PassportRF.Issuer = "Котельниковским о-м Люберецкого УВД МО";
            //fact2.Reason_persons = new schemaEgisso.Reason_persons();
            //schemaEgisso.PrsnInfo prsnInfo = new schemaEgisso.PrsnInfo();

            //fact2.Reason_persons.PrsnInfo.Add(prsnInfo);
            //prsnInfo.SNILS = "77777777777";
            //prsnInfo.FamilyName = "Баубынская";
            //prsnInfo.FirstName = "Наталия";
            //prsnInfo.Patronymic = "Григорьевна";
            //prsnInfo.Gender = "Female";
            //prsnInfo.BirthDate = new XmlParser().Parse("1938-09-23");
            //prsnInfo.IdentityDoc = new ns53.IdentityDocA();

            //prsnInfo.IdentityDoc.PassportRF = new schemaEgisso.PassportRF();
            //prsnInfo.IdentityDoc.PassportRF.Series = "4225";
            //prsnInfo.IdentityDoc.PassportRF.Number = "335528";
            //prsnInfo.IdentityDoc.PassportRF.IssueDate = new XmlParser().Parse("2003-07-15");
            //prsnInfo.IdentityDoc.PassportRF.Issuer = "Котельниковским о-м Люберецкого УВД МО";

            //schemaEgisso.PrsnInfo prsnInfo1 = new schemaEgisso.PrsnInfo();
            //fact2.Reason_persons.PrsnInfo.Add(prsnInfo);
            //prsnInfo1.SNILS = "77777777777";
            //prsnInfo1.FamilyName = "Баубынская";
            //prsnInfo1.FirstName = "Наталия";
            //prsnInfo1.Patronymic = "Григорьевна";
            //prsnInfo1.Gender = "Female";
            //prsnInfo1.BirthDate = new XmlParser().Parse("1938-09-23");
            //prsnInfo1.IdentityDoc = new ns53.IdentityDocA();

            //prsnInfo1.IdentityDoc.BirthCertificate = new schemaEgisso.BirthCertificate();
            //prsnInfo1.IdentityDoc.BirthCertificate.Series = "III-СН";
            //prsnInfo1.IdentityDoc.BirthCertificate.Number = "335528";
            //prsnInfo1.IdentityDoc.BirthCertificate.IssueDate = new XmlParser().Parse("2003-07-15");
            //prsnInfo1.IdentityDoc.BirthCertificate.Issuer = "Котельниковским о-м Люберецкого УВД МО";

            //schemaEgisso.PrsnInfo prsnInfo2 = new schemaEgisso.PrsnInfo();
            //fact2.Reason_persons.PrsnInfo.Add(prsnInfo);
            //prsnInfo2.SNILS = "77777777777";
            //prsnInfo2.FamilyName = "Баубынская";
            //prsnInfo2.FirstName = "Наталия";
            //prsnInfo2.Patronymic = "Григорьевна";
            //prsnInfo2.Gender = "Female";
            //prsnInfo2.BirthDate = new XmlParser().Parse("1938-09-23");
            //prsnInfo2.IdentityDoc = new ns53.IdentityDocA();
            //prsnInfo2.IdentityDoc.BirthCertificate = new schemaEgisso.BirthCertificate();
            //prsnInfo2.IdentityDoc.BirthCertificate.Series = "III-СН";
            //prsnInfo2.IdentityDoc.BirthCertificate.Number = "335528";
            //prsnInfo2.IdentityDoc.BirthCertificate.IssueDate = new XmlParser().Parse("2003-07-15");
            //prsnInfo2.IdentityDoc.BirthCertificate.Issuer = "Котельниковским о-м Люберецкого УВД МО";


            //fact2.LMSZID = "4a382da4-6075-4500-8671-fc327c640275";
            //fact2.CategoryID = "efd64fa2-cda9-45a7-90a1-bcfd600a03ff";
            //fact2.Decision_date = new XmlParser().Parse("2018-01-01");
            //fact2.DateStart = new XmlParser().Parse("2018-01-01");
            //fact2.DateFinish = new XmlParser().Parse("2018-05-01");
            //fact2.NeedsCriteria = new schemaEgisso.NeedsCriteria();
            //fact2.NeedsCriteria.UsingSign = false;
            //fact2.NeedsCriteria.Criteria = "";
            //fact2.Assignment_info = new schemaEgisso.Assignment_info();
            //fact2.Assignment_info.ServiceForm = new ns52.ServiceForm();
            //fact2.Assignment_info.ServiceForm.Amount = "10";
            //fact2.Assignment_info.ServiceForm.MeasuryCode = "03";
            //fact2.Assignment_info.ServiceForm.Content = "Содержание";
            //fact2.Assignment_info.ServiceForm.Comment = "Комментарий";
            //fact2.Assignment_info.ServiceForm.EquivalentAmount = 982;
            ////       fact2.Assignment_info.Monetary_form = new ns52.Monetary_form();
            //fact2.LastChanging = new XmlParser().ParseIso("2018-11-19T16:12:22");
            //ns51.Fact fact3 = new ns51.Fact();
            //rt.Package.Elements.Fact.Add(fact3);
            //fact3.ID = "cf69db17-6fd7-44aa-ab43-e808fcf98ac4";
            //fact3.OSZCode = "2472.000001";
            //fact3.MSZ_receiver = new schemaEgisso.MSZ_receiver();
            //fact3.MSZ_receiver.SNILS = "44444444444";
            //fact3.MSZ_receiver.FamilyName = "Александрова";
            //fact3.MSZ_receiver.FirstName = "Анжела";
            //fact3.MSZ_receiver.Patronymic = "Николаевна";
            //fact3.MSZ_receiver.Gender = "Female";
            //fact3.MSZ_receiver.BirthDate = new XmlParser().Parse("1938-12-05");
            //fact3.MSZ_receiver.IdentityDoc = new schemaEgisso.IdentityDoc();
            //fact3.MSZ_receiver.IdentityDoc.PassportRF = new schemaEgisso.PassportRF();
            //fact3.MSZ_receiver.IdentityDoc.PassportRF.Series = "4622";
            //fact3.MSZ_receiver.IdentityDoc.PassportRF.Number = "672243";
            //fact3.MSZ_receiver.IdentityDoc.PassportRF.IssueDate = new XmlParser().Parse("2002-01-30");
            //fact3.MSZ_receiver.IdentityDoc.PassportRF.Issuer = "Котельниковским о-м Люберецкого УВД МО";

            //fact3.LMSZID = "4a382da4-6075-4500-8671-fc327c640275";
            //fact3.CategoryID = "efd64fa2-cda9-45a7-90a1-bcfd600a03ff";
            //fact3.Decision_date = new XmlParser().Parse("2018-01-01");
            //fact3.DateStart = new XmlParser().Parse("2018-01-01");
            //fact3.DateFinish = new XmlParser().Parse("2018-04-01");
            //fact3.NeedsCriteria = new schemaEgisso.NeedsCriteria();
            //fact3.NeedsCriteria.UsingSign = false;
            //fact3.NeedsCriteria.Criteria = "";
            //fact3.Assignment_info = new schemaEgisso.Assignment_info();

            //fact3.Assignment_info.Monetary_form = new ns52.Monetary_form();
            //fact3.Assignment_info.Monetary_form.Amount = "822,45";
            //fact3.LastChanging = new XmlParser().ParseIso("2018-11-19T16:12:22");
            //ns51.Fact fact4 = new ns51.Fact();
            //rt.Package.Elements.Fact.Add(fact4);
            //fact4.ID = "4a74b00d-666b-4907-b86c-52e1b6f29109";
            //fact4.OSZCode = "2472.000001";
            //fact4.MSZ_receiver = new schemaEgisso.MSZ_receiver();
            //fact4.MSZ_receiver.SNILS = "55555555555";
            //fact4.MSZ_receiver.FamilyName = "Бабанский";
            //fact4.MSZ_receiver.FirstName = "Евгений";
            //fact4.MSZ_receiver.Patronymic = "Сергеевич";
            //fact4.MSZ_receiver.Gender = "Male";
            //fact4.MSZ_receiver.BirthDate = new XmlParser().Parse("1939-01-15");
            //fact4.MSZ_receiver.IdentityDoc = new schemaEgisso.IdentityDoc();
            //fact4.MSZ_receiver.IdentityDoc.PassportRF = new schemaEgisso.PassportRF();
            //fact4.MSZ_receiver.IdentityDoc.PassportRF.Series = "4654";
            //fact4.MSZ_receiver.IdentityDoc.PassportRF.Number = "673332";
            //fact4.MSZ_receiver.IdentityDoc.PassportRF.IssueDate = new XmlParser().Parse("2002-01-30");
            //fact4.MSZ_receiver.IdentityDoc.PassportRF.Issuer = "Котельниковским о-м Люберецкого УВД МО";

            //fact4.LMSZID = "4a382da4-6075-4500-8671-fc327c640275";
            //fact4.CategoryID = "efd64fa2-cda9-45a7-90a1-bcfd600a03ff";
            //fact4.Decision_date = new XmlParser().Parse("2018-01-01");
            //fact4.DateStart = new XmlParser().Parse("2018-01-01");
            //fact4.DateFinish = new XmlParser().Parse("2018-03-01");
            //fact4.NeedsCriteria = new schemaEgisso.NeedsCriteria();
            //fact4.NeedsCriteria.UsingSign = false;
            //fact4.NeedsCriteria.Criteria = "";
            //fact4.Assignment_info = new schemaEgisso.Assignment_info();

            //fact4.Assignment_info.Monetary_form = new ns52.Monetary_form();
            //fact4.Assignment_info.Monetary_form.Amount = "1667,55";
            //fact4.LastChanging = new XmlParser().ParseIso("2018-11-19T16:12:22");

            //rt.ToXmlFile("1.xml");
            //--------------------------------------------------------------------------------------------------------
            //первоначальная загрузка данных - передаем ссылку на форму
            GetData getData = new GetDataOFL();
            List<Record> records = getData.Load(this);
            //Группировка по проживающим для выгрузки в XML


            List<RecordXML> recordsXml = new GetDataOFL().GetXMLRecords(records);
            ns55.Data rt = new ns55.Data();
            rt.Package = new schemaEgisso.Package();
            rt.Package.PackageID = Guid.NewGuid().ToString();

            rt.Package.Elements = new ns51.Elements();

            List<ns51.Fact> facts = new List<ns51.Fact>();
            foreach (RecordXML rec in recordsXml)
            {
                string gender = "";
                if (rec.GenderRecip == "Ж")
                {
                    gender = "Female";
                }
                else
                {
                    gender = "Male";
                }

                ns51.Fact fact = new ns51.Fact();
                fact.ID = Guid.NewGuid().ToString();

                fact.OSZCode = rec.OnmszCode;
                fact.MSZ_receiver = new schemaEgisso.MSZ_receiver();
                fact.MSZ_receiver.SNILS = rec.SnilsRecip;
                fact.MSZ_receiver.FamilyName = rec.FamilyNameRecip;
                fact.MSZ_receiver.FirstName = rec.NameRecip;
                if (rec.PatronymicRecip != "")
                    fact.MSZ_receiver.Patronymic = rec.PatronymicRecip;
                else
                    //ставим прочерк если нет отчества
                    fact.MSZ_receiver.Patronymic = "-";



                fact.MSZ_receiver.Gender = gender;
                fact.MSZ_receiver.BirthDate = new XmlDateTime((DateTime)rec.BirthDateRecip);
                fact.MSZ_receiver.IdentityDoc = new schemaEgisso.IdentityDoc();

                fact.MSZ_receiver.IdentityDoc.PassportRF = new schemaEgisso.PassportRF();
                fact.MSZ_receiver.IdentityDoc.PassportRF.Series = rec.DocSeriesRecip;
                fact.MSZ_receiver.IdentityDoc.PassportRF.Number = rec.DocNumberRecip;
                fact.MSZ_receiver.IdentityDoc.PassportRF.IssueDate = new XmlDateTime((DateTime)rec.DocIssueDateRecip);
                fact.MSZ_receiver.IdentityDoc.PassportRF.Issuer = rec.DocIssuerRecip;
                //если нету, то не ставим Reason_persons
                if (rec.prozhiv != null && rec.prozhiv.Count >= 1)
                {
                    fact.Reason_persons = new schemaEgisso.Reason_persons();

                    foreach (Prozhiv prozhiv in rec.prozhiv)
                    {
                        //закидываем проживающих по циклу


                        schemaEgisso.PrsnInfo prsnInfo = new schemaEgisso.PrsnInfo();

                        prsnInfo.SNILS = prozhiv.SnilsReason;
                        prsnInfo.FamilyName = prozhiv.FamilyNameReason;
                        prsnInfo.FirstName = prozhiv.NameReason;
                        if (prozhiv.PatronymicReason != "")
                            prsnInfo.Patronymic = prozhiv.PatronymicReason;



                        if (prozhiv.GenderReason == "Ж")
                        {
                            gender = "Female";
                        }
                        else
                        {
                            gender = "Male";
                        }
                        prsnInfo.Gender = gender;
                        prsnInfo.BirthDate = new XmlDateTime((DateTime)prozhiv.BirthdateReason);
                        prsnInfo.IdentityDoc = new ns53.IdentityDocA();
                        //если паспорт, считаем что идут только паспорта и свидетельства о рождении
                        if (prozhiv.DoctypeReason == "01")
                        {

                            prsnInfo.IdentityDoc.PassportRF = new schemaEgisso.PassportRF();
                            prsnInfo.IdentityDoc.PassportRF.Series = prozhiv.DocSeriesReason;
                            prsnInfo.IdentityDoc.PassportRF.Number = prozhiv.DocNumberReason;
                            prsnInfo.IdentityDoc.PassportRF.IssueDate = new XmlDateTime((DateTime)prozhiv.DocIssueDateReason);
                            prsnInfo.IdentityDoc.PassportRF.Issuer = prozhiv.DocIssuerReason;
                        }
                        else if (prozhiv.DoctypeReason == "05")
                        {
                            prsnInfo.IdentityDoc.BirthCertificate = new schemaEgisso.BirthCertificate();
                            prsnInfo.IdentityDoc.BirthCertificate.Series = prozhiv.DocSeriesReason;
                            prsnInfo.IdentityDoc.BirthCertificate.Number = prozhiv.DocNumberReason;
                            prsnInfo.IdentityDoc.BirthCertificate.IssueDate = new XmlDateTime((DateTime)prozhiv.DocIssueDateReason);
                            prsnInfo.IdentityDoc.BirthCertificate.Issuer = prozhiv.DocIssuerReason;
                        }
                        fact.Reason_persons.PrsnInfo.Add(prsnInfo);
                    }
                }

                fact.LMSZID = rec.LmszId;
                fact.CategoryID = rec.CategoryId;
                fact.Decision_date = new XmlDateTime((DateTime)rec.DecisionDate);
                fact.DateStart = new XmlDateTime((DateTime)rec.DateStart);
                fact.DateFinish = new XmlDateTime((DateTime)rec.DateFinish);
                fact.NeedsCriteria = new schemaEgisso.NeedsCriteria();
                fact.NeedsCriteria.UsingSign = false;
                fact.NeedsCriteria.Criteria = "";
                fact.Assignment_info = new schemaEgisso.Assignment_info();
                //   fact.Assignment_info.ServiceForm = new ns52.ServiceForm();
                fact.Assignment_info.Monetary_form = new ns52.Monetary_form();
                fact.Assignment_info.Monetary_form.Amount = rec.Amount.ToString();
                fact.LastChanging = new XmlDateTime(DateTime.Now);

                rt.Package.Elements.Fact.Add(fact);
            }
            if (rt.Package.Elements.Fact.Count == 0)
            {
                MessageBox.Show("Нет записей для выгрузки");
                return;
            }
            //ошибки выгрузки ОФЛ
            Dictionary<int, string> monthes = new GetDataOFL().Monthes();
            using (TextWriter writer = new StreamWriter("ошибки_выгрузки_ОФЛ.csv", false, Encoding.GetEncoding(1251)))
            {

                var csv = new CsvWriter(writer);
                csv.Configuration.Delimiter = ";";
                csv.WriteRecords(GetData.errorList); // where values implements IEnumerable
            }
            //f

            rt.ToXmlFile("0336_10.06.S_001ofl.xml");
            MessageBox.Show("Выгрузка файла для ОФЛ 0336_10.06.S_001ofl.xml была успешно выполнена.");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //первоначальная загрузка данных - передаем ссылку на форму

            GetData getData = new GetDataKaprem();
            List<Record> records = getData.Load(this);
            //Группировка по проживающим для выгрузки в XML
            List<RecordXML> recordsXml = new GetDataKaprem().GetXMLRecords(records);
            ns55.Data rt = new ns55.Data();
            rt.Package = new schemaEgisso.Package();
            rt.Package.PackageID = Guid.NewGuid().ToString();
            //rt.Package.PackageID = "7deea631-8d9d-46d6-83fe-fd88cda3267a";
            rt.Package.Elements = new ns51.Elements();

            List<ns51.Fact> facts = new List<ns51.Fact>();
            foreach (RecordXML rec in recordsXml)
            {
                string gender = "";
                if (rec.GenderRecip == "Ж")
                {
                    gender = "Female";
                }
                else
                {
                    gender = "Male";
                }

                ns51.Fact fact = new ns51.Fact();
                fact.ID = Guid.NewGuid().ToString();

                fact.OSZCode = rec.OnmszCode;
                fact.MSZ_receiver = new schemaEgisso.MSZ_receiver();
                //обработаем снилс
                fact.MSZ_receiver.SNILS = rec.SnilsRecip.Replace(" ", "").Replace("-", "");
                fact.MSZ_receiver.FamilyName = rec.FamilyNameRecip;
                fact.MSZ_receiver.FirstName = rec.NameRecip;
                if (rec.PatronymicRecip != "")
                    fact.MSZ_receiver.Patronymic = rec.PatronymicRecip;
                else
                    //ставим прочерк если нет отчества
                    fact.MSZ_receiver.Patronymic = "-";



                fact.MSZ_receiver.Gender = gender;
                fact.MSZ_receiver.BirthDate = new XmlDateTime((DateTime)rec.BirthDateRecip);
                fact.MSZ_receiver.IdentityDoc = new schemaEgisso.IdentityDoc();
                fact.MSZ_receiver.IdentityDoc.PassportRF = new schemaEgisso.PassportRF();
                fact.MSZ_receiver.IdentityDoc.PassportRF.Series = rec.DocSeriesRecip;
                fact.MSZ_receiver.IdentityDoc.PassportRF.Number = rec.DocNumberRecip;
                fact.MSZ_receiver.IdentityDoc.PassportRF.IssueDate = new XmlDateTime((DateTime)rec.DocIssueDateRecip);
                fact.MSZ_receiver.IdentityDoc.PassportRF.Issuer = rec.DocIssuerRecip;
                //если нету, то не ставим Reason_persons
                if (rec.prozhiv != null && rec.prozhiv.Count >= 1)
                {
                    fact.Reason_persons = new schemaEgisso.Reason_persons();
                    foreach (Prozhiv prozhiv in rec.prozhiv)
                    {
                        //закидываем проживающих по циклу


                        schemaEgisso.PrsnInfo prsnInfo = new schemaEgisso.PrsnInfo();
                        fact.Reason_persons.PrsnInfo.Add(prsnInfo);
                        //обработаем снилс
                        prsnInfo.SNILS = prozhiv.SnilsReason.Replace(" ", "").Replace("-", "");
                        prsnInfo.FamilyName = prozhiv.FamilyNameReason;
                        prsnInfo.FirstName = prozhiv.NameReason;
                        if (prozhiv.PatronymicReason != "")
                            prsnInfo.Patronymic = prozhiv.PatronymicReason;

                        if (prozhiv.GenderReason == "Ж")
                        {
                            gender = "Female";
                        }
                        else
                        {
                            gender = "Male";
                        }
                        prsnInfo.Gender = gender;
                        prsnInfo.BirthDate = new XmlDateTime((DateTime)prozhiv.BirthdateReason);
                        prsnInfo.IdentityDoc = new ns53.IdentityDocA();
                        prsnInfo.IdentityDoc.PassportRF = new schemaEgisso.PassportRF();
                        prsnInfo.IdentityDoc.PassportRF.Series = prozhiv.DocSeriesReason;
                        prsnInfo.IdentityDoc.PassportRF.Number = prozhiv.DocNumberReason;
                        prsnInfo.IdentityDoc.PassportRF.IssueDate = new XmlDateTime((DateTime)prozhiv.DocIssueDateReason);
                        prsnInfo.IdentityDoc.PassportRF.Issuer = prozhiv.DocIssuerReason;
                    }


                }

                fact.LMSZID = rec.LmszId;
                fact.CategoryID = rec.CategoryId;
                fact.Decision_date = new XmlDateTime((DateTime)rec.DecisionDate);
                fact.DateStart = new XmlDateTime((DateTime)rec.DateStart);
                fact.DateFinish = new XmlDateTime((DateTime)rec.DateFinish);
                fact.NeedsCriteria = new schemaEgisso.NeedsCriteria();
                fact.NeedsCriteria.UsingSign = false;
                fact.NeedsCriteria.Criteria = "";
                fact.Assignment_info = new schemaEgisso.Assignment_info();
                //   fact.Assignment_info.ServiceForm = new ns52.ServiceForm();
                fact.Assignment_info.Monetary_form = new ns52.Monetary_form();
                fact.Assignment_info.Monetary_form.Amount = rec.Amount.ToString();
                fact.LastChanging = new XmlDateTime(DateTime.Now);

                rt.Package.Elements.Fact.Add(fact);
                //
            }

            if (rt.Package.Elements.Fact.Count == 0)
            {
                MessageBox.Show("Нет записей для выгрузки");
                return;
            }


            rt.ToXmlFile("0336_10.06.S_001kaprem.xml");
            MessageBox.Show("Выгрузка файла для Капремонта 0336_10.06.S_001kaprem.xml была успешно выполнена");

            //    List<Record> records = new GetDataKaprem().Load(this);
            int a = 0;
            a++;
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            OpenFileDialog OPF = new OpenFileDialog();
            OPF.Multiselect = true;

            // string xmlFile = openFileDialog.FileName; 
            XmlDocument doc = new XmlDocument();
            //XmlElement root = doc.DocumentElement;
            List<Chelovek> chelovek = new List<Chelovek>();
            if (OPF.ShowDialog() == DialogResult.OK)
            {

                //openFileDialog.Filter = "CSV files (*.csv)|*.csv|XML files (*.xml)|*.xml";
                doc.Load(OPF.FileName);
                XmlElement root = doc.DocumentElement;
                Chelovek user = new Chelovek();
                //XElement xdoc = XElement.Load(OPF.FileName);
                //
                foreach (XmlElement xnode in root)
                {
                    XmlNode attr = xnode.Attributes.GetNamedItem("ns51:fact");
                    
                    if (attr != null)
                        user.Fact = attr.Value;


                    foreach (XmlNode childnode in xnode.ChildNodes)
                    {
                        //foreach (XmlNode childnode1 in xnode.ChildNodes)
                        //{
                        //    foreach (XmlNode childnode2 in xnode.ChildNodes)
                        //    {

                        //        foreach (XmlNode childnode3 in xnode.ChildNodes)
                        //{
                        if (childnode.Name == "ns51:elements")
                            user.Elements = attr.Value;
                        if (childnode.Name == "ns52:OSZCode")
                            user.OSZCode = attr.Value;
                        if (childnode.Name == "ns51:ID")
                            user.ID = attr.Value;
                        if (childnode.Name == "ns33:Patronymic")
                            user.Patronymic = childnode.InnerText;
                        if (childnode.Name == "ns52:LMSZID")
                            user.LMSZID = childnode.InnerText;
                        

                        //}
                        //}
                        //}
                    }
                    chelovek.Add(user);


                    //}

                    ////csvparse nado sdelat tak esli OPF.file name CSV a ne prosto filename //
                    ////
                    //  FileStream fileStream = new FileStream(path + "//" + files[i], FileMode.Open);
                    //StreamReader streamReader = new StreamReader(fileStream, encoding);
                    //Configuration config = new Configuration();
                    //
                    //config.RegisterClassMap<DataHelperMap>();


                    if (openFileDialog.FileName != string.Empty)
                    {

                        openFileDialog.Filter = "CSV files (*.csv)|*.csv|XML files (*.xml)|*.xml";
                        StreamReader reader = File.OpenText(OPF.FileName);
                        reader.Read();
                        
                        string streamContents;
                        
                   
                        streamContents = reader.ReadToEnd();
                        var xDoc = XDocument.Parse(OPF.FileName);
                        var xDocx = XDocument.Parse(OPF.FileName);
                        XNamespace ns52 = XNamespace.Get("urn://egisso-ru/types/assignment-fact/1.0.3");
                        XNamespace ns53 = XNamespace.Get("urn://egisso-ru/types/prsn-info/1.0.3");
                        XNamespace ns33 = XNamespace.Get("urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1");
                        XNamespace ns51 = XNamespace.Get("urn://egisso-ru/types/package-RAF/1.0.3");
                        XNamespace ns54 = XNamespace.Get("urn://egisso-ru/types/assignment-fact/1.0.3");
                        List<Chelovek> chel = new List<Chelovek>();

                        foreach (XElement el in xDoc.Element(ns33 + "data").Element(ns51 + "package").Element(ns51 + "elements").Elements(ns51 + "fact"))

                        {
                            var item = new Chelovek();

                            item.A = el.Element(ns52 + "Внешний идентификатор записи в системе ПИ").Value;
                            item.B = el.Element(ns52 + "Внутренний идентификатор записи в ЕГИССО").Value;
                            item.C = el.Element(ns52 + "Статус записи").Value;
                            item.D = el.Element(ns52 + "Дата и время статуса").Value;
                            item.E = el.Element(ns52 + "Код правила").Value;
                            item.F = el.Element(ns52 + "Комментарий").Value;
                            

                            chel.Add(user);
                            try
                            {
                                foreach (XElement el2 in el.Element(ns53 + "reason_persons").Elements(ns33 + "prsnInfo"))

                                {
                                    foreach (XmlNode childnode in xnode.ChildNodes)
                                    {
                                        var item2 = new csvParse();

                                        item2.A = el.Element(ns52 + "Внешний идентификатор записи в системе ПИ").Value;
                                        item2.B = el.Element(ns52 + "Внутренний идентификатор записи в ЕГИССО").Value;
                                        item2.C = el.Element(ns52 + "Статус записи").Value;
                                        item2.D = el.Element(ns52 + "Дата и время статуса").Value;
                                        item2.E = el.Element(ns52 + "Код правила").Value;
                                        item2.F = el.Element(ns52 + "Комментарий").Value;

                                    }
                                }
                            }

                            catch (Exception ex)
                            {
                                //int yy = 0;
                                //yy++;
                                foreach (XAttribute attrit in el.Attributes())



                                    MessageBox.Show("{0}", attr.ToString()).ToString();
                            }

                            //foreach (XElement xel in el.Elements())

                            //{


                            //}




                        }

                        using (var writer = new StreamWriter("test.csv", false, Encoding.GetEncoding(1251)))
                        using (var csv = new CsvWriter(writer))
                        {
                          

                            csv.Configuration.Delimiter = ";";
                            XmlReader xReader = XmlReader.Create(new StringReader(OPF.FileName));
                            while (xReader.Read())
                            {
                                switch (xReader.NodeType)
                                {
                                    case XmlNodeType.Element:
                                        user.F.IndexOf("<" + xReader.Name + ">");
                                        break;
                                    case XmlNodeType.Text:
                                        user.D.IndexOf("1");
                                        break;
                                    case XmlNodeType.Entity:
                                        break;
                                        
                                }
                                //return streamContent;
                            }
                            // csv.WriteRecords(chel);



                        }
                        
                    }
                }
            }
        }
    }
}