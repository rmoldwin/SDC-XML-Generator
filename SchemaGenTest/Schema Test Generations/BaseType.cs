// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code++. Version 4.2.0.15
//  </auto-generated>
// ------------------------------------------------------------------------------
#pragma warning disable
namespace SDC
{
using System;
using System.Diagnostics;
using System.Xml.Serialization;
using System.Collections;
using System.Xml.Schema;
using System.ComponentModel;
using System.Collections.Specialized;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.Reflection;
using System.IO;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Xml;

[XmlIncludeAttribute(typeof(gYearMonth_Stype))]
[XmlIncludeAttribute(typeof(gYearMonth_DEtype))]
[XmlIncludeAttribute(typeof(dayTimeDuration_Stype))]
[XmlIncludeAttribute(typeof(dayTimeDuration_DEtype))]
[XmlIncludeAttribute(typeof(IfBoolCompareType))]
[XmlIncludeAttribute(typeof(MaxExclusiveType))]
[XmlIncludeAttribute(typeof(MaxInclusiveType))]
[XmlIncludeAttribute(typeof(MinExclusiveType))]
[XmlIncludeAttribute(typeof(MinInclusiveType))]
[XmlIncludeAttribute(typeof(ItemNameType))]
[XmlIncludeAttribute(typeof(GetCodeType))]
[XmlIncludeAttribute(typeof(DestinationType))]
[XmlIncludeAttribute(typeof(ChangeTrackingType))]
[XmlIncludeAttribute(typeof(ReplacedIDsType))]
[XmlIncludeAttribute(typeof(TargetItemNameType))]
[XmlIncludeAttribute(typeof(AreaCodeType))]
[XmlIncludeAttribute(typeof(CountryCodeType))]
[XmlIncludeAttribute(typeof(dateTime_Stype))]
[XmlIncludeAttribute(typeof(dateTime_DEtype))]
[XmlIncludeAttribute(typeof(CodeMatchType))]
[XmlIncludeAttribute(typeof(PhoneNumberType))]
[XmlIncludeAttribute(typeof(EmailAddressType))]
[XmlIncludeAttribute(typeof(yearMonthDuration_Stype))]
[XmlIncludeAttribute(typeof(yearMonthDuration_DEtype))]
[XmlIncludeAttribute(typeof(XML_Stype))]
[XmlIncludeAttribute(typeof(XML_DEtype))]
[XmlIncludeAttribute(typeof(unsignedShort_Stype))]
[XmlIncludeAttribute(typeof(unsignedShort_DEtype))]
[XmlIncludeAttribute(typeof(unsignedLong_Stype))]
[XmlIncludeAttribute(typeof(unsignedLong_DEtype))]
[XmlIncludeAttribute(typeof(unsignedInt_Stype))]
[XmlIncludeAttribute(typeof(unsignedInt_DEtype))]
[XmlIncludeAttribute(typeof(unsignedByte_Stype))]
[XmlIncludeAttribute(typeof(unsignedByte_DEtype))]
[XmlIncludeAttribute(typeof(time_Stype))]
[XmlIncludeAttribute(typeof(time_DEtype))]
[XmlIncludeAttribute(typeof(string_Stype))]
[XmlIncludeAttribute(typeof(FileHashType))]
[XmlIncludeAttribute(typeof(TargetItemXPathType))]
[XmlIncludeAttribute(typeof(LanguageCodeISO6393_Type))]
[XmlIncludeAttribute(typeof(UnitsType))]
[XmlIncludeAttribute(typeof(AcceptabilityType))]
[XmlIncludeAttribute(typeof(string_DEtype))]
[XmlIncludeAttribute(typeof(short_Stype))]
[XmlIncludeAttribute(typeof(short_DEtype))]
[XmlIncludeAttribute(typeof(positiveInteger_Stype))]
[XmlIncludeAttribute(typeof(positiveInteger_DEtype))]
[XmlIncludeAttribute(typeof(nonPositiveInteger_Stype))]
[XmlIncludeAttribute(typeof(nonPositiveInteger_DEtype))]
[XmlIncludeAttribute(typeof(nonNegativeInteger_Stype))]
[XmlIncludeAttribute(typeof(nonNegativeInteger_DEtype))]
[XmlIncludeAttribute(typeof(negativeInteger_Stype))]
[XmlIncludeAttribute(typeof(negativeInteger_DEtype))]
[XmlIncludeAttribute(typeof(long_Stype))]
[XmlIncludeAttribute(typeof(long_DEtype))]
[XmlIncludeAttribute(typeof(HTML_Stype))]
[XmlIncludeAttribute(typeof(HTML_DEtype))]
[XmlIncludeAttribute(typeof(hexBinary_Stype))]
[XmlIncludeAttribute(typeof(hexBinary_DEtype))]
[XmlIncludeAttribute(typeof(gYear_Stype))]
[XmlIncludeAttribute(typeof(gYear_DEtype))]
[XmlIncludeAttribute(typeof(gMonthDay_Stype))]
[XmlIncludeAttribute(typeof(gMonthDay_DEtype))]
[XmlIncludeAttribute(typeof(gMonth_Stype))]
[XmlIncludeAttribute(typeof(gMonth_DEtype))]
[XmlIncludeAttribute(typeof(gDay_Stype))]
[XmlIncludeAttribute(typeof(gDay_DEtype))]
[XmlIncludeAttribute(typeof(float_Stype))]
[XmlIncludeAttribute(typeof(float_DEtype))]
[XmlIncludeAttribute(typeof(double_Stype))]
[XmlIncludeAttribute(typeof(double_DEtype))]
[XmlIncludeAttribute(typeof(decimal_Stype))]
[XmlIncludeAttribute(typeof(decimal_DEtype))]
[XmlIncludeAttribute(typeof(dateTimeStamp_Stype))]
[XmlIncludeAttribute(typeof(dateTimeStamp_DEtype))]
[XmlIncludeAttribute(typeof(date_Stype))]
[XmlIncludeAttribute(typeof(date_DEtype))]
[XmlIncludeAttribute(typeof(byte_Stype))]
[XmlIncludeAttribute(typeof(byte_DEtype))]
[XmlIncludeAttribute(typeof(integer_Stype))]
[XmlIncludeAttribute(typeof(integer_DEtype))]
[XmlIncludeAttribute(typeof(int_Stype))]
[XmlIncludeAttribute(typeof(int_DEtype))]
[XmlIncludeAttribute(typeof(duration_Stype))]
[XmlIncludeAttribute(typeof(duration_DEtype))]
[XmlIncludeAttribute(typeof(boolean_Stype))]
[XmlIncludeAttribute(typeof(boolean_DEtype))]
[XmlIncludeAttribute(typeof(base64Binary_Stype))]
[XmlIncludeAttribute(typeof(HashType))]
[XmlIncludeAttribute(typeof(base64Binary_DEtype))]
[XmlIncludeAttribute(typeof(anyURI_Stype))]
[XmlIncludeAttribute(typeof(TargetItemIDType))]
[XmlIncludeAttribute(typeof(anyURI_DEtype))]
[XmlIncludeAttribute(typeof(anyType_DEtype))]
[XmlIncludeAttribute(typeof(ExtensionType))]
[XmlIncludeAttribute(typeof(CommentType))]
[XmlIncludeAttribute(typeof(ExtensionBaseType))]
[XmlIncludeAttribute(typeof(RulesType))]
[XmlIncludeAttribute(typeof(ChangedSelectedItemsType))]
[XmlIncludeAttribute(typeof(ReplacedResponseType))]
[XmlIncludeAttribute(typeof(ResponseChangeType))]
[XmlIncludeAttribute(typeof(ListType))]
[XmlIncludeAttribute(typeof(ListFieldType))]
[XmlIncludeAttribute(typeof(ChildItemsType))]
[XmlIncludeAttribute(typeof(ResponseFieldType))]
[XmlIncludeAttribute(typeof(ListItemResponseFieldType))]
[XmlIncludeAttribute(typeof(ActValidateFormType))]
[XmlIncludeAttribute(typeof(ActSendReportType))]
[XmlIncludeAttribute(typeof(ActShowReportType))]
[XmlIncludeAttribute(typeof(ActSaveResponsesType))]
[XmlIncludeAttribute(typeof(ActShowFormType))]
[XmlIncludeAttribute(typeof(ActShowMessageType))]
[XmlIncludeAttribute(typeof(ActSetValueType))]
[XmlIncludeAttribute(typeof(SetPropertyType))]
[XmlIncludeAttribute(typeof(ThenType))]
[XmlIncludeAttribute(typeof(PredicateBetweenType))]
[XmlIncludeAttribute(typeof(PredicateInListType))]
[XmlIncludeAttribute(typeof(PredicateCompareType))]
[XmlIncludeAttribute(typeof(ScriptCodeType))]
[XmlIncludeAttribute(typeof(ExpressionType))]
[XmlIncludeAttribute(typeof(PredicateType))]
[XmlIncludeAttribute(typeof(ExclusiveItemPairsType))]
[XmlIncludeAttribute(typeof(GetPropertyValuesType))]
[XmlIncludeAttribute(typeof(IfType))]
[XmlIncludeAttribute(typeof(WatchedPropertyType))]
[XmlIncludeAttribute(typeof(IfThenType))]
[XmlIncludeAttribute(typeof(OnEventType))]
[XmlIncludeAttribute(typeof(IdentifiedExtensionType))]
[XmlIncludeAttribute(typeof(ChangedListItemType))]
[XmlIncludeAttribute(typeof(DisplayedType))]
[XmlIncludeAttribute(typeof(ButtonItemType))]
[XmlIncludeAttribute(typeof(RepeatingType))]
[XmlIncludeAttribute(typeof(QuestionItemBaseType))]
[XmlIncludeAttribute(typeof(QuestionItemType))]
[XmlIncludeAttribute(typeof(SectionBaseType))]
[XmlIncludeAttribute(typeof(SectionItemType))]
[XmlIncludeAttribute(typeof(ListItemBaseType))]
[XmlIncludeAttribute(typeof(ListItemType))]
[XmlIncludeAttribute(typeof(FormDesignType))]
[XmlIncludeAttribute(typeof(InjectFormType))]
[XmlIncludeAttribute(typeof(ActInjectType))]
[XmlIncludeAttribute(typeof(LinkType))]
[XmlIncludeAttribute(typeof(ChangeType))]
[XmlIncludeAttribute(typeof(ComplianceRuleType))]
[XmlIncludeAttribute(typeof(SubmissionRuleType))]
[XmlIncludeAttribute(typeof(ProvenanceType))]
[XmlIncludeAttribute(typeof(AssociatedFilesType))]
[XmlIncludeAttribute(typeof(LanguageType))]
[XmlIncludeAttribute(typeof(ApprovalType))]
[XmlIncludeAttribute(typeof(FileDatesType))]
[XmlIncludeAttribute(typeof(FileUsageType))]
[XmlIncludeAttribute(typeof(ContactsType))]
[XmlIncludeAttribute(typeof(ChangedFieldType))]
[XmlIncludeAttribute(typeof(ChangeLogType))]
[XmlIncludeAttribute(typeof(VersionType))]
[XmlIncludeAttribute(typeof(FileType))]
[XmlIncludeAttribute(typeof(IdentifierType))]
[XmlIncludeAttribute(typeof(PhoneType))]
[XmlIncludeAttribute(typeof(EmailType))]
[XmlIncludeAttribute(typeof(AddressType))]
[XmlIncludeAttribute(typeof(OrganizationType))]
[XmlIncludeAttribute(typeof(JobType))]
[XmlIncludeAttribute(typeof(NameType))]
[XmlIncludeAttribute(typeof(PersonType))]
[XmlIncludeAttribute(typeof(ContactType))]
[XmlIncludeAttribute(typeof(CodeSystemType))]
[XmlIncludeAttribute(typeof(CodingType))]
[XmlIncludeAttribute(typeof(ParameterType))]
[XmlIncludeAttribute(typeof(WebServiceType))]
[XmlIncludeAttribute(typeof(LookupEndPointType))]
[XmlIncludeAttribute(typeof(RichTextType))]
[XmlIncludeAttribute(typeof(ActSendMessageType))]
[XmlIncludeAttribute(typeof(BlobType))]
[XmlIncludeAttribute(typeof(DataTypes_SType))]
[XmlIncludeAttribute(typeof(DataTypes_DEType))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1067.0")]
[Serializable]
[DebuggerStepThrough]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[XmlTypeAttribute(Namespace="http://healthIT.gov/sdc")]
[DataContractAttribute(Name="BaseType", Namespace="http://healthIT.gov/sdc")]
public abstract partial class BaseType : INotifyPropertyChanged
{
    
    private bool _shouldSerializeorder;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private string _name;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private string _type;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private string _styleClass;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private System.Nullable<decimal> _order;
    
    private static XmlSerializer serializer;
    
    private ObjectChangeTracker changeTrackerField;
    
    /// <summary>
    /// Developer assigned identifier, similar to a unique control/object
    /// name, used to provide the ability for programmatic manipulation of an
    /// element.
    /// </summary>
    [XmlAttributeAttribute(DataType="ID")]
    [DataMember]
    public virtual string name
    {
        get
        {
            return _name;
        }
        set
        {
            if ((_name == value))
            {
                return;
            }
            if (((_name == null) 
                        || (_name.Equals(value) != true)))
            {
                _name = value;
                OnPropertyChanged("name", value);
            }
        }
    }
    
    /// <summary>
    /// The @type attribute can contain custom metadata "tokens" for the
    /// element, chosen from a standardized list of terms. Tokens are short alphanumeric
    /// text strings, defined by the W3C Schema NMTOKEN specification, that are defined
    /// in an Implementation Guide. The type xsd:NMTOKEN represents a single string
    /// token. NMTOKEN values may consist of letters, digits, periods ( . ), hyphens ( -
    /// ), underscores ( _ ), and colons ( : ). They may start with any of these
    /// characters. (www.datypic.com/sc/xsd/t-xsd_NMTOKEN.html) @type tokens may be
    /// specific for one or more kinds of SDC elements. Multiple tokens in the type
    /// attribute should be separated by whitespace. Type tokens may be used to specify
    /// special handling by an application, and are usually used to define form display
    /// constraints, but may include other custom metadata as well. Style metadata
    /// should generally be handled with @styleClass rather than @type. @type token
    /// examples include: tooltip, statusLineText, alignTopLeft, align:bottom,
    /// _pageBreak-after, etc. @type metadata should generally not affect the
    /// information content of a form.
    /// </summary>
    [XmlAttributeAttribute(DataType="NMTOKENS")]
    [DataMember]
    public virtual string type
    {
        get
        {
            return _type;
        }
        set
        {
            if ((_type == value))
            {
                return;
            }
            if (((_type == null) 
                        || (_type.Equals(value) != true)))
            {
                _type = value;
                OnPropertyChanged("type", value);
            }
        }
    }
    
    /// <summary>
    /// Developer assigned class name for display styling, generally for
    /// use with an external style sheet.
    /// </summary>
    [XmlAttributeAttribute(DataType="NMTOKENS")]
    [DataMember]
    public virtual string styleClass
    {
        get
        {
            return _styleClass;
        }
        set
        {
            if ((_styleClass == value))
            {
                return;
            }
            if (((_styleClass == null) 
                        || (_styleClass.Equals(value) != true)))
            {
                _styleClass = value;
                OnPropertyChanged("styleClass", value);
            }
        }
    }
    
    /// <summary>
    /// @order allows the form template developer to define a sequential
    /// order for elements in a template. This serves the purpose of providing a
    /// definitive/original order to sections, questions, answer choices, etc., when
    /// required for display purposes. This is important when the original XML ordering
    /// may become disrupted due to the use of an implementation technology that does
    /// not natively support ordering (e.g., object collections), and it can also
    /// provide a check on the proper importing of the XML tree during
    /// implementation.
    /// </summary>
    [XmlAttribute]
    [DataMember]
    public virtual decimal order
    {
        get
        {
            if (_order.HasValue)
            {
                return _order.Value;
            }
            else
            {
                return default(decimal);
            }
        }
        set
        {
            if ((_order.Equals(value) != true))
            {
                _order = value;
                OnPropertyChanged("order", value);
            }
            _shouldSerializeorder = true;
        }
    }
    
    [XmlIgnore]
    [DataMember]
    public virtual bool orderSpecified
    {
        get
        {
            return _order.HasValue;
        }
        set
        {
            if (value==false)
            {
                _order = null;
            }
        }
    }
    
    private static XmlSerializer Serializer
    {
        get
        {
            if ((serializer == null))
            {
                serializer = new XmlSerializerFactory().CreateSerializer(typeof(BaseType));
            }
            return serializer;
        }
    }
    
    [XmlIgnore()]
    public ObjectChangeTracker ChangeTracker
    {
        get
        {
            if ((changeTrackerField == null))
            {
                changeTrackerField = new ObjectChangeTracker(this);
            }
            return changeTrackerField;
        }
    }
    
    public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
    
    /// <summary>
    /// Test whether order should be serialized
    /// </summary>
    public virtual bool ShouldSerializeorder()
    {
        if (_shouldSerializeorder)
        {
            return true;
        }
        return (_order != default(decimal));
    }
    
    /// <summary>
    /// Test whether name should be serialized
    /// </summary>
    public virtual bool ShouldSerializename()
    {
        return !string.IsNullOrEmpty(name);
    }
    
    /// <summary>
    /// Test whether type should be serialized
    /// </summary>
    public virtual bool ShouldSerializetype()
    {
        return !string.IsNullOrEmpty(type);
    }
    
    /// <summary>
    /// Test whether styleClass should be serialized
    /// </summary>
    public virtual bool ShouldSerializestyleClass()
    {
        return !string.IsNullOrEmpty(styleClass);
    }
    
    public virtual void OnPropertyChanged(string propertyName, object value)
    {
        ChangeTracker.RecordCurrentValue(propertyName, value);
        System.ComponentModel.PropertyChangedEventHandler handler = PropertyChanged;
        if ((handler != null))
        {
            handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    }
    
    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current BaseType object into an XML string
    /// </summary>
    /// <returns>string XML value</returns>
    public virtual string Serialize()
    {
        StreamReader streamReader = null;
        MemoryStream memoryStream = null;
        try
        {
            memoryStream = new MemoryStream();
            System.Xml.XmlWriterSettings xmlWriterSettings = new System.Xml.XmlWriterSettings();
            xmlWriterSettings.Indent = true;
            System.Xml.XmlWriter xmlWriter = XmlWriter.Create(memoryStream, xmlWriterSettings);
            Serializer.Serialize(xmlWriter, this);
            memoryStream.Seek(0, SeekOrigin.Begin);
            streamReader = new StreamReader(memoryStream);
            return streamReader.ReadToEnd();
        }
        finally
        {
            if ((streamReader != null))
            {
                streamReader.Dispose();
            }
            if ((memoryStream != null))
            {
                memoryStream.Dispose();
            }
        }
    }
    
    /// <summary>
    /// Deserializes workflow markup into an BaseType object
    /// </summary>
    /// <param name="input">string workflow markup to deserialize</param>
    /// <param name="obj">Output BaseType object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string input, out BaseType obj, out Exception exception)
    {
        exception = null;
        obj = default(BaseType);
        try
        {
            obj = Deserialize(input);
            return true;
        }
        catch (Exception ex)
        {
            exception = ex;
            return false;
        }
    }
    
    public static bool Deserialize(string input, out BaseType obj)
    {
        Exception exception = null;
        return Deserialize(input, out obj, out exception);
    }
    
    public new static BaseType Deserialize(string input)
    {
        StringReader stringReader = null;
        try
        {
            stringReader = new StringReader(input);
            return ((BaseType)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
        }
        finally
        {
            if ((stringReader != null))
            {
                stringReader.Dispose();
            }
        }
    }
    
    public static BaseType Deserialize(Stream s)
    {
        return ((BaseType)(Serializer.Deserialize(s)));
    }
    #endregion
    
    /// <summary>
    /// Serializes current BaseType object into file
    /// </summary>
    /// <param name="fileName">full path of outupt xml file</param>
    /// <param name="exception">output Exception value if failed</param>
    /// <returns>true if can serialize and save into file; otherwise, false</returns>
    public virtual bool SaveToFile(string fileName, out Exception exception)
    {
        exception = null;
        try
        {
            SaveToFile(fileName);
            return true;
        }
        catch (Exception e)
        {
            exception = e;
            return false;
        }
    }
    
    public virtual void SaveToFile(string fileName)
    {
        StreamWriter streamWriter = null;
        try
        {
            string xmlString = Serialize();
            FileInfo xmlFile = new FileInfo(fileName);
            streamWriter = xmlFile.CreateText();
            streamWriter.WriteLine(xmlString);
            streamWriter.Close();
        }
        finally
        {
            if ((streamWriter != null))
            {
                streamWriter.Dispose();
            }
        }
    }
    
    /// <summary>
    /// Deserializes xml markup from file into an BaseType object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output BaseType object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out BaseType obj, out Exception exception)
    {
        exception = null;
        obj = default(BaseType);
        try
        {
            obj = LoadFromFile(fileName);
            return true;
        }
        catch (Exception ex)
        {
            exception = ex;
            return false;
        }
    }
    
    public static bool LoadFromFile(string fileName, out BaseType obj)
    {
        Exception exception = null;
        return LoadFromFile(fileName, out obj, out exception);
    }
    
    public new static BaseType LoadFromFile(string fileName)
    {
        FileStream file = null;
        StreamReader sr = null;
        try
        {
            file = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            sr = new StreamReader(file);
            string xmlString = sr.ReadToEnd();
            sr.Close();
            file.Close();
            return Deserialize(xmlString);
        }
        finally
        {
            if ((file != null))
            {
                file.Dispose();
            }
            if ((sr != null))
            {
                sr.Dispose();
            }
        }
    }
    
    #region Clone method
    /// <summary>
    /// Create a clone of this BaseType object
    /// </summary>
    public virtual BaseType Clone()
    {
        return ((BaseType)(MemberwiseClone()));
    }
    #endregion
}
}
#pragma warning restore
