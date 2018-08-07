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
/// Function or web service that returns a numeric list value.  Contains an optional location to store the value.
/// </summary>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ihe:qrph:sdc:2016")]
public partial class FuncBoolListType000 : ReturnBoolListType
{
    
    #region Private fields
    [EditorBrowsable(EditorBrowsableState.Never)]
    private anyURI_Stype _function;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private RichTextType _security;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private List<ExtensionBaseType> _items;
    
    private static XmlSerializer serializer;
    #endregion
    
    /// <summary>
    /// Name of the function or URI of the web service. The Function may use the parameter list and transmit the item name, property and value for each parameter.
    /// 
    /// The function must understand the parameters and return an appropriate response of the correct data type.  Guidelines for URI construction syntax will be defined external to this Schema, and may be use-case and implementation-specific.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public virtual anyURI_Stype Function
    {
        get
        {
            return this._function;
        }
        set
        {
            this._function = value;
        }
    }
    
    /// <summary>
    /// Information about securly accessing the web service.  More detailed service patterns may be required.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public virtual RichTextType Security
    {
        get
        {
            return this._security;
        }
        set
        {
            this._security = value;
        }
    }
    
    [System.Xml.Serialization.XmlElementAttribute("ParameterRef", typeof(ParameterItemType111), Order=2)]
    [System.Xml.Serialization.XmlElementAttribute("ParameterValue", typeof(ParameterValueType), Order=2)]
    public virtual List<ExtensionBaseType> Items
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
    
    private static XmlSerializer Serializer
    {
        get
        {
            if ((serializer == null))
            {
                serializer = new XmlSerializerFactory().CreateSerializer(typeof(FuncBoolListType000));
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
    /// Test whether Function should be serialized
    /// </summary>
    public virtual bool ShouldSerializeFunction()
    {
        return (_function != null);
    }
    
    /// <summary>
    /// Test whether Security should be serialized
    /// </summary>
    public virtual bool ShouldSerializeSecurity()
    {
        return (_security != null);
    }
    
    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current FuncBoolListType000 object into an XML string
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
    /// Deserializes workflow markup into an FuncBoolListType000 object
    /// </summary>
    /// <param name="input">string workflow markup to deserialize</param>
    /// <param name="obj">Output FuncBoolListType000 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string input, out FuncBoolListType000 obj, out System.Exception exception)
    {
        exception = null;
        obj = default(FuncBoolListType000);
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
    
    public static bool Deserialize(string input, out FuncBoolListType000 obj)
    {
        System.Exception exception = null;
        return Deserialize(input, out obj, out exception);
    }
    
    public new static FuncBoolListType000 Deserialize(string input)
    {
        System.IO.StringReader stringReader = null;
        try
        {
            stringReader = new System.IO.StringReader(input);
            return ((FuncBoolListType000)(Serializer.Deserialize(XmlReader.Create(stringReader))));
        }
        finally
        {
            if ((stringReader != null))
            {
                stringReader.Dispose();
            }
        }
    }
    
    public static FuncBoolListType000 Deserialize(System.IO.Stream s)
    {
        return ((FuncBoolListType000)(Serializer.Deserialize(s)));
    }
    #endregion
    
    /// <summary>
    /// Serializes current FuncBoolListType000 object into file
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
    /// Deserializes xml markup from file into an FuncBoolListType000 object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output FuncBoolListType000 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, System.Text.Encoding encoding, out FuncBoolListType000 obj, out System.Exception exception)
    {
        exception = null;
        obj = default(FuncBoolListType000);
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
    
    public static bool LoadFromFile(string fileName, out FuncBoolListType000 obj, out System.Exception exception)
    {
        return LoadFromFile(fileName, System.Text.Encoding.UTF8, out obj, out exception);
    }
    
    public static bool LoadFromFile(string fileName, out FuncBoolListType000 obj)
    {
        System.Exception exception = null;
        return LoadFromFile(fileName, out obj, out exception);
    }
    
    public static FuncBoolListType000 LoadFromFile(string fileName)
    {
        return LoadFromFile(fileName, System.Text.Encoding.UTF8);
    }
    
    public new static FuncBoolListType000 LoadFromFile(string fileName, System.Text.Encoding encoding)
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
