// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code++. Version 4.2.0.31
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
using System.IO;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Collections.Generic;

/// <summary>
/// This type represents any object that is designed to have a visual presence on a form, e.g., Sections, Questions, ListItems, Notes and Blobs.  (Other items not inheriting this type may use an optional styleClass attribute.)
/// </summary>
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ButtonItemType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(RepeatingType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(QuestionItemBaseType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(QuestionItemType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(SectionBaseType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(SectionItemType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ListItemBaseType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ListItemType))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1067.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://healthIT.gov/sdc")]
    public partial class DisplayedType : IdentifiedExtensionType
{
    
    private bool _shouldSerializeshowInReport;
    
    private bool _shouldSerializemustImplement;
    
    private bool _shouldSerializevisible;
    
    private bool _shouldSerializeenabled;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private List<RichTextType> _otherText;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private List<LinkType> _link;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private List<BlobType> _blobContent;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private List<ContactType> _contact;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private List<CodingType> _codedValue;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private List<IfThenType> _onEnter;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private List<IfThenType> _onExit;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private List<OnEventType> _onEvent;
    
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
    
    /// <summary>
    /// DisplayedType class constructor
    /// </summary>
    public DisplayedType()
    {
        this._enabled = true;
        this._visible = true;
        this._mustImplement = true;
        this._showInReport = true;
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
    [System.Xml.Serialization.XmlElementAttribute("OtherText", Order=0)]
    public virtual List<RichTextType> OtherText
    {
        get
        {
            return this._otherText;
        }
        set
        {
            this._otherText = value;
        }
    }
    
    /// <summary>
    /// Link to external information.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute("Link", Order=1)]
    public virtual List<LinkType> Link
    {
        get
        {
            return this._link;
        }
        set
        {
            this._link = value;
        }
    }
    
    /// <summary>
    /// Blob information associated with the current DisplayedType.  The blob may contain any type of special media, but must be base 64 encoded.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute("BlobContent", Order=2)]
    public virtual List<BlobType> BlobContent
    {
        get
        {
            return this._blobContent;
        }
        set
        {
            this._blobContent = value;
        }
    }
    
    /// <summary>
    /// Any desired contact information regarding, e.g., the form item, authoring process, certifications, code or coding processs.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute("Contact", Order=3)]
    public virtual List<ContactType> Contact
    {
        get
        {
            return this._contact;
        }
        set
        {
            this._contact = value;
        }
    }
    
    /// <summary>
    /// Coding, terminology, classification, keyword, or local values
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute("CodedValue", Order=4)]
    public virtual List<CodingType> CodedValue
    {
        get
        {
            return this._codedValue;
        }
        set
        {
            this._codedValue = value;
        }
    }
    
    [System.Xml.Serialization.XmlElementAttribute("OnEnter", Order=5)]
    public virtual List<IfThenType> OnEnter
    {
        get
        {
            return this._onEnter;
        }
        set
        {
            this._onEnter = value;
        }
    }
    
    [System.Xml.Serialization.XmlElementAttribute("OnExit", Order=6)]
    public virtual List<IfThenType> OnExit
    {
        get
        {
            return this._onExit;
        }
        set
        {
            this._onExit = value;
        }
    }
    
    /// <summary>
    /// Generic event handler - eventName must be specified.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute("OnEvent", Order=7)]
    public virtual List<OnEventType> OnEvent
    {
        get
        {
            return this._onEvent;
        }
        set
        {
            this._onEvent = value;
        }
    }
    
    /// <summary>
    /// Activate the DisplayedType item if the contained conditions are met.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order=8)]
    public virtual WatchedPropertyType ActivateIf
    {
        get
        {
            return this._activateIf;
        }
        set
        {
            this._activateIf = value;
        }
    }
    
    /// <summary>
    /// DeActivate the DisplayedType item if the contained conditions are met.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order=9)]
    public virtual WatchedPropertyType DeActivateIf
    {
        get
        {
            return this._deActivateIf;
        }
        set
        {
            this._deActivateIf = value;
        }
    }
    
    /// <summary>
    /// The primary text to show on the form.  Also known as "prompt" or "label" or "visibleText" or "caption"
    /// </summary>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public virtual string title
    {
        get
        {
            return this._title;
        }
        set
        {
            this._title = value;
        }
    }
    
    /// <summary>
    /// Determines whether the user can interact with the displayed item when the form is first displayed.
    /// </summary>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(true)]
    public virtual bool enabled
    {
        get
        {
            return this._enabled;
        }
        set
        {
            this._enabled = value;
            _shouldSerializeenabled = true;
        }
    }
    
    /// <summary>
    /// Determines whether the item should be visible on a computer screen when the form is first displayed.
    /// </summary>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(true)]
    public virtual bool visible
    {
        get
        {
            return this._visible;
        }
        set
        {
            this._visible = value;
            _shouldSerializevisible = true;
        }
    }
    
    /// <summary>
    /// If this attribute is set to "true" (the default), then the form implementation must make this item available for use on the form. If this attribute is set to "false" on a parent or ancestor item, then all child/descendant items inherit this "false" setting, even if they have this attribute set to "true." In other words, the child/descendent items do not need to be implemented if any parent/ancestor item has this attribute set to false.
    /// </summary>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(true)]
    public virtual bool mustImplement
    {
        get
        {
            return this._mustImplement;
        }
        set
        {
            this._mustImplement = value;
            _shouldSerializemustImplement = true;
        }
    }
    
    /// <summary>
    /// If @showInReport on a Question is false, then the Question and its ListItems (if any) should not be present in a typical report derived from this template.  If this attribute appears on a ListItem, then the entire question and all ListItems should be omitted from the report.  If this attribute appears on a Section, then the entire Section and all Section contents (descendents) should be omitted from the report.  If @showInReport appears on a DisplayedItem, then the DisplayedItem (and all sub-items) should be omitted from the report.
    /// 
    /// This attribute is usually set to false when a Question is used to control form behavior (e.g., skip logic), or when the Question provides unhelpful "negative" information about actions that did not occur or were not performed, or things that were not observed.
    /// </summary>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(true)]
    public virtual bool showInReport
    {
        get
        {
            return this._showInReport;
        }
        set
        {
            this._showInReport = value;
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
    
    /// <summary>
    /// Test whether OtherText should be serialized
    /// </summary>
    public virtual bool ShouldSerializeOtherText()
    {
        return OtherText != null && OtherText.Count > 0;
    }
    
    /// <summary>
    /// Test whether Link should be serialized
    /// </summary>
    public virtual bool ShouldSerializeLink()
    {
        return Link != null && Link.Count > 0;
    }
    
    /// <summary>
    /// Test whether BlobContent should be serialized
    /// </summary>
    public virtual bool ShouldSerializeBlobContent()
    {
        return BlobContent != null && BlobContent.Count > 0;
    }
    
    /// <summary>
    /// Test whether Contact should be serialized
    /// </summary>
    public virtual bool ShouldSerializeContact()
    {
        return Contact != null && Contact.Count > 0;
    }
    
    /// <summary>
    /// Test whether CodedValue should be serialized
    /// </summary>
    public virtual bool ShouldSerializeCodedValue()
    {
        return CodedValue != null && CodedValue.Count > 0;
    }
    
    /// <summary>
    /// Test whether OnEnter should be serialized
    /// </summary>
    public virtual bool ShouldSerializeOnEnter()
    {
        return OnEnter != null && OnEnter.Count > 0;
    }
    
    /// <summary>
    /// Test whether OnExit should be serialized
    /// </summary>
    public virtual bool ShouldSerializeOnExit()
    {
        return OnExit != null && OnExit.Count > 0;
    }
    
    /// <summary>
    /// Test whether OnEvent should be serialized
    /// </summary>
    public virtual bool ShouldSerializeOnEvent()
    {
        return OnEvent != null && OnEvent.Count > 0;
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
        System.IO.StreamReader streamReader = null;
        System.IO.MemoryStream memoryStream = null;
        try
        {
            memoryStream = new System.IO.MemoryStream();
            System.Xml.XmlWriterSettings xmlWriterSettings = new System.Xml.XmlWriterSettings();
            xmlWriterSettings.Indent = true;
            System.Xml.XmlWriter xmlWriter = XmlWriter.Create(memoryStream, xmlWriterSettings);
            Serializer.Serialize(xmlWriter, this);
            memoryStream.Seek(0, System.IO.SeekOrigin.Begin);
            streamReader = new System.IO.StreamReader(memoryStream);
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
    public static bool Deserialize(string input, out DisplayedType obj, out System.Exception exception)
    {
        exception = null;
        obj = default(DisplayedType);
        try
        {
            obj = Deserialize(input);
            return true;
        }
        catch (System.Exception ex)
        {
            exception = ex;
            return false;
        }
    }
    
    public static bool Deserialize(string input, out DisplayedType obj)
    {
        System.Exception exception = null;
        return Deserialize(input, out obj, out exception);
    }
    
    public new static DisplayedType Deserialize(string input)
    {
        System.IO.StringReader stringReader = null;
        try
        {
            stringReader = new System.IO.StringReader(input);
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
    
    public static DisplayedType Deserialize(System.IO.Stream s)
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
    public virtual bool SaveToFile(string fileName, out System.Exception exception)
    {
        exception = null;
        try
        {
            SaveToFile(fileName);
            return true;
        }
        catch (System.Exception e)
        {
            exception = e;
            return false;
        }
    }
    
    public virtual void SaveToFile(string fileName)
    {
        System.IO.StreamWriter streamWriter = null;
        try
        {
            string xmlString = Serialize();
            System.IO.FileInfo xmlFile = new System.IO.FileInfo(fileName);
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
    public static bool LoadFromFile(string fileName, out DisplayedType obj, out System.Exception exception)
    {
        exception = null;
        obj = default(DisplayedType);
        try
        {
            obj = LoadFromFile(fileName);
            return true;
        }
        catch (System.Exception ex)
        {
            exception = ex;
            return false;
        }
    }
    
    public static bool LoadFromFile(string fileName, out DisplayedType obj)
    {
        System.Exception exception = null;
        return LoadFromFile(fileName, out obj, out exception);
    }
    
    public new static DisplayedType LoadFromFile(string fileName)
    {
        System.IO.FileStream file = null;
        System.IO.StreamReader sr = null;
        try
        {
            file = new System.IO.FileStream(fileName, FileMode.Open, FileAccess.Read);
            sr = new System.IO.StreamReader(file);
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
}
}
#pragma warning restore
