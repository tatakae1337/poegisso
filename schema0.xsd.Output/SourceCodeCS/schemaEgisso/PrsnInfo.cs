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
	/// <summary>
	/// 	This class represents the ComplexType prsnInfo
	/// </summary>
	[LiquidTechnologies.Runtime.Net40.XmlObjectInfo(LiquidTechnologies.Runtime.Net40.XmlObjectBase.XmlElementGroupType.Sequence,
													LiquidTechnologies.Runtime.Net40.XmlObjectBase.XmlElementType.Element,
													"prsnInfo", "", true, false)]
	public partial class PrsnInfo : schemaEgisso.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		///		Constructor for PrsnInfo
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\Users\peter\Documents\Visual Studio 2017\Projects\egisso_\schema0.xsd</BR>
		/// </remarks>
		public PrsnInfo()
		{
			_elementName = "prsnInfo";
			Init();
		}
		public PrsnInfo(String elementName)
		{
			_elementName = elementName;
			Init();
		}
		#endregion

		#region Initilization methods for the class
		/// <summary>
		///		Initilizes the class
		/// </summary>
		/// <remarks>
		///		<BR>The Creates all the mandatory fields (populated with the default data) 
		///		All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\Users\peter\Documents\Visual Studio 2017\Projects\egisso_\schema0.xsd.</BR>
		/// </remarks>
		protected override void Init()
		{
			schemaEgisso.Registration.iRegistrationIndicator = 0; // causes registration to take place
			m_SNILS = "";
			m_FamilyName = "";
			m_FirstName = "";
			m_Patronymic = "";
			m_Gender = "";
			m_BirthDate = new LiquidTechnologies.Runtime.Net40.XmlDateTime(LiquidTechnologies.Runtime.Net40.XmlDateTime.DateType.date);
			m_IdentityDoc = new ns53.IdentityDocA("IdentityDoc");



// ##HAND_CODED_BLOCK_START ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional initilization code here...

// ##HAND_CODED_BLOCK_END ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
		}
		#endregion

		#region ICloneable Interface
		/// <summary>
		///		Allows the class to be copied
		/// </summary>
		/// <remarks>
		///		Performs a 'deep copy' of all the data in the class (and its children)
		/// </remarks>
		public override object Clone()
		{
			schemaEgisso.PrsnInfo newObject = new schemaEgisso.PrsnInfo(_elementName);
			newObject.m_SNILS = m_SNILS;
			newObject.m_FamilyName = m_FamilyName;
			newObject.m_FirstName = m_FirstName;
			newObject.m_Patronymic = m_Patronymic;
			newObject.m_Gender = m_Gender;
			newObject.m_BirthDate = (LiquidTechnologies.Runtime.Net40.XmlDateTime)m_BirthDate.Clone();
			newObject.m_IdentityDoc = null;
			if (m_IdentityDoc != null)
				newObject.m_IdentityDoc = (ns53.IdentityDocA)m_IdentityDoc.Clone();


// ##HAND_CODED_BLOCK_START ID="Additional clone"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional clone code here...

// ##HAND_CODED_BLOCK_END ID="Additional clone"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

			return newObject;
		}
		#endregion

		#region Member variables

		protected override String TargetNamespace
		{
			get { return ""; }
		}

		#region Attribute - SNILS
		/// <summary>
		///		Represents a mandatory Element in the XML document
		///		
		/// </summary>
		/// <remarks>
		///		<BR></BR>
		///		<BR>This property is represented as an Element in the XML.</BR>
		///		<BR>It is mandatory and therefore must be populated within the XML.</BR>
		///		<BR>It is defaulted to "".</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net40.ElementInfoSeqPrimMnd("SNILS", "urn://egisso-ru/types/prsn-info/1.0.3", LiquidTechnologies.Runtime.Net40.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net40.WhitespaceUtils.WhitespaceRule.Preserve, "", -1, -1, "", "", "", "", -1)]
		public String SNILS
		{
			get 
			{ 
				return m_SNILS;  
			}
			set 
			{ 
				// Apply whitespace rules appropriatley
				value = LiquidTechnologies.Runtime.Net40.WhitespaceUtils.Preserve(value); 
				m_SNILS = value;
			}
		}
		protected String m_SNILS;

		#endregion
		#region Attribute - FamilyName
		/// <summary>
		///		Represents a mandatory Element in the XML document
		///		
		/// </summary>
		/// <remarks>
		///		<BR></BR>
		///		<BR>This property is represented as an Element in the XML.</BR>
		///		<BR>It is mandatory and therefore must be populated within the XML.</BR>
		///		<BR>It is defaulted to "".</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net40.ElementInfoSeqPrimMnd("FamilyName", "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1", LiquidTechnologies.Runtime.Net40.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net40.WhitespaceUtils.WhitespaceRule.Preserve, "", -1, -1, "", "", "", "", -1)]
		public String FamilyName
		{
			get 
			{ 
				return m_FamilyName;  
			}
			set 
			{ 
				// Apply whitespace rules appropriatley
				value = LiquidTechnologies.Runtime.Net40.WhitespaceUtils.Preserve(value); 
				m_FamilyName = value;
			}
		}
		protected String m_FamilyName;

		#endregion
		#region Attribute - FirstName
		/// <summary>
		///		Represents a mandatory Element in the XML document
		///		
		/// </summary>
		/// <remarks>
		///		<BR></BR>
		///		<BR>This property is represented as an Element in the XML.</BR>
		///		<BR>It is mandatory and therefore must be populated within the XML.</BR>
		///		<BR>It is defaulted to "".</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net40.ElementInfoSeqPrimMnd("FirstName", "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1", LiquidTechnologies.Runtime.Net40.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net40.WhitespaceUtils.WhitespaceRule.Preserve, "", -1, -1, "", "", "", "", -1)]
		public String FirstName
		{
			get 
			{ 
				return m_FirstName;  
			}
			set 
			{ 
				// Apply whitespace rules appropriatley
				value = LiquidTechnologies.Runtime.Net40.WhitespaceUtils.Preserve(value); 
				m_FirstName = value;
			}
		}
		protected String m_FirstName;

		#endregion
		#region Attribute - Patronymic
		/// <summary>
		///		Represents a mandatory Element in the XML document
		///		
		/// </summary>
		/// <remarks>
		///		<BR></BR>
		///		<BR>This property is represented as an Element in the XML.</BR>
		///		<BR>It is mandatory and therefore must be populated within the XML.</BR>
		///		<BR>It is defaulted to "".</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net40.ElementInfoSeqPrimMnd("Patronymic", "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1", LiquidTechnologies.Runtime.Net40.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net40.WhitespaceUtils.WhitespaceRule.Preserve, "", -1, -1, "", "", "", "", -1)]
		public String Patronymic
		{
			get 
			{ 
				return m_Patronymic;  
			}
			set 
			{ 
				// Apply whitespace rules appropriatley
				value = LiquidTechnologies.Runtime.Net40.WhitespaceUtils.Preserve(value); 
				m_Patronymic = value;
			}
		}
		protected String m_Patronymic;

		#endregion
		#region Attribute - Gender
		/// <summary>
		///		Represents a mandatory Element in the XML document
		///		
		/// </summary>
		/// <remarks>
		///		<BR></BR>
		///		<BR>This property is represented as an Element in the XML.</BR>
		///		<BR>It is mandatory and therefore must be populated within the XML.</BR>
		///		<BR>It is defaulted to "".</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net40.ElementInfoSeqPrimMnd("Gender", "urn://egisso-ru/types/prsn-info/1.0.3", LiquidTechnologies.Runtime.Net40.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net40.WhitespaceUtils.WhitespaceRule.Preserve, "", -1, -1, "", "", "", "", -1)]
		public String Gender
		{
			get 
			{ 
				return m_Gender;  
			}
			set 
			{ 
				// Apply whitespace rules appropriatley
				value = LiquidTechnologies.Runtime.Net40.WhitespaceUtils.Preserve(value); 
				m_Gender = value;
			}
		}
		protected String m_Gender;

		#endregion
		#region Attribute - BirthDate
		/// <summary>
		///		Represents a mandatory Element in the XML document
		///		
		/// </summary>
		/// <remarks>
		///		<BR></BR>
		///		<BR>This property is represented as an Element in the XML.</BR>
		///		<BR>It is mandatory and therefore must be populated within the XML.</BR>
		///		<BR>It is defaulted to new LiquidTechnologies.Runtime.Net40.XmlDateTime(LiquidTechnologies.Runtime.Net40.XmlDateTime.DateType.date).</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net40.ElementInfoSeqPrimMnd("BirthDate", "urn://egisso-ru/types/prsn-info/1.0.3", LiquidTechnologies.Runtime.Net40.Conversions.ConversionType.type_date, null, LiquidTechnologies.Runtime.Net40.WhitespaceUtils.WhitespaceRule.Collapse, "", -1, -1, "", "", "", "", -1)]
		public LiquidTechnologies.Runtime.Net40.XmlDateTime BirthDate
		{
			get 
			{ 
				return m_BirthDate;  
			}
			set 
			{ 
				m_BirthDate.SetDateTime(value, m_BirthDate.Type); 
			}
		}
		protected LiquidTechnologies.Runtime.Net40.XmlDateTime m_BirthDate;

		#endregion
		#region Attribute - IdentityDoc
		/// <summary>
		///		Represents a mandatory Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is mandatory and therefore must be populated within the XML.</BR>
		///		<BR>If this property is set, then the object will be COPIED. If the property is set to null an exception is raised.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net40.ElementInfoSeqClsMnd("IdentityDoc", "urn://egisso-ru/types/prsn-info/1.0.3", LiquidTechnologies.Runtime.Net40.XmlObjectBase.XmlElementType.Element, typeof(ns53.IdentityDocA), false)]
		public ns53.IdentityDocA IdentityDoc
		{
			get 
			{ 
				return m_IdentityDoc;  
			}
			set 
			{ 
				Throw_IfPropertyIsNull(value, "IdentityDoc");
				if (value != null)
					SetElementName(value, "IdentityDoc");
				m_IdentityDoc = value;
			}
		}
		protected ns53.IdentityDocA m_IdentityDoc;
		
		#endregion
	
		#region Attribute - Namespace
		public override String Namespace
		{
			get { return ""; }
		}	
		#endregion	

		#region Attribute - GetBase
		public override LiquidTechnologies.Runtime.Net40.XmlObjectBase GetBase()
		{
			return this;
		}
		#endregion
		#endregion

// ##HAND_CODED_BLOCK_START ID="Additional Methods"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional Methods and members here...

// ##HAND_CODED_BLOCK_END ID="Additional Methods"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
	}
}


