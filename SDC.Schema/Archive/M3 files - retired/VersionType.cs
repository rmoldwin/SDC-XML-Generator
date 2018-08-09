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
/// A generic structure for recording file version metadata.
/// </summary>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2053.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ihe:qrph:sdc:2016")]
public partial class VersionType : ExtensionBaseType
{
    
    #region Private fields
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
    #endregion
    
    /// <summary>
    /// Information about the document that describes the versioning methodology nomenclature.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public virtual FileType VersioningReference
    {
        get
        {
            return this._versioningReference;
        }
        set
        {
            this._versioningReference = value;
        }
    }
    
    /// <summary>
    /// Comments about the changes in this version
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public virtual RichTextType VersionComments
    {
        get
        {
            return this._versionComments;
        }
        set
        {
            this._versionComments = value;
        }
    }
    
    /// <summary>
    /// Itemized list of changes in the new version
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public virtual VersionTypeChanges Changes
    {
        get
        {
            return this._changes;
        }
        set
        {
            this._changes = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public virtual string fullVersion
    {
        get
        {
            return this._fullVersion;
        }
        set
        {
            this._fullVersion = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public virtual string versionRegExPattern
    {
        get
        {
            return this._versionRegExPattern;
        }
        set
        {
            this._versionRegExPattern = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute("versionLevel.1")]
    public virtual string versionLevel1
    {
        get
        {
            return this._versionLevel1;
        }
        set
        {
            this._versionLevel1 = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute("versionLevel.2")]
    public virtual string versionLevel2
    {
        get
        {
            return this._versionLevel2;
        }
        set
        {
            this._versionLevel2 = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute("versionLevel.3")]
    public virtual string versionLevel3
    {
        get
        {
            return this._versionLevel3;
        }
        set
        {
            this._versionLevel3 = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute("versionLevel.4")]
    public virtual string versionLevel4
    {
        get
        {
            return this._versionLevel4;
        }
        set
        {
            this._versionLevel4 = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute("versionLevel.5")]
    public virtual string versionLevel5
    {
        get
        {
            return this._versionLevel5;
        }
        set
        {
            this._versionLevel5 = value;
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
    /// Deserializes workflow markup into an VersionType object
    /// </summary>
    /// <param name="input">string workflow markup to deserialize</param>
    /// <param name="obj">Output VersionType object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string input, out VersionType obj, out System.Exception exception)
    {
        exception = null;
        obj = default(VersionType);
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
    
    public static bool Deserialize(string input, out VersionType obj)
    {
        System.Exception exception = null;
        return Deserialize(input, out obj, out exception);
    }
    
    public new static VersionType Deserialize(string input)
    {
        System.IO.StringReader stringReader = null;
        try
        {
            stringReader = new System.IO.StringReader(input);
            return ((VersionType)(Serializer.Deserialize(XmlReader.Create(stringReader))));
        }
        finally
        {
            if ((stringReader != null))
            {
                stringReader.Dispose();
            }
        }
    }
    
    public static VersionType Deserialize(System.IO.Stream s)
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
    /// Deserializes xml markup from file into an VersionType object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output VersionType object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, System.Text.Encoding encoding, out VersionType obj, out System.Exception exception)
    {
        exception = null;
        obj = default(VersionType);
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
    
    public static bool LoadFromFile(string fileName, out VersionType obj, out System.Exception exception)
    {
        return LoadFromFile(fileName, System.Text.Encoding.UTF8, out obj, out exception);
    }
    
    public static bool LoadFromFile(string fileName, out VersionType obj)
    {
        System.Exception exception = null;
        return LoadFromFile(fileName, out obj, out exception);
    }
    
    public static VersionType LoadFromFile(string fileName)
    {
        return LoadFromFile(fileName, System.Text.Encoding.UTF8);
    }
    
    public new static VersionType LoadFromFile(string fileName, System.Text.Encoding encoding)
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