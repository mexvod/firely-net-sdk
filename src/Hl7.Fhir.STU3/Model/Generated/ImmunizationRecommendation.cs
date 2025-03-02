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
  /// Guidance or advice relating to an immunization
  /// </summary>
  /// <remarks>
  /// A patient's point-in-time immunization and recommendation (i.e. forecasting a patient's immunization eligibility according to a published schedule) with optional supporting justification.
  /// </remarks>
  [Serializable]
  [DataContract]
  [FhirType("ImmunizationRecommendation","http://hl7.org/fhir/StructureDefinition/ImmunizationRecommendation", IsResource=true)]
  public partial class ImmunizationRecommendation : Hl7.Fhir.Model.DomainResource, IIdentifiable<List<Identifier>>
  {
    /// <summary>
    /// FHIR Type Name
    /// </summary>
    public override string TypeName { get { return "ImmunizationRecommendation"; } }

    /// <summary>
    /// Vaccine administration recommendations
    /// </summary>
    [Serializable]
    [DataContract]
    [FhirType("ImmunizationRecommendation#Recommendation", IsNestedType=true)]
    [BackboneType("ImmunizationRecommendation.recommendation")]
    public partial class RecommendationComponent : Hl7.Fhir.Model.BackboneElement
    {
      /// <summary>
      /// FHIR Type Name
      /// </summary>
      public override string TypeName { get { return "ImmunizationRecommendation#Recommendation"; } }

      /// <summary>
      /// Date recommendation created
      /// </summary>
      [FhirElement("date", InSummary=true, Order=40)]
      [Cardinality(Min=1,Max=1)]
      [DataMember]
      public Hl7.Fhir.Model.FhirDateTime DateElement
      {
        get { return _DateElement; }
        set { _DateElement = value; OnPropertyChanged("DateElement"); }
      }

      private Hl7.Fhir.Model.FhirDateTime _DateElement;

      /// <summary>
      /// Date recommendation created
      /// </summary>
      /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
      [IgnoreDataMember]
      public string Date
      {
        get { return DateElement != null ? DateElement.Value : null; }
        set
        {
          if (value == null)
            DateElement = null;
          else
            DateElement = new Hl7.Fhir.Model.FhirDateTime(value);
          OnPropertyChanged("Date");
        }
      }

      /// <summary>
      /// Vaccine recommendation applies to
      /// </summary>
      [FhirElement("vaccineCode", InSummary=true, Order=50)]
      [Binding("VaccineCode")]
      [DataMember]
      public Hl7.Fhir.Model.CodeableConcept VaccineCode
      {
        get { return _VaccineCode; }
        set { _VaccineCode = value; OnPropertyChanged("VaccineCode"); }
      }

      private Hl7.Fhir.Model.CodeableConcept _VaccineCode;

      /// <summary>
      /// Disease to be immunized against
      /// </summary>
      [FhirElement("targetDisease", InSummary=true, Order=60)]
      [Binding("TargetDisease")]
      [DataMember]
      public Hl7.Fhir.Model.CodeableConcept TargetDisease
      {
        get { return _TargetDisease; }
        set { _TargetDisease = value; OnPropertyChanged("TargetDisease"); }
      }

      private Hl7.Fhir.Model.CodeableConcept _TargetDisease;

      /// <summary>
      /// Recommended dose number
      /// </summary>
      [FhirElement("doseNumber", InSummary=true, Order=70)]
      [DataMember]
      public Hl7.Fhir.Model.PositiveInt DoseNumberElement
      {
        get { return _DoseNumberElement; }
        set { _DoseNumberElement = value; OnPropertyChanged("DoseNumberElement"); }
      }

      private Hl7.Fhir.Model.PositiveInt _DoseNumberElement;

      /// <summary>
      /// Recommended dose number
      /// </summary>
      /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
      [IgnoreDataMember]
      public int? DoseNumber
      {
        get { return DoseNumberElement != null ? DoseNumberElement.Value : null; }
        set
        {
          if (value == null)
            DoseNumberElement = null;
          else
            DoseNumberElement = new Hl7.Fhir.Model.PositiveInt(value);
          OnPropertyChanged("DoseNumber");
        }
      }

      /// <summary>
      /// Vaccine administration status
      /// </summary>
      [FhirElement("forecastStatus", InSummary=true, Order=80)]
      [Binding("ImmunizationRecommendationStatus")]
      [Cardinality(Min=1,Max=1)]
      [DataMember]
      public Hl7.Fhir.Model.CodeableConcept ForecastStatus
      {
        get { return _ForecastStatus; }
        set { _ForecastStatus = value; OnPropertyChanged("ForecastStatus"); }
      }

      private Hl7.Fhir.Model.CodeableConcept _ForecastStatus;

      /// <summary>
      /// Dates governing proposed immunization
      /// </summary>
      [FhirElement("dateCriterion", Order=90)]
      [Cardinality(Min=0,Max=-1)]
      [DataMember]
      public List<Hl7.Fhir.Model.ImmunizationRecommendation.DateCriterionComponent> DateCriterion
      {
        get { if(_DateCriterion==null) _DateCriterion = new List<Hl7.Fhir.Model.ImmunizationRecommendation.DateCriterionComponent>(); return _DateCriterion; }
        set { _DateCriterion = value; OnPropertyChanged("DateCriterion"); }
      }

      private List<Hl7.Fhir.Model.ImmunizationRecommendation.DateCriterionComponent> _DateCriterion;

      /// <summary>
      /// Protocol used by recommendation
      /// </summary>
      [FhirElement("protocol", Order=100)]
      [DataMember]
      public Hl7.Fhir.Model.ImmunizationRecommendation.ProtocolComponent Protocol
      {
        get { return _Protocol; }
        set { _Protocol = value; OnPropertyChanged("Protocol"); }
      }

      private Hl7.Fhir.Model.ImmunizationRecommendation.ProtocolComponent _Protocol;

      /// <summary>
      /// Past immunizations supporting recommendation
      /// </summary>
      [FhirElement("supportingImmunization", Order=110)]
      [CLSCompliant(false)]
      [References("Immunization")]
      [Cardinality(Min=0,Max=-1)]
      [DataMember]
      public List<Hl7.Fhir.Model.ResourceReference> SupportingImmunization
      {
        get { if(_SupportingImmunization==null) _SupportingImmunization = new List<Hl7.Fhir.Model.ResourceReference>(); return _SupportingImmunization; }
        set { _SupportingImmunization = value; OnPropertyChanged("SupportingImmunization"); }
      }

      private List<Hl7.Fhir.Model.ResourceReference> _SupportingImmunization;

      /// <summary>
      /// Patient observations supporting recommendation
      /// </summary>
      [FhirElement("supportingPatientInformation", Order=120)]
      [CLSCompliant(false)]
      [References("Observation","AllergyIntolerance")]
      [Cardinality(Min=0,Max=-1)]
      [DataMember]
      public List<Hl7.Fhir.Model.ResourceReference> SupportingPatientInformation
      {
        get { if(_SupportingPatientInformation==null) _SupportingPatientInformation = new List<Hl7.Fhir.Model.ResourceReference>(); return _SupportingPatientInformation; }
        set { _SupportingPatientInformation = value; OnPropertyChanged("SupportingPatientInformation"); }
      }

      private List<Hl7.Fhir.Model.ResourceReference> _SupportingPatientInformation;

      public override IDeepCopyable CopyTo(IDeepCopyable other)
      {
        var dest = other as RecommendationComponent;

        if (dest == null)
        {
          throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        base.CopyTo(dest);
        if(DateElement != null) dest.DateElement = (Hl7.Fhir.Model.FhirDateTime)DateElement.DeepCopy();
        if(VaccineCode != null) dest.VaccineCode = (Hl7.Fhir.Model.CodeableConcept)VaccineCode.DeepCopy();
        if(TargetDisease != null) dest.TargetDisease = (Hl7.Fhir.Model.CodeableConcept)TargetDisease.DeepCopy();
        if(DoseNumberElement != null) dest.DoseNumberElement = (Hl7.Fhir.Model.PositiveInt)DoseNumberElement.DeepCopy();
        if(ForecastStatus != null) dest.ForecastStatus = (Hl7.Fhir.Model.CodeableConcept)ForecastStatus.DeepCopy();
        if(DateCriterion.Any()) dest.DateCriterion = new List<Hl7.Fhir.Model.ImmunizationRecommendation.DateCriterionComponent>(DateCriterion.DeepCopy());
        if(Protocol != null) dest.Protocol = (Hl7.Fhir.Model.ImmunizationRecommendation.ProtocolComponent)Protocol.DeepCopy();
        if(SupportingImmunization.Any()) dest.SupportingImmunization = new List<Hl7.Fhir.Model.ResourceReference>(SupportingImmunization.DeepCopy());
        if(SupportingPatientInformation.Any()) dest.SupportingPatientInformation = new List<Hl7.Fhir.Model.ResourceReference>(SupportingPatientInformation.DeepCopy());
        return dest;
      }

      public override IDeepCopyable DeepCopy()
      {
        return CopyTo(new RecommendationComponent());
      }

      ///<inheritdoc />
      public override bool Matches(IDeepComparable other)
      {
        var otherT = other as RecommendationComponent;
        if(otherT == null) return false;

        if(!base.Matches(otherT)) return false;
        if( !DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
        if( !DeepComparable.Matches(VaccineCode, otherT.VaccineCode)) return false;
        if( !DeepComparable.Matches(TargetDisease, otherT.TargetDisease)) return false;
        if( !DeepComparable.Matches(DoseNumberElement, otherT.DoseNumberElement)) return false;
        if( !DeepComparable.Matches(ForecastStatus, otherT.ForecastStatus)) return false;
        if( !DeepComparable.Matches(DateCriterion, otherT.DateCriterion)) return false;
        if( !DeepComparable.Matches(Protocol, otherT.Protocol)) return false;
        if( !DeepComparable.Matches(SupportingImmunization, otherT.SupportingImmunization)) return false;
        if( !DeepComparable.Matches(SupportingPatientInformation, otherT.SupportingPatientInformation)) return false;

        return true;
      }

      public override bool IsExactly(IDeepComparable other)
      {
        var otherT = other as RecommendationComponent;
        if(otherT == null) return false;

        if(!base.IsExactly(otherT)) return false;
        if( !DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
        if( !DeepComparable.IsExactly(VaccineCode, otherT.VaccineCode)) return false;
        if( !DeepComparable.IsExactly(TargetDisease, otherT.TargetDisease)) return false;
        if( !DeepComparable.IsExactly(DoseNumberElement, otherT.DoseNumberElement)) return false;
        if( !DeepComparable.IsExactly(ForecastStatus, otherT.ForecastStatus)) return false;
        if( !DeepComparable.IsExactly(DateCriterion, otherT.DateCriterion)) return false;
        if( !DeepComparable.IsExactly(Protocol, otherT.Protocol)) return false;
        if( !DeepComparable.IsExactly(SupportingImmunization, otherT.SupportingImmunization)) return false;
        if( !DeepComparable.IsExactly(SupportingPatientInformation, otherT.SupportingPatientInformation)) return false;

        return true;
      }

      [IgnoreDataMember]
      public override IEnumerable<Base> Children
      {
        get
        {
          foreach (var item in base.Children) yield return item;
          if (DateElement != null) yield return DateElement;
          if (VaccineCode != null) yield return VaccineCode;
          if (TargetDisease != null) yield return TargetDisease;
          if (DoseNumberElement != null) yield return DoseNumberElement;
          if (ForecastStatus != null) yield return ForecastStatus;
          foreach (var elem in DateCriterion) { if (elem != null) yield return elem; }
          if (Protocol != null) yield return Protocol;
          foreach (var elem in SupportingImmunization) { if (elem != null) yield return elem; }
          foreach (var elem in SupportingPatientInformation) { if (elem != null) yield return elem; }
        }
      }

      [IgnoreDataMember]
      public override IEnumerable<ElementValue> NamedChildren
      {
        get
        {
          foreach (var item in base.NamedChildren) yield return item;
          if (DateElement != null) yield return new ElementValue("date", DateElement);
          if (VaccineCode != null) yield return new ElementValue("vaccineCode", VaccineCode);
          if (TargetDisease != null) yield return new ElementValue("targetDisease", TargetDisease);
          if (DoseNumberElement != null) yield return new ElementValue("doseNumber", DoseNumberElement);
          if (ForecastStatus != null) yield return new ElementValue("forecastStatus", ForecastStatus);
          foreach (var elem in DateCriterion) { if (elem != null) yield return new ElementValue("dateCriterion", elem); }
          if (Protocol != null) yield return new ElementValue("protocol", Protocol);
          foreach (var elem in SupportingImmunization) { if (elem != null) yield return new ElementValue("supportingImmunization", elem); }
          foreach (var elem in SupportingPatientInformation) { if (elem != null) yield return new ElementValue("supportingPatientInformation", elem); }
        }
      }

      protected override bool TryGetValue(string key, out object value)
      {
        switch (key)
        {
          case "date":
            value = DateElement;
            return DateElement is not null;
          case "vaccineCode":
            value = VaccineCode;
            return VaccineCode is not null;
          case "targetDisease":
            value = TargetDisease;
            return TargetDisease is not null;
          case "doseNumber":
            value = DoseNumberElement;
            return DoseNumberElement is not null;
          case "forecastStatus":
            value = ForecastStatus;
            return ForecastStatus is not null;
          case "dateCriterion":
            value = DateCriterion;
            return DateCriterion?.Any() == true;
          case "protocol":
            value = Protocol;
            return Protocol is not null;
          case "supportingImmunization":
            value = SupportingImmunization;
            return SupportingImmunization?.Any() == true;
          case "supportingPatientInformation":
            value = SupportingPatientInformation;
            return SupportingPatientInformation?.Any() == true;
          default:
            return base.TryGetValue(key, out value);
        }

      }

      protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
      {
        foreach (var kvp in base.GetElementPairs()) yield return kvp;
        if (DateElement is not null) yield return new KeyValuePair<string,object>("date",DateElement);
        if (VaccineCode is not null) yield return new KeyValuePair<string,object>("vaccineCode",VaccineCode);
        if (TargetDisease is not null) yield return new KeyValuePair<string,object>("targetDisease",TargetDisease);
        if (DoseNumberElement is not null) yield return new KeyValuePair<string,object>("doseNumber",DoseNumberElement);
        if (ForecastStatus is not null) yield return new KeyValuePair<string,object>("forecastStatus",ForecastStatus);
        if (DateCriterion?.Any() == true) yield return new KeyValuePair<string,object>("dateCriterion",DateCriterion);
        if (Protocol is not null) yield return new KeyValuePair<string,object>("protocol",Protocol);
        if (SupportingImmunization?.Any() == true) yield return new KeyValuePair<string,object>("supportingImmunization",SupportingImmunization);
        if (SupportingPatientInformation?.Any() == true) yield return new KeyValuePair<string,object>("supportingPatientInformation",SupportingPatientInformation);
      }

    }

    /// <summary>
    /// Dates governing proposed immunization
    /// </summary>
    /// <remarks>
    /// Vaccine date recommendations.  For example, earliest date to administer, latest date to administer, etc.
    /// </remarks>
    [Serializable]
    [DataContract]
    [FhirType("ImmunizationRecommendation#DateCriterion", IsNestedType=true)]
    [BackboneType("ImmunizationRecommendation.recommendation.dateCriterion")]
    public partial class DateCriterionComponent : Hl7.Fhir.Model.BackboneElement
    {
      /// <summary>
      /// FHIR Type Name
      /// </summary>
      public override string TypeName { get { return "ImmunizationRecommendation#DateCriterion"; } }

      /// <summary>
      /// Type of date
      /// </summary>
      [FhirElement("code", Order=40)]
      [Binding("ImmunizationRecommendationDateCriterion")]
      [Cardinality(Min=1,Max=1)]
      [DataMember]
      public Hl7.Fhir.Model.CodeableConcept Code
      {
        get { return _Code; }
        set { _Code = value; OnPropertyChanged("Code"); }
      }

      private Hl7.Fhir.Model.CodeableConcept _Code;

      /// <summary>
      /// Recommended date
      /// </summary>
      [FhirElement("value", Order=50)]
      [Cardinality(Min=1,Max=1)]
      [DataMember]
      public Hl7.Fhir.Model.FhirDateTime ValueElement
      {
        get { return _ValueElement; }
        set { _ValueElement = value; OnPropertyChanged("ValueElement"); }
      }

      private Hl7.Fhir.Model.FhirDateTime _ValueElement;

      /// <summary>
      /// Recommended date
      /// </summary>
      /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
      [IgnoreDataMember]
      public string Value
      {
        get { return ValueElement != null ? ValueElement.Value : null; }
        set
        {
          if (value == null)
            ValueElement = null;
          else
            ValueElement = new Hl7.Fhir.Model.FhirDateTime(value);
          OnPropertyChanged("Value");
        }
      }

      public override IDeepCopyable CopyTo(IDeepCopyable other)
      {
        var dest = other as DateCriterionComponent;

        if (dest == null)
        {
          throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        base.CopyTo(dest);
        if(Code != null) dest.Code = (Hl7.Fhir.Model.CodeableConcept)Code.DeepCopy();
        if(ValueElement != null) dest.ValueElement = (Hl7.Fhir.Model.FhirDateTime)ValueElement.DeepCopy();
        return dest;
      }

      public override IDeepCopyable DeepCopy()
      {
        return CopyTo(new DateCriterionComponent());
      }

      ///<inheritdoc />
      public override bool Matches(IDeepComparable other)
      {
        var otherT = other as DateCriterionComponent;
        if(otherT == null) return false;

        if(!base.Matches(otherT)) return false;
        if( !DeepComparable.Matches(Code, otherT.Code)) return false;
        if( !DeepComparable.Matches(ValueElement, otherT.ValueElement)) return false;

        return true;
      }

      public override bool IsExactly(IDeepComparable other)
      {
        var otherT = other as DateCriterionComponent;
        if(otherT == null) return false;

        if(!base.IsExactly(otherT)) return false;
        if( !DeepComparable.IsExactly(Code, otherT.Code)) return false;
        if( !DeepComparable.IsExactly(ValueElement, otherT.ValueElement)) return false;

        return true;
      }

      [IgnoreDataMember]
      public override IEnumerable<Base> Children
      {
        get
        {
          foreach (var item in base.Children) yield return item;
          if (Code != null) yield return Code;
          if (ValueElement != null) yield return ValueElement;
        }
      }

      [IgnoreDataMember]
      public override IEnumerable<ElementValue> NamedChildren
      {
        get
        {
          foreach (var item in base.NamedChildren) yield return item;
          if (Code != null) yield return new ElementValue("code", Code);
          if (ValueElement != null) yield return new ElementValue("value", ValueElement);
        }
      }

      protected override bool TryGetValue(string key, out object value)
      {
        switch (key)
        {
          case "code":
            value = Code;
            return Code is not null;
          case "value":
            value = ValueElement;
            return ValueElement is not null;
          default:
            return base.TryGetValue(key, out value);
        }

      }

      protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
      {
        foreach (var kvp in base.GetElementPairs()) yield return kvp;
        if (Code is not null) yield return new KeyValuePair<string,object>("code",Code);
        if (ValueElement is not null) yield return new KeyValuePair<string,object>("value",ValueElement);
      }

    }

    /// <summary>
    /// Protocol used by recommendation
    /// </summary>
    /// <remarks>
    /// Contains information about the protocol under which the vaccine was administered.
    /// </remarks>
    [Serializable]
    [DataContract]
    [FhirType("ImmunizationRecommendation#Protocol", IsNestedType=true)]
    [BackboneType("ImmunizationRecommendation.recommendation.protocol")]
    public partial class ProtocolComponent : Hl7.Fhir.Model.BackboneElement
    {
      /// <summary>
      /// FHIR Type Name
      /// </summary>
      public override string TypeName { get { return "ImmunizationRecommendation#Protocol"; } }

      /// <summary>
      /// Dose number within sequence
      /// </summary>
      [FhirElement("doseSequence", Order=40)]
      [DataMember]
      public Hl7.Fhir.Model.PositiveInt DoseSequenceElement
      {
        get { return _DoseSequenceElement; }
        set { _DoseSequenceElement = value; OnPropertyChanged("DoseSequenceElement"); }
      }

      private Hl7.Fhir.Model.PositiveInt _DoseSequenceElement;

      /// <summary>
      /// Dose number within sequence
      /// </summary>
      /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
      [IgnoreDataMember]
      public int? DoseSequence
      {
        get { return DoseSequenceElement != null ? DoseSequenceElement.Value : null; }
        set
        {
          if (value == null)
            DoseSequenceElement = null;
          else
            DoseSequenceElement = new Hl7.Fhir.Model.PositiveInt(value);
          OnPropertyChanged("DoseSequence");
        }
      }

      /// <summary>
      /// Protocol details
      /// </summary>
      [FhirElement("description", Order=50)]
      [DataMember]
      public Hl7.Fhir.Model.FhirString DescriptionElement
      {
        get { return _DescriptionElement; }
        set { _DescriptionElement = value; OnPropertyChanged("DescriptionElement"); }
      }

      private Hl7.Fhir.Model.FhirString _DescriptionElement;

      /// <summary>
      /// Protocol details
      /// </summary>
      /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
      [IgnoreDataMember]
      public string Description
      {
        get { return DescriptionElement != null ? DescriptionElement.Value : null; }
        set
        {
          if (value == null)
            DescriptionElement = null;
          else
            DescriptionElement = new Hl7.Fhir.Model.FhirString(value);
          OnPropertyChanged("Description");
        }
      }

      /// <summary>
      /// Who is responsible for protocol
      /// </summary>
      [FhirElement("authority", Order=60)]
      [CLSCompliant(false)]
      [References("Organization")]
      [DataMember]
      public Hl7.Fhir.Model.ResourceReference Authority
      {
        get { return _Authority; }
        set { _Authority = value; OnPropertyChanged("Authority"); }
      }

      private Hl7.Fhir.Model.ResourceReference _Authority;

      /// <summary>
      /// Name of vaccination series
      /// </summary>
      [FhirElement("series", Order=70)]
      [DataMember]
      public Hl7.Fhir.Model.FhirString SeriesElement
      {
        get { return _SeriesElement; }
        set { _SeriesElement = value; OnPropertyChanged("SeriesElement"); }
      }

      private Hl7.Fhir.Model.FhirString _SeriesElement;

      /// <summary>
      /// Name of vaccination series
      /// </summary>
      /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
      [IgnoreDataMember]
      public string Series
      {
        get { return SeriesElement != null ? SeriesElement.Value : null; }
        set
        {
          if (value == null)
            SeriesElement = null;
          else
            SeriesElement = new Hl7.Fhir.Model.FhirString(value);
          OnPropertyChanged("Series");
        }
      }

      public override IDeepCopyable CopyTo(IDeepCopyable other)
      {
        var dest = other as ProtocolComponent;

        if (dest == null)
        {
          throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        base.CopyTo(dest);
        if(DoseSequenceElement != null) dest.DoseSequenceElement = (Hl7.Fhir.Model.PositiveInt)DoseSequenceElement.DeepCopy();
        if(DescriptionElement != null) dest.DescriptionElement = (Hl7.Fhir.Model.FhirString)DescriptionElement.DeepCopy();
        if(Authority != null) dest.Authority = (Hl7.Fhir.Model.ResourceReference)Authority.DeepCopy();
        if(SeriesElement != null) dest.SeriesElement = (Hl7.Fhir.Model.FhirString)SeriesElement.DeepCopy();
        return dest;
      }

      public override IDeepCopyable DeepCopy()
      {
        return CopyTo(new ProtocolComponent());
      }

      ///<inheritdoc />
      public override bool Matches(IDeepComparable other)
      {
        var otherT = other as ProtocolComponent;
        if(otherT == null) return false;

        if(!base.Matches(otherT)) return false;
        if( !DeepComparable.Matches(DoseSequenceElement, otherT.DoseSequenceElement)) return false;
        if( !DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
        if( !DeepComparable.Matches(Authority, otherT.Authority)) return false;
        if( !DeepComparable.Matches(SeriesElement, otherT.SeriesElement)) return false;

        return true;
      }

      public override bool IsExactly(IDeepComparable other)
      {
        var otherT = other as ProtocolComponent;
        if(otherT == null) return false;

        if(!base.IsExactly(otherT)) return false;
        if( !DeepComparable.IsExactly(DoseSequenceElement, otherT.DoseSequenceElement)) return false;
        if( !DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
        if( !DeepComparable.IsExactly(Authority, otherT.Authority)) return false;
        if( !DeepComparable.IsExactly(SeriesElement, otherT.SeriesElement)) return false;

        return true;
      }

      [IgnoreDataMember]
      public override IEnumerable<Base> Children
      {
        get
        {
          foreach (var item in base.Children) yield return item;
          if (DoseSequenceElement != null) yield return DoseSequenceElement;
          if (DescriptionElement != null) yield return DescriptionElement;
          if (Authority != null) yield return Authority;
          if (SeriesElement != null) yield return SeriesElement;
        }
      }

      [IgnoreDataMember]
      public override IEnumerable<ElementValue> NamedChildren
      {
        get
        {
          foreach (var item in base.NamedChildren) yield return item;
          if (DoseSequenceElement != null) yield return new ElementValue("doseSequence", DoseSequenceElement);
          if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
          if (Authority != null) yield return new ElementValue("authority", Authority);
          if (SeriesElement != null) yield return new ElementValue("series", SeriesElement);
        }
      }

      protected override bool TryGetValue(string key, out object value)
      {
        switch (key)
        {
          case "doseSequence":
            value = DoseSequenceElement;
            return DoseSequenceElement is not null;
          case "description":
            value = DescriptionElement;
            return DescriptionElement is not null;
          case "authority":
            value = Authority;
            return Authority is not null;
          case "series":
            value = SeriesElement;
            return SeriesElement is not null;
          default:
            return base.TryGetValue(key, out value);
        }

      }

      protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
      {
        foreach (var kvp in base.GetElementPairs()) yield return kvp;
        if (DoseSequenceElement is not null) yield return new KeyValuePair<string,object>("doseSequence",DoseSequenceElement);
        if (DescriptionElement is not null) yield return new KeyValuePair<string,object>("description",DescriptionElement);
        if (Authority is not null) yield return new KeyValuePair<string,object>("authority",Authority);
        if (SeriesElement is not null) yield return new KeyValuePair<string,object>("series",SeriesElement);
      }

    }

    /// <summary>
    /// Business identifier
    /// </summary>
    [FhirElement("identifier", InSummary=true, Order=90, FiveWs="id")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.Identifier> Identifier
    {
      get { if(_Identifier==null) _Identifier = new List<Hl7.Fhir.Model.Identifier>(); return _Identifier; }
      set { _Identifier = value; OnPropertyChanged("Identifier"); }
    }

    private List<Hl7.Fhir.Model.Identifier> _Identifier;

    /// <summary>
    /// Who this profile is for
    /// </summary>
    [FhirElement("patient", InSummary=true, Order=100, FiveWs="who.focus")]
    [CLSCompliant(false)]
    [References("Patient")]
    [Cardinality(Min=1,Max=1)]
    [DataMember]
    public Hl7.Fhir.Model.ResourceReference Patient
    {
      get { return _Patient; }
      set { _Patient = value; OnPropertyChanged("Patient"); }
    }

    private Hl7.Fhir.Model.ResourceReference _Patient;

    /// <summary>
    /// Vaccine administration recommendations
    /// </summary>
    [FhirElement("recommendation", InSummary=true, Order=110)]
    [Cardinality(Min=1,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.ImmunizationRecommendation.RecommendationComponent> Recommendation
    {
      get { if(_Recommendation==null) _Recommendation = new List<Hl7.Fhir.Model.ImmunizationRecommendation.RecommendationComponent>(); return _Recommendation; }
      set { _Recommendation = value; OnPropertyChanged("Recommendation"); }
    }

    private List<Hl7.Fhir.Model.ImmunizationRecommendation.RecommendationComponent> _Recommendation;

    List<Identifier> IIdentifiable<List<Identifier>>.Identifier { get => Identifier; set => Identifier = value; }

    public override IDeepCopyable CopyTo(IDeepCopyable other)
    {
      var dest = other as ImmunizationRecommendation;

      if (dest == null)
      {
        throw new ArgumentException("Can only copy to an object of the same type", "other");
      }

      base.CopyTo(dest);
      if(Identifier.Any()) dest.Identifier = new List<Hl7.Fhir.Model.Identifier>(Identifier.DeepCopy());
      if(Patient != null) dest.Patient = (Hl7.Fhir.Model.ResourceReference)Patient.DeepCopy();
      if(Recommendation.Any()) dest.Recommendation = new List<Hl7.Fhir.Model.ImmunizationRecommendation.RecommendationComponent>(Recommendation.DeepCopy());
      return dest;
    }

    public override IDeepCopyable DeepCopy()
    {
      return CopyTo(new ImmunizationRecommendation());
    }

    ///<inheritdoc />
    public override bool Matches(IDeepComparable other)
    {
      var otherT = other as ImmunizationRecommendation;
      if(otherT == null) return false;

      if(!base.Matches(otherT)) return false;
      if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
      if( !DeepComparable.Matches(Patient, otherT.Patient)) return false;
      if( !DeepComparable.Matches(Recommendation, otherT.Recommendation)) return false;

      return true;
    }

    public override bool IsExactly(IDeepComparable other)
    {
      var otherT = other as ImmunizationRecommendation;
      if(otherT == null) return false;

      if(!base.IsExactly(otherT)) return false;
      if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
      if( !DeepComparable.IsExactly(Patient, otherT.Patient)) return false;
      if( !DeepComparable.IsExactly(Recommendation, otherT.Recommendation)) return false;

      return true;
    }

    [IgnoreDataMember]
    public override IEnumerable<Base> Children
    {
      get
      {
        foreach (var item in base.Children) yield return item;
        foreach (var elem in Identifier) { if (elem != null) yield return elem; }
        if (Patient != null) yield return Patient;
        foreach (var elem in Recommendation) { if (elem != null) yield return elem; }
      }
    }

    [IgnoreDataMember]
    public override IEnumerable<ElementValue> NamedChildren
    {
      get
      {
        foreach (var item in base.NamedChildren) yield return item;
        foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
        if (Patient != null) yield return new ElementValue("patient", Patient);
        foreach (var elem in Recommendation) { if (elem != null) yield return new ElementValue("recommendation", elem); }
      }
    }

    protected override bool TryGetValue(string key, out object value)
    {
      switch (key)
      {
        case "identifier":
          value = Identifier;
          return Identifier?.Any() == true;
        case "patient":
          value = Patient;
          return Patient is not null;
        case "recommendation":
          value = Recommendation;
          return Recommendation?.Any() == true;
        default:
          return base.TryGetValue(key, out value);
      }

    }

    protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
    {
      foreach (var kvp in base.GetElementPairs()) yield return kvp;
      if (Identifier?.Any() == true) yield return new KeyValuePair<string,object>("identifier",Identifier);
      if (Patient is not null) yield return new KeyValuePair<string,object>("patient",Patient);
      if (Recommendation?.Any() == true) yield return new KeyValuePair<string,object>("recommendation",Recommendation);
    }

  }

}

// end of file
