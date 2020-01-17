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

namespace ns51
{
	/// <summary>
	/// 	This class represents the ComplexType fact
	/// </summary>
	[LiquidTechnologies.Runtime.Net40.XmlObjectInfo(LiquidTechnologies.Runtime.Net40.XmlObjectBase.XmlElementGroupType.Sequence,
													LiquidTechnologies.Runtime.Net40.XmlObjectBase.XmlElementType.Element,
													"fact", "urn://egisso-ru/types/package-RAF/1.0.3", true, false)]
	public partial class Fact : schemaEgisso.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		///		Constructor for Fact
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\Users\peter\Documents\Visual Studio 2017\Projects\egisso_\schema0.xsd</BR>
		/// </remarks>
		public Fact()
		{
			_elementName = "fact";
			Init();
		}
		public Fact(String elementName)
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
			m_ID = "";
			m_OSZCode = "";
			m_MSZ_receiver = new schemaEgisso.MSZ_receiver("MSZ_receiver");
			m_Reason_persons = null;
			m_LMSZID = "";
			m_CategoryID = "";
			m_Decision_date = new LiquidTechnologies.Runtime.Net40.XmlDateTime(LiquidTechnologies.Runtime.Net40.XmlDateTime.DateType.date);
			m_DateStart = new LiquidTechnologies.Runtime.Net40.XmlDateTime(LiquidTechnologies.Runtime.Net40.XmlDateTime.DateType.date);
			m_DateFinish = new LiquidTechnologies.Runtime.Net40.XmlDateTime(LiquidTechnologies.Runtime.Net40.XmlDateTime.DateType.date);
			m_NeedsCriteria = new schemaEgisso.NeedsCriteria("needsCriteria");
			m_Assignment_info = new schemaEgisso.Assignment_info("assignment_info");
			m_LastChanging = new LiquidTechnologies.Runtime.Net40.XmlDateTime(LiquidTechnologies.Runtime.Net40.XmlDateTime.DateType.dateTime);
            //


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
			ns51.Fact newObject = new ns51.Fact(_elementName);
			newObject.m_ID = m_ID;
			newObject.m_OSZCode = m_OSZCode;
			newObject.m_MSZ_receiver = null;
			if (m_MSZ_receiver != null)
				newObject.m_MSZ_receiver = (schemaEgisso.MSZ_receiver)m_MSZ_receiver.Clone();
			newObject.m_Reason_persons = null;
			if (m_Reason_persons != null)
				newObject.m_Reason_persons = (schemaEgisso.Reason_persons)m_Reason_persons.Clone();
			newObject.m_LMSZID = m_LMSZID;
			newObject.m_CategoryID = m_CategoryID;
			newObject.m_Decision_date = (LiquidTechnologies.Runtime.Net40.XmlDateTime)m_Decision_date.Clone();
			newObject.m_DateStart = (LiquidTechnologies.Runtime.Net40.XmlDateTime)m_DateStart.Clone();
			newObject.m_DateFinish = (LiquidTechnologies.Runtime.Net40.XmlDateTime)m_DateFinish.Clone();
			newObject.m_NeedsCriteria = null;
			if (m_NeedsCriteria != null)
				newObject.m_NeedsCriteria = (schemaEgisso.NeedsCriteria)m_NeedsCriteria.Clone();
			newObject.m_Assignment_info = null;
			if (m_Assignment_info != null)
				newObject.m_Assignment_info = (schemaEgisso.Assignment_info)m_Assignment_info.Clone();
			newObject.m_LastChanging = (LiquidTechnologies.Runtime.Net40.XmlDateTime)m_LastChanging.Clone();


// ##HAND_CODED_BLOCK_START ID="Additional clone"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional clone code here...

// ##HAND_CODED_BLOCK_END ID="Additional clone"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

			return newObject;
		}
		#endregion

		#region Member variables

		protected override String TargetNamespace
		{
			get { return "urn://egisso-ru/types/package-RAF/1.0.3"; }
		}

		#region Attribute - ID
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
        [LiquidTechnologies.Runtime.Net40.ElementInfoSeqPrimMnd("ID", "urn://egisso-ru/types/assignment-fact/1.0.3", LiquidTechnologies.Runtime.Net40.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net40.WhitespaceUtils.WhitespaceRule.Preserve, "", -1, -1, "", "", "", "", -1)]
		public String ID
		{
			get 
			{ 
				return m_ID;  
			}
			set 
			{ 
				// Apply whitespace rules appropriatley
				value = LiquidTechnologies.Runtime.Net40.WhitespaceUtils.Preserve(value); 
				m_ID = value;
			}
		}
		protected String m_ID;

		#endregion
		#region Attribute - OSZCode
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
        [LiquidTechnologies.Runtime.Net40.ElementInfoSeqPrimMnd("OSZCode", "urn://egisso-ru/types/assignment-fact/1.0.3", LiquidTechnologies.Runtime.Net40.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net40.WhitespaceUtils.WhitespaceRule.Preserve, "", -1, -1, "", "", "", "", -1)]
		public String OSZCode
		{
			get 
			{ 
				return m_OSZCode;  
			}
			set 
			{ 
				// Apply whitespace rules appropriatley
				value = LiquidTechnologies.Runtime.Net40.WhitespaceUtils.Preserve(value); 
				m_OSZCode = value;
			}
		}
		protected String m_OSZCode;

		#endregion
		#region Attribute - MSZ_receiver
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
        [LiquidTechnologies.Runtime.Net40.ElementInfoSeqClsMnd("MSZ_receiver", "urn://egisso-ru/types/assignment-fact/1.0.3", LiquidTechnologies.Runtime.Net40.XmlObjectBase.XmlElementType.Element, typeof(schemaEgisso.MSZ_receiver), true)]
		public schemaEgisso.MSZ_receiver MSZ_receiver
		{
			get 
			{ 
				return m_MSZ_receiver;  
			}
			set 
			{ 
				Throw_IfPropertyIsNull(value, "MSZ_receiver");
				if (value != null)
					SetElementName(value, "MSZ_receiver");
				m_MSZ_receiver = value;
			}
		}
		protected schemaEgisso.MSZ_receiver m_MSZ_receiver;
		
		#endregion
		#region Attribute - reason_persons
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net40.ElementInfoSeqClsOpt("reason_persons", "urn://egisso-ru/types/assignment-fact/1.0.3", LiquidTechnologies.Runtime.Net40.XmlObjectBase.XmlElementType.Element, typeof(schemaEgisso.Reason_persons))]
		public schemaEgisso.Reason_persons Reason_persons
		{
			get 
			{ 
				return m_Reason_persons;  
			}
			set 
			{ 
				if (value == null)
					m_Reason_persons = null;
				else
				{
					SetElementName(value, "reason_persons");
					m_Reason_persons = value; 
				}
			}
		}
		protected schemaEgisso.Reason_persons m_Reason_persons;
		
		#endregion
		#region Attribute - LMSZID
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
        [LiquidTechnologies.Runtime.Net40.ElementInfoSeqPrimMnd("LMSZID", "urn://egisso-ru/types/assignment-fact/1.0.3", LiquidTechnologies.Runtime.Net40.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net40.WhitespaceUtils.WhitespaceRule.Preserve, "", -1, -1, "", "", "", "", -1)]
		public String LMSZID
		{
			get 
			{ 
				return m_LMSZID;  
			}
			set 
			{ 
				// Apply whitespace rules appropriatley
				value = LiquidTechnologies.Runtime.Net40.WhitespaceUtils.Preserve(value); 
				m_LMSZID = value;
			}
		}
		protected String m_LMSZID;

		#endregion
		#region Attribute - categoryID
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
        [LiquidTechnologies.Runtime.Net40.ElementInfoSeqPrimMnd("categoryID", "urn://egisso-ru/types/assignment-fact/1.0.3", LiquidTechnologies.Runtime.Net40.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net40.WhitespaceUtils.WhitespaceRule.Preserve, "", -1, -1, "", "", "", "", -1)]
		public String CategoryID
		{
			get 
			{ 
				return m_CategoryID;  
			}
			set 
			{ 
				// Apply whitespace rules appropriatley
				value = LiquidTechnologies.Runtime.Net40.WhitespaceUtils.Preserve(value); 
				m_CategoryID = value;
			}
		}
		protected String m_CategoryID;

		#endregion
		#region Attribute - decision_date
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
        [LiquidTechnologies.Runtime.Net40.ElementInfoSeqPrimMnd("decision_date", "urn://egisso-ru/types/assignment-fact/1.0.3", LiquidTechnologies.Runtime.Net40.Conversions.ConversionType.type_date, null, LiquidTechnologies.Runtime.Net40.WhitespaceUtils.WhitespaceRule.Collapse, "", -1, -1, "", "", "", "", -1)]
		public LiquidTechnologies.Runtime.Net40.XmlDateTime Decision_date
		{
			get 
			{ 
				return m_Decision_date;  
			}
			set 
			{ 
				m_Decision_date.SetDateTime(value, m_Decision_date.Type); 
			}
		}
		protected LiquidTechnologies.Runtime.Net40.XmlDateTime m_Decision_date;

		#endregion
		#region Attribute - dateStart
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
        [LiquidTechnologies.Runtime.Net40.ElementInfoSeqPrimMnd("dateStart", "urn://egisso-ru/types/assignment-fact/1.0.3", LiquidTechnologies.Runtime.Net40.Conversions.ConversionType.type_date, null, LiquidTechnologies.Runtime.Net40.WhitespaceUtils.WhitespaceRule.Collapse, "", -1, -1, "", "", "", "", -1)]
		public LiquidTechnologies.Runtime.Net40.XmlDateTime DateStart
		{
			get 
			{ 
				return m_DateStart;  
			}
			set 
			{ 
				m_DateStart.SetDateTime(value, m_DateStart.Type); 
			}
		}
		protected LiquidTechnologies.Runtime.Net40.XmlDateTime m_DateStart;

		#endregion
		#region Attribute - dateFinish
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
        [LiquidTechnologies.Runtime.Net40.ElementInfoSeqPrimMnd("dateFinish", "urn://egisso-ru/types/assignment-fact/1.0.3", LiquidTechnologies.Runtime.Net40.Conversions.ConversionType.type_date, null, LiquidTechnologies.Runtime.Net40.WhitespaceUtils.WhitespaceRule.Collapse, "", -1, -1, "", "", "", "", -1)]
		public LiquidTechnologies.Runtime.Net40.XmlDateTime DateFinish
		{
			get 
			{ 
				return m_DateFinish;  
			}
			set 
			{ 
				m_DateFinish.SetDateTime(value, m_DateFinish.Type); 
			}
		}
		protected LiquidTechnologies.Runtime.Net40.XmlDateTime m_DateFinish;

		#endregion
		#region Attribute - needsCriteria
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
        [LiquidTechnologies.Runtime.Net40.ElementInfoSeqClsMnd("needsCriteria", "urn://egisso-ru/types/assignment-fact/1.0.3", LiquidTechnologies.Runtime.Net40.XmlObjectBase.XmlElementType.Element, typeof(schemaEgisso.NeedsCriteria), true)]
		public schemaEgisso.NeedsCriteria NeedsCriteria
		{
			get 
			{ 
				return m_NeedsCriteria;  
			}
			set 
			{ 
				Throw_IfPropertyIsNull(value, "needsCriteria");
				if (value != null)
					SetElementName(value, "needsCriteria");
				m_NeedsCriteria = value;
			}
		}
		protected schemaEgisso.NeedsCriteria m_NeedsCriteria;
		
		#endregion
		#region Attribute - assignment_info
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
        [LiquidTechnologies.Runtime.Net40.ElementInfoSeqClsMnd("assignment_info", "urn://egisso-ru/types/assignment-fact/1.0.3", LiquidTechnologies.Runtime.Net40.XmlObjectBase.XmlElementType.Element, typeof(schemaEgisso.Assignment_info), false)]
		public schemaEgisso.Assignment_info Assignment_info
		{
			get 
			{ 
				return m_Assignment_info;  
			}
			set 
			{ 
				Throw_IfPropertyIsNull(value, "assignment_info");
				if (value != null)
					SetElementName(value, "assignment_info");
				m_Assignment_info = value;
			}
		}
		protected schemaEgisso.Assignment_info m_Assignment_info;
		
		#endregion
		#region Attribute - lastChanging
		/// <summary>
		///		Represents a mandatory Element in the XML document
		///		
		/// </summary>
		/// <remarks>
		///		<BR></BR>
		///		<BR>This property is represented as an Element in the XML.</BR>
		///		<BR>It is mandatory and therefore must be populated within the XML.</BR>
		///		<BR>It is defaulted to new LiquidTechnologies.Runtime.Net40.XmlDateTime(LiquidTechnologies.Runtime.Net40.XmlDateTime.DateType.dateTime).</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net40.ElementInfoSeqPrimMnd("lastChanging", "urn://egisso-ru/types/package-RAF/1.0.3", LiquidTechnologies.Runtime.Net40.Conversions.ConversionType.type_datetime, null, LiquidTechnologies.Runtime.Net40.WhitespaceUtils.WhitespaceRule.Collapse, "", -1, -1, "", "", "", "", -1)]
		public LiquidTechnologies.Runtime.Net40.XmlDateTime LastChanging
		{
			get 
			{ 
				return m_LastChanging;  
			}
			set 
			{ 
				m_LastChanging.SetDateTime(value, m_LastChanging.Type); 
			}
		}
		protected LiquidTechnologies.Runtime.Net40.XmlDateTime m_LastChanging;

		#endregion
	
		#region Attribute - Namespace
		public override String Namespace
		{
			get { return "urn://egisso-ru/types/package-RAF/1.0.3"; }
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


