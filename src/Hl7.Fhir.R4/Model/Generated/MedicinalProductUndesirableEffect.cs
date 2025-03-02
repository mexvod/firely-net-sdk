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
  /// MedicinalProductUndesirableEffect
  /// </summary>
  /// <remarks>
  /// Describe the undesirable effects of the medicinal product.
  /// </remarks>
  [Serializable]
  [DataContract]
  [FhirType("MedicinalProductUndesirableEffect","http://hl7.org/fhir/StructureDefinition/MedicinalProductUndesirableEffect", IsResource=true)]
  public partial class MedicinalProductUndesirableEffect : Hl7.Fhir.Model.DomainResource
  {
    /// <summary>
    /// FHIR Type Name
    /// </summary>
    public override string TypeName { get { return "MedicinalProductUndesirableEffect"; } }

    /// <summary>
    /// The medication for which this is an indication
    /// </summary>
    [FhirElement("subject", InSummary=true, Order=90)]
    [CLSCompliant(false)]
    [References("MedicinalProduct","Medication")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.ResourceReference> Subject
    {
      get { if(_Subject==null) _Subject = new List<Hl7.Fhir.Model.ResourceReference>(); return _Subject; }
      set { _Subject = value; OnPropertyChanged("Subject"); }
    }

    private List<Hl7.Fhir.Model.ResourceReference> _Subject;

    /// <summary>
    /// The symptom, condition or undesirable effect
    /// </summary>
    [FhirElement("symptomConditionEffect", InSummary=true, Order=100)]
    [DataMember]
    public Hl7.Fhir.Model.CodeableConcept SymptomConditionEffect
    {
      get { return _SymptomConditionEffect; }
      set { _SymptomConditionEffect = value; OnPropertyChanged("SymptomConditionEffect"); }
    }

    private Hl7.Fhir.Model.CodeableConcept _SymptomConditionEffect;

    /// <summary>
    /// Classification of the effect
    /// </summary>
    [FhirElement("classification", InSummary=true, Order=110)]
    [DataMember]
    public Hl7.Fhir.Model.CodeableConcept Classification
    {
      get { return _Classification; }
      set { _Classification = value; OnPropertyChanged("Classification"); }
    }

    private Hl7.Fhir.Model.CodeableConcept _Classification;

    /// <summary>
    /// The frequency of occurrence of the effect
    /// </summary>
    [FhirElement("frequencyOfOccurrence", InSummary=true, Order=120)]
    [DataMember]
    public Hl7.Fhir.Model.CodeableConcept FrequencyOfOccurrence
    {
      get { return _FrequencyOfOccurrence; }
      set { _FrequencyOfOccurrence = value; OnPropertyChanged("FrequencyOfOccurrence"); }
    }

    private Hl7.Fhir.Model.CodeableConcept _FrequencyOfOccurrence;

    /// <summary>
    /// The population group to which this applies
    /// </summary>
    [FhirElement("population", InSummary=true, Order=130)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.Population> Population
    {
      get { if(_Population==null) _Population = new List<Hl7.Fhir.Model.Population>(); return _Population; }
      set { _Population = value; OnPropertyChanged("Population"); }
    }

    private List<Hl7.Fhir.Model.Population> _Population;

    public override IDeepCopyable CopyTo(IDeepCopyable other)
    {
      var dest = other as MedicinalProductUndesirableEffect;

      if (dest == null)
      {
        throw new ArgumentException("Can only copy to an object of the same type", "other");
      }

      base.CopyTo(dest);
      if(Subject.Any()) dest.Subject = new List<Hl7.Fhir.Model.ResourceReference>(Subject.DeepCopy());
      if(SymptomConditionEffect != null) dest.SymptomConditionEffect = (Hl7.Fhir.Model.CodeableConcept)SymptomConditionEffect.DeepCopy();
      if(Classification != null) dest.Classification = (Hl7.Fhir.Model.CodeableConcept)Classification.DeepCopy();
      if(FrequencyOfOccurrence != null) dest.FrequencyOfOccurrence = (Hl7.Fhir.Model.CodeableConcept)FrequencyOfOccurrence.DeepCopy();
      if(Population.Any()) dest.Population = new List<Hl7.Fhir.Model.Population>(Population.DeepCopy());
      return dest;
    }

    public override IDeepCopyable DeepCopy()
    {
      return CopyTo(new MedicinalProductUndesirableEffect());
    }

    ///<inheritdoc />
    public override bool Matches(IDeepComparable other)
    {
      var otherT = other as MedicinalProductUndesirableEffect;
      if(otherT == null) return false;

      if(!base.Matches(otherT)) return false;
      if( !DeepComparable.Matches(Subject, otherT.Subject)) return false;
      if( !DeepComparable.Matches(SymptomConditionEffect, otherT.SymptomConditionEffect)) return false;
      if( !DeepComparable.Matches(Classification, otherT.Classification)) return false;
      if( !DeepComparable.Matches(FrequencyOfOccurrence, otherT.FrequencyOfOccurrence)) return false;
      if( !DeepComparable.Matches(Population, otherT.Population)) return false;

      return true;
    }

    public override bool IsExactly(IDeepComparable other)
    {
      var otherT = other as MedicinalProductUndesirableEffect;
      if(otherT == null) return false;

      if(!base.IsExactly(otherT)) return false;
      if( !DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
      if( !DeepComparable.IsExactly(SymptomConditionEffect, otherT.SymptomConditionEffect)) return false;
      if( !DeepComparable.IsExactly(Classification, otherT.Classification)) return false;
      if( !DeepComparable.IsExactly(FrequencyOfOccurrence, otherT.FrequencyOfOccurrence)) return false;
      if( !DeepComparable.IsExactly(Population, otherT.Population)) return false;

      return true;
    }

    [IgnoreDataMember]
    public override IEnumerable<Base> Children
    {
      get
      {
        foreach (var item in base.Children) yield return item;
        foreach (var elem in Subject) { if (elem != null) yield return elem; }
        if (SymptomConditionEffect != null) yield return SymptomConditionEffect;
        if (Classification != null) yield return Classification;
        if (FrequencyOfOccurrence != null) yield return FrequencyOfOccurrence;
        foreach (var elem in Population) { if (elem != null) yield return elem; }
      }
    }

    [IgnoreDataMember]
    public override IEnumerable<ElementValue> NamedChildren
    {
      get
      {
        foreach (var item in base.NamedChildren) yield return item;
        foreach (var elem in Subject) { if (elem != null) yield return new ElementValue("subject", elem); }
        if (SymptomConditionEffect != null) yield return new ElementValue("symptomConditionEffect", SymptomConditionEffect);
        if (Classification != null) yield return new ElementValue("classification", Classification);
        if (FrequencyOfOccurrence != null) yield return new ElementValue("frequencyOfOccurrence", FrequencyOfOccurrence);
        foreach (var elem in Population) { if (elem != null) yield return new ElementValue("population", elem); }
      }
    }

    protected override bool TryGetValue(string key, out object value)
    {
      switch (key)
      {
        case "subject":
          value = Subject;
          return Subject?.Any() == true;
        case "symptomConditionEffect":
          value = SymptomConditionEffect;
          return SymptomConditionEffect is not null;
        case "classification":
          value = Classification;
          return Classification is not null;
        case "frequencyOfOccurrence":
          value = FrequencyOfOccurrence;
          return FrequencyOfOccurrence is not null;
        case "population":
          value = Population;
          return Population?.Any() == true;
        default:
          return base.TryGetValue(key, out value);
      }

    }

    protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
    {
      foreach (var kvp in base.GetElementPairs()) yield return kvp;
      if (Subject?.Any() == true) yield return new KeyValuePair<string,object>("subject",Subject);
      if (SymptomConditionEffect is not null) yield return new KeyValuePair<string,object>("symptomConditionEffect",SymptomConditionEffect);
      if (Classification is not null) yield return new KeyValuePair<string,object>("classification",Classification);
      if (FrequencyOfOccurrence is not null) yield return new KeyValuePair<string,object>("frequencyOfOccurrence",FrequencyOfOccurrence);
      if (Population?.Any() == true) yield return new KeyValuePair<string,object>("population",Population);
    }

  }

}

// end of file
