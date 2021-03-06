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

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1067.0")]
[Serializable]
[DebuggerStepThrough]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[XmlTypeAttribute(Namespace="http://healthIT.gov/sdc")]
[DataContractAttribute(Name="anyType_DEtype", Namespace="http://healthIT.gov/sdc")]
public partial class anyType_DEtype : BaseType
{
    
    private bool _shouldSerializemaxLength;
    
    private bool _shouldSerializeminLength;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private BindingList<System.Xml.XmlElement> _any;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private System.Nullable<long> _minLength;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private System.Nullable<long> _maxLength;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private string _schema;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private string _namespace;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private BindingList<System.Xml.XmlAttribute> _anyAttr;
    
    private static XmlSerializer serializer;
    
    private ObjectChangeTracker changeTrackerField;
    
    [XmlAnyElementAttribute(Order=0)]
    [DataMember]
    public virtual BindingList<System.Xml.XmlElement> Any
    {
        get
        {
            return _any;
        }
        set
        {
            if ((_any == value))
            {
                return;
            }
            if (((_any == null) 
                        || (_any.Equals(value) != true)))
            {
                _any = value;
                OnPropertyChanged("Any", value);
            }
        }
    }
    
    [XmlAttribute]
    [DataMember]
    public virtual long minLength
    {
        get
        {
            if (_minLength.HasValue)
            {
                return _minLength.Value;
            }
            else
            {
                return default(long);
            }
        }
        set
        {
            if ((_minLength.Equals(value) != true))
            {
                _minLength = value;
                OnPropertyChanged("minLength", value);
            }
            _shouldSerializeminLength = true;
        }
    }
    
    [XmlIgnore]
    [DataMember]
    public virtual bool minLengthSpecified
    {
        get
        {
            return _minLength.HasValue;
        }
        set
        {
            if (value==false)
            {
                _minLength = null;
            }
        }
    }
    
    [XmlAttribute]
    [DataMember]
    public virtual long maxLength
    {
        get
        {
            if (_maxLength.HasValue)
            {
                return _maxLength.Value;
            }
            else
            {
                return default(long);
            }
        }
        set
        {
            if ((_maxLength.Equals(value) != true))
            {
                _maxLength = value;
                OnPropertyChanged("maxLength", value);
            }
            _shouldSerializemaxLength = true;
        }
    }
    
    [XmlIgnore]
    [DataMember]
    public virtual bool maxLengthSpecified
    {
        get
        {
            return _maxLength.HasValue;
        }
        set
        {
            if (value==false)
            {
                _maxLength = null;
            }
        }
    }
    
    [XmlAttribute]
    [DataMember]
    public virtual string schema
    {
        get
        {
            return _schema;
        }
        set
        {
            if ((_schema == value))
            {
                return;
            }
            if (((_schema == null) 
                        || (_schema.Equals(value) != true)))
            {
                _schema = value;
                OnPropertyChanged("schema", value);
            }
        }
    }
    
    /// <summary>
    /// Namespace used in an XML Schema file, if any, used to constrain and validate the the content of this field.  This is similar to the use of namespaces with the xs:any element in XML Schemas.
    /// 
    /// See: http://www.w3.org/TR/xmlschema-0/#any
    /// </summary>
    [XmlAttribute]
    [DataMember]
    public virtual string @namespace
    {
        get
        {
            return _namespace;
        }
        set
        {
            if ((_namespace == value))
            {
                return;
            }
            if (((_namespace == null) 
                        || (_namespace.Equals(value) != true)))
            {
                _namespace = value;
                OnPropertyChanged("namespace", value);
            }
        }
    }
    
    [XmlAnyAttributeAttribute()]
    [DataMember]
    public virtual BindingList<System.Xml.XmlAttribute> AnyAttr
    {
        get
        {
            return _anyAttr;
        }
        set
        {
            if ((_anyAttr == value))
            {
                return;
            }
            if (((_anyAttr == null) 
                        || (_anyAttr.Equals(value) != true)))
            {
                _anyAttr = value;
                OnPropertyChanged("AnyAttr", value);
            }
        }
    }
    
    private static XmlSerializer Serializer
    {
        get
        {
            if ((serializer == null))
            {
                serializer = new XmlSerializerFactory().CreateSerializer(typeof(anyType_DEtype));
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
    /// Test whether minLength should be serialized
    /// </summary>
    public virtual bool ShouldSerializeminLength()
    {
        if (_shouldSerializeminLength)
        {
            return true;
        }
        return (_minLength != default(long));
    }
    
    /// <summary>
    /// Test whether maxLength should be serialized
    /// </summary>
    public virtual bool ShouldSerializemaxLength()
    {
        if (_shouldSerializemaxLength)
        {
            return true;
        }
        return (_maxLength != default(long));
    }
    
    /// <summary>
    /// Test whether schema should be serialized
    /// </summary>
    public virtual bool ShouldSerializeschema()
    {
        return !string.IsNullOrEmpty(schema);
    }
    
    /// <summary>
    /// Test whether namespace should be serialized
    /// </summary>
    public virtual bool ShouldSerializenamespace()
    {
        return !string.IsNullOrEmpty(@namespace);
    }
    
    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current anyType_DEtype object into an XML string
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
    /// Deserializes workflow markup into an anyType_DEtype object
    /// </summary>
    /// <param name="input">string workflow markup to deserialize</param>
    /// <param name="obj">Output anyType_DEtype object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string input, out anyType_DEtype obj, out Exception exception)
    {
        exception = null;
        obj = default(anyType_DEtype);
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
    
    public static bool Deserialize(string input, out anyType_DEtype obj)
    {
        Exception exception = null;
        return Deserialize(input, out obj, out exception);
    }
    
    public new static anyType_DEtype Deserialize(string input)
    {
        StringReader stringReader = null;
        try
        {
            stringReader = new StringReader(input);
            return ((anyType_DEtype)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
        }
        finally
        {
            if ((stringReader != null))
            {
                stringReader.Dispose();
            }
        }
    }
    
    public static anyType_DEtype Deserialize(Stream s)
    {
        return ((anyType_DEtype)(Serializer.Deserialize(s)));
    }
    #endregion
    
    /// <summary>
    /// Serializes current anyType_DEtype object into file
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
    /// Deserializes xml markup from file into an anyType_DEtype object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output anyType_DEtype object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out anyType_DEtype obj, out Exception exception)
    {
        exception = null;
        obj = default(anyType_DEtype);
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
    
    public static bool LoadFromFile(string fileName, out anyType_DEtype obj)
    {
        Exception exception = null;
        return LoadFromFile(fileName, out obj, out exception);
    }
    
    public new static anyType_DEtype LoadFromFile(string fileName)
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
    /// Create a clone of this anyType_DEtype object
    /// </summary>
    public virtual anyType_DEtype Clone()
    {
        return ((anyType_DEtype)(MemberwiseClone()));
    }
    #endregion
}
}
#pragma warning restore
