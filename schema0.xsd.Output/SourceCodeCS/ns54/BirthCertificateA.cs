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

namespace ns54
{
	/// <summary>
	/// 	This class represents the Element BirthCertificate
	/// </summary>
	[LiquidTechnologies.Runtime.Net40.XmlObjectInfo(LiquidTechnologies.Runtime.Net40.XmlObjectBase.XmlElementGroupType.Sequence,
													LiquidTechnologies.Runtime.Net40.XmlObjectBase.XmlElementType.Element,
													"BirthCertificate", "urn://egisso-ru/types/basic/1.0.4", true, false)]
	public partial class BirthCertificate : schemaEgisso.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		///		Constructor for BirthCertificate
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\Users\peter\Documents\Visual Studio 2017\Projects\egisso_\schema0.xsd</BR>
		/// </remarks>
		public BirthCertificate()
		{
			_elementName = "BirthCertificate";
			Init();
		}
		public BirthCertificate(String elementName)
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
			m_Series = "";
			m_Number = "";
			m_IssueDate = new LiquidTechnologies.Runtime.Net40.XmlDateTime(LiquidTechnologies.Runtime.Net40.XmlDateTime.DateType.date);
			m_Issuer = "";



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
			ns54.BirthCertificate newObject = new ns54.BirthCertificate(_elementName);
			newObject.m_Series = m_Series;
			newObject.m_Number = m_Number;
			newObject.m_IssueDate = (LiquidTechnologies.Runtime.Net40.XmlDateTime)m_IssueDate.Clone();
			newObject.m_Issuer = m_Issuer;


// ##HAND_CODED_BLOCK_START ID="Additional clone"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional clone code here...

// ##HAND_CODED_BLOCK_END ID="Additional clone"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

			return newObject;
		}
		#endregion

		#region Member variables

		protected override String TargetNamespace
		{
			get { return "urn://egisso-ru/types/basic/1.0.4"; }
		}

		#region Attribute - Series
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
        [LiquidTechnologies.Runtime.Net40.ElementInfoSeqPrimMnd("Series", "urn://egisso-ru/types/basic/1.0.4", LiquidTechnologies.Runtime.Net40.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net40.WhitespaceUtils.WhitespaceRule.Preserve, "", -1, -1, "", "", "", "", -1)]
		public String Series
		{
			get 
			{ 
				return m_Series;  
			}
			set 
			{ 
				// Apply whitespace rules appropriatley
				value = LiquidTechnologies.Runtime.Net40.WhitespaceUtils.Preserve(value); 
				m_Series = value;
			}
		}
		protected String m_Series;

		#endregion
		#region Attribute - Number
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
        [LiquidTechnologies.Runtime.Net40.ElementInfoSeqPrimMnd("Number", "urn://egisso-ru/types/basic/1.0.4", LiquidTechnologies.Runtime.Net40.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net40.WhitespaceUtils.WhitespaceRule.Preserve, "", -1, -1, "", "", "", "", -1)]
		public String Number
		{
			get 
			{ 
				return m_Number;  
			}
			set 
			{ 
				// Apply whitespace rules appropriatley
				value = LiquidTechnologies.Runtime.Net40.WhitespaceUtils.Preserve(value); 
				m_Number = value;
			}
		}
		protected String m_Number;

		#endregion
		#region Attribute - IssueDate
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
        [LiquidTechnologies.Runtime.Net40.ElementInfoSeqPrimMnd("IssueDate", "urn://egisso-ru/types/basic/1.0.4", LiquidTechnologies.Runtime.Net40.Conversions.ConversionType.type_date, null, LiquidTechnologies.Runtime.Net40.WhitespaceUtils.WhitespaceRule.Collapse, "", -1, -1, "", "", "", "", -1)]
		public LiquidTechnologies.Runtime.Net40.XmlDateTime IssueDate
		{
			get 
			{ 
				return m_IssueDate;  
			}
			set 
			{ 
				m_IssueDate.SetDateTime(value, m_IssueDate.Type); 
			}
		}
		protected LiquidTechnologies.Runtime.Net40.XmlDateTime m_IssueDate;

		#endregion
		#region Attribute - Issuer
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
        [LiquidTechnologies.Runtime.Net40.ElementInfoSeqPrimMnd("Issuer", "urn://egisso-ru/types/basic/1.0.4", LiquidTechnologies.Runtime.Net40.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net40.WhitespaceUtils.WhitespaceRule.Preserve, "", -1, -1, "", "", "", "", -1)]
		public String Issuer
		{
			get 
			{ 
				return m_Issuer;  
			}
			set 
			{ 
				// Apply whitespace rules appropriatley
				value = LiquidTechnologies.Runtime.Net40.WhitespaceUtils.Preserve(value); 
				m_Issuer = value;
			}
		}
		protected String m_Issuer;

		#endregion
	
		#region Attribute - Namespace
		public override String Namespace
		{
			get { return "urn://egisso-ru/types/basic/1.0.4"; }
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


