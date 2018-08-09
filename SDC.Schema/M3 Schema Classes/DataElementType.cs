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

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ihe:qrph:sdc:2016")]
[System.Xml.Serialization.XmlRootAttribute("DataElement", Namespace="urn:ihe:qrph:sdc:2016", IsNullable=false)]
public partial class DataElementType : IdentifiedExtensionType
{
    
    #region Private fields
    [EditorBrowsable(EditorBrowsableState.Never)]
    private List<IdentifiedExtensionType> _items;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private string _prevVersionURI;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private string _basedOnURI;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private string _filename;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private string _title;
    
    private static XmlSerializer serializer;
    #endregion
    
    [System.Xml.Serialization.XmlElementAttribute("ButtonAction", typeof(ButtonItemType), Order=0)]
    [System.Xml.Serialization.XmlElementAttribute("DisplayedItem", typeof(DisplayedType), Order=0)]
    [System.Xml.Serialization.XmlElementAttribute("InjectForm", typeof(InjectFormType), Order=0)]
    [System.Xml.Serialization.XmlElementAttribute("Question", typeof(QuestionItemType), Order=0)]
    [System.Xml.Serialization.XmlElementAttribute("Section", typeof(SectionItemType), Order=0)]
    public virtual List<IdentifiedExtensionType> Items
    {
        get
        {
            return this._items;
        }
        set
        {
            this._items = value;
        }
    }
    
    /// <summary>
    /// NEW: URI used to identify the form that is the immediate previous version of the current FormDesign
    /// </summary>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
    public virtual string prevVersionURI
    {
        get
        {
            return this._prevVersionURI;
        }
        set
        {
            this._prevVersionURI = value;
        }
    }
    
    /// <summary>
    /// URI used to identify the original DE that that this DE is based upon.
    /// 
    /// The current DE may reuse the original @IDs whenever the question/answer/semantic context is identical to the original.  However, a clear policy for DE @ID reuse must be extablished.
    /// 
    /// Relying on a CodedValue, mapping file or table may be a better and more flexible approach than @basedOnURI. In this way, users could compare data elements to determine if they contain semantic matches, and this is supported better with a more robust code map section.
    /// </summary>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
    public virtual string basedOnURI
    {
        get
        {
            return this._basedOnURI;
        }
        set
        {
            this._basedOnURI = value;
        }
    }
    
    /// <summary>
    /// Filename to use when the current DE XML is saved as a file.
    /// </summary>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public virtual string filename
    {
        get
        {
            return this._filename;
        }
        set
        {
            this._filename = value;
        }
    }
    
    /// <summary>
    /// Human readable title for display when choosing DEs
    /// </summary>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public virtual string title
    {
        get
        {
            return this._title;
        }
        set
        {
            this._title = value;
        }
    }
    
    private static XmlSerializer Serializer
    {
        get
        {
            if ((serializer == null))
            {
                serializer = new XmlSerializerFactory().CreateSerializer(typeof(DataElementType));
            }
            return serializer;
        }
    }
    
    /// <summary>
    /// Test whether Items should be serialized
    /// </summary>
    public virtual bool ShouldSerializeItems()
    {
        return Items != null && Items.Count > 0;
    }
    
    /// <summary>
    /// Test whether prevVersionURI should be serialized
    /// </summary>
    public virtual bool ShouldSerializeprevVersionURI()
    {
        return !string.IsNullOrEmpty(prevVersionURI);
    }
    
    /// <summary>
    /// Test whether basedOnURI should be serialized
    /// </summary>
    public virtual bool ShouldSerializebasedOnURI()
    {
        return !string.IsNullOrEmpty(basedOnURI);
    }
    
    /// <summary>
    /// Test whether filename should be serialized
    /// </summary>
    public virtual bool ShouldSerializefilename()
    {
        return !string.IsNullOrEmpty(filename);
    }
    
    /// <summary>
    /// Test whether title should be serialized
    /// </summary>
    public virtual bool ShouldSerializetitle()
    {
        return !string.IsNullOrEmpty(title);
    }
    
    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current DataElementType object into an XML string
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
    /// Deserializes workflow markup into an DataElementType object
    /// </summary>
    /// <param name="input">string workflow markup to deserialize</param>
    /// <param name="obj">Output DataElementType object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string input, out DataElementType obj, out System.Exception exception)
    {
        exception = null;
        obj = default(DataElementType);
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
    
    public static bool Deserialize(string input, out DataElementType obj)
    {
        System.Exception exception = null;
        return Deserialize(input, out obj, out exception);
    }
    
    public new static DataElementType Deserialize(string input)
    {
        System.IO.StringReader stringReader = null;
        try
        {
            stringReader = new System.IO.StringReader(input);
            return ((DataElementType)(Serializer.Deserialize(XmlReader.Create(stringReader))));
        }
        finally
        {
            if ((stringReader != null))
            {
                stringReader.Dispose();
            }
        }
    }
    
    public static DataElementType Deserialize(System.IO.Stream s)
    {
        return ((DataElementType)(Serializer.Deserialize(s)));
    }
    #endregion
    
    /// <summary>
    /// Serializes current DataElementType object into file
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
    /// Deserializes xml markup from file into an DataElementType object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output DataElementType object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, System.Text.Encoding encoding, out DataElementType obj, out System.Exception exception)
    {
        exception = null;
        obj = default(DataElementType);
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
    
    public static bool LoadFromFile(string fileName, out DataElementType obj, out System.Exception exception)
    {
        return LoadFromFile(fileName, System.Text.Encoding.UTF8, out obj, out exception);
    }
    
    public static bool LoadFromFile(string fileName, out DataElementType obj)
    {
        System.Exception exception = null;
        return LoadFromFile(fileName, out obj, out exception);
    }
    
    public static DataElementType LoadFromFile(string fileName)
    {
        return LoadFromFile(fileName, System.Text.Encoding.UTF8);
    }
    
    public new static DataElementType LoadFromFile(string fileName, System.Text.Encoding encoding)
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