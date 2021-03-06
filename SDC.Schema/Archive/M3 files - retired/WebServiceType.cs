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
/// Web service that returns a value using the data type required by the parent Response field.
/// </summary>
[System.Xml.Serialization.XmlIncludeAttribute(typeof(LookupEndPointType))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2053.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ihe:qrph:sdc:2016")]
public partial class WebServiceType : ExtensionBaseType
{
    
    #region Private fields
    [EditorBrowsable(EditorBrowsableState.Never)]
    private List<RichTextType> _property;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private anyURI_Stype _uRI;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private RichTextType _security;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private List<GetParameterFromPropertyType> _parameter;
    
    private static XmlSerializer serializer;
    #endregion
    
    /// <summary>
    /// Property is any type of secondary text that is associated with any form item (e.g., section, question, list item) in any context.  The Property context is specified by the @type attribute.  Examples of @type values may include:
    /// -alternate language representations, e.g., 'spanish'
    /// -'instruction'
    /// -'tooltip'
    /// -'help' for a pop-up help box
    /// -'outlining' (such as question numbering)
    /// 
    /// The @type enumerations must be defined and documented for the particular use case, and are currently out of scope in this schema definition.  Multiple type tokens for a single element are supported.
    /// 
    /// RENAMED:  'OtherText' to 'Property' 9/14/2016
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute("Property", Order=0)]
    public virtual List<RichTextType> Property
    {
        get
        {
            return this._property;
        }
        set
        {
            this._property = value;
        }
    }
    
    /// <summary>
    /// THe URI/URL may use the parameter list and transmit the item name, property and value for each parameter.  The URI must understand the parameters and return an appropriate repsonse of the correct data type.  Guidelines for URI/URI construction syntax will be defined external to this Schema.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public virtual anyURI_Stype URI
    {
        get
        {
            return this._uRI;
        }
        set
        {
            this._uRI = value;
        }
    }
    
    /// <summary>
    /// Information about securly accessing the web service.  More detailed service patterns may be required.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
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
    
    /// <summary>
    /// Parameters are named FormDesign items which have property values that need to be supplied to a scripted function or a web service URI.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute("Parameter", Order=3)]
    public virtual List<GetParameterFromPropertyType> Parameter
    {
        get
        {
            return this._parameter;
        }
        set
        {
            this._parameter = value;
        }
    }
    
    private static XmlSerializer Serializer
    {
        get
        {
            if ((serializer == null))
            {
                serializer = new XmlSerializerFactory().CreateSerializer(typeof(WebServiceType));
            }
            return serializer;
        }
    }
    
    /// <summary>
    /// Test whether Property should be serialized
    /// </summary>
    public virtual bool ShouldSerializeProperty()
    {
        return Property != null && Property.Count > 0;
    }
    
    /// <summary>
    /// Test whether Parameter should be serialized
    /// </summary>
    public virtual bool ShouldSerializeParameter()
    {
        return Parameter != null && Parameter.Count > 0;
    }
    
    /// <summary>
    /// Test whether URI should be serialized
    /// </summary>
    public virtual bool ShouldSerializeURI()
    {
        return (_uRI != null);
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
    /// Serializes current WebServiceType object into an XML string
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
    /// Deserializes workflow markup into an WebServiceType object
    /// </summary>
    /// <param name="input">string workflow markup to deserialize</param>
    /// <param name="obj">Output WebServiceType object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string input, out WebServiceType obj, out System.Exception exception)
    {
        exception = null;
        obj = default(WebServiceType);
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
    
    public static bool Deserialize(string input, out WebServiceType obj)
    {
        System.Exception exception = null;
        return Deserialize(input, out obj, out exception);
    }
    
    public new static WebServiceType Deserialize(string input)
    {
        System.IO.StringReader stringReader = null;
        try
        {
            stringReader = new System.IO.StringReader(input);
            return ((WebServiceType)(Serializer.Deserialize(XmlReader.Create(stringReader))));
        }
        finally
        {
            if ((stringReader != null))
            {
                stringReader.Dispose();
            }
        }
    }
    
    public static WebServiceType Deserialize(System.IO.Stream s)
    {
        return ((WebServiceType)(Serializer.Deserialize(s)));
    }
    #endregion
    
    /// <summary>
    /// Serializes current WebServiceType object into file
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
    /// Deserializes xml markup from file into an WebServiceType object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output WebServiceType object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, System.Text.Encoding encoding, out WebServiceType obj, out System.Exception exception)
    {
        exception = null;
        obj = default(WebServiceType);
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
    
    public static bool LoadFromFile(string fileName, out WebServiceType obj, out System.Exception exception)
    {
        return LoadFromFile(fileName, System.Text.Encoding.UTF8, out obj, out exception);
    }
    
    public static bool LoadFromFile(string fileName, out WebServiceType obj)
    {
        System.Exception exception = null;
        return LoadFromFile(fileName, out obj, out exception);
    }
    
    public static WebServiceType LoadFromFile(string fileName)
    {
        return LoadFromFile(fileName, System.Text.Encoding.UTF8);
    }
    
    public new static WebServiceType LoadFromFile(string fileName, System.Text.Encoding encoding)
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
