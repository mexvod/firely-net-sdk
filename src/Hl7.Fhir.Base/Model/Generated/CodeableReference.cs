// <auto-generated/>
// Contents of: hl7.fhir.r5.expansions#5.0.0, hl7.fhir.r5.core#5.0.0

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
  /// Reference to a resource or a concept
  /// </summary>
  /// <remarks>
  /// A reference to a resource (by instance), or instead, a reference to a concept defined in a terminology or ontology (by class).
  /// </remarks>
  [Serializable]
  [DataContract]
  [FhirType("CodeableReference","http://hl7.org/fhir/StructureDefinition/CodeableReference")]
  public partial class CodeableReference : Hl7.Fhir.Model.DataType
  {
    /// <summary>
    /// FHIR Type Name
    /// </summary>
    public override string TypeName { get { return "CodeableReference"; } }

    /// <summary>
    /// Reference to a concept (by class)
    /// </summary>
    [FhirElement("concept", InSummary=true, Order=30)]
    [DataMember]
    public Hl7.Fhir.Model.CodeableConcept Concept
    {
      get { return _Concept; }
      set { _Concept = value; OnPropertyChanged("Concept"); }
    }

    private Hl7.Fhir.Model.CodeableConcept _Concept;

    /// <summary>
    /// Reference to a resource (by instance)
    /// </summary>
    [FhirElement("reference", InSummary=true, Order=40)]
    [DataMember]
    public Hl7.Fhir.Model.ResourceReference Reference
    {
      get { return _Reference; }
      set { _Reference = value; OnPropertyChanged("Reference"); }
    }

    private Hl7.Fhir.Model.ResourceReference _Reference;

    public override IDeepCopyable CopyTo(IDeepCopyable other)
    {
      var dest = other as CodeableReference;

      if (dest == null)
      {
        throw new ArgumentException("Can only copy to an object of the same type", "other");
      }

      base.CopyTo(dest);
      if(Concept != null) dest.Concept = (Hl7.Fhir.Model.CodeableConcept)Concept.DeepCopy();
      if(Reference != null) dest.Reference = (Hl7.Fhir.Model.ResourceReference)Reference.DeepCopy();
      return dest;
    }

    public override IDeepCopyable DeepCopy()
    {
      return CopyTo(new CodeableReference());
    }

    ///<inheritdoc />
    public override bool Matches(IDeepComparable other)
    {
      var otherT = other as CodeableReference;
      if(otherT == null) return false;

      if(!base.Matches(otherT)) return false;
      if( !DeepComparable.Matches(Concept, otherT.Concept)) return false;
      if( !DeepComparable.Matches(Reference, otherT.Reference)) return false;

      return true;
    }

    public override bool IsExactly(IDeepComparable other)
    {
      var otherT = other as CodeableReference;
      if(otherT == null) return false;

      if(!base.IsExactly(otherT)) return false;
      if( !DeepComparable.IsExactly(Concept, otherT.Concept)) return false;
      if( !DeepComparable.IsExactly(Reference, otherT.Reference)) return false;

      return true;
    }

    [IgnoreDataMember]
    public override IEnumerable<Base> Children
    {
      get
      {
        foreach (var item in base.Children) yield return item;
        if (Concept != null) yield return Concept;
        if (Reference != null) yield return Reference;
      }
    }

    [IgnoreDataMember]
    public override IEnumerable<ElementValue> NamedChildren
    {
      get
      {
        foreach (var item in base.NamedChildren) yield return item;
        if (Concept != null) yield return new ElementValue("concept", Concept);
        if (Reference != null) yield return new ElementValue("reference", Reference);
      }
    }

    protected override bool TryGetValue(string key, out object value)
    {
      switch (key)
      {
        case "concept":
          value = Concept;
          return Concept is not null;
        case "reference":
          value = Reference;
          return Reference is not null;
        default:
          return base.TryGetValue(key, out value);
      }

    }

    protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
    {
      foreach (var kvp in base.GetElementPairs()) yield return kvp;
      if (Concept is not null) yield return new KeyValuePair<string,object>("concept",Concept);
      if (Reference is not null) yield return new KeyValuePair<string,object>("reference",Reference);
    }

  }

}

// end of file
