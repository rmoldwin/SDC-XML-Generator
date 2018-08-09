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
/// A hyperlink to an Internet endpoint such as a web page or web service.
/// </summary>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1067.0")]
[Serializable]
[DebuggerStepThrough]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[XmlTypeAttribute(Namespace="http://healthIT.gov/sdc")]
[DataContractAttribute(Name="LinkType", Namespace="http://healthIT.gov/sdc")]
public partial class LinkType : ExtensionBaseType
{
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private RichTextType _linkText;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private anyURI_Stype _linkURI;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private BindingList<RichTextType> _description;
    
    private static XmlSerializer serializer;
    
    private ObjectChangeTracker changeTrackerField;
    
    /// <summary>
    /// A description of the URI link, usually for display purposes.
    /// </summary>
    [XmlElementAttribute(Order=0)]
    [DataMemberAttribute(Order=0)]
    public virtual RichTextType LinkText
    {
        get
        {
            return _linkText;
        }
        set
        {
            if ((_linkText == value))
            {
                return;
            }
            if (((_linkText == null) 
                        || (_linkText.Equals(value) != true)))
            {
                _linkText = value;
                OnPropertyChanged("LinkText", value);
            }
        }
    }
    
    /// <summary>
    /// Link to external information.
    /// </summary>
    [XmlElementAttribute(Order=1)]
    [DataMemberAttribute(Order=1)]
    public virtual anyURI_Stype LinkURI
    {
        get
        {
            return _linkURI;
        }
        set
        {
            if ((_linkURI == value))
            {
                return;
            }
            if (((_linkURI == null) 
                        || (_linkURI.Equals(value) != true)))
            {
                _linkURI = value;
                OnPropertyChanged("LinkURI", value);
            }
        }
    }
    
    /// <summary>
    /// Alternative description(s) of the URI link, not usually for display purposes, but available for special
    /// purposes.
    /// </summary>
    [XmlElementAttribute("Description", Order=2)]
    [DataMemberAttribute(Order=2)]
    public virtual BindingList<RichTextType> Description
    {
        get
        {
            return _description;
        }
        set
        {
            if ((_description == value))
            {
                return;
            }
            if (((_description == null) 
                        || (_description.Equals(value) != true)))
            {
                _description = value;
                OnPropertyChanged("Description", value);
            }
        }
    }
    
    private static XmlSerializer Serializer
    {
        get
        {
            if ((serializer == null))
            {
                serializer = new XmlSerializerFactory().CreateSerializer(typeof(LinkType));
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
    /// Test whether LinkText should be serialized
    /// </summary>
    public virtual bool ShouldSerializeLinkText()
    {
        return (_linkText != null);
    }
    
    /// <summary>
    /// Test whether LinkURI should be serialized
    /// </summary>
    public virtual bool ShouldSerializeLinkURI()
    {
        return (_linkURI != null);
    }
    
    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current LinkType object into an XML string
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
    /// Deserializes workflow markup into an LinkType object
    /// </summary>
    /// <param name="input">string workflow markup to deserialize</param>
    /// <param name="obj">Output LinkType object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string input, out LinkType obj, out Exception exception)
    {
        exception = null;
        obj = default(LinkType);
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
    
    public static bool Deserialize(string input, out LinkType obj)
    {
        Exception exception = null;
        return Deserialize(input, out obj, out exception);
    }
    
    public new static LinkType Deserialize(string input)
    {
        StringReader stringReader = null;
        try
        {
            stringReader = new StringReader(input);
            return ((LinkType)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
        }
        finally
        {
            if ((stringReader != null))
            {
                stringReader.Dispose();
            }
        }
    }
    
    public static LinkType Deserialize(Stream s)
    {
        return ((LinkType)(Serializer.Deserialize(s)));
    }
    #endregion
    
    /// <summary>
    /// Serializes current LinkType object into file
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
    /// Deserializes xml markup from file into an LinkType object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output LinkType object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out LinkType obj, out Exception exception)
    {
        exception = null;
        obj = default(LinkType);
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
    
    public static bool LoadFromFile(string fileName, out LinkType obj)
    {
        Exception exception = null;
        return LoadFromFile(fileName, out obj, out exception);
    }
    
    public new static LinkType LoadFromFile(string fileName)
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
    /// Create a clone of this LinkType object
    /// </summary>
    public virtual LinkType Clone()
    {
        return ((LinkType)(MemberwiseClone()));
    }
    #endregion
}
}
#pragma warning restore