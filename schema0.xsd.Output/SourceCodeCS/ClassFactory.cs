using System;
using System.Xml;

/**********************************************************************************************
 * Copyright (c) 2001-2010 Liquid Technologies Limited. All rights reserved.
 * See www.liquid-technologies.com for product details.
 *
 * Please see products End User License Agreement for distribution permissions.
 *
 * WARNING: THIS FILE IS GENERATED
 * Changes made outside of ##HAND_CODED_BLOCK_START blocks will be overwritten
 *
 * Generation  : by Liquid XML Data Binder 9.0.11.3078
 * Using Schema: C:\Users\peter\Documents\Visual Studio 2017\Projects\egisso_\schema0.xsd
 **********************************************************************************************/

namespace schemaEgisso 
{
	public class ClassFactory : LiquidTechnologies.Runtime.Net40.ClassFactoryBase
	{


		/// <summary>
		/// Creates an object from XML data held in a string.
		/// </summary>
		/// <param name="xmlIn">The data to be loaded</param>
		/// <returns>The wrapper object, loaded with the supplied data</returns>
		/// <remarks>Throws an exception if the XML data is not compatable with the schema</remarks>
		static public LiquidTechnologies.Runtime.Net40.XmlObjectBase FromXml( String xmlIn )
		{
			return FromXml( xmlIn, LiquidTechnologies.Runtime.Net40.XmlSerializationContext.Default );
		}
		/// <summary>
		/// Creates an object from XML data held in a string.
		/// </summary>
		/// <param name="xmlIn">The data to be loaded</param>
		/// <param name="context">The context to use when loading the data</param>
		/// <returns>The wrapper object, loaded with the supplied data</returns>
		/// <remarks>Throws an exception if the XML data is not compatable with the schema</remarks>
		static public LiquidTechnologies.Runtime.Net40.XmlObjectBase FromXml( String xmlIn, LiquidTechnologies.Runtime.Net40.XmlSerializationContext context )
		{
			XmlDocument xmlDoc = new XmlDocument();
			xmlDoc.PreserveWhitespace  = true;
			xmlDoc.LoadXml(xmlIn);
			return FromXmlElement(xmlDoc.DocumentElement, context);
		}

		/// <summary>
		/// Creates an object from XML data held in a File
		/// </summary>
		/// <param name="FileName">The file to be loaded</param>
		/// <returns>The wrapper object, loaded with the supplied data</returns>
		/// <remarks>Throws an exception if the XML data is not compatable with the schema</remarks>
		static public LiquidTechnologies.Runtime.Net40.XmlObjectBase FromXmlFile( String FileName )
		{
			return FromXmlFile(FileName, LiquidTechnologies.Runtime.Net40.XmlSerializationContext.Default);
		}
		/// <summary>
		/// Creates an object from XML data held in a File
		/// </summary>
		/// <param name="FileName">The file to be loaded</param>
		/// <param name="context">The context to use when loading the data</param>
		/// <returns>The wrapper object, loaded with the supplied data</returns>
		/// <remarks>Throws an exception if the XML data is not compatable with the schema</remarks>
		static public LiquidTechnologies.Runtime.Net40.XmlObjectBase FromXmlFile( String FileName, LiquidTechnologies.Runtime.Net40.XmlSerializationContext context )
		{
			using (System.IO.Stream stream = new System.IO.FileStream(FileName, System.IO.FileMode.Open, System.IO.FileAccess.Read,System.IO.FileShare.Read))
			{
				return FromXmlStream(stream, context);
			}
		}

		/// <summary>
		/// Creates an object from XML data held in a stream.
		/// </summary>
		/// <param name="stream">The data to be loaded</param>
		/// <returns>The wrapper object, loaded with the supplied data</returns>
		/// <remarks>Throws an exception if the XML data is not compatable with the schema</remarks>
		static public LiquidTechnologies.Runtime.Net40.XmlObjectBase FromXmlStream(System.IO.Stream stream)
		{
			return FromXmlStream(stream, LiquidTechnologies.Runtime.Net40.XmlSerializationContext.Default);
		}
		/// <summary>
		/// Creates an object from XML data held in a stream.
		/// </summary>
		/// <param name="stream">The data to be loaded</param>
		/// <returns>The wrapper object, loaded with the supplied data</returns>
		/// <remarks>Throws an exception if the XML data is not compatable with the schema</remarks>
		static public LiquidTechnologies.Runtime.Net40.XmlObjectBase FromXmlStream(System.IO.Stream stream, LiquidTechnologies.Runtime.Net40.XmlSerializationContext context)
		{
			XmlDocument xmlDoc = new XmlDocument();
			xmlDoc.PreserveWhitespace  = true;
			// use regular XML Parser
			xmlDoc.Load(stream);
	
			return FromXmlElement(xmlDoc.DocumentElement, context);

		}

		
		/// <summary>
		/// Creates an object from an XML Element.
		/// </summary>
		/// <param name="xmlParent">The data that needs loading</param>
		/// <returns>The wrapper object, loaded with the supplied data</returns>
		/// <remarks>Throws an exception if the XML data is not compatable with the schema</remarks>
		static public LiquidTechnologies.Runtime.Net40.XmlObjectBase FromXmlElement(XmlElement xmlParent)
		{
			return FromXmlElement(xmlParent, LiquidTechnologies.Runtime.Net40.XmlSerializationContext.Default);
		}
			
		/// <summary>
		/// Creates an object from an XML Element.
		/// </summary>
		/// <param name="xmlParent">The data that needs loading</param>
		/// <param name="context">The context to use when loading the data</param>
		/// <returns>The wrapper object, loaded with the supplied data</returns>
		/// <remarks>Throws an exception if the XML data is not compatable with the schema</remarks>
		static public LiquidTechnologies.Runtime.Net40.XmlObjectBase FromXmlElement(XmlElement xmlParent, LiquidTechnologies.Runtime.Net40.XmlSerializationContext context)
		{
			LiquidTechnologies.Runtime.Net40.XmlObjectBase retVal = null;
			String elementName;
			String elementNamespaceUri;


			// Get the type name this is either 
			// from the element ie <Parent>... = Parent
			// or from the type ie <Parent xsi:type="someNS:SomeElement">... = SomeElement
			if (GetElementType(xmlParent) == "")
			{
				elementName = xmlParent.LocalName;
				elementNamespaceUri = xmlParent.NamespaceURI;
			}
			else
			{
				elementName = GetElementType(xmlParent);
				elementNamespaceUri = GetElementTypeNamespaceUri(xmlParent);
			}

			// create the appropriate object
			if (elementName == null || elementName == String.Empty)
				throw new LiquidTechnologies.Runtime.Net40.LtInvalidParamException("The element to load has no name"); 
			else if (elementName == "assignment_info" && elementNamespaceUri == "")
				retVal = new schemaEgisso.Assignment_info();
			else if (elementName == "assignment_info" && elementNamespaceUri == "urn://egisso-ru/types/assignment-fact/1.0.3")
				retVal = new ns52.Assignment_info();
			else if (elementName == "BirthCertificate" && elementNamespaceUri == "")
				retVal = new schemaEgisso.BirthCertificate();
			else if (elementName == "BirthCertificate" && elementNamespaceUri == "urn://egisso-ru/types/basic/1.0.4")
				retVal = new ns54.BirthCertificate();
			else if (elementName == "BirthDate" && elementNamespaceUri == "urn://egisso-ru/types/prsn-info/1.0.3")
				retVal = new ns53.BirthDate();
			else if (elementName == "categoryID" && elementNamespaceUri == "urn://egisso-ru/types/assignment-fact/1.0.3")
				retVal = new ns52.CategoryID();
			else if (elementName == "data" && elementNamespaceUri == "urn://egisso-ru/msg/10.06.S/1.0.2")
				retVal = new ns55.Data();
			else if (elementName == "dateFinish" && elementNamespaceUri == "urn://egisso-ru/types/assignment-fact/1.0.3")
				retVal = new ns52.DateFinish();
			else if (elementName == "dateStart" && elementNamespaceUri == "urn://egisso-ru/types/assignment-fact/1.0.3")
				retVal = new ns52.DateStart();
			else if (elementName == "decision_date" && elementNamespaceUri == "urn://egisso-ru/types/assignment-fact/1.0.3")
				retVal = new ns52.Decision_date();
			else if (elementName == "elements" && elementNamespaceUri == "urn://egisso-ru/types/package-RAF/1.0.3")
				retVal = new ns51.Elements();
			else if (elementName == "fact" && elementNamespaceUri == "urn://egisso-ru/types/package-RAF/1.0.3")
				retVal = new ns51.Fact();
			else if (elementName == "FamilyName" && elementNamespaceUri == "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1")
				retVal = new ns33.FamilyName();
			else if (elementName == "FirstName" && elementNamespaceUri == "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1")
				retVal = new ns33.FirstName();
			else if (elementName == "Gender" && elementNamespaceUri == "urn://egisso-ru/types/prsn-info/1.0.3")
				retVal = new ns53.Gender();
			else if (elementName == "ID" && elementNamespaceUri == "urn://egisso-ru/types/assignment-fact/1.0.3")
				retVal = new ns52.ID();
			else if (elementName == "IdentityDoc" && elementNamespaceUri == "")
				retVal = new schemaEgisso.IdentityDoc();
			else if (elementName == "IdentityDoc" && elementNamespaceUri == "urn://egisso-ru/types/prsn-info/1.0.3")
				retVal = new ns53.IdentityDoc();
			else if (elementName == "IdentityDoc" && elementNamespaceUri == "urn://egisso-ru/types/prsn-info/1.0.3")
				retVal = new ns53.IdentityDocA();
			else if (elementName == "LMSZID" && elementNamespaceUri == "urn://egisso-ru/types/assignment-fact/1.0.3")
				retVal = new ns52.LMSZID();
			else if (elementName == "monetary_form" && elementNamespaceUri == "urn://egisso-ru/types/assignment-fact/1.0.3")
				retVal = new ns52.Monetary_form();
			else if (elementName == "MSZ_receiver" && elementNamespaceUri == "")
				retVal = new schemaEgisso.MSZ_receiver();
			else if (elementName == "MSZ_receiver" && elementNamespaceUri == "urn://egisso-ru/types/assignment-fact/1.0.3")
				retVal = new ns52.MSZ_receiver();
			else if (elementName == "needsCriteria" && elementNamespaceUri == "")
				retVal = new schemaEgisso.NeedsCriteria();
			else if (elementName == "needsCriteria" && elementNamespaceUri == "urn://egisso-ru/types/assignment-fact/1.0.3")
				retVal = new ns52.NeedsCriteria();
			else if (elementName == "OSZCode" && elementNamespaceUri == "urn://egisso-ru/types/assignment-fact/1.0.3")
				retVal = new ns52.OSZCode();
			else if (elementName == "package" && elementNamespaceUri == "")
				retVal = new schemaEgisso.Package();
			else if (elementName == "package" && elementNamespaceUri == "urn://egisso-ru/types/package-RAF/1.0.3")
				retVal = new ns51.Package();
			else if (elementName == "PassportRF" && elementNamespaceUri == "")
				retVal = new schemaEgisso.PassportRF();
			else if (elementName == "PassportRF" && elementNamespaceUri == "urn://egisso-ru/types/basic/1.0.4")
				retVal = new ns54.PassportRF();
			else if (elementName == "Patronymic" && elementNamespaceUri == "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1")
				retVal = new ns33.Patronymic();
			else if (elementName == "prsnInfo" && elementNamespaceUri == "")
				retVal = new schemaEgisso.PrsnInfo();
			else if (elementName == "prsnInfo" && elementNamespaceUri == "urn://egisso-ru/types/prsn-info/1.0.3")
				retVal = new ns53.PrsnInfo();
			else if (elementName == "reason_persons" && elementNamespaceUri == "")
				retVal = new schemaEgisso.Reason_persons();
			else if (elementName == "reason_persons" && elementNamespaceUri == "urn://egisso-ru/types/assignment-fact/1.0.3")
				retVal = new ns52.Reason_persons();
			else if (elementName == "serviceForm" && elementNamespaceUri == "urn://egisso-ru/types/assignment-fact/1.0.3")
				retVal = new ns52.ServiceForm();
			else if (elementName == "SNILS" && elementNamespaceUri == "urn://egisso-ru/types/prsn-info/1.0.3")
				retVal = new ns53.SNILS();
			else
			{
				throw new LiquidTechnologies.Runtime.Net40.LtException(
					string.Format("Failed load the element {0}:{1}. No appropriate class exists to load the data into. Ensure that the XML document complies with the schema.", 
						xmlParent.Name, xmlParent.NamespaceURI)); 
			}
			
			// load the data into the object
			retVal.FromXmlElement(xmlParent, context);

			return retVal;
		}


	}
}
namespace ns11 
{
	public class ClassFactory : LiquidTechnologies.Runtime.Net40.ClassFactoryBase
	{


	}
}
namespace ns43 
{
	public class ClassFactory : LiquidTechnologies.Runtime.Net40.ClassFactoryBase
	{


	}
}
namespace ns53 
{
	public class ClassFactory : LiquidTechnologies.Runtime.Net40.ClassFactoryBase
	{


	}
}
namespace ns63 
{
	public class ClassFactory : LiquidTechnologies.Runtime.Net40.ClassFactoryBase
	{


	}
}
namespace ns13 
{
	public class ClassFactory : LiquidTechnologies.Runtime.Net40.ClassFactoryBase
	{


	}
}
namespace ns47 
{
	public class ClassFactory : LiquidTechnologies.Runtime.Net40.ClassFactoryBase
	{


	}
}
namespace ns49 
{
	public class ClassFactory : LiquidTechnologies.Runtime.Net40.ClassFactoryBase
	{


	}
}
namespace ns59 
{
	public class ClassFactory : LiquidTechnologies.Runtime.Net40.ClassFactoryBase
	{


	}
}
namespace ns69 
{
	public class ClassFactory : LiquidTechnologies.Runtime.Net40.ClassFactoryBase
	{


	}
}
namespace ns17 
{
	public class ClassFactory : LiquidTechnologies.Runtime.Net40.ClassFactoryBase
	{


	}
}
namespace ns19 
{
	public class ClassFactory : LiquidTechnologies.Runtime.Net40.ClassFactoryBase
	{


	}
}
namespace ns29 
{
	public class ClassFactory : LiquidTechnologies.Runtime.Net40.ClassFactoryBase
	{


	}
}
namespace ns39 
{
	public class ClassFactory : LiquidTechnologies.Runtime.Net40.ClassFactoryBase
	{


	}
}
namespace ns4 
{
	public class ClassFactory : LiquidTechnologies.Runtime.Net40.ClassFactoryBase
	{


	}
}
namespace ns41 
{
	public class ClassFactory : LiquidTechnologies.Runtime.Net40.ClassFactoryBase
	{


	}
}
namespace ns51 
{
	public class ClassFactory : LiquidTechnologies.Runtime.Net40.ClassFactoryBase
	{


	}
}
namespace ns71 
{
	public class ClassFactory : LiquidTechnologies.Runtime.Net40.ClassFactoryBase
	{


	}
}
namespace ns30 
{
	public class ClassFactory : LiquidTechnologies.Runtime.Net40.ClassFactoryBase
	{


	}
}
namespace ns21 
{
	public class ClassFactory : LiquidTechnologies.Runtime.Net40.ClassFactoryBase
	{


	}
}
namespace ns31 
{
	public class ClassFactory : LiquidTechnologies.Runtime.Net40.ClassFactoryBase
	{


	}
}
namespace ns65 
{
	public class ClassFactory : LiquidTechnologies.Runtime.Net40.ClassFactoryBase
	{


	}
}
namespace ns15 
{
	public class ClassFactory : LiquidTechnologies.Runtime.Net40.ClassFactoryBase
	{


	}
}
namespace ns25 
{
	public class ClassFactory : LiquidTechnologies.Runtime.Net40.ClassFactoryBase
	{


	}
}
namespace ns35 
{
	public class ClassFactory : LiquidTechnologies.Runtime.Net40.ClassFactoryBase
	{


	}
}
namespace ns57 
{
	public class ClassFactory : LiquidTechnologies.Runtime.Net40.ClassFactoryBase
	{


	}
}
namespace ns23 
{
	public class ClassFactory : LiquidTechnologies.Runtime.Net40.ClassFactoryBase
	{


	}
}
namespace ns37 
{
	public class ClassFactory : LiquidTechnologies.Runtime.Net40.ClassFactoryBase
	{


	}
}
namespace ns32 
{
	public class ClassFactory : LiquidTechnologies.Runtime.Net40.ClassFactoryBase
	{


	}
}
namespace ns61 
{
	public class ClassFactory : LiquidTechnologies.Runtime.Net40.ClassFactoryBase
	{


	}
}
namespace ns45 
{
	public class ClassFactory : LiquidTechnologies.Runtime.Net40.ClassFactoryBase
	{


	}
}
namespace ns44 
{
	public class ClassFactory : LiquidTechnologies.Runtime.Net40.ClassFactoryBase
	{


	}
}
namespace ns48 
{
	public class ClassFactory : LiquidTechnologies.Runtime.Net40.ClassFactoryBase
	{


	}
}
namespace ns58 
{
	public class ClassFactory : LiquidTechnologies.Runtime.Net40.ClassFactoryBase
	{


	}
}
namespace ns68 
{
	public class ClassFactory : LiquidTechnologies.Runtime.Net40.ClassFactoryBase
	{


	}
}
namespace ns18 
{
	public class ClassFactory : LiquidTechnologies.Runtime.Net40.ClassFactoryBase
	{


	}
}
namespace ns28 
{
	public class ClassFactory : LiquidTechnologies.Runtime.Net40.ClassFactoryBase
	{


	}
}
namespace ns38 
{
	public class ClassFactory : LiquidTechnologies.Runtime.Net40.ClassFactoryBase
	{


	}
}
namespace ns27 
{
	public class ClassFactory : LiquidTechnologies.Runtime.Net40.ClassFactoryBase
	{


	}
}
namespace ns40 
{
	public class ClassFactory : LiquidTechnologies.Runtime.Net40.ClassFactoryBase
	{


	}
}
namespace ns50 
{
	public class ClassFactory : LiquidTechnologies.Runtime.Net40.ClassFactoryBase
	{


	}
}
namespace ns60 
{
	public class ClassFactory : LiquidTechnologies.Runtime.Net40.ClassFactoryBase
	{


	}
}
namespace ns70 
{
	public class ClassFactory : LiquidTechnologies.Runtime.Net40.ClassFactoryBase
	{


	}
}
namespace ns10 
{
	public class ClassFactory : LiquidTechnologies.Runtime.Net40.ClassFactoryBase
	{


	}
}
namespace ns20 
{
	public class ClassFactory : LiquidTechnologies.Runtime.Net40.ClassFactoryBase
	{


	}
}
namespace ns54 
{
	public class ClassFactory : LiquidTechnologies.Runtime.Net40.ClassFactoryBase
	{


	}
}
namespace ns64 
{
	public class ClassFactory : LiquidTechnologies.Runtime.Net40.ClassFactoryBase
	{


	}
}
namespace ns14 
{
	public class ClassFactory : LiquidTechnologies.Runtime.Net40.ClassFactoryBase
	{


	}
}
namespace ns24 
{
	public class ClassFactory : LiquidTechnologies.Runtime.Net40.ClassFactoryBase
	{


	}
}
namespace ns34 
{
	public class ClassFactory : LiquidTechnologies.Runtime.Net40.ClassFactoryBase
	{


	}
}
namespace ns42 
{
	public class ClassFactory : LiquidTechnologies.Runtime.Net40.ClassFactoryBase
	{


	}
}
namespace ns52 
{
	public class ClassFactory : LiquidTechnologies.Runtime.Net40.ClassFactoryBase
	{


	}
}
namespace ns62 
{
	public class ClassFactory : LiquidTechnologies.Runtime.Net40.ClassFactoryBase
	{


	}
}
namespace ns12 
{
	public class ClassFactory : LiquidTechnologies.Runtime.Net40.ClassFactoryBase
	{


	}
}
namespace ns46 
{
	public class ClassFactory : LiquidTechnologies.Runtime.Net40.ClassFactoryBase
	{


	}
}
namespace ns56 
{
	public class ClassFactory : LiquidTechnologies.Runtime.Net40.ClassFactoryBase
	{


	}
}
namespace ns66 
{
	public class ClassFactory : LiquidTechnologies.Runtime.Net40.ClassFactoryBase
	{


	}
}
namespace ns67 
{
	public class ClassFactory : LiquidTechnologies.Runtime.Net40.ClassFactoryBase
	{


	}
}
namespace ns16 
{
	public class ClassFactory : LiquidTechnologies.Runtime.Net40.ClassFactoryBase
	{


	}
}
namespace ns26 
{
	public class ClassFactory : LiquidTechnologies.Runtime.Net40.ClassFactoryBase
	{


	}
}
namespace ns36 
{
	public class ClassFactory : LiquidTechnologies.Runtime.Net40.ClassFactoryBase
	{


	}
}
namespace ns5 
{
	public class ClassFactory : LiquidTechnologies.Runtime.Net40.ClassFactoryBase
	{


	}
}
namespace ns6 
{
	public class ClassFactory : LiquidTechnologies.Runtime.Net40.ClassFactoryBase
	{


	}
}
namespace ns7 
{
	public class ClassFactory : LiquidTechnologies.Runtime.Net40.ClassFactoryBase
	{


	}
}
namespace ns2 
{
	public class ClassFactory : LiquidTechnologies.Runtime.Net40.ClassFactoryBase
	{


	}
}
namespace ns3 
{
	public class ClassFactory : LiquidTechnologies.Runtime.Net40.ClassFactoryBase
	{


	}
}
namespace ns33 
{
	public class ClassFactory : LiquidTechnologies.Runtime.Net40.ClassFactoryBase
	{


	}
}
namespace ns9 
{
	public class ClassFactory : LiquidTechnologies.Runtime.Net40.ClassFactoryBase
	{


	}
}
namespace ns8 
{
	public class ClassFactory : LiquidTechnologies.Runtime.Net40.ClassFactoryBase
	{


	}
}
namespace ns22 
{
	public class ClassFactory : LiquidTechnologies.Runtime.Net40.ClassFactoryBase
	{


	}
}
namespace ns55 
{
	public class ClassFactory : LiquidTechnologies.Runtime.Net40.ClassFactoryBase
	{


	}
}

