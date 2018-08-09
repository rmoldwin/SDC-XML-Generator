// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code++. Version 4.4.0.7
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
/// ListField is a grouper for list-like answer choices, which may be derived from either a set of answer choice lists (a List composed of ListItems) or or a list obtained from a LookupEndpoint URI.
/// </summary>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2053.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ihe:qrph:sdc:2016")]
public partial class ListFieldType : ExtensionBaseType
{
    
    #region Private fields
    private bool _shouldSerializeordered;
    
    private bool _shouldSerializemaxSelections;
    
    private bool _shouldSerializeminSelections;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private RichTextType _listHeaderText;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private DataTypes_DEType _defaultListItemDataType;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private CodeSystemType _defaultCodeSystem;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private ExtensionBaseType _item;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private List<RuleSelectionTestType> _illegalListItemPairings;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private List<RuleSingleSelectionSetsType> _illegalCoSelectedListItems;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private List<EventType> _afterChange;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private List<OnEventType> _onEvent;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private string _colTextDelimiter;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private byte _numCols;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private byte _storedCol;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private ushort _minSelections;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private ushort _maxSelections;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private bool _ordered;
    
    private static XmlSerializer serializer;
    #endregion
    
    /// <summary>
    /// ListFieldType class constructor
    /// </summary>
    //public ListFieldType()
    //{
    //    this._colTextDelimiter = "|";
    //    this._numCols = ((byte)(1));
    //    this._storedCol = ((byte)(1));
    //    this._minSelections = ((ushort)(1));
    //    this._maxSelections = ((ushort)(1));
    //    this._ordered = true;
    //}
    
    /// <summary>
    /// The header row for a set of list items.  If the list has more than one column, the column text is separated by the colTextDelimiter.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public virtual RichTextType ListHeaderText
    {
        get
        {
            return this._listHeaderText;
        }
        set
        {
            this._listHeaderText = value;
        }
    }
    
    /// <summary>
    /// Data type enumeration derived from W3C XML Schema.  This element is used only if the ListItems are all associated with coded values from a single coding system.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public virtual DataTypes_DEType DefaultListItemDataType
    {
        get
        {
            return this._defaultListItemDataType;
        }
        set
        {
            this._defaultListItemDataType = value;
        }
    }
    
    /// <summary>
    /// If coded values are used for items in a List (including ListItem and LookupEndPoint lists), then the default coding system should be specified here.  For ListItem nodes, any exceptions to the coding system may be specified on the individual ListItem nodes.  For LookupEndPoints, the endpoint data can optionally specify any exceptions in a dedicated CodeSystem column in the returned list data.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public virtual CodeSystemType DefaultCodeSystem
    {
        get
        {
            return this._defaultCodeSystem;
        }
        set
        {
            this._defaultCodeSystem = value;
        }
    }
    
    [System.Xml.Serialization.XmlElementAttribute("List", typeof(ListType), Order=3)]
    [System.Xml.Serialization.XmlElementAttribute("LookupEndPoint", typeof(LookupEndPointType), Order=3)]
    public virtual ExtensionBaseType Item
    {
        get
        {
            return this._item;
        }
        set
        {
            this._item = value;
        }
    }
    
    [System.Xml.Serialization.XmlElementAttribute("IllegalListItemPairings", Order=4)]
    public virtual List<RuleSelectionTestType> IllegalListItemPairings
    {
        get
        {
            return this._illegalListItemPairings;
        }
        set
        {
            this._illegalListItemPairings = value;
        }
    }
    
    [System.Xml.Serialization.XmlElementAttribute("IllegalCoSelectedListItems", Order=5)]
    public virtual List<RuleSingleSelectionSetsType> IllegalCoSelectedListItems
    {
        get
        {
            return this._illegalCoSelectedListItems;
        }
        set
        {
            this._illegalCoSelectedListItems = value;
        }
    }
    
    /// <summary>
    /// Event that occurs after List Field selections are changed.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute("AfterChange", Order=6)]
    public virtual List<EventType> AfterChange
    {
        get
        {
            return this._afterChange;
        }
        set
        {
            this._afterChange = value;
        }
    }
    
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
    /// Character in the DisplayText that separates the columns and rows in a single or multi-column list.
    /// </summary>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute("|")]
    public virtual string colTextDelimiter
    {
        get
        {
            return this._colTextDelimiter;
        }
        set
        {
            this._colTextDelimiter = value;
        }
    }
    
    /// <summary>
    /// Number of columns in the list
    /// </summary>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(typeof(byte), "1")]
    public virtual byte numCols
    {
        get
        {
            return this._numCols;
        }
        set
        {
            this._numCols = value;
        }
    }
    
    /// <summary>
    /// Determines which column of the list is stored in a database.  This list is one-based.
    /// </summary>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(typeof(byte), "1")]
    public virtual byte storedCol
    {
        get
        {
            return this._storedCol;
        }
        set
        {
            this._storedCol = value;
        }
    }
    
    /// <summary>
    /// Minimum number of answer choices (list items) that must be selected by the user.  Default value is 1.
    /// 
    /// NEW: changed minimum value to 1.
    /// Removed: If set to 0, then this question need not be answered by the user.
    /// </summary>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(typeof(ushort), "1")]
    public virtual ushort minSelections
    {
        get
        {
            return this._minSelections;
        }
        set
        {
            this._minSelections = value;
            _shouldSerializeminSelections = true;
        }
    }
    
    /// <summary>
    /// Maximum number of answer choices (list items) that can be selected by the user.  Must be greater than or equal to minSelections, and no larger than the total number of list items.
    /// 
    /// A value of 0 indicates no limit to the number of selected list items (answers).  This effectively means that the question is multi-select. (Abbreviated as QM)
    /// 
    /// A value of 1 (the default) indicates that the question list is single-select.  (Abbreviated as QS)
    /// </summary>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(typeof(ushort), "1")]
    public virtual ushort maxSelections
    {
        get
        {
            return this._maxSelections;
        }
        set
        {
            this._maxSelections = value;
            _shouldSerializemaxSelections = true;
        }
    }
    
    /// <summary>
    /// If false, then the form implementation may change the order of items in the list.
    /// </summary>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(true)]
    public virtual bool ordered
    {
        get
        {
            return this._ordered;
        }
        set
        {
            this._ordered = value;
            _shouldSerializeordered = true;
        }
    }
    
    private static XmlSerializer Serializer
    {
        get
        {
            if ((serializer == null))
            {
                serializer = new XmlSerializerFactory().CreateSerializer(typeof(ListFieldType));
            }
            return serializer;
        }
    }
    
    /// <summary>
    /// Test whether IllegalListItemPairings should be serialized
    /// </summary>
    public virtual bool ShouldSerializeIllegalListItemPairings()
    {
        return IllegalListItemPairings != null && IllegalListItemPairings.Count > 0;
    }
    
    /// <summary>
    /// Test whether IllegalCoSelectedListItems should be serialized
    /// </summary>
    public virtual bool ShouldSerializeIllegalCoSelectedListItems()
    {
        return IllegalCoSelectedListItems != null && IllegalCoSelectedListItems.Count > 0;
    }
    
    /// <summary>
    /// Test whether AfterChange should be serialized
    /// </summary>
    public virtual bool ShouldSerializeAfterChange()
    {
        return AfterChange != null && AfterChange.Count > 0;
    }
    
    /// <summary>
    /// Test whether OnEvent should be serialized
    /// </summary>
    public virtual bool ShouldSerializeOnEvent()
    {
        return OnEvent != null && OnEvent.Count > 0;
    }
    
    /// <summary>
    /// Test whether minSelections should be serialized
    /// </summary>
    public virtual bool ShouldSerializeminSelections()
    {
        if (_shouldSerializeminSelections)
        {
            return true;
        }
        return (_minSelections != default(ushort));
    }
    
    /// <summary>
    /// Test whether maxSelections should be serialized
    /// </summary>
    public virtual bool ShouldSerializemaxSelections()
    {
        if (_shouldSerializemaxSelections)
        {
            return true;
        }
        return (_maxSelections != default(ushort));
    }
    
    /// <summary>
    /// Test whether ordered should be serialized
    /// </summary>
    public virtual bool ShouldSerializeordered()
    {
        if (_shouldSerializeordered)
        {
            return true;
        }
        return (_ordered != default(bool));
    }
    
    /// <summary>
    /// Test whether ListHeaderText should be serialized
    /// </summary>
    public virtual bool ShouldSerializeListHeaderText()
    {
        return (_listHeaderText != null);
    }
    
    /// <summary>
    /// Test whether DefaultListItemDataType should be serialized
    /// </summary>
    public virtual bool ShouldSerializeDefaultListItemDataType()
    {
        return (_defaultListItemDataType != null);
    }
    
    /// <summary>
    /// Test whether DefaultCodeSystem should be serialized
    /// </summary>
    public virtual bool ShouldSerializeDefaultCodeSystem()
    {
        return (_defaultCodeSystem != null);
    }
    
    /// <summary>
    /// Test whether Item should be serialized
    /// </summary>
    public virtual bool ShouldSerializeItem()
    {
        return (_item != null);
    }
    
    /// <summary>
    /// Test whether colTextDelimiter should be serialized
    /// </summary>
    public virtual bool ShouldSerializecolTextDelimiter()
    {
        return !string.IsNullOrEmpty(colTextDelimiter);
    }
    
    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current ListFieldType object into an XML string
    /// </summary>
    /// <returns>string XML value</returns>
    public virtual string Serialize(System.Text.Encoding encoding)
    {
        System.IO.StreamReader streamReader = null;
        System.IO.MemoryStream memoryStream = null;
        try
        {
            memoryStream = new System.IO.MemoryStream();
            System.Xml.XmlWriterSettings xmlWriterSettings = new System.Xml.XmlWriterSettings();
            xmlWriterSettings.Encoding = encoding;
            xmlWriterSettings.Indent = true;
            xmlWriterSettings.IndentChars = " ";
            System.Xml.XmlWriter xmlWriter = XmlWriter.Create(memoryStream, xmlWriterSettings);
            Serializer.Serialize(xmlWriter, this);
            memoryStream.Seek(0, SeekOrigin.Begin);
            streamReader = new System.IO.StreamReader(memoryStream, encoding);
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
    
    public virtual string Serialize()
    {
        return Serialize(System.Text.Encoding.UTF8);
    }
    
    /// <summary>
    /// Deserializes workflow markup into an ListFieldType object
    /// </summary>
    /// <param name="input">string workflow markup to deserialize</param>
    /// <param name="obj">Output ListFieldType object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string input, out ListFieldType obj, out System.Exception exception)
    {
        exception = null;
        obj = default(ListFieldType);
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
    
    public static bool Deserialize(string input, out ListFieldType obj)
    {
        System.Exception exception = null;
        return Deserialize(input, out obj, out exception);
    }
    
    public new static ListFieldType Deserialize(string input)
    {
        System.IO.StringReader stringReader = null;
        try
        {
            stringReader = new System.IO.StringReader(input);
            return ((ListFieldType)(Serializer.Deserialize(XmlReader.Create(stringReader))));
        }
        finally
        {
            if ((stringReader != null))
            {
                stringReader.Dispose();
            }
        }
    }
    
    public static ListFieldType Deserialize(System.IO.Stream s)
    {
        return ((ListFieldType)(Serializer.Deserialize(s)));
    }
    #endregion
    
    /// <summary>
    /// Serializes current ListFieldType object into file
    /// </summary>
    /// <param name="fileName">full path of outupt xml file</param>
    /// <param name="exception">output Exception value if failed</param>
    /// <returns>true if can serialize and save into file; otherwise, false</returns>
    public virtual bool SaveToFile(string fileName, System.Text.Encoding encoding, out System.Exception exception)
    {
        exception = null;
        try
        {
            SaveToFile(fileName, encoding);
            return true;
        }
        catch (System.Exception e)
        {
            exception = e;
            return false;
        }
    }
    
    public virtual bool SaveToFile(string fileName, out System.Exception exception)
    {
        return SaveToFile(fileName, System.Text.Encoding.UTF8, out exception);
    }
    
    public virtual void SaveToFile(string fileName)
    {
        SaveToFile(fileName, System.Text.Encoding.UTF8);
    }
    
    public virtual void SaveToFile(string fileName, System.Text.Encoding encoding)
    {
        System.IO.StreamWriter streamWriter = null;
        try
        {
            string xmlString = Serialize(encoding);
            streamWriter = new System.IO.StreamWriter(fileName, false, encoding);
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
    /// Deserializes xml markup from file into an ListFieldType object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output ListFieldType object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, System.Text.Encoding encoding, out ListFieldType obj, out System.Exception exception)
    {
        exception = null;
        obj = default(ListFieldType);
        try
        {
            obj = LoadFromFile(fileName, encoding);
            return true;
        }
        catch (System.Exception ex)
        {
            exception = ex;
            return false;
        }
    }
    
    public static bool LoadFromFile(string fileName, out ListFieldType obj, out System.Exception exception)
    {
        return LoadFromFile(fileName, System.Text.Encoding.UTF8, out obj, out exception);
    }
    
    public static bool LoadFromFile(string fileName, out ListFieldType obj)
    {
        System.Exception exception = null;
        return LoadFromFile(fileName, out obj, out exception);
    }
    
    public static ListFieldType LoadFromFile(string fileName)
    {
        return LoadFromFile(fileName, System.Text.Encoding.UTF8);
    }
    
    public new static ListFieldType LoadFromFile(string fileName, System.Text.Encoding encoding)
    {
        System.IO.FileStream file = null;
        System.IO.StreamReader sr = null;
        try
        {
            file = new System.IO.FileStream(fileName, FileMode.Open, FileAccess.Read);
            sr = new System.IO.StreamReader(file, encoding);
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