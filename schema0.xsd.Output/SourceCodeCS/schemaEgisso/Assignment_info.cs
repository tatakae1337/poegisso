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
	/// 	This class represents the ComplexType assignment_info
	/// </summary>
	[LiquidTechnologies.Runtime.Net40.XmlObjectInfo(LiquidTechnologies.Runtime.Net40.XmlObjectBase.XmlElementGroupType.Sequence,
													LiquidTechnologies.Runtime.Net40.XmlObjectBase.XmlElementType.Element,
													"assignment_info", "", true, false)]
	public partial class Assignment_info : schemaEgisso.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		///		Constructor for Assignment_info
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\Users\peter\Documents\Visual Studio 2017\Projects\egisso_\schema0.xsd</BR>
		/// </remarks>
		public Assignment_info()
		{
			_elementName = "assignment_info";
			Init();
		}
		public Assignment_info(String elementName)
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
			m_ServiceForm = null;
			m_Monetary_form = null;



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
			schemaEgisso.Assignment_info newObject = new schemaEgisso.Assignment_info(_elementName);
			newObject.m_ServiceForm = null;
			if (m_ServiceForm != null)
				newObject.m_ServiceForm = (ns52.ServiceForm)m_ServiceForm.Clone();
			newObject.m_Monetary_form = null;
			if (m_Monetary_form != null)
				newObject.m_Monetary_form = (ns52.Monetary_form)m_Monetary_form.Clone();


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

		#region Attribute - serviceForm
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net40.ElementInfoSeqClsOpt("serviceForm", "urn://egisso-ru/types/assignment-fact/1.0.3", LiquidTechnologies.Runtime.Net40.XmlObjectBase.XmlElementType.Element, typeof(ns52.ServiceForm))]
		public ns52.ServiceForm ServiceForm
		{
			get 
			{ 
				return m_ServiceForm;  
			}
			set 
			{ 
				if (value == null)
					m_ServiceForm = null;
				else
				{
					SetElementName(value, "serviceForm");
					m_ServiceForm = value; 
				}
			}
		}
		protected ns52.ServiceForm m_ServiceForm;
		
		#endregion
		#region Attribute - monetary_form
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net40.ElementInfoSeqClsOpt("monetary_form", "urn://egisso-ru/types/assignment-fact/1.0.3", LiquidTechnologies.Runtime.Net40.XmlObjectBase.XmlElementType.Element, typeof(ns52.Monetary_form))]
		public ns52.Monetary_form Monetary_form
		{
			get 
			{ 
				return m_Monetary_form;  
			}
			set 
			{ 
				if (value == null)
					m_Monetary_form = null;
				else
				{
					SetElementName(value, "monetary_form");
					m_Monetary_form = value; 
				}
			}
		}
		protected ns52.Monetary_form m_Monetary_form;
		
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


