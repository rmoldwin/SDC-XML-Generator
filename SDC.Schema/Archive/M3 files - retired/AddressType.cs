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
/// Type of address, e.g., home, office, etc
/// </summary>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2053.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ihe:qrph:sdc:2016")]
public partial class AddressType : ExtensionBaseType
{
    
    #region Private fields
    [EditorBrowsable(EditorBrowsableState.Never)]
    private string_Stype _addressType1;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private List<string_Stype> _internalAddress;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private List<string_Stype> _addressLine;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private string_Stype _city;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private string_Stype _jurisdiction;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private string_Stype _state;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private string_Stype _postalCode;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private string_Stype _country;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private string_Stype _usage;
    
    private static XmlSerializer serializer;
    #endregion
    
    [System.Xml.Serialization.XmlElementAttribute("AddressType", Order=0)]
    public virtual string_Stype AddressType1
    {
        get
        {
            return this._addressType1;
        }
        set
        {
            this._addressType1 = value;
        }
    }
    
    [System.Xml.Serialization.XmlElementAttribute("InternalAddress", Order=1)]
    public virtual List<string_Stype> InternalAddress
    {
        get
        {
            return this._internalAddress;
        }
        set
        {
            this._internalAddress = value;
        }
    }
    
    [System.Xml.Serialization.XmlElementAttribute("AddressLine", Order=2)]
    public virtual List<string_Stype> AddressLine
    {
        get
        {
            return this._addressLine;
        }
        set
        {
            this._addressLine = value;
        }
    }
    
    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public virtual string_Stype City
    {
        get
        {
            return this._city;
        }
        set
        {
            this._city = value;
        }
    }
    
    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public virtual string_Stype Jurisdiction
    {
        get
        {
            return this._jurisdiction;
        }
        set
        {
            this._jurisdiction = value;
        }
    }
    
    [System.Xml.Serialization.XmlElementAttribute(Order=5)]
    public virtual string_Stype State
    {
        get
        {
            return this._state;
        }
        set
        {
            this._state = value;
        }
    }
    
    [System.Xml.Serialization.XmlElementAttribute(Order=6)]
    public virtual string_Stype PostalCode
    {
        get
        {
            return this._postalCode;
        }
        set
        {
            this._postalCode = value;
        }
    }
    
    [System.Xml.Serialization.XmlElementAttribute(Order=7)]
    public virtual string_Stype Country
    {
        get
        {
            return this._country;
        }
        set
        {
            this._country = value;
        }
    }
    
    [System.Xml.Serialization.XmlElementAttribute(Order=8)]
    public virtual string_Stype Usage
    {
        get
        {
            return this._usage;
        }
        set
        {
            this._usage = value;
        }
    }
    
    private static XmlSerializer Serializer
    {
        get
        {
            if ((serializer == null))
            {
                serializer = new XmlSerializerFactory().CreateSerializer(typeof(AddressType));
            }
            return serializer;
        }
    }
    
    /// <summary>
    /// Test whether InternalAddress should be serialized
    /// </summary>
    public virtual bool ShouldSerializeInternalAddress()
    {
        return InternalAddress != null && InternalAddress.Count > 0;
    }
    
    /// <summary>
    /// Test whether AddressLine should be serialized
    /// </summary>
    public virtual bool ShouldSerializeAddressLine()
    {
        return AddressLine != null && AddressLine.Count > 0;
    }
    
    /// <summary>
    /// Test whether AddressType1 should be serialized
    /// </summary>
    public virtual bool ShouldSerializeAddressType1()
    {
        return (_addressType1 != null);
    }
    
    /// <summary>
    /// Test whether City should be serialized
    /// </summary>
    public virtual bool ShouldSerializeCity()
    {
        return (_city != null);
    }
    
    /// <summary>
    /// Test whether Jurisdiction should be serialized
    /// </summary>
    public virtual bool ShouldSerializeJurisdiction()
    {
        return (_jurisdiction != null);
    }
    
    /// <summary>
    /// Test whether State should be serialized
    /// </summary>
    public virtual bool ShouldSerializeState()
    {
        return (_state != null);
    }
    
    /// <summary>
    /// Test whether PostalCode should be serialized
    /// </summary>
    public virtual bool ShouldSerializePostalCode()
    {
        return (_postalCode != null);
    }
    
    /// <summary>
    /// Test whether Country should be serialized
    /// </summary>
    public virtual bool ShouldSerializeCountry()
    {
        return (_country != null);
    }
    
    /// <summary>
    /// Test whether Usage should be serialized
    /// </summary>
    public virtual bool ShouldSerializeUsage()
    {
        return (_usage != null);
    }
    
    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current AddressType object into an XML string
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
    /// Deserializes workflow markup into an AddressType object
    /// </summary>
    /// <param name="input">string workflow markup to deserialize</param>
    /// <param name="obj">Output AddressType object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string input, out AddressType obj, out System.Exception exception)
    {
        exception = null;
        obj = default(AddressType);
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
    
    public static bool Deserialize(string input, out AddressType obj)
    {
        System.Exception exception = null;
        return Deserialize(input, out obj, out exception);
    }
    
    public new static AddressType Deserialize(string input)
    {
        System.IO.StringReader stringReader = null;
        try
        {
            stringReader = new System.IO.StringReader(input);
            return ((AddressType)(Serializer.Deserialize(XmlReader.Create(stringReader))));
        }
        finally
        {
            if ((stringReader != null))
            {
                stringReader.Dispose();
            }
        }
    }
    
    public static AddressType Deserialize(System.IO.Stream s)
    {
        return ((AddressType)(Serializer.Deserialize(s)));
    }
    #endregion
    
    /// <summary>
    /// Serializes current AddressType object into file
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
    /// Deserializes xml markup from file into an AddressType object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output AddressType object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, System.Text.Encoding encoding, out AddressType obj, out System.Exception exception)
    {
        exception = null;
        obj = default(AddressType);
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
    
    public static bool LoadFromFile(string fileName, out AddressType obj, out System.Exception exception)
    {
        return LoadFromFile(fileName, System.Text.Encoding.UTF8, out obj, out exception);
    }
    
    public static bool LoadFromFile(string fileName, out AddressType obj)
    {
        System.Exception exception = null;
        return LoadFromFile(fileName, out obj, out exception);
    }
    
    public static AddressType LoadFromFile(string fileName)
    {
        return LoadFromFile(fileName, System.Text.Encoding.UTF8);
    }
    
    public new static AddressType LoadFromFile(string fileName, System.Text.Encoding encoding)
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
