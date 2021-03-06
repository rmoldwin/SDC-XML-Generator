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
/// This type represents the "Then" and "Else" parts of an If-Then" statement. It can also be used to specify actions after an event is fired in the form.  It contains form-related actions and allows nested If-Then-Else structures to further define form actions.
/// </summary>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1067.0")]
[Serializable]
[DebuggerStepThrough]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[XmlTypeAttribute(Namespace="http://healthIT.gov/sdc")]
[DataContractAttribute(Name="ThenType", Namespace="http://healthIT.gov/sdc")]
public partial class ThenType : ExtensionBaseType
{
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private BindingList<BaseType> _items;
    
    private static XmlSerializer serializer;
    
    private ObjectChangeTracker changeTrackerField;
    
    [XmlElementAttribute("Action", typeof(ExtensionType), Order=0)]
    [XmlElementAttribute("CallIfThen", typeof(ItemNameType), Order=0)]
    [XmlElementAttribute("IfThen", typeof(IfThenType), Order=0)]
    [XmlElementAttribute("Inject", typeof(ActInjectType), Order=0)]
    [XmlElementAttribute("RunCommand", typeof(ExpressionType), Order=0)]
    [XmlElementAttribute("Save", typeof(ActSaveResponsesType), Order=0)]
    [XmlElementAttribute("SetProperty", typeof(SetPropertyType), Order=0)]
    [XmlElementAttribute("SetValue", typeof(ActSetValueType), Order=0)]
    [XmlElementAttribute("ShowForm", typeof(ActShowFormType), Order=0)]
    [XmlElementAttribute("ShowMessage", typeof(ActShowMessageType), Order=0)]
    [XmlElementAttribute("ShowReport", typeof(ActShowReportType), Order=0)]
    [XmlElementAttribute("ShowURL", typeof(WebServiceType), Order=0)]
    [XmlElementAttribute("_SendMessage", typeof(ActSendMessageType), Order=0)]
    [XmlElementAttribute("_SendReport", typeof(ActSendReportType), Order=0)]
    [XmlElementAttribute("_ValidateForm", typeof(ActValidateFormType), Order=0)]
    [DataMemberAttribute(Name="Action", Order=0)]
    public virtual BindingList<BaseType> Items
    {
        get
        {
            return _items;
        }
        set
        {
            if ((_items == value))
            {
                return;
            }
            if (((_items == null) 
                        || (_items.Equals(value) != true)))
            {
                _items = value;
                OnPropertyChanged("Items", value);
            }
        }
    }
    
    private static XmlSerializer Serializer
    {
        get
        {
            if ((serializer == null))
            {
                serializer = new XmlSerializerFactory().CreateSerializer(typeof(ThenType));
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
    
    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current ThenType object into an XML string
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
    /// Deserializes workflow markup into an ThenType object
    /// </summary>
    /// <param name="input">string workflow markup to deserialize</param>
    /// <param name="obj">Output ThenType object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string input, out ThenType obj, out Exception exception)
    {
        exception = null;
        obj = default(ThenType);
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
    
    public static bool Deserialize(string input, out ThenType obj)
    {
        Exception exception = null;
        return Deserialize(input, out obj, out exception);
    }
    
    public new static ThenType Deserialize(string input)
    {
        StringReader stringReader = null;
        try
        {
            stringReader = new StringReader(input);
            return ((ThenType)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
        }
        finally
        {
            if ((stringReader != null))
            {
                stringReader.Dispose();
            }
        }
    }
    
    public static ThenType Deserialize(Stream s)
    {
        return ((ThenType)(Serializer.Deserialize(s)));
    }
    #endregion
    
    /// <summary>
    /// Serializes current ThenType object into file
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
    /// Deserializes xml markup from file into an ThenType object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output ThenType object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out ThenType obj, out Exception exception)
    {
        exception = null;
        obj = default(ThenType);
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
    
    public static bool LoadFromFile(string fileName, out ThenType obj)
    {
        Exception exception = null;
        return LoadFromFile(fileName, out obj, out exception);
    }
    
    public new static ThenType LoadFromFile(string fileName)
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
    /// Create a clone of this ThenType object
    /// </summary>
    public virtual ThenType Clone()
    {
        return ((ThenType)(MemberwiseClone()));
    }
    #endregion
}
}
#pragma warning restore
