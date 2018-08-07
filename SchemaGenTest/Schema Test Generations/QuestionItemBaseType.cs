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
/// Represents questions.  Parent items may be Section, Question, and ListItem.
/// </summary>
[XmlIncludeAttribute(typeof(QuestionItemType))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1067.0")]
[Serializable]
[DebuggerStepThrough]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[XmlTypeAttribute(Namespace="http://healthIT.gov/sdc")]
[DataContractAttribute(Name="QuestionItemBaseType", Namespace="http://healthIT.gov/sdc")]
public partial class QuestionItemBaseType : RepeatingType
{
    
    private bool _shouldSerializereadOnly;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private ExtensionBaseType _item;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private BindingList<ResponseChangeType> _responseHistory;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private bool _readOnly;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private System.Nullable<QuestionItemBaseTypeResponseTypeEnum> _responseTypeEnum;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private System.Nullable<QuestionItemBaseTypeResponseStatusEnum> _responseStatusEnum;
    
    private static XmlSerializer serializer;
    
    private ObjectChangeTracker changeTrackerField;
    
    /// <summary>
    /// QuestionItemBaseType class constructor
    /// </summary>
    public QuestionItemBaseType()
    {
        _readOnly = false;
    }
    
    [XmlElementAttribute("ListField", typeof(ListFieldType), Order=0)]
    [XmlElementAttribute("ResponseField", typeof(ResponseFieldType), Order=0)]
    [DataMemberAttribute(Name="ListField", Order=0)]
    public virtual ExtensionBaseType Item
    {
        get
        {
            return _item;
        }
        set
        {
            if ((_item == value))
            {
                return;
            }
            if (((_item == null) 
                        || (_item.Equals(value) != true)))
            {
                _item = value;
                OnPropertyChanged("Item", value);
            }
        }
    }
    
    /// <summary>
    /// For recording metadata and changes about the current answer and any previous (replaced) answers to the current question. Each ResponseHistory element is single unit of response(s), taking place at the same time, to the question.  It records the person who made the change, the DateTime of the change, and the the previous ReplacedResponse.  ReplacedResponse includes each answer selection or fill-in response to the question at the time the change was submitted.
    /// </summary>
    [XmlElementAttribute("ResponseHistory", Order=1)]
    [DataMemberAttribute(Order=1)]
    public virtual BindingList<ResponseChangeType> ResponseHistory
    {
        get
        {
            return _responseHistory;
        }
        set
        {
            if ((_responseHistory == value))
            {
                return;
            }
            if (((_responseHistory == null) 
                        || (_responseHistory.Equals(value) != true)))
            {
                _responseHistory = value;
                OnPropertyChanged("ResponseHistory", value);
            }
        }
    }
    
    /// <summary>
    /// If @readOnly is set to true, the this field may not be edited by the user, and any default values set by template should be considered part of the stored data set responses, and transmitted by the SubmitForm transaction.
    /// </summary>
    [XmlAttribute]
    [System.ComponentModel.DefaultValueAttribute(false)]
    [DataMember]
    public virtual bool readOnly
    {
        get
        {
            return _readOnly;
        }
        set
        {
            if ((_readOnly.Equals(value) != true))
            {
                _readOnly = value;
                OnPropertyChanged("readOnly", value);
            }
            _shouldSerializereadOnly = true;
        }
    }
    
    [XmlAttribute]
    [DataMember]
    public virtual QuestionItemBaseTypeResponseTypeEnum responseTypeEnum
    {
        get
        {
            if (_responseTypeEnum.HasValue)
            {
                return _responseTypeEnum.Value;
            }
            else
            {
                return default(QuestionItemBaseTypeResponseTypeEnum);
            }
        }
        set
        {
            if ((_responseTypeEnum.Equals(value) != true))
            {
                _responseTypeEnum = value;
                OnPropertyChanged("responseTypeEnum", value);
            }
        }
    }
    
    [XmlIgnore]
    [DataMember]
    public virtual bool responseTypeEnumSpecified
    {
        get
        {
            return _responseTypeEnum.HasValue;
        }
        set
        {
            if (value==false)
            {
                _responseTypeEnum = null;
            }
        }
    }
    
    [XmlAttribute]
    [DataMember]
    public virtual QuestionItemBaseTypeResponseStatusEnum responseStatusEnum
    {
        get
        {
            if (_responseStatusEnum.HasValue)
            {
                return _responseStatusEnum.Value;
            }
            else
            {
                return default(QuestionItemBaseTypeResponseStatusEnum);
            }
        }
        set
        {
            if ((_responseStatusEnum.Equals(value) != true))
            {
                _responseStatusEnum = value;
                OnPropertyChanged("responseStatusEnum", value);
            }
        }
    }
    
    [XmlIgnore]
    [DataMember]
    public virtual bool responseStatusEnumSpecified
    {
        get
        {
            return _responseStatusEnum.HasValue;
        }
        set
        {
            if (value==false)
            {
                _responseStatusEnum = null;
            }
        }
    }
    
    private static XmlSerializer Serializer
    {
        get
        {
            if ((serializer == null))
            {
                serializer = new XmlSerializerFactory().CreateSerializer(typeof(QuestionItemBaseType));
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
    
    /// <summary>
    /// Test whether readOnly should be serialized
    /// </summary>
    public virtual bool ShouldSerializereadOnly()
    {
        if (_shouldSerializereadOnly)
        {
            return true;
        }
        return (_readOnly != default(bool));
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
    /// Serializes current QuestionItemBaseType object into an XML string
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
    /// Deserializes workflow markup into an QuestionItemBaseType object
    /// </summary>
    /// <param name="input">string workflow markup to deserialize</param>
    /// <param name="obj">Output QuestionItemBaseType object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string input, out QuestionItemBaseType obj, out Exception exception)
    {
        exception = null;
        obj = default(QuestionItemBaseType);
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
    
    public static bool Deserialize(string input, out QuestionItemBaseType obj)
    {
        Exception exception = null;
        return Deserialize(input, out obj, out exception);
    }
    
    public new static QuestionItemBaseType Deserialize(string input)
    {
        StringReader stringReader = null;
        try
        {
            stringReader = new StringReader(input);
            return ((QuestionItemBaseType)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
        }
        finally
        {
            if ((stringReader != null))
            {
                stringReader.Dispose();
            }
        }
    }
    
    public static QuestionItemBaseType Deserialize(Stream s)
    {
        return ((QuestionItemBaseType)(Serializer.Deserialize(s)));
    }
    #endregion
    
    /// <summary>
    /// Serializes current QuestionItemBaseType object into file
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
    /// Deserializes xml markup from file into an QuestionItemBaseType object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output QuestionItemBaseType object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out QuestionItemBaseType obj, out Exception exception)
    {
        exception = null;
        obj = default(QuestionItemBaseType);
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
    
    public static bool LoadFromFile(string fileName, out QuestionItemBaseType obj)
    {
        Exception exception = null;
        return LoadFromFile(fileName, out obj, out exception);
    }
    
    public new static QuestionItemBaseType LoadFromFile(string fileName)
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
    /// Create a clone of this QuestionItemBaseType object
    /// </summary>
    public virtual QuestionItemBaseType Clone()
    {
        return ((QuestionItemBaseType)(MemberwiseClone()));
    }
    #endregion
}
}
#pragma warning restore
