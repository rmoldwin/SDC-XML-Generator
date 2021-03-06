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
[DataContractAttribute(Name="double_DEtype", Namespace="http://healthIT.gov/sdc")]
public partial class double_DEtype : double_Stype
{
    
    private bool _shouldSerializemaxExclusive;
    
    private bool _shouldSerializeminExclusive;
    
    private bool _shouldSerializemaxInclusive;
    
    private bool _shouldSerializeminInclusive;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private System.Nullable<double> _minInclusive;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private System.Nullable<double> _maxInclusive;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private System.Nullable<double> _minExclusive;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private System.Nullable<double> _maxExclusive;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private System.Nullable<byte> _fractionDigits;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private System.Nullable<byte> _totalDigits;
    
    private static XmlSerializer serializer;
    
    private ObjectChangeTracker changeTrackerField;
    
    [XmlAttribute]
    [DataMember]
    public virtual double minInclusive
    {
        get
        {
            if (_minInclusive.HasValue)
            {
                return _minInclusive.Value;
            }
            else
            {
                return default(double);
            }
        }
        set
        {
            if ((_minInclusive.Equals(value) != true))
            {
                _minInclusive = value;
                OnPropertyChanged("minInclusive", value);
            }
            _shouldSerializeminInclusive = true;
        }
    }
    
    [XmlIgnore]
    [DataMember]
    public virtual bool minInclusiveSpecified
    {
        get
        {
            return _minInclusive.HasValue;
        }
        set
        {
            if (value==false)
            {
                _minInclusive = null;
            }
        }
    }
    
    [XmlAttribute]
    [DataMember]
    public virtual double maxInclusive
    {
        get
        {
            if (_maxInclusive.HasValue)
            {
                return _maxInclusive.Value;
            }
            else
            {
                return default(double);
            }
        }
        set
        {
            if ((_maxInclusive.Equals(value) != true))
            {
                _maxInclusive = value;
                OnPropertyChanged("maxInclusive", value);
            }
            _shouldSerializemaxInclusive = true;
        }
    }
    
    [XmlIgnore]
    [DataMember]
    public virtual bool maxInclusiveSpecified
    {
        get
        {
            return _maxInclusive.HasValue;
        }
        set
        {
            if (value==false)
            {
                _maxInclusive = null;
            }
        }
    }
    
    [XmlAttribute]
    [DataMember]
    public virtual double minExclusive
    {
        get
        {
            if (_minExclusive.HasValue)
            {
                return _minExclusive.Value;
            }
            else
            {
                return default(double);
            }
        }
        set
        {
            if ((_minExclusive.Equals(value) != true))
            {
                _minExclusive = value;
                OnPropertyChanged("minExclusive", value);
            }
            _shouldSerializeminExclusive = true;
        }
    }
    
    [XmlIgnore]
    [DataMember]
    public virtual bool minExclusiveSpecified
    {
        get
        {
            return _minExclusive.HasValue;
        }
        set
        {
            if (value==false)
            {
                _minExclusive = null;
            }
        }
    }
    
    [XmlAttribute]
    [DataMember]
    public virtual double maxExclusive
    {
        get
        {
            if (_maxExclusive.HasValue)
            {
                return _maxExclusive.Value;
            }
            else
            {
                return default(double);
            }
        }
        set
        {
            if ((_maxExclusive.Equals(value) != true))
            {
                _maxExclusive = value;
                OnPropertyChanged("maxExclusive", value);
            }
            _shouldSerializemaxExclusive = true;
        }
    }
    
    [XmlIgnore]
    [DataMember]
    public virtual bool maxExclusiveSpecified
    {
        get
        {
            return _maxExclusive.HasValue;
        }
        set
        {
            if (value==false)
            {
                _maxExclusive = null;
            }
        }
    }
    
    [XmlAttribute]
    [DataMember]
    public virtual byte fractionDigits
    {
        get
        {
            if (_fractionDigits.HasValue)
            {
                return _fractionDigits.Value;
            }
            else
            {
                return default(byte);
            }
        }
        set
        {
            if ((_fractionDigits == value))
            {
                return;
            }
            if (((_fractionDigits == null) 
                        || (_fractionDigits.Equals(value) != true)))
            {
                _fractionDigits = value;
                OnPropertyChanged("fractionDigits", value);
            }
        }
    }
    
    [XmlIgnore]
    [DataMember]
    public virtual bool fractionDigitsSpecified
    {
        get
        {
            return _fractionDigits.HasValue;
        }
        set
        {
            if (value==false)
            {
                _fractionDigits = null;
            }
        }
    }
    
    [XmlAttribute]
    [DataMember]
    public virtual byte totalDigits
    {
        get
        {
            if (_totalDigits.HasValue)
            {
                return _totalDigits.Value;
            }
            else
            {
                return default(byte);
            }
        }
        set
        {
            if ((_totalDigits == value))
            {
                return;
            }
            if (((_totalDigits == null) 
                        || (_totalDigits.Equals(value) != true)))
            {
                _totalDigits = value;
                OnPropertyChanged("totalDigits", value);
            }
        }
    }
    
    [XmlIgnore]
    [DataMember]
    public virtual bool totalDigitsSpecified
    {
        get
        {
            return _totalDigits.HasValue;
        }
        set
        {
            if (value==false)
            {
                _totalDigits = null;
            }
        }
    }
    
    private static XmlSerializer Serializer
    {
        get
        {
            if ((serializer == null))
            {
                serializer = new XmlSerializerFactory().CreateSerializer(typeof(double_DEtype));
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
    /// Test whether minInclusive should be serialized
    /// </summary>
    public virtual bool ShouldSerializeminInclusive()
    {
        if (_shouldSerializeminInclusive)
        {
            return true;
        }
        return (_minInclusive != default(double));
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
        return (_maxInclusive != default(double));
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
        return (_minExclusive != default(double));
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
        return (_maxExclusive != default(double));
    }
    
    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current double_DEtype object into an XML string
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
    /// Deserializes workflow markup into an double_DEtype object
    /// </summary>
    /// <param name="input">string workflow markup to deserialize</param>
    /// <param name="obj">Output double_DEtype object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string input, out double_DEtype obj, out Exception exception)
    {
        exception = null;
        obj = default(double_DEtype);
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
    
    public static bool Deserialize(string input, out double_DEtype obj)
    {
        Exception exception = null;
        return Deserialize(input, out obj, out exception);
    }
    
    public new static double_DEtype Deserialize(string input)
    {
        StringReader stringReader = null;
        try
        {
            stringReader = new StringReader(input);
            return ((double_DEtype)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
        }
        finally
        {
            if ((stringReader != null))
            {
                stringReader.Dispose();
            }
        }
    }
    
    public static double_DEtype Deserialize(Stream s)
    {
        return ((double_DEtype)(Serializer.Deserialize(s)));
    }
    #endregion
    
    /// <summary>
    /// Serializes current double_DEtype object into file
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
    /// Deserializes xml markup from file into an double_DEtype object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output double_DEtype object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out double_DEtype obj, out Exception exception)
    {
        exception = null;
        obj = default(double_DEtype);
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
    
    public static bool LoadFromFile(string fileName, out double_DEtype obj)
    {
        Exception exception = null;
        return LoadFromFile(fileName, out obj, out exception);
    }
    
    public new static double_DEtype LoadFromFile(string fileName)
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
    /// Create a clone of this double_DEtype object
    /// </summary>
    public virtual double_DEtype Clone()
    {
        return ((double_DEtype)(MemberwiseClone()));
    }
    #endregion
}
}
#pragma warning restore
