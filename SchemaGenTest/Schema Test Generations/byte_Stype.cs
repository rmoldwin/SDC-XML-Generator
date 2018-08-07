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

[XmlIncludeAttribute(typeof(byte_DEtype))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1067.0")]
[Serializable]
[DebuggerStepThrough]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[XmlTypeAttribute(Namespace="http://healthIT.gov/sdc")]
[DataContractAttribute(Name="byte_Stype", Namespace="http://healthIT.gov/sdc")]
public partial class byte_Stype : BaseType
{
    
    private bool _shouldSerializeval;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private System.Nullable<sbyte> _val;
    
    private static XmlSerializer serializer;
    
    private ObjectChangeTracker changeTrackerField;
    
    [XmlAttribute]
    [DataMember]
    public virtual sbyte val
    {
        get
        {
            if (_val.HasValue)
            {
                return _val.Value;
            }
            else
            {
                return default(sbyte);
            }
        }
        set
        {
            if ((_val == value))
            {
                return;
            }
            _shouldSerializeval = true;
            if (((_val == null) 
                        || (_val.Equals(value) != true)))
            {
                _val = value;
                OnPropertyChanged("val", value);
            }
        }
    }
    
    [XmlIgnore]
    [DataMember]
    public virtual bool valSpecified
    {
        get
        {
            return _val.HasValue;
        }
        set
        {
            if (value==false)
            {
                _val = null;
            }
        }
    }
    
    private static XmlSerializer Serializer
    {
        get
        {
            if ((serializer == null))
            {
                serializer = new XmlSerializerFactory().CreateSerializer(typeof(byte_Stype));
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
    /// Test whether val should be serialized
    /// </summary>
    public virtual bool ShouldSerializeval()
    {
        if (_shouldSerializeval)
        {
            return true;
        }
        return (_val != default(sbyte));
    }
    
    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current byte_Stype object into an XML string
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
    /// Deserializes workflow markup into an byte_Stype object
    /// </summary>
    /// <param name="input">string workflow markup to deserialize</param>
    /// <param name="obj">Output byte_Stype object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string input, out byte_Stype obj, out Exception exception)
    {
        exception = null;
        obj = default(byte_Stype);
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
    
    public static bool Deserialize(string input, out byte_Stype obj)
    {
        Exception exception = null;
        return Deserialize(input, out obj, out exception);
    }
    
    public new static byte_Stype Deserialize(string input)
    {
        StringReader stringReader = null;
        try
        {
            stringReader = new StringReader(input);
            return ((byte_Stype)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
        }
        finally
        {
            if ((stringReader != null))
            {
                stringReader.Dispose();
            }
        }
    }
    
    public static byte_Stype Deserialize(Stream s)
    {
        return ((byte_Stype)(Serializer.Deserialize(s)));
    }
    #endregion
    
    /// <summary>
    /// Serializes current byte_Stype object into file
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
    /// Deserializes xml markup from file into an byte_Stype object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output byte_Stype object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out byte_Stype obj, out Exception exception)
    {
        exception = null;
        obj = default(byte_Stype);
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
    
    public static bool LoadFromFile(string fileName, out byte_Stype obj)
    {
        Exception exception = null;
        return LoadFromFile(fileName, out obj, out exception);
    }
    
    public new static byte_Stype LoadFromFile(string fileName)
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
    /// Create a clone of this byte_Stype object
    /// </summary>
    public virtual byte_Stype Clone()
    {
        return ((byte_Stype)(MemberwiseClone()));
    }
    #endregion
}
}
#pragma warning restore
