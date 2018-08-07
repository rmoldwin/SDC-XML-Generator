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
/// List of numeric values or references to numeric values inside a string list.  Allows constraints on the values in the list. Each value in the list must be validated per the constraints in the list attributes.
/// 
/// Precede named references with "$" to distinguish them from literal strings.
/// </summary>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ihe:qrph:sdc:2016")]
public abstract partial class IntegerListType : ExtensionBaseType
{
    
    #region Private fields
    private bool _shouldSerializeminInclusive;
    
    private bool _shouldSerializemaxInclusive;
    
    private bool _shouldSerializeminExclusive;
    
    private bool _shouldSerializemaxExclusive;
    
    private bool _shouldSerializeallowReferencess;
    
    private bool _shouldSerializeminCount;
    
    private bool _shouldSerializemaxCount;
    
    private bool _shouldSerializeallowNulls;
    
    private bool _shouldSerializesorted;
    
    private bool _shouldSerializeuniqueItems;
    
    private bool _shouldSerializeresolveReferences;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private List<string> _val;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private bool _resolveReferences;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private bool _uniqueItems;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private bool _sorted;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private AnyListTypeSortDirection _sortDirection;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private bool _allowNulls;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private System.Nullable<long> _maxCount;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private System.Nullable<long> _minCount;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private bool _allowReferencess;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private System.Nullable<DataTypeInteger_StypeEnum> _dataTypeInteger;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private System.Nullable<byte> _totalDigits;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private System.Nullable<long> _maxExclusive;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private System.Nullable<long> _minExclusive;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private System.Nullable<long> _maxInclusive;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private System.Nullable<long> _minInclusive;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private string _pattern;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private IntegerListTypeQuantEnum _quantEnum;
    
    private static XmlSerializer serializer;
    #endregion
    
    /// <summary>
    /// IntegerListType class constructor
    /// </summary>
    public IntegerListType()
    {
        this._resolveReferences = true;
        this._uniqueItems = false;
        this._sorted = false;
        this._sortDirection = AnyListTypeSortDirection.Asc;
        this._allowNulls = false;
        this._allowReferencess = false;
        this._dataTypeInteger = DataTypeInteger_StypeEnum.integer;
        this._quantEnum = IntegerListTypeQuantEnum.EQ;
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public virtual List<string> val
    {
        get
        {
            return this._val;
        }
        set
        {
            this._val = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(true)]
    public virtual bool resolveReferences
    {
        get
        {
            return this._resolveReferences;
        }
        set
        {
            this._resolveReferences = value;
            _shouldSerializeresolveReferences = true;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(false)]
    public virtual bool uniqueItems
    {
        get
        {
            return this._uniqueItems;
        }
        set
        {
            this._uniqueItems = value;
            _shouldSerializeuniqueItems = true;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(false)]
    public virtual bool sorted
    {
        get
        {
            return this._sorted;
        }
        set
        {
            this._sorted = value;
            _shouldSerializesorted = true;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(AnyListTypeSortDirection.Asc)]
    public virtual AnyListTypeSortDirection sortDirection
    {
        get
        {
            return this._sortDirection;
        }
        set
        {
            this._sortDirection = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(false)]
    public virtual bool allowNulls
    {
        get
        {
            return this._allowNulls;
        }
        set
        {
            this._allowNulls = value;
            _shouldSerializeallowNulls = true;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public virtual long maxCount
    {
        get
        {
            if (this._maxCount.HasValue)
            {
                return this._maxCount.Value;
            }
            else
            {
                return default(long);
            }
        }
        set
        {
            this._maxCount = value;
            _shouldSerializemaxCount = true;
        }
    }
    
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public virtual bool maxCountSpecified
    {
        get
        {
            return this._maxCount.HasValue;
        }
        set
        {
            if (value==false)
            {
                this._maxCount = null;
            }
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public virtual long minCount
    {
        get
        {
            if (this._minCount.HasValue)
            {
                return this._minCount.Value;
            }
            else
            {
                return default(long);
            }
        }
        set
        {
            this._minCount = value;
            _shouldSerializeminCount = true;
        }
    }
    
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public virtual bool minCountSpecified
    {
        get
        {
            return this._minCount.HasValue;
        }
        set
        {
            if (value==false)
            {
                this._minCount = null;
            }
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(false)]
    public virtual bool allowReferencess
    {
        get
        {
            return this._allowReferencess;
        }
        set
        {
            this._allowReferencess = value;
            _shouldSerializeallowReferencess = true;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified)]
    [System.ComponentModel.DefaultValueAttribute(DataTypeInteger_StypeEnum.integer)]
    public virtual DataTypeInteger_StypeEnum dataTypeInteger
    {
        get
        {
            if (this._dataTypeInteger.HasValue)
            {
                return this._dataTypeInteger.Value;
            }
            else
            {
                return default(DataTypeInteger_StypeEnum);
            }
        }
        set
        {
            this._dataTypeInteger = value;
        }
    }
    
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public virtual bool dataTypeIntegerSpecified
    {
        get
        {
            return this._dataTypeInteger.HasValue;
        }
        set
        {
            if (value==false)
            {
                this._dataTypeInteger = null;
            }
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public virtual byte totalDigits
    {
        get
        {
            if (this._totalDigits.HasValue)
            {
                return this._totalDigits.Value;
            }
            else
            {
                return default(byte);
            }
        }
        set
        {
            this._totalDigits = value;
        }
    }
    
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public virtual bool totalDigitsSpecified
    {
        get
        {
            return this._totalDigits.HasValue;
        }
        set
        {
            if (value==false)
            {
                this._totalDigits = null;
            }
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public virtual long maxExclusive
    {
        get
        {
            if (this._maxExclusive.HasValue)
            {
                return this._maxExclusive.Value;
            }
            else
            {
                return default(long);
            }
        }
        set
        {
            this._maxExclusive = value;
            _shouldSerializemaxExclusive = true;
        }
    }
    
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public virtual bool maxExclusiveSpecified
    {
        get
        {
            return this._maxExclusive.HasValue;
        }
        set
        {
            if (value==false)
            {
                this._maxExclusive = null;
            }
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public virtual long minExclusive
    {
        get
        {
            if (this._minExclusive.HasValue)
            {
                return this._minExclusive.Value;
            }
            else
            {
                return default(long);
            }
        }
        set
        {
            this._minExclusive = value;
            _shouldSerializeminExclusive = true;
        }
    }
    
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public virtual bool minExclusiveSpecified
    {
        get
        {
            return this._minExclusive.HasValue;
        }
        set
        {
            if (value==false)
            {
                this._minExclusive = null;
            }
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public virtual long maxInclusive
    {
        get
        {
            if (this._maxInclusive.HasValue)
            {
                return this._maxInclusive.Value;
            }
            else
            {
                return default(long);
            }
        }
        set
        {
            this._maxInclusive = value;
            _shouldSerializemaxInclusive = true;
        }
    }
    
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public virtual bool maxInclusiveSpecified
    {
        get
        {
            return this._maxInclusive.HasValue;
        }
        set
        {
            if (value==false)
            {
                this._maxInclusive = null;
            }
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public virtual long minInclusive
    {
        get
        {
            if (this._minInclusive.HasValue)
            {
                return this._minInclusive.Value;
            }
            else
            {
                return default(long);
            }
        }
        set
        {
            this._minInclusive = value;
            _shouldSerializeminInclusive = true;
        }
    }
    
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public virtual bool minInclusiveSpecified
    {
        get
        {
            return this._minInclusive.HasValue;
        }
        set
        {
            if (value==false)
            {
                this._minInclusive = null;
            }
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public virtual string pattern
    {
        get
        {
            return this._pattern;
        }
        set
        {
            this._pattern = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(IntegerListTypeQuantEnum.EQ)]
    public virtual IntegerListTypeQuantEnum quantEnum
    {
        get
        {
            return this._quantEnum;
        }
        set
        {
            this._quantEnum = value;
        }
    }
    
    private static XmlSerializer Serializer
    {
        get
        {
            if ((serializer == null))
            {
                serializer = new XmlSerializerFactory().CreateSerializer(typeof(IntegerListType));
            }
            return serializer;
        }
    }
    
    /// <summary>
    /// Test whether val should be serialized
    /// </summary>
    public virtual bool ShouldSerializeval()
    {
        return val != null && val.Count > 0;
    }
    
    /// <summary>
    /// Test whether resolveReferences should be serialized
    /// </summary>
    public virtual bool ShouldSerializeresolveReferences()
    {
        if (_shouldSerializeresolveReferences)
        {
            return true;
        }
        return (_resolveReferences != default(bool));
    }
    
    /// <summary>
    /// Test whether uniqueItems should be serialized
    /// </summary>
    public virtual bool ShouldSerializeuniqueItems()
    {
        if (_shouldSerializeuniqueItems)
        {
            return true;
        }
        return (_uniqueItems != default(bool));
    }
    
    /// <summary>
    /// Test whether sorted should be serialized
    /// </summary>
    public virtual bool ShouldSerializesorted()
    {
        if (_shouldSerializesorted)
        {
            return true;
        }
        return (_sorted != default(bool));
    }
    
    /// <summary>
    /// Test whether allowNulls should be serialized
    /// </summary>
    public virtual bool ShouldSerializeallowNulls()
    {
        if (_shouldSerializeallowNulls)
        {
            return true;
        }
        return (_allowNulls != default(bool));
    }
    
    /// <summary>
    /// Test whether maxCount should be serialized
    /// </summary>
    public virtual bool ShouldSerializemaxCount()
    {
        if (_shouldSerializemaxCount)
        {
            return true;
        }
        return (_maxCount != default(long));
    }
    
    /// <summary>
    /// Test whether minCount should be serialized
    /// </summary>
    public virtual bool ShouldSerializeminCount()
    {
        if (_shouldSerializeminCount)
        {
            return true;
        }
        return (_minCount != default(long));
    }
    
    /// <summary>
    /// Test whether allowReferencess should be serialized
    /// </summary>
    public virtual bool ShouldSerializeallowReferencess()
    {
        if (_shouldSerializeallowReferencess)
        {
            return true;
        }
        return (_allowReferencess != default(bool));
    }
    
    /// <summary>
    /// Test whether maxExclusive should be serialized
    /// </summary>
    public virtual bool ShouldSerializemaxExclusive()
    {
        if (_shouldSerializemaxExclusive)
        {
            return true;
        }
        return (_maxExclusive != default(long));
    }
    
    /// <summary>
    /// Test whether minExclusive should be serialized
    /// </summary>
    public virtual bool ShouldSerializeminExclusive()
    {
        if (_shouldSerializeminExclusive)
        {
            return true;
        }
        return (_minExclusive != default(long));
    }
    
    /// <summary>
    /// Test whether maxInclusive should be serialized
    /// </summary>
    public virtual bool ShouldSerializemaxInclusive()
    {
        if (_shouldSerializemaxInclusive)
        {
            return true;
        }
        return (_maxInclusive != default(long));
    }
    
    /// <summary>
    /// Test whether minInclusive should be serialized
    /// </summary>
    public virtual bool ShouldSerializeminInclusive()
    {
        if (_shouldSerializeminInclusive)
        {
            return true;
        }
        return (_minInclusive != default(long));
    }
    
    /// <summary>
    /// Test whether pattern should be serialized
    /// </summary>
    public virtual bool ShouldSerializepattern()
    {
        return !string.IsNullOrEmpty(pattern);
    }
    
    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current IntegerListType object into an XML string
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
    /// Deserializes workflow markup into an IntegerListType object
    /// </summary>
    /// <param name="input">string workflow markup to deserialize</param>
    /// <param name="obj">Output IntegerListType object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string input, out IntegerListType obj, out System.Exception exception)
    {
        exception = null;
        obj = default(IntegerListType);
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
    
    public static bool Deserialize(string input, out IntegerListType obj)
    {
        System.Exception exception = null;
        return Deserialize(input, out obj, out exception);
    }
    
    public new static IntegerListType Deserialize(string input)
    {
        System.IO.StringReader stringReader = null;
        try
        {
            stringReader = new System.IO.StringReader(input);
            return ((IntegerListType)(Serializer.Deserialize(XmlReader.Create(stringReader))));
        }
        finally
        {
            if ((stringReader != null))
            {
                stringReader.Dispose();
            }
        }
    }
    
    public static IntegerListType Deserialize(System.IO.Stream s)
    {
        return ((IntegerListType)(Serializer.Deserialize(s)));
    }
    #endregion
    
    /// <summary>
    /// Serializes current IntegerListType object into file
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
    /// Deserializes xml markup from file into an IntegerListType object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output IntegerListType object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, System.Text.Encoding encoding, out IntegerListType obj, out System.Exception exception)
    {
        exception = null;
        obj = default(IntegerListType);
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
    
    public static bool LoadFromFile(string fileName, out IntegerListType obj, out System.Exception exception)
    {
        return LoadFromFile(fileName, System.Text.Encoding.UTF8, out obj, out exception);
    }
    
    public static bool LoadFromFile(string fileName, out IntegerListType obj)
    {
        System.Exception exception = null;
        return LoadFromFile(fileName, out obj, out exception);
    }
    
    public static IntegerListType LoadFromFile(string fileName)
    {
        return LoadFromFile(fileName, System.Text.Encoding.UTF8);
    }
    
    public new static IntegerListType LoadFromFile(string fileName, System.Text.Encoding encoding)
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
