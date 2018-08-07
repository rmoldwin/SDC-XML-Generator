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

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2053.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ihe:qrph:sdc:2016")]
public partial class negativeInteger_DEtype : negativeInteger_Stype
{
    
    #region Private fields
    [EditorBrowsable(EditorBrowsableState.Never)]
    private string _minInclusive;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private string _maxInclusive;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private string _minExclusive;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private string _maxExclusive;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private System.Nullable<byte> _totalDigits;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private string _mask;
    
    private static XmlSerializer serializer;
    #endregion
    
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="negativeInteger")]
    public virtual string minInclusive
    {
        get
        {
            return this._minInclusive;
        }
        set
        {
            this._minInclusive = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="negativeInteger")]
    public virtual string maxInclusive
    {
        get
        {
            return this._maxInclusive;
        }
        set
        {
            this._maxInclusive = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="negativeInteger")]
    public virtual string minExclusive
    {
        get
        {
            return this._minExclusive;
        }
        set
        {
            this._minExclusive = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="negativeInteger")]
    public virtual string maxExclusive
    {
        get
        {
            return this._maxExclusive;
        }
        set
        {
            this._maxExclusive = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public virtual byte totalDigits
    {
        get
        {
            if (this._totalDigits.HasValue)
            {
                return this._totalDigits.Value;
            }
            else
            {
                return default(byte);
            }
        }
        set
        {
            this._totalDigits = value;
        }
    }
    
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public virtual bool totalDigitsSpecified
    {
        get
        {
            return this._totalDigits.HasValue;
        }
        set
        {
            if (value==false)
            {
                this._totalDigits = null;
            }
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public virtual string mask
    {
        get
        {
            return this._mask;
        }
        set
        {
            this._mask = value;
        }
    }
    
    private static XmlSerializer Serializer
    {
        get
        {
            if ((serializer == null))
            {
                serializer = new XmlSerializerFactory().CreateSerializer(typeof(negativeInteger_DEtype));
            }
            return serializer;
        }
    }
    
    /// <summary>
    /// Test whether minInclusive should be serialized
    /// </summary>
    public virtual bool ShouldSerializeminInclusive()
    {
        return !string.IsNullOrEmpty(minInclusive);
    }
    
    /// <summary>
    /// Test whether maxInclusive should be serialized
    /// </summary>
    public virtual bool ShouldSerializemaxInclusive()
    {
        return !string.IsNullOrEmpty(maxInclusive);
    }
    
    /// <summary>
    /// Test whether minExclusive should be serialized
    /// </summary>
    public virtual bool ShouldSerializeminExclusive()
    {
        return !string.IsNullOrEmpty(minExclusive);
    }
    
    /// <summary>
    /// Test whether maxExclusive should be serialized
    /// </summary>
    public virtual bool ShouldSerializemaxExclusive()
    {
        return !string.IsNullOrEmpty(maxExclusive);
    }
    
    /// <summary>
    /// Test whether mask should be serialized
    /// </summary>
    public virtual bool ShouldSerializemask()
    {
        return !string.IsNullOrEmpty(mask);
    }
    
    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current negativeInteger_DEtype object into an XML string
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
    /// Deserializes workflow markup into an negativeInteger_DEtype object
    /// </summary>
    /// <param name="input">string workflow markup to deserialize</param>
    /// <param name="obj">Output negativeInteger_DEtype object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string input, out negativeInteger_DEtype obj, out System.Exception exception)
    {
        exception = null;
        obj = default(negativeInteger_DEtype);
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
    
    public static bool Deserialize(string input, out negativeInteger_DEtype obj)
    {
        System.Exception exception = null;
        return Deserialize(input, out obj, out exception);
    }
    
    public new static negativeInteger_DEtype Deserialize(string input)
    {
        System.IO.StringReader stringReader = null;
        try
        {
            stringReader = new System.IO.StringReader(input);
            return ((negativeInteger_DEtype)(Serializer.Deserialize(XmlReader.Create(stringReader))));
        }
        finally
        {
            if ((stringReader != null))
            {
                stringReader.Dispose();
            }
        }
    }
    
    public static negativeInteger_DEtype Deserialize(System.IO.Stream s)
    {
        return ((negativeInteger_DEtype)(Serializer.Deserialize(s)));
    }
    #endregion
    
    /// <summary>
    /// Serializes current negativeInteger_DEtype object into file
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
    /// Deserializes xml markup from file into an negativeInteger_DEtype object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output negativeInteger_DEtype object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, System.Text.Encoding encoding, out negativeInteger_DEtype obj, out System.Exception exception)
    {
        exception = null;
        obj = default(negativeInteger_DEtype);
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
    
    public static bool LoadFromFile(string fileName, out negativeInteger_DEtype obj, out System.Exception exception)
    {
        return LoadFromFile(fileName, System.Text.Encoding.UTF8, out obj, out exception);
    }
    
    public static bool LoadFromFile(string fileName, out negativeInteger_DEtype obj)
    {
        System.Exception exception = null;
        return LoadFromFile(fileName, out obj, out exception);
    }
    
    public static negativeInteger_DEtype LoadFromFile(string fileName)
    {
        return LoadFromFile(fileName, System.Text.Encoding.UTF8);
    }
    
    public new static negativeInteger_DEtype LoadFromFile(string fileName, System.Text.Encoding encoding)
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
