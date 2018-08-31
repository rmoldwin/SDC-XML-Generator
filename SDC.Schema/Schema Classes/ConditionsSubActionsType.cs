// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code++. Version 4.4.0.7
//  </auto-generated>
// ------------------------------------------------------------------------------
#pragma warning disable
namespace SDC.Schema
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

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ihe:qrph:sdc:2016")]
public partial class ConditionsSubActionsType : FuncBoolBaseType
{
    
    private bool _shouldSerializeboolOp;
    
    private bool _shouldSerializenot;
    
    private static XmlSerializer serializer;
    
        [System.Xml.Serialization.XmlElementAttribute("AttributeCondition", Order=0)]
        public virtual List<ConditionsSubActionsTypeAttributeCondition> AttributeCondition { get; set; }
        [System.Xml.Serialization.XmlElementAttribute("MultiSelections", Order=1)]
        public virtual List<ConditionsSubActionsTypeMultiSelections> MultiSelections { get; set; }
        [System.Xml.Serialization.XmlElementAttribute("IllegalSelectionSets", Order=2)]
        public virtual List<ConditionsSubActionsTypeIllegalSelectionSets> IllegalSelectionSets { get; set; }
        [System.Xml.Serialization.XmlElementAttribute("IllegalSelectionTest", Order=3)]
        public virtual List<ConditionsSubActionsTypeIllegalSelectionTest> IllegalSelectionTest { get; set; }
        [System.Xml.Serialization.XmlElementAttribute("ScriptCondition", Order=4)]
        public virtual List<ConditionsSubActionsTypeScriptCondition> ScriptCondition { get; set; }
        [System.Xml.Serialization.XmlElementAttribute("Group", Order=5)]
        public virtual List<ConditionalGroupActionType> Group { get; set; }
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified)]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public virtual bool not { get; set; }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool notSpecified { get; set; }
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(GetItemAttribValuesTypeBoolOp.AND)]
        public virtual GetItemAttribValuesTypeBoolOp boolOp { get; set; }
    
    /// <summary>
    /// ConditionsSubActionsType class constructor
    /// </summary>
    public ConditionsSubActionsType()
    {
        this.not = false;
        this.boolOp = GetItemAttribValuesTypeBoolOp.AND;
    }
    
    private static XmlSerializer Serializer
    {
        get
        {
            if ((serializer == null))
            {
                serializer = new XmlSerializerFactory().CreateSerializer(typeof(ConditionsSubActionsType));
            }
            return serializer;
        }
    }
    
    /// <summary>
    /// Test whether AttributeCondition should be serialized
    /// </summary>
    public virtual bool ShouldSerializeAttributeCondition()
    {
        return AttributeCondition != null && AttributeCondition.Count > 0;
    }
    
    /// <summary>
    /// Test whether MultiSelections should be serialized
    /// </summary>
    public virtual bool ShouldSerializeMultiSelections()
    {
        return MultiSelections != null && MultiSelections.Count > 0;
    }
    
    /// <summary>
    /// Test whether IllegalSelectionSets should be serialized
    /// </summary>
    public virtual bool ShouldSerializeIllegalSelectionSets()
    {
        return IllegalSelectionSets != null && IllegalSelectionSets.Count > 0;
    }
    
    /// <summary>
    /// Test whether IllegalSelectionTest should be serialized
    /// </summary>
    public virtual bool ShouldSerializeIllegalSelectionTest()
    {
        return IllegalSelectionTest != null && IllegalSelectionTest.Count > 0;
    }
    
    /// <summary>
    /// Test whether ScriptCondition should be serialized
    /// </summary>
    public virtual bool ShouldSerializeScriptCondition()
    {
        return ScriptCondition != null && ScriptCondition.Count > 0;
    }
    
    /// <summary>
    /// Test whether Group should be serialized
    /// </summary>
    public virtual bool ShouldSerializeGroup()
    {
        return Group != null && Group.Count > 0;
    }
    
    /// <summary>
    /// Test whether not should be serialized
    /// </summary>
    public virtual bool ShouldSerializenot()
    {
        if (_shouldSerializenot)
        {
            return true;
        }
        return (not != default(bool));
    }
    
    /// <summary>
    /// Test whether boolOp should be serialized
    /// </summary>
    public virtual bool ShouldSerializeboolOp()
    {
        if (_shouldSerializeboolOp)
        {
            return true;
        }
        return (boolOp != default(GetItemAttribValuesTypeBoolOp));
    }
    
    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current ConditionsSubActionsType object into an XML string
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
    /// Deserializes workflow markup into an ConditionsSubActionsType object
    /// </summary>
    /// <param name="input">string workflow markup to deserialize</param>
    /// <param name="obj">Output ConditionsSubActionsType object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string input, out ConditionsSubActionsType obj, out System.Exception exception)
    {
        exception = null;
        obj = default(ConditionsSubActionsType);
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
    
    public static bool Deserialize(string input, out ConditionsSubActionsType obj)
    {
        System.Exception exception = null;
        return Deserialize(input, out obj, out exception);
    }
    
    public new static ConditionsSubActionsType Deserialize(string input)
    {
        System.IO.StringReader stringReader = null;
        try
        {
            stringReader = new System.IO.StringReader(input);
            return ((ConditionsSubActionsType)(Serializer.Deserialize(XmlReader.Create(stringReader))));
        }
        finally
        {
            if ((stringReader != null))
            {
                stringReader.Dispose();
            }
        }
    }
    
    public static ConditionsSubActionsType Deserialize(System.IO.Stream s)
    {
        return ((ConditionsSubActionsType)(Serializer.Deserialize(s)));
    }
    #endregion
    
    /// <summary>
    /// Serializes current ConditionsSubActionsType object into file
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
    /// Deserializes xml markup from file into an ConditionsSubActionsType object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output ConditionsSubActionsType object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, System.Text.Encoding encoding, out ConditionsSubActionsType obj, out System.Exception exception)
    {
        exception = null;
        obj = default(ConditionsSubActionsType);
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
    
    public static bool LoadFromFile(string fileName, out ConditionsSubActionsType obj, out System.Exception exception)
    {
        return LoadFromFile(fileName, System.Text.Encoding.UTF8, out obj, out exception);
    }
    
    public static bool LoadFromFile(string fileName, out ConditionsSubActionsType obj)
    {
        System.Exception exception = null;
        return LoadFromFile(fileName, out obj, out exception);
    }
    
    public static ConditionsSubActionsType LoadFromFile(string fileName)
    {
        return LoadFromFile(fileName, System.Text.Encoding.UTF8);
    }
    
    public new static ConditionsSubActionsType LoadFromFile(string fileName, System.Text.Encoding encoding)
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