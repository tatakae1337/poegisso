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

namespace ns52
{
	/// <summary>
	/// 	This class represents the ComplexType monetary_form
	/// </summary>
	[LiquidTechnologies.Runtime.Net40.XmlObjectInfo(LiquidTechnologies.Runtime.Net40.XmlObjectBase.XmlElementGroupType.Sequence,
													LiquidTechnologies.Runtime.Net40.XmlObjectBase.XmlElementType.Element,
													"monetary_form", "urn://egisso-ru/types/assignment-fact/1.0.3", true, false)]
	public partial class Monetary_form : schemaEgisso.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		///		Constructor for Monetary_form
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\Users\peter\Documents\Visual Studio 2017\Projects\egisso_\schema0.xsd</BR>
		/// </remarks>
		public Monetary_form()
		{
			_elementName = "monetary_form";
			Init();
		}
		public Monetary_form(String elementName)
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
			m_Amount = "";



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
			ns52.Monetary_form newObject = new ns52.Monetary_form(_elementName);
			newObject.m_Amount = m_Amount;


// ##HAND_CODED_BLOCK_START ID="Additional clone"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional clone code here...

// ##HAND_CODED_BLOCK_END ID="Additional clone"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

			return newObject;
		}
		#endregion

		#region Member variables

		protected override String TargetNamespace
		{
			get { return "urn://egisso-ru/types/assignment-fact/1.0.3"; }
		}

		#region Attribute - amount
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
        [LiquidTechnologies.Runtime.Net40.ElementInfoSeqPrimMnd("amount", "urn://egisso-ru/types/assignment-fact/1.0.3", LiquidTechnologies.Runtime.Net40.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net40.WhitespaceUtils.WhitespaceRule.Preserve, "", -1, -1, "", "", "", "", -1)]
		public String Amount
		{
			get 
			{ 
				return m_Amount;  
			}
			set 
			{ 
				// Apply whitespace rules appropriatley
				value = LiquidTechnologies.Runtime.Net40.WhitespaceUtils.Preserve(value); 
				m_Amount = value;
			}
		}
		protected String m_Amount;

		#endregion
	
		#region Attribute - Namespace
		public override String Namespace
		{
			get { return "urn://egisso-ru/types/assignment-fact/1.0.3"; }
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


