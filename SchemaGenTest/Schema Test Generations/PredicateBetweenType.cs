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
[DataContractAttribute(Name="PredicateBetweenType", Namespace="http://healthIT.gov/sdc")]
public partial class PredicateBetweenType : ExtensionBaseType
{
    
    private bool _shouldSerializenot;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private BaseType _item;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private BaseType _item1;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private bool? _not;
    
    private static XmlSerializer serializer;
    
    private ObjectChangeTracker changeTrackerField;
    
    [XmlElementAttribute("MinExclusive", typeof(MinExclusiveType), Order=0)]
    [XmlElementAttribute("MinInclusive", typeof(MinInclusiveType), Order=0)]
    [DataMemberAttribute(Name="MinExclusive", Order=0)]
    public virtual BaseType Item
    {
        get
        {
            return _item;
        }
        set
        {
            if ((_item == value))
            {
                return;
            }
            if (((_item == null) 
                        || (_item.Equals(value) != true)))
            {
                _item = value;
                OnPropertyChanged("Item", value);
            }
        }
    }
    
    [XmlElementAttribute("MaxExclusive", typeof(MaxExclusiveType), Order=1)]
    [XmlElementAttribute("MaxInclusive", typeof(MaxInclusiveType), Order=1)]
    [DataMemberAttribute(Name="MaxExclusive", Order=1)]
    public virtual BaseType Item1
    {
        get
        {
            return _item1;
        }
        set
        {
            if ((_item1 == value))
            {
                return;
            }
            if (((_item1 == null) 
                        || (_item1.Equals(value) != true)))
            {
                _item1 = value;
                OnPropertyChanged("Item1", value);
            }
        }
    }
    
    /// <summary>
    /// If true, @not converts the function into: not Between()
    /// </summary>
    [XmlAttribute]
    [DataMember]
    public virtual bool not
    {
        get
        {
            if (_not.HasValue)
            {
                return _not.Value;
            }
            else
            {
                return default(bool);
            }
        }
        set
        {
            if ((_not.Equals(value) != true))
            {
                _not = value;
                OnPropertyChanged("not", value);
            }
            _shouldSerializenot = true;
        }
    }
    
    [XmlIgnore]
    [DataMember]
    public virtual bool notSpecified
    {
        get
        {
            return _not.HasValue;
        }
        set
        {
            if (value==false)
            {
                _not = null;
            }
        }
    }
    
    private static XmlSerializer Serializer
    {
        get
        {
            if ((serializer == null))
            {
                serializer = new XmlSerializerFactory().CreateSerializer(typeof(PredicateBetweenType));
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
    /// Test whether not should be serialized
    /// </summary>
    public virtual bool ShouldSerializenot()
    {
        if (_shouldSerializenot)
        {
            return true;
        }
        return (_not != default(bool));
    }
    
    /// <summary>
    /// Test whether Item should be serialized
    /// </summary>
    public virtual bool ShouldSerializeItem()
    {
        return (_item != null);
    }
    
    /// <summary>
    /// Test whether Item1 should be serialized
    /// </summary>
    public virtual bool ShouldSerializeItem1()
    {
        return (_item1 != null);
    }
    
    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current PredicateBetweenType object into an XML string
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
    /// Deserializes workflow markup into an PredicateBetweenType object
    /// </summary>
    /// <param name="input">string workflow markup to deserialize</param>
    /// <param name="obj">Output PredicateBetweenType object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string input, out PredicateBetweenType obj, out Exception exception)
    {
        exception = null;
        obj = default(PredicateBetweenType);
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
    
    public static bool Deserialize(string input, out PredicateBetweenType obj)
    {
        Exception exception = null;
        return Deserialize(input, out obj, out exception);
    }
    
    public new static PredicateBetweenType Deserialize(string input)
    {
        StringReader stringReader = null;
        try
        {
            stringReader = new StringReader(input);
            return ((PredicateBetweenType)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
        }
        finally
        {
            if ((stringReader != null))
            {
                stringReader.Dispose();
            }
        }
    }
    
    public static PredicateBetweenType Deserialize(Stream s)
    {
        return ((PredicateBetweenType)(Serializer.Deserialize(s)));
    }
    #endregion
    
    /// <summary>
    /// Serializes current PredicateBetweenType object into file
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
    /// Deserializes xml markup from file into an PredicateBetweenType object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output PredicateBetweenType object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out PredicateBetweenType obj, out Exception exception)
    {
        exception = null;
        obj = default(PredicateBetweenType);
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
    
    public static bool LoadFromFile(string fileName, out PredicateBetweenType obj)
    {
        Exception exception = null;
        return LoadFromFile(fileName, out obj, out exception);
    }
    
    public new static PredicateBetweenType LoadFromFile(string fileName)
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
    /// Create a clone of this PredicateBetweenType object
    /// </summary>
    public virtual PredicateBetweenType Clone()
    {
        return ((PredicateBetweenType)(MemberwiseClone()));
    }
    #endregion
}
}
#pragma warning restore
