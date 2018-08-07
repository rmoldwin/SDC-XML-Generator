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

/// <summary>
/// This type represents any object that is designed to have a visual presence on a form, e.g., Sections, Questions, ListItems, Notes and Blobs.  (Other items not inheriting this type may use an optional styleClass attribute.)
/// </summary>
[XmlIncludeAttribute(typeof(ButtonItemType))]
[XmlIncludeAttribute(typeof(RepeatingType))]
[XmlIncludeAttribute(typeof(QuestionItemBaseType))]
[XmlIncludeAttribute(typeof(QuestionItemType))]
[XmlIncludeAttribute(typeof(SectionBaseType))]
[XmlIncludeAttribute(typeof(SectionItemType))]
[XmlIncludeAttribute(typeof(ListItemBaseType))]
[XmlIncludeAttribute(typeof(ListItemType))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1067.0")]
[Serializable]
[DebuggerStepThrough]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[XmlTypeAttribute(Namespace="http://healthIT.gov/sdc")]
[DataContractAttribute(Name="DisplayedType", Namespace="http://healthIT.gov/sdc")]
public partial class DisplayedType : IdentifiedExtensionType
{
    
    private bool _shouldSerializeshowInReport;
    
    private bool _shouldSerializemustImplement;
    
    private bool _shouldSerializevisible;
    
    private bool _shouldSerializeenabled;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private BindingList<RichTextType> _otherText;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private BindingList<LinkType> _link;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private BindingList<BlobType> _blobContent;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private BindingList<ContactType> _contact;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private BindingList<CodingType> _codedValue;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private BindingList<IfThenType> _onEnter;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private BindingList<IfThenType> _onExit;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private BindingList<OnEventType> _onEvent;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private WatchedPropertyType _activateIf;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private WatchedPropertyType _deActivateIf;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private string _title;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private bool _enabled;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private bool _visible;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private bool _mustImplement;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private bool _showInReport;
    
    private static XmlSerializer serializer;
    
    private ObjectChangeTracker changeTrackerField;
    
    /// <summary>
    /// DisplayedType class constructor
    /// </summary>
    public DisplayedType()
    {
        _enabled = true;
        _visible = true;
        _mustImplement = true;
        _showInReport = true;
    }
    
    /// <summary>
    /// OtherText is any type of secondary text that is associated with any form item (e.g., section, question, list item) in any context.  The Description context is specified by the @type attribute.  Examples of Description @type values may include:
    /// -alternate language representations,
    /// -explanations for the user of the form,
    /// -tooltips,
    /// -pop-up help,
    /// -outlining (such as question numbering)
    /// 
    /// The @type enumerations must be defined and documented for the particular use case, and are currently out of scope in this schema definition.
    /// </summary>
    [XmlElementAttribute("OtherText", Order=0)]
    [DataMemberAttribute(Order=0)]
    public virtual BindingList<RichTextType> OtherText
    {
        get
        {
            return _otherText;
        }
        set
        {
            if ((_otherText == value))
            {
                return;
            }
            if (((_otherText == null) 
                        || (_otherText.Equals(value) != true)))
            {
                _otherText = value;
                OnPropertyChanged("OtherText", value);
            }
        }
    }
    
    /// <summary>
    /// Link to external information.
    /// </summary>
    [XmlElementAttribute("Link", Order=1)]
    [DataMemberAttribute(Order=1)]
    public virtual BindingList<LinkType> Link
    {
        get
        {
            return _link;
        }
        set
        {
            if ((_link == value))
            {
                return;
            }
            if (((_link == null) 
                        || (_link.Equals(value) != true)))
            {
                _link = value;
                OnPropertyChanged("Link", value);
            }
        }
    }
    
    /// <summary>
    /// Blob information associated with the current DisplayedType.  The blob may contain any type of special media, but must be base 64 encoded.
    /// </summary>
    [XmlElementAttribute("BlobContent", Order=2)]
    [DataMemberAttribute(Order=2)]
    public virtual BindingList<BlobType> BlobContent
    {
        get
        {
            return _blobContent;
        }
        set
        {
            if ((_blobContent == value))
            {
                return;
            }
            if (((_blobContent == null) 
                        || (_blobContent.Equals(value) != true)))
            {
                _blobContent = value;
                OnPropertyChanged("BlobContent", value);
            }
        }
    }
    
    /// <summary>
    /// Any desired contact information regarding, e.g., the form item, authoring process, certifications, code or coding processs.
    /// </summary>
    [XmlElementAttribute("Contact", Order=3)]
    [DataMemberAttribute(Order=3)]
    public virtual BindingList<ContactType> Contact
    {
        get
        {
            return _contact;
        }
        set
        {
            if ((_contact == value))
            {
                return;
            }
            if (((_contact == null) 
                        || (_contact.Equals(value) != true)))
            {
                _contact = value;
                OnPropertyChanged("Contact", value);
            }
        }
    }
    
    /// <summary>
    /// Coding, terminology, classification, keyword, or local values
    /// </summary>
    [XmlElementAttribute("CodedValue", Order=4)]
    [DataMemberAttribute(Order=4)]
    public virtual BindingList<CodingType> CodedValue
    {
        get
        {
            return _codedValue;
        }
        set
        {
            if ((_codedValue == value))
            {
                return;
            }
            if (((_codedValue == null) 
                        || (_codedValue.Equals(value) != true)))
            {
                _codedValue = value;
                OnPropertyChanged("CodedValue", value);
            }
        }
    }
    
    [XmlElementAttribute("OnEnter", Order=5)]
    [DataMemberAttribute(Order=5)]
    public virtual BindingList<IfThenType> OnEnter
    {
        get
        {
            return _onEnter;
        }
        set
        {
            if ((_onEnter == value))
            {
                return;
            }
            if (((_onEnter == null) 
                        || (_onEnter.Equals(value) != true)))
            {
                _onEnter = value;
                OnPropertyChanged("OnEnter", value);
            }
        }
    }
    
    [XmlElementAttribute("OnExit", Order=6)]
    [DataMemberAttribute(Order=6)]
    public virtual BindingList<IfThenType> OnExit
    {
        get
        {
            return _onExit;
        }
        set
        {
            if ((_onExit == value))
            {
                return;
            }
            if (((_onExit == null) 
                        || (_onExit.Equals(value) != true)))
            {
                _onExit = value;
                OnPropertyChanged("OnExit", value);
            }
        }
    }
    
    /// <summary>
    /// Generic event handler - eventName must be specified.
    /// </summary>
    [XmlElementAttribute("OnEvent", Order=7)]
    [DataMemberAttribute(Order=7)]
    public virtual BindingList<OnEventType> OnEvent
    {
        get
        {
            return _onEvent;
        }
        set
        {
            if ((_onEvent == value))
            {
                return;
            }
            if (((_onEvent == null) 
                        || (_onEvent.Equals(value) != true)))
            {
                _onEvent = value;
                OnPropertyChanged("OnEvent", value);
            }
        }
    }
    
    /// <summary>
    /// Activate the DisplayedType item if the contained conditions are met.
    /// </summary>
    [XmlElementAttribute(Order=8)]
    [DataMemberAttribute(Order=8)]
    public virtual WatchedPropertyType ActivateIf
    {
        get
        {
            return _activateIf;
        }
        set
        {
            if ((_activateIf == value))
            {
                return;
            }
            if (((_activateIf == null) 
                        || (_activateIf.Equals(value) != true)))
            {
                _activateIf = value;
                OnPropertyChanged("ActivateIf", value);
            }
        }
    }
    
    /// <summary>
    /// DeActivate the DisplayedType item if the contained conditions are met.
    /// </summary>
    [XmlElementAttribute(Order=9)]
    [DataMemberAttribute(Order=9)]
    public virtual WatchedPropertyType DeActivateIf
    {
        get
        {
            return _deActivateIf;
        }
        set
        {
            if ((_deActivateIf == value))
            {
                return;
            }
            if (((_deActivateIf == null) 
                        || (_deActivateIf.Equals(value) != true)))
            {
                _deActivateIf = value;
                OnPropertyChanged("DeActivateIf", value);
            }
        }
    }
    
    /// <summary>
    /// The primary text to show on the form.  Also known as "prompt" or "label" or "visibleText" or "caption"
    /// </summary>
    [XmlAttribute]
    [DataMember]
    public virtual string title
    {
        get
        {
            return _title;
        }
        set
        {
            if ((_title == value))
            {
                return;
            }
            if (((_title == null) 
                        || (_title.Equals(value) != true)))
            {
                _title = value;
                OnPropertyChanged("title", value);
            }
        }
    }
    
    /// <summary>
    /// Determines whether the user can interact with the displayed item when the form is first displayed.
    /// </summary>
    [XmlAttribute]
    [System.ComponentModel.DefaultValueAttribute(true)]
    [DataMember]
    public virtual bool enabled
    {
        get
        {
            return _enabled;
        }
        set
        {
            if ((_enabled.Equals(value) != true))
            {
                _enabled = value;
                OnPropertyChanged("enabled", value);
            }
            _shouldSerializeenabled = true;
        }
    }
    
    /// <summary>
    /// Determines whether the item should be visible on a computer screen when the form is first displayed.
    /// </summary>
    [XmlAttribute]
    [System.ComponentModel.DefaultValueAttribute(true)]
    [DataMember]
    public virtual bool visible
    {
        get
        {
            return _visible;
        }
        set
        {
            if ((_visible.Equals(value) != true))
            {
                _visible = value;
                OnPropertyChanged("visible", value);
            }
            _shouldSerializevisible = true;
        }
    }
    
    /// <summary>
    /// If this attribute is set to "true" (the default), then the form implementation must make this item available for use on the form. If this attribute is set to "false" on a parent or ancestor item, then all child/descendant items inherit this "false" setting, even if they have this attribute set to "true." In other words, the child/descendent items do not need to be implemented if any parent/ancestor item has this attribute set to false.
    /// </summary>
    [XmlAttribute]
    [System.ComponentModel.DefaultValueAttribute(true)]
    [DataMember]
    public virtual bool mustImplement
    {
        get
        {
            return _mustImplement;
        }
        set
        {
            if ((_mustImplement.Equals(value) != true))
            {
                _mustImplement = value;
                OnPropertyChanged("mustImplement", value);
            }
            _shouldSerializemustImplement = true;
        }
    }
    
    /// <summary>
    /// If @showInReport on a Question is false, then the Question and its ListItems (if any) should not be present in a typical report derived from this template.  If this attribute appears on a ListItem, then the entire question and all ListItems should be omitted from the report.  If this attribute appears on a Section, then the entire Section and all Section contents (descendents) should be omitted from the report.  If @showInReport appears on a DisplayedItem, then the DisplayedItem (and all sub-items) should be omitted from the report.
    /// 
    /// This attribute is usually set to false when a Question is used to control form behavior (e.g., skip logic), or when the Question provides unhelpful "negative" information about actions that did not occur or were not performed, or things that were not observed.
    /// </summary>
    [XmlAttribute]
    [System.ComponentModel.DefaultValueAttribute(true)]
    [DataMember]
    public virtual bool showInReport
    {
        get
        {
            return _showInReport;
        }
        set
        {
            if ((_showInReport.Equals(value) != true))
            {
                _showInReport = value;
                OnPropertyChanged("showInReport", value);
            }
            _shouldSerializeshowInReport = true;
        }
    }
    
    private static XmlSerializer Serializer
    {
        get
        {
            if ((serializer == null))
            {
                serializer = new XmlSerializerFactory().CreateSerializer(typeof(DisplayedType));
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
    
    /// <summary>
    /// Test whether enabled should be serialized
    /// </summary>
    public virtual bool ShouldSerializeenabled()
    {
        if (_shouldSerializeenabled)
        {
            return true;
        }
        return (_enabled != default(bool));
    }
    
    /// <summary>
    /// Test whether visible should be serialized
    /// </summary>
    public virtual bool ShouldSerializevisible()
    {
        if (_shouldSerializevisible)
        {
            return true;
        }
        return (_visible != default(bool));
    }
    
    /// <summary>
    /// Test whether mustImplement should be serialized
    /// </summary>
    public virtual bool ShouldSerializemustImplement()
    {
        if (_shouldSerializemustImplement)
        {
            return true;
        }
        return (_mustImplement != default(bool));
    }
    
    /// <summary>
    /// Test whether showInReport should be serialized
    /// </summary>
    public virtual bool ShouldSerializeshowInReport()
    {
        if (_shouldSerializeshowInReport)
        {
            return true;
        }
        return (_showInReport != default(bool));
    }
    
    /// <summary>
    /// Test whether ActivateIf should be serialized
    /// </summary>
    public virtual bool ShouldSerializeActivateIf()
    {
        return (_activateIf != null);
    }
    
    /// <summary>
    /// Test whether DeActivateIf should be serialized
    /// </summary>
    public virtual bool ShouldSerializeDeActivateIf()
    {
        return (_deActivateIf != null);
    }
    
    /// <summary>
    /// Test whether title should be serialized
    /// </summary>
    public virtual bool ShouldSerializetitle()
    {
        return !string.IsNullOrEmpty(title);
    }
    
    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current DisplayedType object into an XML string
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
    /// Deserializes workflow markup into an DisplayedType object
    /// </summary>
    /// <param name="input">string workflow markup to deserialize</param>
    /// <param name="obj">Output DisplayedType object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string input, out DisplayedType obj, out Exception exception)
    {
        exception = null;
        obj = default(DisplayedType);
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
    
    public static bool Deserialize(string input, out DisplayedType obj)
    {
        Exception exception = null;
        return Deserialize(input, out obj, out exception);
    }
    
    public new static DisplayedType Deserialize(string input)
    {
        StringReader stringReader = null;
        try
        {
            stringReader = new StringReader(input);
            return ((DisplayedType)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
        }
        finally
        {
            if ((stringReader != null))
            {
                stringReader.Dispose();
            }
        }
    }
    
    public static DisplayedType Deserialize(Stream s)
    {
        return ((DisplayedType)(Serializer.Deserialize(s)));
    }
    #endregion
    
    /// <summary>
    /// Serializes current DisplayedType object into file
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
    /// Deserializes xml markup from file into an DisplayedType object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output DisplayedType object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out DisplayedType obj, out Exception exception)
    {
        exception = null;
        obj = default(DisplayedType);
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
    
    public static bool LoadFromFile(string fileName, out DisplayedType obj)
    {
        Exception exception = null;
        return LoadFromFile(fileName, out obj, out exception);
    }
    
    public new static DisplayedType LoadFromFile(string fileName)
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
    /// Create a clone of this DisplayedType object
    /// </summary>
    public virtual DisplayedType Clone()
    {
        return ((DisplayedType)(MemberwiseClone()));
    }
    #endregion
}
}
#pragma warning restore
