// <auto-generated/>
// Contents of: hl7.fhir.r3.expansions#3.0.2, hl7.fhir.r3.core#3.0.2

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Serialization;
using Hl7.Fhir.Specification;
using Hl7.Fhir.Utility;
using Hl7.Fhir.Validation;
using SystemPrimitive = Hl7.Fhir.ElementModel.Types;

/*
  Copyright (c) 2011+, HL7, Inc.
  All rights reserved.
  
  Redistribution and use in source and binary forms, with or without modification, 
  are permitted provided that the following conditions are met:
  
   * Redistributions of source code must retain the above copyright notice, this 
     list of conditions and the following disclaimer.
   * Redistributions in binary form must reproduce the above copyright notice, 
     this list of conditions and the following disclaimer in the documentation 
     and/or other materials provided with the distribution.
   * Neither the name of HL7 nor the names of its contributors may be used to 
     endorse or promote products derived from this software without specific 
     prior written permission.
  
  THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND 
  ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED 
  WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. 
  IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, 
  INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT 
  NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR 
  PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, 
  WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
  ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 
  POSSIBILITY OF SUCH DAMAGE.
  
*/

namespace Hl7.Fhir.Model
{
  /// <summary>
  /// Describes a required data item
  /// </summary>
  /// <remarks>
  /// Describes a required data item for evaluation in terms of the type of data, and optional code or date-based filters of the data.
  /// </remarks>
  [Serializable]
  [DataContract]
  [FhirType("DataRequirement","http://hl7.org/fhir/StructureDefinition/DataRequirement")]
  public partial class DataRequirement : Hl7.Fhir.Model.DataType
  {
    /// <summary>
    /// FHIR Type Name
    /// </summary>
    public override string TypeName { get { return "DataRequirement"; } }

    /// <summary>
    /// What codes are expected
    /// </summary>
    /// <remarks>
    /// Code filters specify additional constraints on the data, specifying the value set of interest for a particular element of the data.
    /// </remarks>
    [Serializable]
    [DataContract]
    [FhirType("DataRequirement#CodeFilter", IsNestedType=true)]
    [BackboneType("DataRequirement.codeFilter")]
    public partial class CodeFilterComponent : Hl7.Fhir.Model.Element
    {
      /// <summary>
      /// FHIR Type Name
      /// </summary>
      public override string TypeName { get { return "DataRequirement#CodeFilter"; } }

      /// <summary>
      /// The code-valued attribute of the filter
      /// </summary>
      [FhirElement("path", InSummary=true, Order=30)]
      [Cardinality(Min=1,Max=1)]
      [DataMember]
      public Hl7.Fhir.Model.FhirString PathElement
      {
        get { return _PathElement; }
        set { _PathElement = value; OnPropertyChanged("PathElement"); }
      }

      private Hl7.Fhir.Model.FhirString _PathElement;

      /// <summary>
      /// The code-valued attribute of the filter
      /// </summary>
      /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
      [IgnoreDataMember]
      public string Path
      {
        get { return PathElement != null ? PathElement.Value : null; }
        set
        {
          if (value == null)
            PathElement = null;
          else
            PathElement = new Hl7.Fhir.Model.FhirString(value);
          OnPropertyChanged("Path");
        }
      }

      /// <summary>
      /// Valueset for the filter
      /// </summary>
      [FhirElement("valueSet", InSummary=true, Order=40, Choice=ChoiceType.DatatypeChoice)]
      [CLSCompliant(false)]
      [References("ValueSet")]
      [AllowedTypes(typeof(Hl7.Fhir.Model.FhirString),typeof(Hl7.Fhir.Model.ResourceReference))]
      [DataMember]
      public Hl7.Fhir.Model.DataType ValueSet
      {
        get { return _ValueSet; }
        set { _ValueSet = value; OnPropertyChanged("ValueSet"); }
      }

      private Hl7.Fhir.Model.DataType _ValueSet;

      /// <summary>
      /// What code is expected
      /// </summary>
      [FhirElement("valueCode", InSummary=true, Order=50)]
      [Cardinality(Min=0,Max=-1)]
      [DataMember]
      public List<Hl7.Fhir.Model.Code> ValueCodeElement
      {
        get { if(_ValueCodeElement==null) _ValueCodeElement = new List<Hl7.Fhir.Model.Code>(); return _ValueCodeElement; }
        set { _ValueCodeElement = value; OnPropertyChanged("ValueCodeElement"); }
      }

      private List<Hl7.Fhir.Model.Code> _ValueCodeElement;

      /// <summary>
      /// What code is expected
      /// </summary>
      /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
      [IgnoreDataMember]
      public IEnumerable<string> ValueCode
      {
        get { return ValueCodeElement != null ? ValueCodeElement.Select(elem => elem.Value) : null; }
        set
        {
          if (value == null)
            ValueCodeElement = null;
          else
            ValueCodeElement = new List<Hl7.Fhir.Model.Code>(value.Select(elem=>new Hl7.Fhir.Model.Code(elem)));
          OnPropertyChanged("ValueCode");
        }
      }

      /// <summary>
      /// What Coding is expected
      /// </summary>
      [FhirElement("valueCoding", InSummary=true, Order=60)]
      [Cardinality(Min=0,Max=-1)]
      [DataMember]
      public List<Hl7.Fhir.Model.Coding> ValueCoding
      {
        get { if(_ValueCoding==null) _ValueCoding = new List<Hl7.Fhir.Model.Coding>(); return _ValueCoding; }
        set { _ValueCoding = value; OnPropertyChanged("ValueCoding"); }
      }

      private List<Hl7.Fhir.Model.Coding> _ValueCoding;

      /// <summary>
      /// What CodeableConcept is expected
      /// </summary>
      [FhirElement("valueCodeableConcept", InSummary=true, Order=70)]
      [Cardinality(Min=0,Max=-1)]
      [DataMember]
      public List<Hl7.Fhir.Model.CodeableConcept> ValueCodeableConcept
      {
        get { if(_ValueCodeableConcept==null) _ValueCodeableConcept = new List<Hl7.Fhir.Model.CodeableConcept>(); return _ValueCodeableConcept; }
        set { _ValueCodeableConcept = value; OnPropertyChanged("ValueCodeableConcept"); }
      }

      private List<Hl7.Fhir.Model.CodeableConcept> _ValueCodeableConcept;

      public override IDeepCopyable CopyTo(IDeepCopyable other)
      {
        var dest = other as CodeFilterComponent;

        if (dest == null)
        {
          throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        base.CopyTo(dest);
        if(PathElement != null) dest.PathElement = (Hl7.Fhir.Model.FhirString)PathElement.DeepCopy();
        if(ValueSet != null) dest.ValueSet = (Hl7.Fhir.Model.DataType)ValueSet.DeepCopy();
        if(ValueCodeElement.Any()) dest.ValueCodeElement = new List<Hl7.Fhir.Model.Code>(ValueCodeElement.DeepCopy());
        if(ValueCoding.Any()) dest.ValueCoding = new List<Hl7.Fhir.Model.Coding>(ValueCoding.DeepCopy());
        if(ValueCodeableConcept.Any()) dest.ValueCodeableConcept = new List<Hl7.Fhir.Model.CodeableConcept>(ValueCodeableConcept.DeepCopy());
        return dest;
      }

      public override IDeepCopyable DeepCopy()
      {
        return CopyTo(new CodeFilterComponent());
      }

      ///<inheritdoc />
      public override bool Matches(IDeepComparable other)
      {
        var otherT = other as CodeFilterComponent;
        if(otherT == null) return false;

        if(!base.Matches(otherT)) return false;
        if( !DeepComparable.Matches(PathElement, otherT.PathElement)) return false;
        if( !DeepComparable.Matches(ValueSet, otherT.ValueSet)) return false;
        if( !DeepComparable.Matches(ValueCodeElement, otherT.ValueCodeElement)) return false;
        if( !DeepComparable.Matches(ValueCoding, otherT.ValueCoding)) return false;
        if( !DeepComparable.Matches(ValueCodeableConcept, otherT.ValueCodeableConcept)) return false;

        return true;
      }

      public override bool IsExactly(IDeepComparable other)
      {
        var otherT = other as CodeFilterComponent;
        if(otherT == null) return false;

        if(!base.IsExactly(otherT)) return false;
        if( !DeepComparable.IsExactly(PathElement, otherT.PathElement)) return false;
        if( !DeepComparable.IsExactly(ValueSet, otherT.ValueSet)) return false;
        if( !DeepComparable.IsExactly(ValueCodeElement, otherT.ValueCodeElement)) return false;
        if( !DeepComparable.IsExactly(ValueCoding, otherT.ValueCoding)) return false;
        if( !DeepComparable.IsExactly(ValueCodeableConcept, otherT.ValueCodeableConcept)) return false;

        return true;
      }

      [IgnoreDataMember]
      public override IEnumerable<Base> Children
      {
        get
        {
          foreach (var item in base.Children) yield return item;
          if (PathElement != null) yield return PathElement;
          if (ValueSet != null) yield return ValueSet;
          foreach (var elem in ValueCodeElement) { if (elem != null) yield return elem; }
          foreach (var elem in ValueCoding) { if (elem != null) yield return elem; }
          foreach (var elem in ValueCodeableConcept) { if (elem != null) yield return elem; }
        }
      }

      [IgnoreDataMember]
      public override IEnumerable<ElementValue> NamedChildren
      {
        get
        {
          foreach (var item in base.NamedChildren) yield return item;
          if (PathElement != null) yield return new ElementValue("path", PathElement);
          if (ValueSet != null) yield return new ElementValue("valueSet", ValueSet);
          foreach (var elem in ValueCodeElement) { if (elem != null) yield return new ElementValue("valueCode", elem); }
          foreach (var elem in ValueCoding) { if (elem != null) yield return new ElementValue("valueCoding", elem); }
          foreach (var elem in ValueCodeableConcept) { if (elem != null) yield return new ElementValue("valueCodeableConcept", elem); }
        }
      }

      protected override bool TryGetValue(string key, out object value)
      {
        switch (key)
        {
          case "path":
            value = PathElement;
            return PathElement is not null;
          case "valueSet":
            value = ValueSet;
            return ValueSet is not null;
          case "valueCode":
            value = ValueCodeElement;
            return ValueCodeElement?.Any() == true;
          case "valueCoding":
            value = ValueCoding;
            return ValueCoding?.Any() == true;
          case "valueCodeableConcept":
            value = ValueCodeableConcept;
            return ValueCodeableConcept?.Any() == true;
          default:
            return base.TryGetValue(key, out value);
        }

      }

      protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
      {
        foreach (var kvp in base.GetElementPairs()) yield return kvp;
        if (PathElement is not null) yield return new KeyValuePair<string,object>("path",PathElement);
        if (ValueSet is not null) yield return new KeyValuePair<string,object>("valueSet",ValueSet);
        if (ValueCodeElement?.Any() == true) yield return new KeyValuePair<string,object>("valueCode",ValueCodeElement);
        if (ValueCoding?.Any() == true) yield return new KeyValuePair<string,object>("valueCoding",ValueCoding);
        if (ValueCodeableConcept?.Any() == true) yield return new KeyValuePair<string,object>("valueCodeableConcept",ValueCodeableConcept);
      }

    }

    /// <summary>
    /// What dates/date ranges are expected
    /// </summary>
    /// <remarks>
    /// Date filters specify additional constraints on the data in terms of the applicable date range for specific elements.
    /// </remarks>
    [Serializable]
    [DataContract]
    [FhirType("DataRequirement#DateFilter", IsNestedType=true)]
    [BackboneType("DataRequirement.dateFilter")]
    public partial class DateFilterComponent : Hl7.Fhir.Model.Element
    {
      /// <summary>
      /// FHIR Type Name
      /// </summary>
      public override string TypeName { get { return "DataRequirement#DateFilter"; } }

      /// <summary>
      /// The date-valued attribute of the filter
      /// </summary>
      [FhirElement("path", InSummary=true, Order=30)]
      [Cardinality(Min=1,Max=1)]
      [DataMember]
      public Hl7.Fhir.Model.FhirString PathElement
      {
        get { return _PathElement; }
        set { _PathElement = value; OnPropertyChanged("PathElement"); }
      }

      private Hl7.Fhir.Model.FhirString _PathElement;

      /// <summary>
      /// The date-valued attribute of the filter
      /// </summary>
      /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
      [IgnoreDataMember]
      public string Path
      {
        get { return PathElement != null ? PathElement.Value : null; }
        set
        {
          if (value == null)
            PathElement = null;
          else
            PathElement = new Hl7.Fhir.Model.FhirString(value);
          OnPropertyChanged("Path");
        }
      }

      /// <summary>
      /// The value of the filter, as a Period, DateTime, or Duration value
      /// </summary>
      [FhirElement("value", InSummary=true, Order=40, Choice=ChoiceType.DatatypeChoice)]
      [CLSCompliant(false)]
      [AllowedTypes(typeof(Hl7.Fhir.Model.FhirDateTime),typeof(Hl7.Fhir.Model.Period),typeof(Hl7.Fhir.Model.Duration))]
      [DataMember]
      public Hl7.Fhir.Model.DataType Value
      {
        get { return _Value; }
        set { _Value = value; OnPropertyChanged("Value"); }
      }

      private Hl7.Fhir.Model.DataType _Value;

      public override IDeepCopyable CopyTo(IDeepCopyable other)
      {
        var dest = other as DateFilterComponent;

        if (dest == null)
        {
          throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        base.CopyTo(dest);
        if(PathElement != null) dest.PathElement = (Hl7.Fhir.Model.FhirString)PathElement.DeepCopy();
        if(Value != null) dest.Value = (Hl7.Fhir.Model.DataType)Value.DeepCopy();
        return dest;
      }

      public override IDeepCopyable DeepCopy()
      {
        return CopyTo(new DateFilterComponent());
      }

      ///<inheritdoc />
      public override bool Matches(IDeepComparable other)
      {
        var otherT = other as DateFilterComponent;
        if(otherT == null) return false;

        if(!base.Matches(otherT)) return false;
        if( !DeepComparable.Matches(PathElement, otherT.PathElement)) return false;
        if( !DeepComparable.Matches(Value, otherT.Value)) return false;

        return true;
      }

      public override bool IsExactly(IDeepComparable other)
      {
        var otherT = other as DateFilterComponent;
        if(otherT == null) return false;

        if(!base.IsExactly(otherT)) return false;
        if( !DeepComparable.IsExactly(PathElement, otherT.PathElement)) return false;
        if( !DeepComparable.IsExactly(Value, otherT.Value)) return false;

        return true;
      }

      [IgnoreDataMember]
      public override IEnumerable<Base> Children
      {
        get
        {
          foreach (var item in base.Children) yield return item;
          if (PathElement != null) yield return PathElement;
          if (Value != null) yield return Value;
        }
      }

      [IgnoreDataMember]
      public override IEnumerable<ElementValue> NamedChildren
      {
        get
        {
          foreach (var item in base.NamedChildren) yield return item;
          if (PathElement != null) yield return new ElementValue("path", PathElement);
          if (Value != null) yield return new ElementValue("value", Value);
        }
      }

      protected override bool TryGetValue(string key, out object value)
      {
        switch (key)
        {
          case "path":
            value = PathElement;
            return PathElement is not null;
          case "value":
            value = Value;
            return Value is not null;
          default:
            return base.TryGetValue(key, out value);
        }

      }

      protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
      {
        foreach (var kvp in base.GetElementPairs()) yield return kvp;
        if (PathElement is not null) yield return new KeyValuePair<string,object>("path",PathElement);
        if (Value is not null) yield return new KeyValuePair<string,object>("value",Value);
      }

    }

    /// <summary>
    /// The type of the required data
    /// </summary>
    [FhirElement("type", InSummary=true, Order=30)]
    [DeclaredType(Type = typeof(Code))]
    [Binding("FHIRAllTypes")]
    [Cardinality(Min=1,Max=1)]
    [DataMember]
    public Code<Hl7.Fhir.Model.FHIRAllTypes> TypeElement
    {
      get { return _TypeElement; }
      set { _TypeElement = value; OnPropertyChanged("TypeElement"); }
    }

    private Code<Hl7.Fhir.Model.FHIRAllTypes> _TypeElement;

    /// <summary>
    /// The type of the required data
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public Hl7.Fhir.Model.FHIRAllTypes? Type
    {
      get { return TypeElement != null ? TypeElement.Value : null; }
      set
      {
        if (value == null)
          TypeElement = null;
        else
          TypeElement = new Code<Hl7.Fhir.Model.FHIRAllTypes>(value);
        OnPropertyChanged("Type");
      }
    }

    /// <summary>
    /// The profile of the required data
    /// </summary>
    [FhirElement("profile", InSummary=true, Order=40)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.FhirUri> ProfileElement
    {
      get { if(_ProfileElement==null) _ProfileElement = new List<Hl7.Fhir.Model.FhirUri>(); return _ProfileElement; }
      set { _ProfileElement = value; OnPropertyChanged("ProfileElement"); }
    }

    private List<Hl7.Fhir.Model.FhirUri> _ProfileElement;

    /// <summary>
    /// The profile of the required data
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public IEnumerable<string> Profile
    {
      get { return ProfileElement != null ? ProfileElement.Select(elem => elem.Value) : null; }
      set
      {
        if (value == null)
          ProfileElement = null;
        else
          ProfileElement = new List<Hl7.Fhir.Model.FhirUri>(value.Select(elem=>new Hl7.Fhir.Model.FhirUri(elem)));
        OnPropertyChanged("Profile");
      }
    }

    /// <summary>
    /// Indicates that specific structure elements are referenced by the knowledge module
    /// </summary>
    [FhirElement("mustSupport", InSummary=true, Order=50)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.FhirString> MustSupportElement
    {
      get { if(_MustSupportElement==null) _MustSupportElement = new List<Hl7.Fhir.Model.FhirString>(); return _MustSupportElement; }
      set { _MustSupportElement = value; OnPropertyChanged("MustSupportElement"); }
    }

    private List<Hl7.Fhir.Model.FhirString> _MustSupportElement;

    /// <summary>
    /// Indicates that specific structure elements are referenced by the knowledge module
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public IEnumerable<string> MustSupport
    {
      get { return MustSupportElement != null ? MustSupportElement.Select(elem => elem.Value) : null; }
      set
      {
        if (value == null)
          MustSupportElement = null;
        else
          MustSupportElement = new List<Hl7.Fhir.Model.FhirString>(value.Select(elem=>new Hl7.Fhir.Model.FhirString(elem)));
        OnPropertyChanged("MustSupport");
      }
    }

    /// <summary>
    /// What codes are expected
    /// </summary>
    [FhirElement("codeFilter", InSummary=true, Order=60)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.DataRequirement.CodeFilterComponent> CodeFilter
    {
      get { if(_CodeFilter==null) _CodeFilter = new List<Hl7.Fhir.Model.DataRequirement.CodeFilterComponent>(); return _CodeFilter; }
      set { _CodeFilter = value; OnPropertyChanged("CodeFilter"); }
    }

    private List<Hl7.Fhir.Model.DataRequirement.CodeFilterComponent> _CodeFilter;

    /// <summary>
    /// What dates/date ranges are expected
    /// </summary>
    [FhirElement("dateFilter", InSummary=true, Order=70)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.DataRequirement.DateFilterComponent> DateFilter
    {
      get { if(_DateFilter==null) _DateFilter = new List<Hl7.Fhir.Model.DataRequirement.DateFilterComponent>(); return _DateFilter; }
      set { _DateFilter = value; OnPropertyChanged("DateFilter"); }
    }

    private List<Hl7.Fhir.Model.DataRequirement.DateFilterComponent> _DateFilter;

    public override IDeepCopyable CopyTo(IDeepCopyable other)
    {
      var dest = other as DataRequirement;

      if (dest == null)
      {
        throw new ArgumentException("Can only copy to an object of the same type", "other");
      }

      base.CopyTo(dest);
      if(TypeElement != null) dest.TypeElement = (Code<Hl7.Fhir.Model.FHIRAllTypes>)TypeElement.DeepCopy();
      if(ProfileElement.Any()) dest.ProfileElement = new List<Hl7.Fhir.Model.FhirUri>(ProfileElement.DeepCopy());
      if(MustSupportElement.Any()) dest.MustSupportElement = new List<Hl7.Fhir.Model.FhirString>(MustSupportElement.DeepCopy());
      if(CodeFilter.Any()) dest.CodeFilter = new List<Hl7.Fhir.Model.DataRequirement.CodeFilterComponent>(CodeFilter.DeepCopy());
      if(DateFilter.Any()) dest.DateFilter = new List<Hl7.Fhir.Model.DataRequirement.DateFilterComponent>(DateFilter.DeepCopy());
      return dest;
    }

    public override IDeepCopyable DeepCopy()
    {
      return CopyTo(new DataRequirement());
    }

    ///<inheritdoc />
    public override bool Matches(IDeepComparable other)
    {
      var otherT = other as DataRequirement;
      if(otherT == null) return false;

      if(!base.Matches(otherT)) return false;
      if( !DeepComparable.Matches(TypeElement, otherT.TypeElement)) return false;
      if( !DeepComparable.Matches(ProfileElement, otherT.ProfileElement)) return false;
      if( !DeepComparable.Matches(MustSupportElement, otherT.MustSupportElement)) return false;
      if( !DeepComparable.Matches(CodeFilter, otherT.CodeFilter)) return false;
      if( !DeepComparable.Matches(DateFilter, otherT.DateFilter)) return false;

      return true;
    }

    public override bool IsExactly(IDeepComparable other)
    {
      var otherT = other as DataRequirement;
      if(otherT == null) return false;

      if(!base.IsExactly(otherT)) return false;
      if( !DeepComparable.IsExactly(TypeElement, otherT.TypeElement)) return false;
      if( !DeepComparable.IsExactly(ProfileElement, otherT.ProfileElement)) return false;
      if( !DeepComparable.IsExactly(MustSupportElement, otherT.MustSupportElement)) return false;
      if( !DeepComparable.IsExactly(CodeFilter, otherT.CodeFilter)) return false;
      if( !DeepComparable.IsExactly(DateFilter, otherT.DateFilter)) return false;

      return true;
    }

    [IgnoreDataMember]
    public override IEnumerable<Base> Children
    {
      get
      {
        foreach (var item in base.Children) yield return item;
        if (TypeElement != null) yield return TypeElement;
        foreach (var elem in ProfileElement) { if (elem != null) yield return elem; }
        foreach (var elem in MustSupportElement) { if (elem != null) yield return elem; }
        foreach (var elem in CodeFilter) { if (elem != null) yield return elem; }
        foreach (var elem in DateFilter) { if (elem != null) yield return elem; }
      }
    }

    [IgnoreDataMember]
    public override IEnumerable<ElementValue> NamedChildren
    {
      get
      {
        foreach (var item in base.NamedChildren) yield return item;
        if (TypeElement != null) yield return new ElementValue("type", TypeElement);
        foreach (var elem in ProfileElement) { if (elem != null) yield return new ElementValue("profile", elem); }
        foreach (var elem in MustSupportElement) { if (elem != null) yield return new ElementValue("mustSupport", elem); }
        foreach (var elem in CodeFilter) { if (elem != null) yield return new ElementValue("codeFilter", elem); }
        foreach (var elem in DateFilter) { if (elem != null) yield return new ElementValue("dateFilter", elem); }
      }
    }

    protected override bool TryGetValue(string key, out object value)
    {
      switch (key)
      {
        case "type":
          value = TypeElement;
          return TypeElement is not null;
        case "profile":
          value = ProfileElement;
          return ProfileElement?.Any() == true;
        case "mustSupport":
          value = MustSupportElement;
          return MustSupportElement?.Any() == true;
        case "codeFilter":
          value = CodeFilter;
          return CodeFilter?.Any() == true;
        case "dateFilter":
          value = DateFilter;
          return DateFilter?.Any() == true;
        default:
          return base.TryGetValue(key, out value);
      }

    }

    protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
    {
      foreach (var kvp in base.GetElementPairs()) yield return kvp;
      if (TypeElement is not null) yield return new KeyValuePair<string,object>("type",TypeElement);
      if (ProfileElement?.Any() == true) yield return new KeyValuePair<string,object>("profile",ProfileElement);
      if (MustSupportElement?.Any() == true) yield return new KeyValuePair<string,object>("mustSupport",MustSupportElement);
      if (CodeFilter?.Any() == true) yield return new KeyValuePair<string,object>("codeFilter",CodeFilter);
      if (DateFilter?.Any() == true) yield return new KeyValuePair<string,object>("dateFilter",DateFilter);
    }

  }

}

// end of file
