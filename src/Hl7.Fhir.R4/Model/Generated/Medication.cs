// <auto-generated/>
// Contents of: hl7.fhir.r4.expansions#4.0.1, hl7.fhir.r4.core#4.0.1

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
  /// Definition of a Medication
  /// </summary>
  /// <remarks>
  /// This resource is primarily used for the identification and definition of a medication for the purposes of prescribing, dispensing, and administering a medication as well as for making statements about medication use.
  /// </remarks>
  [Serializable]
  [DataContract]
  [FhirType("Medication","http://hl7.org/fhir/StructureDefinition/Medication", IsResource=true)]
  public partial class Medication : Hl7.Fhir.Model.DomainResource, IIdentifiable<List<Identifier>>, ICoded<Hl7.Fhir.Model.CodeableConcept>
  {
    /// <summary>
    /// FHIR Type Name
    /// </summary>
    public override string TypeName { get { return "Medication"; } }

    /// <summary>
    /// Medication Status Codes
    /// (url: http://hl7.org/fhir/ValueSet/medication-status)
    /// (system: http://hl7.org/fhir/CodeSystem/medication-status)
    /// </summary>
    [FhirEnumeration("MedicationStatusCodes", "http://hl7.org/fhir/ValueSet/medication-status", "http://hl7.org/fhir/CodeSystem/medication-status")]
    public enum MedicationStatusCodes
    {
      /// <summary>
      /// The medication is available for use.
      /// (system: http://hl7.org/fhir/CodeSystem/medication-status)
      /// </summary>
      [EnumLiteral("active"), Description("Active")]
      Active,
      /// <summary>
      /// The medication is not available for use.
      /// (system: http://hl7.org/fhir/CodeSystem/medication-status)
      /// </summary>
      [EnumLiteral("inactive"), Description("Inactive")]
      Inactive,
      /// <summary>
      /// The medication was entered in error.
      /// (system: http://hl7.org/fhir/CodeSystem/medication-status)
      /// </summary>
      [EnumLiteral("entered-in-error"), Description("Entered in Error")]
      EnteredInError,
    }

    /// <summary>
    /// Active or inactive ingredient
    /// </summary>
    /// <remarks>
    /// Identifies a particular constituent of interest in the product.
    /// The ingredients need not be a complete list.  If an ingredient is not specified, this does not indicate whether an ingredient is present or absent.  If an ingredient is specified it does not mean that all ingredients are specified.  It is possible to specify both inactive and active ingredients.
    /// </remarks>
    [Serializable]
    [DataContract]
    [FhirType("Medication#Ingredient", IsNestedType=true)]
    [BackboneType("Medication.ingredient")]
    public partial class IngredientComponent : Hl7.Fhir.Model.BackboneElement
    {
      /// <summary>
      /// FHIR Type Name
      /// </summary>
      public override string TypeName { get { return "Medication#Ingredient"; } }

      /// <summary>
      /// The actual ingredient or content
      /// </summary>
      [FhirElement("item", Order=40, Choice=ChoiceType.DatatypeChoice)]
      [CLSCompliant(false)]
      [References("Substance","Medication")]
      [AllowedTypes(typeof(Hl7.Fhir.Model.CodeableConcept),typeof(Hl7.Fhir.Model.ResourceReference))]
      [Cardinality(Min=1,Max=1)]
      [DataMember]
      public Hl7.Fhir.Model.DataType Item
      {
        get { return _Item; }
        set { _Item = value; OnPropertyChanged("Item"); }
      }

      private Hl7.Fhir.Model.DataType _Item;

      /// <summary>
      /// Active ingredient indicator
      /// </summary>
      [FhirElement("isActive", Order=50)]
      [DataMember]
      public Hl7.Fhir.Model.FhirBoolean IsActiveElement
      {
        get { return _IsActiveElement; }
        set { _IsActiveElement = value; OnPropertyChanged("IsActiveElement"); }
      }

      private Hl7.Fhir.Model.FhirBoolean _IsActiveElement;

      /// <summary>
      /// Active ingredient indicator
      /// </summary>
      /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
      [IgnoreDataMember]
      public bool? IsActive
      {
        get { return IsActiveElement != null ? IsActiveElement.Value : null; }
        set
        {
          if (value == null)
            IsActiveElement = null;
          else
            IsActiveElement = new Hl7.Fhir.Model.FhirBoolean(value);
          OnPropertyChanged("IsActive");
        }
      }

      /// <summary>
      /// Quantity of ingredient present
      /// </summary>
      [FhirElement("strength", Order=60)]
      [DataMember]
      public Hl7.Fhir.Model.Ratio Strength
      {
        get { return _Strength; }
        set { _Strength = value; OnPropertyChanged("Strength"); }
      }

      private Hl7.Fhir.Model.Ratio _Strength;

      public override IDeepCopyable CopyTo(IDeepCopyable other)
      {
        var dest = other as IngredientComponent;

        if (dest == null)
        {
          throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        base.CopyTo(dest);
        if(Item != null) dest.Item = (Hl7.Fhir.Model.DataType)Item.DeepCopy();
        if(IsActiveElement != null) dest.IsActiveElement = (Hl7.Fhir.Model.FhirBoolean)IsActiveElement.DeepCopy();
        if(Strength != null) dest.Strength = (Hl7.Fhir.Model.Ratio)Strength.DeepCopy();
        return dest;
      }

      public override IDeepCopyable DeepCopy()
      {
        return CopyTo(new IngredientComponent());
      }

      ///<inheritdoc />
      public override bool Matches(IDeepComparable other)
      {
        var otherT = other as IngredientComponent;
        if(otherT == null) return false;

        if(!base.Matches(otherT)) return false;
        if( !DeepComparable.Matches(Item, otherT.Item)) return false;
        if( !DeepComparable.Matches(IsActiveElement, otherT.IsActiveElement)) return false;
        if( !DeepComparable.Matches(Strength, otherT.Strength)) return false;

        return true;
      }

      public override bool IsExactly(IDeepComparable other)
      {
        var otherT = other as IngredientComponent;
        if(otherT == null) return false;

        if(!base.IsExactly(otherT)) return false;
        if( !DeepComparable.IsExactly(Item, otherT.Item)) return false;
        if( !DeepComparable.IsExactly(IsActiveElement, otherT.IsActiveElement)) return false;
        if( !DeepComparable.IsExactly(Strength, otherT.Strength)) return false;

        return true;
      }

      [IgnoreDataMember]
      public override IEnumerable<Base> Children
      {
        get
        {
          foreach (var item in base.Children) yield return item;
          if (Item != null) yield return Item;
          if (IsActiveElement != null) yield return IsActiveElement;
          if (Strength != null) yield return Strength;
        }
      }

      [IgnoreDataMember]
      public override IEnumerable<ElementValue> NamedChildren
      {
        get
        {
          foreach (var item in base.NamedChildren) yield return item;
          if (Item != null) yield return new ElementValue("item", Item);
          if (IsActiveElement != null) yield return new ElementValue("isActive", IsActiveElement);
          if (Strength != null) yield return new ElementValue("strength", Strength);
        }
      }

      protected override bool TryGetValue(string key, out object value)
      {
        switch (key)
        {
          case "item":
            value = Item;
            return Item is not null;
          case "isActive":
            value = IsActiveElement;
            return IsActiveElement is not null;
          case "strength":
            value = Strength;
            return Strength is not null;
          default:
            return base.TryGetValue(key, out value);
        }

      }

      protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
      {
        foreach (var kvp in base.GetElementPairs()) yield return kvp;
        if (Item is not null) yield return new KeyValuePair<string,object>("item",Item);
        if (IsActiveElement is not null) yield return new KeyValuePair<string,object>("isActive",IsActiveElement);
        if (Strength is not null) yield return new KeyValuePair<string,object>("strength",Strength);
      }

    }

    /// <summary>
    /// Details about packaged medications
    /// </summary>
    /// <remarks>
    /// Information that only applies to packages (not products).
    /// </remarks>
    [Serializable]
    [DataContract]
    [FhirType("Medication#Batch", IsNestedType=true)]
    [BackboneType("Medication.batch")]
    public partial class BatchComponent : Hl7.Fhir.Model.BackboneElement
    {
      /// <summary>
      /// FHIR Type Name
      /// </summary>
      public override string TypeName { get { return "Medication#Batch"; } }

      /// <summary>
      /// Identifier assigned to batch
      /// </summary>
      [FhirElement("lotNumber", Order=40)]
      [DataMember]
      public Hl7.Fhir.Model.FhirString LotNumberElement
      {
        get { return _LotNumberElement; }
        set { _LotNumberElement = value; OnPropertyChanged("LotNumberElement"); }
      }

      private Hl7.Fhir.Model.FhirString _LotNumberElement;

      /// <summary>
      /// Identifier assigned to batch
      /// </summary>
      /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
      [IgnoreDataMember]
      public string LotNumber
      {
        get { return LotNumberElement != null ? LotNumberElement.Value : null; }
        set
        {
          if (value == null)
            LotNumberElement = null;
          else
            LotNumberElement = new Hl7.Fhir.Model.FhirString(value);
          OnPropertyChanged("LotNumber");
        }
      }

      /// <summary>
      /// When batch will expire
      /// </summary>
      [FhirElement("expirationDate", Order=50)]
      [DataMember]
      public Hl7.Fhir.Model.FhirDateTime ExpirationDateElement
      {
        get { return _ExpirationDateElement; }
        set { _ExpirationDateElement = value; OnPropertyChanged("ExpirationDateElement"); }
      }

      private Hl7.Fhir.Model.FhirDateTime _ExpirationDateElement;

      /// <summary>
      /// When batch will expire
      /// </summary>
      /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
      [IgnoreDataMember]
      public string ExpirationDate
      {
        get { return ExpirationDateElement != null ? ExpirationDateElement.Value : null; }
        set
        {
          if (value == null)
            ExpirationDateElement = null;
          else
            ExpirationDateElement = new Hl7.Fhir.Model.FhirDateTime(value);
          OnPropertyChanged("ExpirationDate");
        }
      }

      public override IDeepCopyable CopyTo(IDeepCopyable other)
      {
        var dest = other as BatchComponent;

        if (dest == null)
        {
          throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        base.CopyTo(dest);
        if(LotNumberElement != null) dest.LotNumberElement = (Hl7.Fhir.Model.FhirString)LotNumberElement.DeepCopy();
        if(ExpirationDateElement != null) dest.ExpirationDateElement = (Hl7.Fhir.Model.FhirDateTime)ExpirationDateElement.DeepCopy();
        return dest;
      }

      public override IDeepCopyable DeepCopy()
      {
        return CopyTo(new BatchComponent());
      }

      ///<inheritdoc />
      public override bool Matches(IDeepComparable other)
      {
        var otherT = other as BatchComponent;
        if(otherT == null) return false;

        if(!base.Matches(otherT)) return false;
        if( !DeepComparable.Matches(LotNumberElement, otherT.LotNumberElement)) return false;
        if( !DeepComparable.Matches(ExpirationDateElement, otherT.ExpirationDateElement)) return false;

        return true;
      }

      public override bool IsExactly(IDeepComparable other)
      {
        var otherT = other as BatchComponent;
        if(otherT == null) return false;

        if(!base.IsExactly(otherT)) return false;
        if( !DeepComparable.IsExactly(LotNumberElement, otherT.LotNumberElement)) return false;
        if( !DeepComparable.IsExactly(ExpirationDateElement, otherT.ExpirationDateElement)) return false;

        return true;
      }

      [IgnoreDataMember]
      public override IEnumerable<Base> Children
      {
        get
        {
          foreach (var item in base.Children) yield return item;
          if (LotNumberElement != null) yield return LotNumberElement;
          if (ExpirationDateElement != null) yield return ExpirationDateElement;
        }
      }

      [IgnoreDataMember]
      public override IEnumerable<ElementValue> NamedChildren
      {
        get
        {
          foreach (var item in base.NamedChildren) yield return item;
          if (LotNumberElement != null) yield return new ElementValue("lotNumber", LotNumberElement);
          if (ExpirationDateElement != null) yield return new ElementValue("expirationDate", ExpirationDateElement);
        }
      }

      protected override bool TryGetValue(string key, out object value)
      {
        switch (key)
        {
          case "lotNumber":
            value = LotNumberElement;
            return LotNumberElement is not null;
          case "expirationDate":
            value = ExpirationDateElement;
            return ExpirationDateElement is not null;
          default:
            return base.TryGetValue(key, out value);
        }

      }

      protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
      {
        foreach (var kvp in base.GetElementPairs()) yield return kvp;
        if (LotNumberElement is not null) yield return new KeyValuePair<string,object>("lotNumber",LotNumberElement);
        if (ExpirationDateElement is not null) yield return new KeyValuePair<string,object>("expirationDate",ExpirationDateElement);
      }

    }

    /// <summary>
    /// Business identifier for this medication
    /// </summary>
    [FhirElement("identifier", InSummary=true, Order=90, FiveWs="FiveWs.identifier")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.Identifier> Identifier
    {
      get { if(_Identifier==null) _Identifier = new List<Hl7.Fhir.Model.Identifier>(); return _Identifier; }
      set { _Identifier = value; OnPropertyChanged("Identifier"); }
    }

    private List<Hl7.Fhir.Model.Identifier> _Identifier;

    /// <summary>
    /// Codes that identify this medication
    /// </summary>
    [FhirElement("code", InSummary=true, Order=100, FiveWs="FiveWs.class")]
    [Binding("MedicationFormalRepresentation")]
    [DataMember]
    public Hl7.Fhir.Model.CodeableConcept Code
    {
      get { return _Code; }
      set { _Code = value; OnPropertyChanged("Code"); }
    }

    private Hl7.Fhir.Model.CodeableConcept _Code;

    /// <summary>
    /// active | inactive | entered-in-error
    /// </summary>
    [FhirElement("status", InSummary=true, IsModifier=true, Order=110)]
    [DeclaredType(Type = typeof(Code))]
    [Binding("MedicationStatus")]
    [DataMember]
    public Code<Hl7.Fhir.Model.Medication.MedicationStatusCodes> StatusElement
    {
      get { return _StatusElement; }
      set { _StatusElement = value; OnPropertyChanged("StatusElement"); }
    }

    private Code<Hl7.Fhir.Model.Medication.MedicationStatusCodes> _StatusElement;

    /// <summary>
    /// active | inactive | entered-in-error
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public Hl7.Fhir.Model.Medication.MedicationStatusCodes? Status
    {
      get { return StatusElement != null ? StatusElement.Value : null; }
      set
      {
        if (value == null)
          StatusElement = null;
        else
          StatusElement = new Code<Hl7.Fhir.Model.Medication.MedicationStatusCodes>(value);
        OnPropertyChanged("Status");
      }
    }

    /// <summary>
    /// Manufacturer of the item
    /// </summary>
    [FhirElement("manufacturer", InSummary=true, Order=120, FiveWs="FiveWs.actor")]
    [CLSCompliant(false)]
    [References("Organization")]
    [DataMember]
    public Hl7.Fhir.Model.ResourceReference Manufacturer
    {
      get { return _Manufacturer; }
      set { _Manufacturer = value; OnPropertyChanged("Manufacturer"); }
    }

    private Hl7.Fhir.Model.ResourceReference _Manufacturer;

    /// <summary>
    /// powder | tablets | capsule +
    /// </summary>
    [FhirElement("form", Order=130)]
    [Binding("MedicationForm")]
    [DataMember]
    public Hl7.Fhir.Model.CodeableConcept Form
    {
      get { return _Form; }
      set { _Form = value; OnPropertyChanged("Form"); }
    }

    private Hl7.Fhir.Model.CodeableConcept _Form;

    /// <summary>
    /// Amount of drug in package
    /// </summary>
    [FhirElement("amount", InSummary=true, Order=140)]
    [DataMember]
    public Hl7.Fhir.Model.Ratio Amount
    {
      get { return _Amount; }
      set { _Amount = value; OnPropertyChanged("Amount"); }
    }

    private Hl7.Fhir.Model.Ratio _Amount;

    /// <summary>
    /// Active or inactive ingredient
    /// </summary>
    [FhirElement("ingredient", Order=150)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.Medication.IngredientComponent> Ingredient
    {
      get { if(_Ingredient==null) _Ingredient = new List<Hl7.Fhir.Model.Medication.IngredientComponent>(); return _Ingredient; }
      set { _Ingredient = value; OnPropertyChanged("Ingredient"); }
    }

    private List<Hl7.Fhir.Model.Medication.IngredientComponent> _Ingredient;

    /// <summary>
    /// Details about packaged medications
    /// </summary>
    [FhirElement("batch", Order=160)]
    [DataMember]
    public Hl7.Fhir.Model.Medication.BatchComponent Batch
    {
      get { return _Batch; }
      set { _Batch = value; OnPropertyChanged("Batch"); }
    }

    private Hl7.Fhir.Model.Medication.BatchComponent _Batch;

    List<Identifier> IIdentifiable<List<Identifier>>.Identifier { get => Identifier; set => Identifier = value; }

    Hl7.Fhir.Model.CodeableConcept ICoded<Hl7.Fhir.Model.CodeableConcept>.Code { get => Code; set => Code = value; }
    IEnumerable<Coding> ICoded.ToCodings() => Code.ToCodings();

    public override IDeepCopyable CopyTo(IDeepCopyable other)
    {
      var dest = other as Medication;

      if (dest == null)
      {
        throw new ArgumentException("Can only copy to an object of the same type", "other");
      }

      base.CopyTo(dest);
      if(Identifier.Any()) dest.Identifier = new List<Hl7.Fhir.Model.Identifier>(Identifier.DeepCopy());
      if(Code != null) dest.Code = (Hl7.Fhir.Model.CodeableConcept)Code.DeepCopy();
      if(StatusElement != null) dest.StatusElement = (Code<Hl7.Fhir.Model.Medication.MedicationStatusCodes>)StatusElement.DeepCopy();
      if(Manufacturer != null) dest.Manufacturer = (Hl7.Fhir.Model.ResourceReference)Manufacturer.DeepCopy();
      if(Form != null) dest.Form = (Hl7.Fhir.Model.CodeableConcept)Form.DeepCopy();
      if(Amount != null) dest.Amount = (Hl7.Fhir.Model.Ratio)Amount.DeepCopy();
      if(Ingredient.Any()) dest.Ingredient = new List<Hl7.Fhir.Model.Medication.IngredientComponent>(Ingredient.DeepCopy());
      if(Batch != null) dest.Batch = (Hl7.Fhir.Model.Medication.BatchComponent)Batch.DeepCopy();
      return dest;
    }

    public override IDeepCopyable DeepCopy()
    {
      return CopyTo(new Medication());
    }

    ///<inheritdoc />
    public override bool Matches(IDeepComparable other)
    {
      var otherT = other as Medication;
      if(otherT == null) return false;

      if(!base.Matches(otherT)) return false;
      if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
      if( !DeepComparable.Matches(Code, otherT.Code)) return false;
      if( !DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
      if( !DeepComparable.Matches(Manufacturer, otherT.Manufacturer)) return false;
      if( !DeepComparable.Matches(Form, otherT.Form)) return false;
      if( !DeepComparable.Matches(Amount, otherT.Amount)) return false;
      if( !DeepComparable.Matches(Ingredient, otherT.Ingredient)) return false;
      if( !DeepComparable.Matches(Batch, otherT.Batch)) return false;

      return true;
    }

    public override bool IsExactly(IDeepComparable other)
    {
      var otherT = other as Medication;
      if(otherT == null) return false;

      if(!base.IsExactly(otherT)) return false;
      if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
      if( !DeepComparable.IsExactly(Code, otherT.Code)) return false;
      if( !DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
      if( !DeepComparable.IsExactly(Manufacturer, otherT.Manufacturer)) return false;
      if( !DeepComparable.IsExactly(Form, otherT.Form)) return false;
      if( !DeepComparable.IsExactly(Amount, otherT.Amount)) return false;
      if( !DeepComparable.IsExactly(Ingredient, otherT.Ingredient)) return false;
      if( !DeepComparable.IsExactly(Batch, otherT.Batch)) return false;

      return true;
    }

    [IgnoreDataMember]
    public override IEnumerable<Base> Children
    {
      get
      {
        foreach (var item in base.Children) yield return item;
        foreach (var elem in Identifier) { if (elem != null) yield return elem; }
        if (Code != null) yield return Code;
        if (StatusElement != null) yield return StatusElement;
        if (Manufacturer != null) yield return Manufacturer;
        if (Form != null) yield return Form;
        if (Amount != null) yield return Amount;
        foreach (var elem in Ingredient) { if (elem != null) yield return elem; }
        if (Batch != null) yield return Batch;
      }
    }

    [IgnoreDataMember]
    public override IEnumerable<ElementValue> NamedChildren
    {
      get
      {
        foreach (var item in base.NamedChildren) yield return item;
        foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
        if (Code != null) yield return new ElementValue("code", Code);
        if (StatusElement != null) yield return new ElementValue("status", StatusElement);
        if (Manufacturer != null) yield return new ElementValue("manufacturer", Manufacturer);
        if (Form != null) yield return new ElementValue("form", Form);
        if (Amount != null) yield return new ElementValue("amount", Amount);
        foreach (var elem in Ingredient) { if (elem != null) yield return new ElementValue("ingredient", elem); }
        if (Batch != null) yield return new ElementValue("batch", Batch);
      }
    }

    protected override bool TryGetValue(string key, out object value)
    {
      switch (key)
      {
        case "identifier":
          value = Identifier;
          return Identifier?.Any() == true;
        case "code":
          value = Code;
          return Code is not null;
        case "status":
          value = StatusElement;
          return StatusElement is not null;
        case "manufacturer":
          value = Manufacturer;
          return Manufacturer is not null;
        case "form":
          value = Form;
          return Form is not null;
        case "amount":
          value = Amount;
          return Amount is not null;
        case "ingredient":
          value = Ingredient;
          return Ingredient?.Any() == true;
        case "batch":
          value = Batch;
          return Batch is not null;
        default:
          return base.TryGetValue(key, out value);
      }

    }

    protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
    {
      foreach (var kvp in base.GetElementPairs()) yield return kvp;
      if (Identifier?.Any() == true) yield return new KeyValuePair<string,object>("identifier",Identifier);
      if (Code is not null) yield return new KeyValuePair<string,object>("code",Code);
      if (StatusElement is not null) yield return new KeyValuePair<string,object>("status",StatusElement);
      if (Manufacturer is not null) yield return new KeyValuePair<string,object>("manufacturer",Manufacturer);
      if (Form is not null) yield return new KeyValuePair<string,object>("form",Form);
      if (Amount is not null) yield return new KeyValuePair<string,object>("amount",Amount);
      if (Ingredient?.Any() == true) yield return new KeyValuePair<string,object>("ingredient",Ingredient);
      if (Batch is not null) yield return new KeyValuePair<string,object>("batch",Batch);
    }

  }

}

// end of file
