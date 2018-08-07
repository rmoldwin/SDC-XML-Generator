// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code++. Version 4.2.0.31
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
/// Representation of plain text with an option for HTML-formatting.
/// Contains optional boilerplate metadata to aid programmatic manipulation. HTML
/// formatting is generally contained in CDATA tags to prevent XML parsing and schema
/// errors.
/// </summary>
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ActSendMessageType))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1067.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://healthIT.gov/sdc")]
public partial class RichTextType : ExtensionBaseType
{
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private HTML_Stype _hTML;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private string _val;
    
    private static XmlSerializer serializer;
    
    /// <summary>
    /// Contains optional HTML formatting. The HTML must reflect the contents of the UTF8Text element. (Future modelling may include a Schema to restrict the HTML formatting.)
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public virtual HTML_Stype HTML
    {
        get
        {
            return this._hTML;
        }
        set
        {
            this._hTML = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public virtual string val
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
    
    private static XmlSerializer Serializer
    {
        get
        {
            if ((serializer == null))
            {
                serializer = new XmlSerializerFactory().CreateSerializer(typeof(RichTextType));
            }
            return serializer;
        }
    }
    
    /// <summary>
    /// Test whether HTML should be serialized
    /// </summary>
    public virtual bool ShouldSerializeHTML()
    {
        return (_hTML != null);
    }
    
    /// <summary>
    /// Test whether val should be serialized
    /// </summary>
    public virtual bool ShouldSerializeval()
    {
        return !string.IsNullOrEmpty(val);
    }
    
    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current RichTextType object into an XML string
    /// </summary>
    /// <returns>string XML value</returns>
    public virtual string Serialize()
    {
        System.IO.StreamReader streamReader = null;
        System.IO.MemoryStream memoryStream = null;
        try
        {
            memoryStream = new System.IO.MemoryStream();
            System.Xml.XmlWriterSettings xmlWriterSettings = new System.Xml.XmlWriterSettings();
            xmlWriterSettings.Indent = true;
            System.Xml.XmlWriter xmlWriter = XmlWriter.Create(memoryStream, xmlWriterSettings);
            Serializer.Serialize(xmlWriter, this);
            memoryStream.Seek(0, System.IO.SeekOrigin.Begin);
            streamReader = new System.IO.StreamReader(memoryStream);
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
    /// Deserializes workflow markup into an RichTextType object
    /// </summary>
    /// <param name="input">string workflow markup to deserialize</param>
    /// <param name="obj">Output RichTextType object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string input, out RichTextType obj, out System.Exception exception)
    {
        exception = null;
        obj = default(RichTextType);
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
    
    public static bool Deserialize(string input, out RichTextType obj)
    {
        System.Exception exception = null;
        return Deserialize(input, out obj, out exception);
    }
    
    public new static RichTextType Deserialize(string input)
    {
        System.IO.StringReader stringReader = null;
        try
        {
            stringReader = new System.IO.StringReader(input);
            return ((RichTextType)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
        }
        finally
        {
            if ((stringReader != null))
            {
                stringReader.Dispose();
            }
        }
    }
    
    public static RichTextType Deserialize(System.IO.Stream s)
    {
        return ((RichTextType)(Serializer.Deserialize(s)));
    }
    #endregion
    
    /// <summary>
    /// Serializes current RichTextType object into file
    /// </summary>
    /// <param name="fileName">full path of outupt xml file</param>
    /// <param name="exception">output Exception value if failed</param>
    /// <returns>true if can serialize and save into file; otherwise, false</returns>
    public virtual bool SaveToFile(string fileName, out System.Exception exception)
    {
        exception = null;
        try
        {
            SaveToFile(fileName);
            return true;
        }
        catch (System.Exception e)
        {
            exception = e;
            return false;
        }
    }
    
    public virtual void SaveToFile(string fileName)
    {
        System.IO.StreamWriter streamWriter = null;
        try
        {
            string xmlString = Serialize();
            System.IO.FileInfo xmlFile = new System.IO.FileInfo(fileName);
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
    /// Deserializes xml markup from file into an RichTextType object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output RichTextType object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out RichTextType obj, out System.Exception exception)
    {
        exception = null;
        obj = default(RichTextType);
        try
        {
            obj = LoadFromFile(fileName);
            return true;
        }
        catch (System.Exception ex)
        {
            exception = ex;
            return false;
        }
    }
    
    public static bool LoadFromFile(string fileName, out RichTextType obj)
    {
        System.Exception exception = null;
        return LoadFromFile(fileName, out obj, out exception);
    }
    
    public new static RichTextType LoadFromFile(string fileName)
    {
        System.IO.FileStream file = null;
        System.IO.StreamReader sr = null;
        try
        {
            file = new System.IO.FileStream(fileName, FileMode.Open, FileAccess.Read);
            sr = new System.IO.StreamReader(file);
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
