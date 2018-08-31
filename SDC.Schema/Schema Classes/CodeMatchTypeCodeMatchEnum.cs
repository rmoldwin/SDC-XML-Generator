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
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:ihe:qrph:sdc:2016")]
public enum CodeMatchTypeCodeMatchEnum
{
    
    [System.Xml.Serialization.XmlEnumAttribute("Exact Code Match")]
    ExactCodeMatch,
    
    [System.Xml.Serialization.XmlEnumAttribute("Close Code Match")]
    CloseCodeMatch,
    
    [System.Xml.Serialization.XmlEnumAttribute("Code Broader Than Item")]
    CodeBroaderThanItem,
    
    [System.Xml.Serialization.XmlEnumAttribute("Code Narrower Than Item")]
    CodeNarrowerThanItem,
    
    [System.Xml.Serialization.XmlEnumAttribute("Item Implements Data Element Exactly")]
    ItemImplementsDataElementExactly,
    
    [System.Xml.Serialization.XmlEnumAttribute("Item Derived From Data Element")]
    ItemDerivedFromDataElement,
    
    [System.Xml.Serialization.XmlEnumAttribute("Item Related To Data Element")]
    ItemRelatedToDataElement,
}
}
#pragma warning restore