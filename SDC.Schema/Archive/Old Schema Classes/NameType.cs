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
/// Structure to define a person's name, including prefixes, suffixes, and degrees.
/// </summary>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1067.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://healthIT.gov/sdc")]
public partial class NameType : ExtensionBaseType
{
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private string_Stype _namePrefix;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private string_Stype _firstName;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private string_Stype _middleName;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private string_Stype _lastName;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private string_Stype _nameSuffix;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private List<string_Stype> _degreeCert;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private string_Stype _title;
    
    private static XmlSerializer serializer;
    
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public virtual string_Stype NamePrefix
    {
        get
        {
            return this._namePrefix;
        }
        set
        {
            this._namePrefix = value;
        }
    }
    
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
    public virtual string_Stype FirstName
    {
        get
        {
            return this._firstName;
        }
        set
        {
            this._firstName = value;
        }
    }
    
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public virtual string_Stype MiddleName
    {
        get
        {
            return this._middleName;
        }
        set
        {
            this._middleName = value;
        }
    }
    
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3)]
    public virtual string_Stype LastName
    {
        get
        {
            return this._lastName;
        }
        set
        {
            this._lastName = value;
        }
    }
    
    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public virtual string_Stype NameSuffix
    {
        get
        {
            return this._nameSuffix;
        }
        set
        {
            this._nameSuffix = value;
        }
    }
    
    /// <summary>
    /// Acronyms for degrees and certifications, e.g., MD, PhD, FACP (repeat element for each acronym)
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute("DegreeCert", Order=5)]
    public virtual List<string_Stype> DegreeCert
    {
        get
        {
            return this._degreeCert;
        }
        set
        {
            this._degreeCert = value;
        }
    }
    
    [System.Xml.Serialization.XmlElementAttribute(Order=6)]
    public virtual string_Stype Title
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
                serializer = new XmlSerializerFactory().CreateSerializer(typeof(NameType));
            }
            return serializer;
        }
    }
    
    /// <summary>
    /// Test whether DegreeCert should be serialized
    /// </summary>
    public virtual bool ShouldSerializeDegreeCert()
    {
        return DegreeCert != null && DegreeCert.Count > 0;
    }
    
    /// <summary>
    /// Test whether NamePrefix should be serialized
    /// </summary>
    public virtual bool ShouldSerializeNamePrefix()
    {
        return (_namePrefix != null);
    }
    
    /// <summary>
    /// Test whether FirstName should be serialized
    /// </summary>
    public virtual bool ShouldSerializeFirstName()
    {
        return (_firstName != null);
    }
    
    /// <summary>
    /// Test whether MiddleName should be serialized
    /// </summary>
    public virtual bool ShouldSerializeMiddleName()
    {
        return (_middleName != null);
    }
    
    /// <summary>
    /// Test whether LastName should be serialized
    /// </summary>
    public virtual bool ShouldSerializeLastName()
    {
        return (_lastName != null);
    }
    
    /// <summary>
    /// Test whether NameSuffix should be serialized
    /// </summary>
    public virtual bool ShouldSerializeNameSuffix()
    {
        return (_nameSuffix != null);
    }
    
    /// <summary>
    /// Test whether Title should be serialized
    /// </summary>
    public virtual bool ShouldSerializeTitle()
    {
        return (_title != null);
    }
    
    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current NameType object into an XML string
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
    /// Deserializes workflow markup into an NameType object
    /// </summary>
    /// <param name="input">string workflow markup to deserialize</param>
    /// <param name="obj">Output NameType object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string input, out NameType obj, out System.Exception exception)
    {
        exception = null;
        obj = default(NameType);
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
    
    public static bool Deserialize(string input, out NameType obj)
    {
        System.Exception exception = null;
        return Deserialize(input, out obj, out exception);
    }
    
    public new static NameType Deserialize(string input)
    {
        System.IO.StringReader stringReader = null;
        try
        {
            stringReader = new System.IO.StringReader(input);
            return ((NameType)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
        }
        finally
        {
            if ((stringReader != null))
            {
                stringReader.Dispose();
            }
        }
    }
    
    public static NameType Deserialize(System.IO.Stream s)
    {
        return ((NameType)(Serializer.Deserialize(s)));
    }
    #endregion
    
    /// <summary>
    /// Serializes current NameType object into file
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
    /// Deserializes xml markup from file into an NameType object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output NameType object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out NameType obj, out System.Exception exception)
    {
        exception = null;
        obj = default(NameType);
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
    
    public static bool LoadFromFile(string fileName, out NameType obj)
    {
        System.Exception exception = null;
        return LoadFromFile(fileName, out obj, out exception);
    }
    
    public new static NameType LoadFromFile(string fileName)
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