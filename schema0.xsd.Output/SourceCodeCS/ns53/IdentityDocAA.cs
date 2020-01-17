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

namespace ns53
{
	/// <summary>
	/// 	This class represents the ComplexType IdentityDoc
	/// </summary>
	[LiquidTechnologies.Runtime.Net40.XmlObjectInfo(LiquidTechnologies.Runtime.Net40.XmlObjectBase.XmlElementGroupType.Sequence,
													LiquidTechnologies.Runtime.Net40.XmlObjectBase.XmlElementType.Element,
													"IdentityDoc", "urn://egisso-ru/types/prsn-info/1.0.3", true, false)]
	public partial class IdentityDocA : schemaEgisso.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		///		Constructor for IdentityDocA
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\Users\peter\Documents\Visual Studio 2017\Projects\egisso_\schema0.xsd</BR>
		/// </remarks>
		public IdentityDocA()
		{
			_elementName = "IdentityDoc";
			Init();
		}
		public IdentityDocA(String elementName)
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
			m_PassportRF = null;
			m_BirthCertificate = null;



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
			ns53.IdentityDocA newObject = new ns53.IdentityDocA(_elementName);
			newObject.m_PassportRF = null;
			if (m_PassportRF != null)
				newObject.m_PassportRF = (schemaEgisso.PassportRF)m_PassportRF.Clone();
			newObject.m_BirthCertificate = null;
			if (m_BirthCertificate != null)
				newObject.m_BirthCertificate = (schemaEgisso.BirthCertificate)m_BirthCertificate.Clone();


// ##HAND_CODED_BLOCK_START ID="Additional clone"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional clone code here...

// ##HAND_CODED_BLOCK_END ID="Additional clone"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

			return newObject;
		}
		#endregion

		#region Member variables

		protected override String TargetNamespace
		{
			get { return "urn://egisso-ru/types/prsn-info/1.0.3"; }
		}

		#region Attribute - PassportRF
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net40.ElementInfoSeqClsOpt("PassportRF", "urn://egisso-ru/types/basic/1.0.4", LiquidTechnologies.Runtime.Net40.XmlObjectBase.XmlElementType.Element, typeof(schemaEgisso.PassportRF))]
		public schemaEgisso.PassportRF PassportRF
		{
			get 
			{ 
				return m_PassportRF;  
			}
			set 
			{ 
				if (value == null)
					m_PassportRF = null;
				else
				{
					SetElementName(value, "PassportRF");
					m_PassportRF = value; 
				}
			}
		}
		protected schemaEgisso.PassportRF m_PassportRF;
		
		#endregion
		#region Attribute - BirthCertificate
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net40.ElementInfoSeqClsOpt("BirthCertificate", "urn://egisso-ru/types/basic/1.0.4", LiquidTechnologies.Runtime.Net40.XmlObjectBase.XmlElementType.Element, typeof(schemaEgisso.BirthCertificate))]
		public schemaEgisso.BirthCertificate BirthCertificate
		{
			get 
			{ 
				return m_BirthCertificate;  
			}
			set 
			{ 
				if (value == null)
					m_BirthCertificate = null;
				else
				{
					SetElementName(value, "BirthCertificate");
					m_BirthCertificate = value; 
				}
			}
		}
		protected schemaEgisso.BirthCertificate m_BirthCertificate;
		
		#endregion
	
		#region Attribute - Namespace
		public override String Namespace
		{
			get { return "urn://egisso-ru/types/prsn-info/1.0.3"; }
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


