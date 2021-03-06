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
/// Supports documentation of changes to an SDC SubmitForm answer set.
/// </summary>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1067.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://healthIT.gov/sdc")]
public partial class ReplacedResponseType : ExtensionBaseType
{
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private string_Stype _responseComment;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private PersonType _responseEditor;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private dateTime_Stype _responseDateTime;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private ExtensionBaseType _item;
    
    private static XmlSerializer serializer;
    
    /// <summary>
    /// Comment added to the original response that was replaced, at the time it was first entered.  This comment refers to the response that was replaced, not the replacement activity or the replacement values.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public virtual string_Stype ResponseComment
    {
        get
        {
            return this._responseComment;
        }
        set
        {
            this._responseComment = value;
        }
    }
    
    /// <summary>
    /// Original editor of the response that was replaced, when it was first entered.  This editor refers to the response that was replaced, not the replacement activity.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public virtual PersonType ResponseEditor
    {
        get
        {
            return this._responseEditor;
        }
        set
        {
            this._responseEditor = value;
        }
    }
    
    /// <summary>
    /// Date/Time that the response was first entered.  This date/time refers to the response that was replaced, not the replacement activity.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
    public virtual dateTime_Stype ResponseDateTime
    {
        get
        {
            return this._responseDateTime;
        }
        set
        {
            this._responseDateTime = value;
        }
    }
    
    [System.Xml.Serialization.XmlElementAttribute("Response", typeof(DataTypes_SType), IsNullable=true, Order=3)]
    [System.Xml.Serialization.XmlElementAttribute("SelectedItems", typeof(ChangedSelectedItemsType), IsNullable=true, Order=3)]
    public virtual ExtensionBaseType Item
    {
        get
        {
            return this._item;
        }
        set
        {
            this._item = value;
        }
    }
    
    private static XmlSerializer Serializer
    {
        get
        {
            if ((serializer == null))
            {
                serializer = new XmlSerializerFactory().CreateSerializer(typeof(ReplacedResponseType));
            }
            return serializer;
        }
    }
    
    /// <summary>
    /// Test whether ResponseComment should be serialized
    /// </summary>
    public virtual bool ShouldSerializeResponseComment()
    {
        return (_responseComment != null);
    }
    
    /// <summary>
    /// Test whether ResponseEditor should be serialized
    /// </summary>
    public virtual bool ShouldSerializeResponseEditor()
    {
        return (_responseEditor != null);
    }
    
    /// <summary>
    /// Test whether ResponseDateTime should be serialized
    /// </summary>
    public virtual bool ShouldSerializeResponseDateTime()
    {
        return (_responseDateTime != null);
    }
    
    /// <summary>
    /// Test whether Item should be serialized
    /// </summary>
    public virtual bool ShouldSerializeItem()
    {
        return (_item != null);
    }
    
    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current ReplacedResponseType object into an XML string
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
    /// Deserializes workflow markup into an ReplacedResponseType object
    /// </summary>
    /// <param name="input">string workflow markup to deserialize</param>
    /// <param name="obj">Output ReplacedResponseType object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string input, out ReplacedResponseType obj, out System.Exception exception)
    {
        exception = null;
        obj = default(ReplacedResponseType);
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
    
    public static bool Deserialize(string input, out ReplacedResponseType obj)
    {
        System.Exception exception = null;
        return Deserialize(input, out obj, out exception);
    }
    
    public new static ReplacedResponseType Deserialize(string input)
    {
        System.IO.StringReader stringReader = null;
        try
        {
            stringReader = new System.IO.StringReader(input);
            return ((ReplacedResponseType)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
        }
        finally
        {
            if ((stringReader != null))
            {
                stringReader.Dispose();
            }
        }
    }
    
    public static ReplacedResponseType Deserialize(System.IO.Stream s)
    {
        return ((ReplacedResponseType)(Serializer.Deserialize(s)));
    }
    #endregion
    
    /// <summary>
    /// Serializes current ReplacedResponseType object into file
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
    /// Deserializes xml markup from file into an ReplacedResponseType object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output ReplacedResponseType object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out ReplacedResponseType obj, out System.Exception exception)
    {
        exception = null;
        obj = default(ReplacedResponseType);
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
    
    public static bool LoadFromFile(string fileName, out ReplacedResponseType obj)
    {
        System.Exception exception = null;
        return LoadFromFile(fileName, out obj, out exception);
    }
    
    public new static ReplacedResponseType LoadFromFile(string fileName)
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
