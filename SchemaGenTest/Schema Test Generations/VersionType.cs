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
/// A generic structure for recording file version metadata.
/// </summary>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1067.0")]
[Serializable]
[DebuggerStepThrough]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[XmlTypeAttribute(Namespace="http://healthIT.gov/sdc")]
[DataContractAttribute(Name="VersionType", Namespace="http://healthIT.gov/sdc")]
public partial class VersionType : ExtensionBaseType
{
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private FileType _versioningReference;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private RichTextType _versionComments;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private VersionTypeChanges _changes;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private string _fullVersion;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private string _versionRegExPattern;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private string _versionLevel1;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private string _versionLevel2;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private string _versionLevel3;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private string _versionLevel4;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private string _versionLevel5;
    
    private static XmlSerializer serializer;
    
    private ObjectChangeTracker changeTrackerField;
    
    /// <summary>
    /// Information about the document that describes the versioning methodology nomenclature.
    /// </summary>
    [XmlElementAttribute(Order=0)]
    [DataMemberAttribute(Order=0)]
    public virtual FileType VersioningReference
    {
        get
        {
            return _versioningReference;
        }
        set
        {
            if ((_versioningReference == value))
            {
                return;
            }
            if (((_versioningReference == null) 
                        || (_versioningReference.Equals(value) != true)))
            {
                _versioningReference = value;
                OnPropertyChanged("VersioningReference", value);
            }
        }
    }
    
    /// <summary>
    /// Comments about the changes in this version
    /// </summary>
    [XmlElementAttribute(Order=1)]
    [DataMemberAttribute(Order=1)]
    public virtual RichTextType VersionComments
    {
        get
        {
            return _versionComments;
        }
        set
        {
            if ((_versionComments == value))
            {
                return;
            }
            if (((_versionComments == null) 
                        || (_versionComments.Equals(value) != true)))
            {
                _versionComments = value;
                OnPropertyChanged("VersionComments", value);
            }
        }
    }
    
    /// <summary>
    /// Itemized list of changes in the new version
    /// </summary>
    [XmlElementAttribute(Order=2)]
    [DataMemberAttribute(Order=2)]
    public virtual VersionTypeChanges Changes
    {
        get
        {
            return _changes;
        }
        set
        {
            if ((_changes == value))
            {
                return;
            }
            if (((_changes == null) 
                        || (_changes.Equals(value) != true)))
            {
                _changes = value;
                OnPropertyChanged("Changes", value);
            }
        }
    }
    
    [XmlAttribute]
    [DataMember]
    public virtual string fullVersion
    {
        get
        {
            return _fullVersion;
        }
        set
        {
            if ((_fullVersion == value))
            {
                return;
            }
            if (((_fullVersion == null) 
                        || (_fullVersion.Equals(value) != true)))
            {
                _fullVersion = value;
                OnPropertyChanged("fullVersion", value);
            }
        }
    }
    
    [XmlAttribute]
    [DataMember]
    public virtual string versionRegExPattern
    {
        get
        {
            return _versionRegExPattern;
        }
        set
        {
            if ((_versionRegExPattern == value))
            {
                return;
            }
            if (((_versionRegExPattern == null) 
                        || (_versionRegExPattern.Equals(value) != true)))
            {
                _versionRegExPattern = value;
                OnPropertyChanged("versionRegExPattern", value);
            }
        }
    }
    
    [XmlAttributeAttribute("versionLevel.1")]
    [DataMemberAttribute(Name="versionLevel.1")]
    public virtual string versionLevel1
    {
        get
        {
            return _versionLevel1;
        }
        set
        {
            if ((_versionLevel1 == value))
            {
                return;
            }
            if (((_versionLevel1 == null) 
                        || (_versionLevel1.Equals(value) != true)))
            {
                _versionLevel1 = value;
                OnPropertyChanged("versionLevel1", value);
            }
        }
    }
    
    [XmlAttributeAttribute("versionLevel.2")]
    [DataMemberAttribute(Name="versionLevel.2")]
    public virtual string versionLevel2
    {
        get
        {
            return _versionLevel2;
        }
        set
        {
            if ((_versionLevel2 == value))
            {
                return;
            }
            if (((_versionLevel2 == null) 
                        || (_versionLevel2.Equals(value) != true)))
            {
                _versionLevel2 = value;
                OnPropertyChanged("versionLevel2", value);
            }
        }
    }
    
    [XmlAttributeAttribute("versionLevel.3")]
    [DataMemberAttribute(Name="versionLevel.3")]
    public virtual string versionLevel3
    {
        get
        {
            return _versionLevel3;
        }
        set
        {
            if ((_versionLevel3 == value))
            {
                return;
            }
            if (((_versionLevel3 == null) 
                        || (_versionLevel3.Equals(value) != true)))
            {
                _versionLevel3 = value;
                OnPropertyChanged("versionLevel3", value);
            }
        }
    }
    
    [XmlAttributeAttribute("versionLevel.4")]
    [DataMemberAttribute(Name="versionLevel.4")]
    public virtual string versionLevel4
    {
        get
        {
            return _versionLevel4;
        }
        set
        {
            if ((_versionLevel4 == value))
            {
                return;
            }
            if (((_versionLevel4 == null) 
                        || (_versionLevel4.Equals(value) != true)))
            {
                _versionLevel4 = value;
                OnPropertyChanged("versionLevel4", value);
            }
        }
    }
    
    [XmlAttributeAttribute("versionLevel.5")]
    [DataMemberAttribute(Name="versionLevel.5")]
    public virtual string versionLevel5
    {
        get
        {
            return _versionLevel5;
        }
        set
        {
            if ((_versionLevel5 == value))
            {
                return;
            }
            if (((_versionLevel5 == null) 
                        || (_versionLevel5.Equals(value) != true)))
            {
                _versionLevel5 = value;
                OnPropertyChanged("versionLevel5", value);
            }
        }
    }
    
    private static XmlSerializer Serializer
    {
        get
        {
            if ((serializer == null))
            {
                serializer = new XmlSerializerFactory().CreateSerializer(typeof(VersionType));
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
    /// Test whether VersioningReference should be serialized
    /// </summary>
    public virtual bool ShouldSerializeVersioningReference()
    {
        return (_versioningReference != null);
    }
    
    /// <summary>
    /// Test whether VersionComments should be serialized
    /// </summary>
    public virtual bool ShouldSerializeVersionComments()
    {
        return (_versionComments != null);
    }
    
    /// <summary>
    /// Test whether Changes should be serialized
    /// </summary>
    public virtual bool ShouldSerializeChanges()
    {
        return (_changes != null);
    }
    
    /// <summary>
    /// Test whether fullVersion should be serialized
    /// </summary>
    public virtual bool ShouldSerializefullVersion()
    {
        return !string.IsNullOrEmpty(fullVersion);
    }
    
    /// <summary>
    /// Test whether versionRegExPattern should be serialized
    /// </summary>
    public virtual bool ShouldSerializeversionRegExPattern()
    {
        return !string.IsNullOrEmpty(versionRegExPattern);
    }
    
    /// <summary>
    /// Test whether versionLevel1 should be serialized
    /// </summary>
    public virtual bool ShouldSerializeversionLevel1()
    {
        return !string.IsNullOrEmpty(versionLevel1);
    }
    
    /// <summary>
    /// Test whether versionLevel2 should be serialized
    /// </summary>
    public virtual bool ShouldSerializeversionLevel2()
    {
        return !string.IsNullOrEmpty(versionLevel2);
    }
    
    /// <summary>
    /// Test whether versionLevel3 should be serialized
    /// </summary>
    public virtual bool ShouldSerializeversionLevel3()
    {
        return !string.IsNullOrEmpty(versionLevel3);
    }
    
    /// <summary>
    /// Test whether versionLevel4 should be serialized
    /// </summary>
    public virtual bool ShouldSerializeversionLevel4()
    {
        return !string.IsNullOrEmpty(versionLevel4);
    }
    
    /// <summary>
    /// Test whether versionLevel5 should be serialized
    /// </summary>
    public virtual bool ShouldSerializeversionLevel5()
    {
        return !string.IsNullOrEmpty(versionLevel5);
    }
    
    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current VersionType object into an XML string
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
    /// Deserializes workflow markup into an VersionType object
    /// </summary>
    /// <param name="input">string workflow markup to deserialize</param>
    /// <param name="obj">Output VersionType object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string input, out VersionType obj, out Exception exception)
    {
        exception = null;
        obj = default(VersionType);
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
    
    public static bool Deserialize(string input, out VersionType obj)
    {
        Exception exception = null;
        return Deserialize(input, out obj, out exception);
    }
    
    public new static VersionType Deserialize(string input)
    {
        StringReader stringReader = null;
        try
        {
            stringReader = new StringReader(input);
            return ((VersionType)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
        }
        finally
        {
            if ((stringReader != null))
            {
                stringReader.Dispose();
            }
        }
    }
    
    public static VersionType Deserialize(Stream s)
    {
        return ((VersionType)(Serializer.Deserialize(s)));
    }
    #endregion
    
    /// <summary>
    /// Serializes current VersionType object into file
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
    /// Deserializes xml markup from file into an VersionType object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output VersionType object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out VersionType obj, out Exception exception)
    {
        exception = null;
        obj = default(VersionType);
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
    
    public static bool LoadFromFile(string fileName, out VersionType obj)
    {
        Exception exception = null;
        return LoadFromFile(fileName, out obj, out exception);
    }
    
    public new static VersionType LoadFromFile(string fileName)
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
    /// Create a clone of this VersionType object
    /// </summary>
    public virtual VersionType Clone()
    {
        return ((VersionType)(MemberwiseClone()));
    }
    #endregion
}
}
#pragma warning restore
