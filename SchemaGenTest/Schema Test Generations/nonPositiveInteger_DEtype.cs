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
[DataContractAttribute(Name="nonPositiveInteger_DEtype", Namespace="http://healthIT.gov/sdc")]
public partial class nonPositiveInteger_DEtype : nonPositiveInteger_Stype
{
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private string _minInclusive;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private string _maxInclusive;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private string _minExclusive;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private string _maxExclusive;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private System.Nullable<byte> _totalDigits;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private string _mask;
    
    private static XmlSerializer serializer;
    
    private ObjectChangeTracker changeTrackerField;
    
    [XmlAttributeAttribute(DataType="nonPositiveInteger")]
    [DataMember]
    public virtual string minInclusive
    {
        get
        {
            return _minInclusive;
        }
        set
        {
            if ((_minInclusive == value))
            {
                return;
            }
            if (((_minInclusive == null) 
                        || (_minInclusive.Equals(value) != true)))
            {
                _minInclusive = value;
                OnPropertyChanged("minInclusive", value);
            }
        }
    }
    
    [XmlAttributeAttribute(DataType="nonPositiveInteger")]
    [DataMember]
    public virtual string maxInclusive
    {
        get
        {
            return _maxInclusive;
        }
        set
        {
            if ((_maxInclusive == value))
            {
                return;
            }
            if (((_maxInclusive == null) 
                        || (_maxInclusive.Equals(value) != true)))
            {
                _maxInclusive = value;
                OnPropertyChanged("maxInclusive", value);
            }
        }
    }
    
    [XmlAttributeAttribute(DataType="nonPositiveInteger")]
    [DataMember]
    public virtual string minExclusive
    {
        get
        {
            return _minExclusive;
        }
        set
        {
            if ((_minExclusive == value))
            {
                return;
            }
            if (((_minExclusive == null) 
                        || (_minExclusive.Equals(value) != true)))
            {
                _minExclusive = value;
                OnPropertyChanged("minExclusive", value);
            }
        }
    }
    
    [XmlAttributeAttribute(DataType="nonPositiveInteger")]
    [DataMember]
    public virtual string maxExclusive
    {
        get
        {
            return _maxExclusive;
        }
        set
        {
            if ((_maxExclusive == value))
            {
                return;
            }
            if (((_maxExclusive == null) 
                        || (_maxExclusive.Equals(value) != true)))
            {
                _maxExclusive = value;
                OnPropertyChanged("maxExclusive", value);
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
    
    [XmlAttribute]
    [DataMember]
    public virtual string mask
    {
        get
        {
            return _mask;
        }
        set
        {
            if ((_mask == value))
            {
                return;
            }
            if (((_mask == null) 
                        || (_mask.Equals(value) != true)))
            {
                _mask = value;
                OnPropertyChanged("mask", value);
            }
        }
    }
    
    private static XmlSerializer Serializer
    {
        get
        {
            if ((serializer == null))
            {
                serializer = new XmlSerializerFactory().CreateSerializer(typeof(nonPositiveInteger_DEtype));
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
        return !string.IsNullOrEmpty(minInclusive);
    }
    
    /// <summary>
    /// Test whether maxInclusive should be serialized
    /// </summary>
    public virtual bool ShouldSerializemaxInclusive()
    {
        return !string.IsNullOrEmpty(maxInclusive);
    }
    
    /// <summary>
    /// Test whether minExclusive should be serialized
    /// </summary>
    public virtual bool ShouldSerializeminExclusive()
    {
        return !string.IsNullOrEmpty(minExclusive);
    }
    
    /// <summary>
    /// Test whether maxExclusive should be serialized
    /// </summary>
    public virtual bool ShouldSerializemaxExclusive()
    {
        return !string.IsNullOrEmpty(maxExclusive);
    }
    
    /// <summary>
    /// Test whether mask should be serialized
    /// </summary>
    public virtual bool ShouldSerializemask()
    {
        return !string.IsNullOrEmpty(mask);
    }
    
    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current nonPositiveInteger_DEtype object into an XML string
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
    /// Deserializes workflow markup into an nonPositiveInteger_DEtype object
    /// </summary>
    /// <param name="input">string workflow markup to deserialize</param>
    /// <param name="obj">Output nonPositiveInteger_DEtype object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string input, out nonPositiveInteger_DEtype obj, out Exception exception)
    {
        exception = null;
        obj = default(nonPositiveInteger_DEtype);
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
    
    public static bool Deserialize(string input, out nonPositiveInteger_DEtype obj)
    {
        Exception exception = null;
        return Deserialize(input, out obj, out exception);
    }
    
    public new static nonPositiveInteger_DEtype Deserialize(string input)
    {
        StringReader stringReader = null;
        try
        {
            stringReader = new StringReader(input);
            return ((nonPositiveInteger_DEtype)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
        }
        finally
        {
            if ((stringReader != null))
            {
                stringReader.Dispose();
            }
        }
    }
    
    public static nonPositiveInteger_DEtype Deserialize(Stream s)
    {
        return ((nonPositiveInteger_DEtype)(Serializer.Deserialize(s)));
    }
    #endregion
    
    /// <summary>
    /// Serializes current nonPositiveInteger_DEtype object into file
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
    /// Deserializes xml markup from file into an nonPositiveInteger_DEtype object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output nonPositiveInteger_DEtype object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out nonPositiveInteger_DEtype obj, out Exception exception)
    {
        exception = null;
        obj = default(nonPositiveInteger_DEtype);
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
    
    public static bool LoadFromFile(string fileName, out nonPositiveInteger_DEtype obj)
    {
        Exception exception = null;
        return LoadFromFile(fileName, out obj, out exception);
    }
    
    public new static nonPositiveInteger_DEtype LoadFromFile(string fileName)
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
    /// Create a clone of this nonPositiveInteger_DEtype object
    /// </summary>
    public virtual nonPositiveInteger_DEtype Clone()
    {
        return ((nonPositiveInteger_DEtype)(MemberwiseClone()));
    }
    #endregion
}
}
#pragma warning restore
