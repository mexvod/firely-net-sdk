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
  /// Specific and identified anatomical structure
  /// </summary>
  /// <remarks>
  /// Record details about an anatomical structure.  This resource may be used when a coded concept does not provide the necessary detail needed for the use case.
  /// </remarks>
  [Serializable]
  [DataContract]
  [FhirType("BodyStructure","http://hl7.org/fhir/StructureDefinition/BodyStructure", IsResource=true)]
  public partial class BodyStructure : Hl7.Fhir.Model.DomainResource, IIdentifiable<List<Identifier>>
  {
    /// <summary>
    /// FHIR Type Name
    /// </summary>
    public override string TypeName { get { return "BodyStructure"; } }

    /// <summary>
    /// Included anatomic location(s)
    /// </summary>
    /// <remarks>
    /// The anatomical location(s) or region(s) of the specimen, lesion, or body structure.
    /// </remarks>
    [Serializable]
    [DataContract]
    [FhirType("BodyStructure#IncludedStructure", IsNestedType=true)]
    [BackboneType("BodyStructure.includedStructure")]
    public partial class IncludedStructureComponent : Hl7.Fhir.Model.BackboneElement
    {
      /// <summary>
      /// FHIR Type Name
      /// </summary>
      public override string TypeName { get { return "BodyStructure#IncludedStructure"; } }

      /// <summary>
      /// Code that represents the included structure
      /// </summary>
      [FhirElement("structure", InSummary=true, Order=40, FiveWs="FiveWs.what[x]")]
      [Binding("BodySite")]
      [Cardinality(Min=1,Max=1)]
      [DataMember]
      public Hl7.Fhir.Model.CodeableConcept Structure
      {
        get { return _Structure; }
        set { _Structure = value; OnPropertyChanged("Structure"); }
      }

      private Hl7.Fhir.Model.CodeableConcept _Structure;

      /// <summary>
      /// Code that represents the included structure laterality
      /// </summary>
      [FhirElement("laterality", Order=50, FiveWs="FiveWs.what[x]")]
      [Binding("BodyStructureQualifier")]
      [DataMember]
      public Hl7.Fhir.Model.CodeableConcept Laterality
      {
        get { return _Laterality; }
        set { _Laterality = value; OnPropertyChanged("Laterality"); }
      }

      private Hl7.Fhir.Model.CodeableConcept _Laterality;

      /// <summary>
      /// Landmark relative location
      /// </summary>
      [FhirElement("bodyLandmarkOrientation", Order=60)]
      [Cardinality(Min=0,Max=-1)]
      [DataMember]
      public List<Hl7.Fhir.Model.BodyStructure.BodyLandmarkOrientationComponent> BodyLandmarkOrientation
      {
        get { if(_BodyLandmarkOrientation==null) _BodyLandmarkOrientation = new List<Hl7.Fhir.Model.BodyStructure.BodyLandmarkOrientationComponent>(); return _BodyLandmarkOrientation; }
        set { _BodyLandmarkOrientation = value; OnPropertyChanged("BodyLandmarkOrientation"); }
      }

      private List<Hl7.Fhir.Model.BodyStructure.BodyLandmarkOrientationComponent> _BodyLandmarkOrientation;

      /// <summary>
      /// Cartesian reference for structure
      /// </summary>
      [FhirElement("spatialReference", Order=70, FiveWs="FiveWs.where[x]")]
      [CLSCompliant(false)]
      [References("ImagingSelection")]
      [Cardinality(Min=0,Max=-1)]
      [DataMember]
      public List<Hl7.Fhir.Model.ResourceReference> SpatialReference
      {
        get { if(_SpatialReference==null) _SpatialReference = new List<Hl7.Fhir.Model.ResourceReference>(); return _SpatialReference; }
        set { _SpatialReference = value; OnPropertyChanged("SpatialReference"); }
      }

      private List<Hl7.Fhir.Model.ResourceReference> _SpatialReference;

      /// <summary>
      /// Code that represents the included structure qualifier
      /// </summary>
      [FhirElement("qualifier", Order=80, FiveWs="FiveWs.what[x]")]
      [Binding("BodyStructureQualifier")]
      [Cardinality(Min=0,Max=-1)]
      [DataMember]
      public List<Hl7.Fhir.Model.CodeableConcept> Qualifier
      {
        get { if(_Qualifier==null) _Qualifier = new List<Hl7.Fhir.Model.CodeableConcept>(); return _Qualifier; }
        set { _Qualifier = value; OnPropertyChanged("Qualifier"); }
      }

      private List<Hl7.Fhir.Model.CodeableConcept> _Qualifier;

      public override IDeepCopyable CopyTo(IDeepCopyable other)
      {
        var dest = other as IncludedStructureComponent;

        if (dest == null)
        {
          throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        base.CopyTo(dest);
        if(Structure != null) dest.Structure = (Hl7.Fhir.Model.CodeableConcept)Structure.DeepCopy();
        if(Laterality != null) dest.Laterality = (Hl7.Fhir.Model.CodeableConcept)Laterality.DeepCopy();
        if(BodyLandmarkOrientation.Any()) dest.BodyLandmarkOrientation = new List<Hl7.Fhir.Model.BodyStructure.BodyLandmarkOrientationComponent>(BodyLandmarkOrientation.DeepCopy());
        if(SpatialReference.Any()) dest.SpatialReference = new List<Hl7.Fhir.Model.ResourceReference>(SpatialReference.DeepCopy());
        if(Qualifier.Any()) dest.Qualifier = new List<Hl7.Fhir.Model.CodeableConcept>(Qualifier.DeepCopy());
        return dest;
      }

      public override IDeepCopyable DeepCopy()
      {
        return CopyTo(new IncludedStructureComponent());
      }

      ///<inheritdoc />
      public override bool Matches(IDeepComparable other)
      {
        var otherT = other as IncludedStructureComponent;
        if(otherT == null) return false;

        if(!base.Matches(otherT)) return false;
        if( !DeepComparable.Matches(Structure, otherT.Structure)) return false;
        if( !DeepComparable.Matches(Laterality, otherT.Laterality)) return false;
        if( !DeepComparable.Matches(BodyLandmarkOrientation, otherT.BodyLandmarkOrientation)) return false;
        if( !DeepComparable.Matches(SpatialReference, otherT.SpatialReference)) return false;
        if( !DeepComparable.Matches(Qualifier, otherT.Qualifier)) return false;

        return true;
      }

      public override bool IsExactly(IDeepComparable other)
      {
        var otherT = other as IncludedStructureComponent;
        if(otherT == null) return false;

        if(!base.IsExactly(otherT)) return false;
        if( !DeepComparable.IsExactly(Structure, otherT.Structure)) return false;
        if( !DeepComparable.IsExactly(Laterality, otherT.Laterality)) return false;
        if( !DeepComparable.IsExactly(BodyLandmarkOrientation, otherT.BodyLandmarkOrientation)) return false;
        if( !DeepComparable.IsExactly(SpatialReference, otherT.SpatialReference)) return false;
        if( !DeepComparable.IsExactly(Qualifier, otherT.Qualifier)) return false;

        return true;
      }

      [IgnoreDataMember]
      public override IEnumerable<Base> Children
      {
        get
        {
          foreach (var item in base.Children) yield return item;
          if (Structure != null) yield return Structure;
          if (Laterality != null) yield return Laterality;
          foreach (var elem in BodyLandmarkOrientation) { if (elem != null) yield return elem; }
          foreach (var elem in SpatialReference) { if (elem != null) yield return elem; }
          foreach (var elem in Qualifier) { if (elem != null) yield return elem; }
        }
      }

      [IgnoreDataMember]
      public override IEnumerable<ElementValue> NamedChildren
      {
        get
        {
          foreach (var item in base.NamedChildren) yield return item;
          if (Structure != null) yield return new ElementValue("structure", Structure);
          if (Laterality != null) yield return new ElementValue("laterality", Laterality);
          foreach (var elem in BodyLandmarkOrientation) { if (elem != null) yield return new ElementValue("bodyLandmarkOrientation", elem); }
          foreach (var elem in SpatialReference) { if (elem != null) yield return new ElementValue("spatialReference", elem); }
          foreach (var elem in Qualifier) { if (elem != null) yield return new ElementValue("qualifier", elem); }
        }
      }

      protected override bool TryGetValue(string key, out object value)
      {
        switch (key)
        {
          case "structure":
            value = Structure;
            return Structure is not null;
          case "laterality":
            value = Laterality;
            return Laterality is not null;
          case "bodyLandmarkOrientation":
            value = BodyLandmarkOrientation;
            return BodyLandmarkOrientation?.Any() == true;
          case "spatialReference":
            value = SpatialReference;
            return SpatialReference?.Any() == true;
          case "qualifier":
            value = Qualifier;
            return Qualifier?.Any() == true;
          default:
            return base.TryGetValue(key, out value);
        }

      }

      protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
      {
        foreach (var kvp in base.GetElementPairs()) yield return kvp;
        if (Structure is not null) yield return new KeyValuePair<string,object>("structure",Structure);
        if (Laterality is not null) yield return new KeyValuePair<string,object>("laterality",Laterality);
        if (BodyLandmarkOrientation?.Any() == true) yield return new KeyValuePair<string,object>("bodyLandmarkOrientation",BodyLandmarkOrientation);
        if (SpatialReference?.Any() == true) yield return new KeyValuePair<string,object>("spatialReference",SpatialReference);
        if (Qualifier?.Any() == true) yield return new KeyValuePair<string,object>("qualifier",Qualifier);
      }

    }

    /// <summary>
    /// Landmark relative location
    /// </summary>
    /// <remarks>
    /// Body locations in relation to a specific body landmark (tatoo, scar, other body structure).
    /// </remarks>
    [Serializable]
    [DataContract]
    [FhirType("BodyStructure#BodyLandmarkOrientation", IsNestedType=true)]
    [BackboneType("BodyStructure.includedStructure.bodyLandmarkOrientation")]
    public partial class BodyLandmarkOrientationComponent : Hl7.Fhir.Model.BackboneElement
    {
      /// <summary>
      /// FHIR Type Name
      /// </summary>
      public override string TypeName { get { return "BodyStructure#BodyLandmarkOrientation"; } }

      /// <summary>
      /// Body ]andmark description
      /// </summary>
      [FhirElement("landmarkDescription", Order=40, FiveWs="FiveWs.what[x]")]
      [Binding("bodyLandmarkOrientationLandmarkDescription")]
      [Cardinality(Min=0,Max=-1)]
      [DataMember]
      public List<Hl7.Fhir.Model.CodeableConcept> LandmarkDescription
      {
        get { if(_LandmarkDescription==null) _LandmarkDescription = new List<Hl7.Fhir.Model.CodeableConcept>(); return _LandmarkDescription; }
        set { _LandmarkDescription = value; OnPropertyChanged("LandmarkDescription"); }
      }

      private List<Hl7.Fhir.Model.CodeableConcept> _LandmarkDescription;

      /// <summary>
      /// Clockface orientation
      /// </summary>
      [FhirElement("clockFacePosition", Order=50, FiveWs="FiveWs.what[x]")]
      [Binding("bodyLandmarkOrientationClockFacePosition")]
      [Cardinality(Min=0,Max=-1)]
      [DataMember]
      public List<Hl7.Fhir.Model.CodeableConcept> ClockFacePosition
      {
        get { if(_ClockFacePosition==null) _ClockFacePosition = new List<Hl7.Fhir.Model.CodeableConcept>(); return _ClockFacePosition; }
        set { _ClockFacePosition = value; OnPropertyChanged("ClockFacePosition"); }
      }

      private List<Hl7.Fhir.Model.CodeableConcept> _ClockFacePosition;

      /// <summary>
      /// Landmark relative location
      /// </summary>
      [FhirElement("distanceFromLandmark", Order=60)]
      [Cardinality(Min=0,Max=-1)]
      [DataMember]
      public List<Hl7.Fhir.Model.BodyStructure.DistanceFromLandmarkComponent> DistanceFromLandmark
      {
        get { if(_DistanceFromLandmark==null) _DistanceFromLandmark = new List<Hl7.Fhir.Model.BodyStructure.DistanceFromLandmarkComponent>(); return _DistanceFromLandmark; }
        set { _DistanceFromLandmark = value; OnPropertyChanged("DistanceFromLandmark"); }
      }

      private List<Hl7.Fhir.Model.BodyStructure.DistanceFromLandmarkComponent> _DistanceFromLandmark;

      /// <summary>
      /// Relative landmark surface orientation
      /// </summary>
      [FhirElement("surfaceOrientation", Order=70, FiveWs="FiveWs.what[x]")]
      [Binding("bodyLandmarkOrientationSurfaceOrientation")]
      [Cardinality(Min=0,Max=-1)]
      [DataMember]
      public List<Hl7.Fhir.Model.CodeableConcept> SurfaceOrientation
      {
        get { if(_SurfaceOrientation==null) _SurfaceOrientation = new List<Hl7.Fhir.Model.CodeableConcept>(); return _SurfaceOrientation; }
        set { _SurfaceOrientation = value; OnPropertyChanged("SurfaceOrientation"); }
      }

      private List<Hl7.Fhir.Model.CodeableConcept> _SurfaceOrientation;

      public override IDeepCopyable CopyTo(IDeepCopyable other)
      {
        var dest = other as BodyLandmarkOrientationComponent;

        if (dest == null)
        {
          throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        base.CopyTo(dest);
        if(LandmarkDescription.Any()) dest.LandmarkDescription = new List<Hl7.Fhir.Model.CodeableConcept>(LandmarkDescription.DeepCopy());
        if(ClockFacePosition.Any()) dest.ClockFacePosition = new List<Hl7.Fhir.Model.CodeableConcept>(ClockFacePosition.DeepCopy());
        if(DistanceFromLandmark.Any()) dest.DistanceFromLandmark = new List<Hl7.Fhir.Model.BodyStructure.DistanceFromLandmarkComponent>(DistanceFromLandmark.DeepCopy());
        if(SurfaceOrientation.Any()) dest.SurfaceOrientation = new List<Hl7.Fhir.Model.CodeableConcept>(SurfaceOrientation.DeepCopy());
        return dest;
      }

      public override IDeepCopyable DeepCopy()
      {
        return CopyTo(new BodyLandmarkOrientationComponent());
      }

      ///<inheritdoc />
      public override bool Matches(IDeepComparable other)
      {
        var otherT = other as BodyLandmarkOrientationComponent;
        if(otherT == null) return false;

        if(!base.Matches(otherT)) return false;
        if( !DeepComparable.Matches(LandmarkDescription, otherT.LandmarkDescription)) return false;
        if( !DeepComparable.Matches(ClockFacePosition, otherT.ClockFacePosition)) return false;
        if( !DeepComparable.Matches(DistanceFromLandmark, otherT.DistanceFromLandmark)) return false;
        if( !DeepComparable.Matches(SurfaceOrientation, otherT.SurfaceOrientation)) return false;

        return true;
      }

      public override bool IsExactly(IDeepComparable other)
      {
        var otherT = other as BodyLandmarkOrientationComponent;
        if(otherT == null) return false;

        if(!base.IsExactly(otherT)) return false;
        if( !DeepComparable.IsExactly(LandmarkDescription, otherT.LandmarkDescription)) return false;
        if( !DeepComparable.IsExactly(ClockFacePosition, otherT.ClockFacePosition)) return false;
        if( !DeepComparable.IsExactly(DistanceFromLandmark, otherT.DistanceFromLandmark)) return false;
        if( !DeepComparable.IsExactly(SurfaceOrientation, otherT.SurfaceOrientation)) return false;

        return true;
      }

      [IgnoreDataMember]
      public override IEnumerable<Base> Children
      {
        get
        {
          foreach (var item in base.Children) yield return item;
          foreach (var elem in LandmarkDescription) { if (elem != null) yield return elem; }
          foreach (var elem in ClockFacePosition) { if (elem != null) yield return elem; }
          foreach (var elem in DistanceFromLandmark) { if (elem != null) yield return elem; }
          foreach (var elem in SurfaceOrientation) { if (elem != null) yield return elem; }
        }
      }

      [IgnoreDataMember]
      public override IEnumerable<ElementValue> NamedChildren
      {
        get
        {
          foreach (var item in base.NamedChildren) yield return item;
          foreach (var elem in LandmarkDescription) { if (elem != null) yield return new ElementValue("landmarkDescription", elem); }
          foreach (var elem in ClockFacePosition) { if (elem != null) yield return new ElementValue("clockFacePosition", elem); }
          foreach (var elem in DistanceFromLandmark) { if (elem != null) yield return new ElementValue("distanceFromLandmark", elem); }
          foreach (var elem in SurfaceOrientation) { if (elem != null) yield return new ElementValue("surfaceOrientation", elem); }
        }
      }

      protected override bool TryGetValue(string key, out object value)
      {
        switch (key)
        {
          case "landmarkDescription":
            value = LandmarkDescription;
            return LandmarkDescription?.Any() == true;
          case "clockFacePosition":
            value = ClockFacePosition;
            return ClockFacePosition?.Any() == true;
          case "distanceFromLandmark":
            value = DistanceFromLandmark;
            return DistanceFromLandmark?.Any() == true;
          case "surfaceOrientation":
            value = SurfaceOrientation;
            return SurfaceOrientation?.Any() == true;
          default:
            return base.TryGetValue(key, out value);
        }

      }

      protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
      {
        foreach (var kvp in base.GetElementPairs()) yield return kvp;
        if (LandmarkDescription?.Any() == true) yield return new KeyValuePair<string,object>("landmarkDescription",LandmarkDescription);
        if (ClockFacePosition?.Any() == true) yield return new KeyValuePair<string,object>("clockFacePosition",ClockFacePosition);
        if (DistanceFromLandmark?.Any() == true) yield return new KeyValuePair<string,object>("distanceFromLandmark",DistanceFromLandmark);
        if (SurfaceOrientation?.Any() == true) yield return new KeyValuePair<string,object>("surfaceOrientation",SurfaceOrientation);
      }

    }

    /// <summary>
    /// Landmark relative location
    /// </summary>
    /// <remarks>
    /// The distance in centimeters a certain observation is made from a body landmark.
    /// </remarks>
    [Serializable]
    [DataContract]
    [FhirType("BodyStructure#DistanceFromLandmark", IsNestedType=true)]
    [BackboneType("BodyStructure.includedStructure.bodyLandmarkOrientation.distanceFromLandmark")]
    public partial class DistanceFromLandmarkComponent : Hl7.Fhir.Model.BackboneElement
    {
      /// <summary>
      /// FHIR Type Name
      /// </summary>
      public override string TypeName { get { return "BodyStructure#DistanceFromLandmark"; } }

      /// <summary>
      /// Measurement device
      /// </summary>
      [FhirElement("device", Order=40, FiveWs="FiveWs.what[x]")]
      [Binding("DeviceType")]
      [Cardinality(Min=0,Max=-1)]
      [DataMember]
      public List<Hl7.Fhir.Model.CodeableReference> Device
      {
        get { if(_Device==null) _Device = new List<Hl7.Fhir.Model.CodeableReference>(); return _Device; }
        set { _Device = value; OnPropertyChanged("Device"); }
      }

      private List<Hl7.Fhir.Model.CodeableReference> _Device;

      /// <summary>
      /// Measured distance from body landmark
      /// </summary>
      [FhirElement("value", Order=50)]
      [Cardinality(Min=0,Max=-1)]
      [DataMember]
      public List<Hl7.Fhir.Model.Quantity> Value
      {
        get { if(_Value==null) _Value = new List<Hl7.Fhir.Model.Quantity>(); return _Value; }
        set { _Value = value; OnPropertyChanged("Value"); }
      }

      private List<Hl7.Fhir.Model.Quantity> _Value;

      public override IDeepCopyable CopyTo(IDeepCopyable other)
      {
        var dest = other as DistanceFromLandmarkComponent;

        if (dest == null)
        {
          throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        base.CopyTo(dest);
        if(Device.Any()) dest.Device = new List<Hl7.Fhir.Model.CodeableReference>(Device.DeepCopy());
        if(Value.Any()) dest.Value = new List<Hl7.Fhir.Model.Quantity>(Value.DeepCopy());
        return dest;
      }

      public override IDeepCopyable DeepCopy()
      {
        return CopyTo(new DistanceFromLandmarkComponent());
      }

      ///<inheritdoc />
      public override bool Matches(IDeepComparable other)
      {
        var otherT = other as DistanceFromLandmarkComponent;
        if(otherT == null) return false;

        if(!base.Matches(otherT)) return false;
        if( !DeepComparable.Matches(Device, otherT.Device)) return false;
        if( !DeepComparable.Matches(Value, otherT.Value)) return false;

        return true;
      }

      public override bool IsExactly(IDeepComparable other)
      {
        var otherT = other as DistanceFromLandmarkComponent;
        if(otherT == null) return false;

        if(!base.IsExactly(otherT)) return false;
        if( !DeepComparable.IsExactly(Device, otherT.Device)) return false;
        if( !DeepComparable.IsExactly(Value, otherT.Value)) return false;

        return true;
      }

      [IgnoreDataMember]
      public override IEnumerable<Base> Children
      {
        get
        {
          foreach (var item in base.Children) yield return item;
          foreach (var elem in Device) { if (elem != null) yield return elem; }
          foreach (var elem in Value) { if (elem != null) yield return elem; }
        }
      }

      [IgnoreDataMember]
      public override IEnumerable<ElementValue> NamedChildren
      {
        get
        {
          foreach (var item in base.NamedChildren) yield return item;
          foreach (var elem in Device) { if (elem != null) yield return new ElementValue("device", elem); }
          foreach (var elem in Value) { if (elem != null) yield return new ElementValue("value", elem); }
        }
      }

      protected override bool TryGetValue(string key, out object value)
      {
        switch (key)
        {
          case "device":
            value = Device;
            return Device?.Any() == true;
          case "value":
            value = Value;
            return Value?.Any() == true;
          default:
            return base.TryGetValue(key, out value);
        }

      }

      protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
      {
        foreach (var kvp in base.GetElementPairs()) yield return kvp;
        if (Device?.Any() == true) yield return new KeyValuePair<string,object>("device",Device);
        if (Value?.Any() == true) yield return new KeyValuePair<string,object>("value",Value);
      }

    }

    /// <summary>
    /// Bodystructure identifier
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
    /// Whether this record is in active use
    /// </summary>
    [FhirElement("active", InSummary=true, IsModifier=true, Order=100, FiveWs="FiveWs.status")]
    [DataMember]
    public Hl7.Fhir.Model.FhirBoolean ActiveElement
    {
      get { return _ActiveElement; }
      set { _ActiveElement = value; OnPropertyChanged("ActiveElement"); }
    }

    private Hl7.Fhir.Model.FhirBoolean _ActiveElement;

    /// <summary>
    /// Whether this record is in active use
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public bool? Active
    {
      get { return ActiveElement != null ? ActiveElement.Value : null; }
      set
      {
        if (value == null)
          ActiveElement = null;
        else
          ActiveElement = new Hl7.Fhir.Model.FhirBoolean(value);
        OnPropertyChanged("Active");
      }
    }

    /// <summary>
    /// Kind of Structure
    /// </summary>
    [FhirElement("morphology", InSummary=true, Order=110, FiveWs="FiveWs.what[x]")]
    [Binding("BodyStructureCode")]
    [DataMember]
    public Hl7.Fhir.Model.CodeableConcept Morphology
    {
      get { return _Morphology; }
      set { _Morphology = value; OnPropertyChanged("Morphology"); }
    }

    private Hl7.Fhir.Model.CodeableConcept _Morphology;

    /// <summary>
    /// Included anatomic location(s)
    /// </summary>
    [FhirElement("includedStructure", Order=120)]
    [Cardinality(Min=1,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.BodyStructure.IncludedStructureComponent> IncludedStructure
    {
      get { if(_IncludedStructure==null) _IncludedStructure = new List<Hl7.Fhir.Model.BodyStructure.IncludedStructureComponent>(); return _IncludedStructure; }
      set { _IncludedStructure = value; OnPropertyChanged("IncludedStructure"); }
    }

    private List<Hl7.Fhir.Model.BodyStructure.IncludedStructureComponent> _IncludedStructure;

    /// <summary>
    /// Excluded anatomic locations(s)
    /// </summary>
    [FhirElement("excludedStructure", Order=130)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.BodyStructure.IncludedStructureComponent> ExcludedStructure
    {
      get { if(_ExcludedStructure==null) _ExcludedStructure = new List<Hl7.Fhir.Model.BodyStructure.IncludedStructureComponent>(); return _ExcludedStructure; }
      set { _ExcludedStructure = value; OnPropertyChanged("ExcludedStructure"); }
    }

    private List<Hl7.Fhir.Model.BodyStructure.IncludedStructureComponent> _ExcludedStructure;

    /// <summary>
    /// Text description
    /// </summary>
    [FhirElement("description", InSummary=true, Order=140, FiveWs="FiveWs.what[x]")]
    [DataMember]
    public Hl7.Fhir.Model.Markdown DescriptionElement
    {
      get { return _DescriptionElement; }
      set { _DescriptionElement = value; OnPropertyChanged("DescriptionElement"); }
    }

    private Hl7.Fhir.Model.Markdown _DescriptionElement;

    /// <summary>
    /// Text description
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
          DescriptionElement = new Hl7.Fhir.Model.Markdown(value);
        OnPropertyChanged("Description");
      }
    }

    /// <summary>
    /// Attached images
    /// </summary>
    [FhirElement("image", Order=150, FiveWs="FiveWs.what[x]")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.Attachment> Image
    {
      get { if(_Image==null) _Image = new List<Hl7.Fhir.Model.Attachment>(); return _Image; }
      set { _Image = value; OnPropertyChanged("Image"); }
    }

    private List<Hl7.Fhir.Model.Attachment> _Image;

    /// <summary>
    /// Who this is about
    /// </summary>
    [FhirElement("patient", InSummary=true, Order=160, FiveWs="FiveWs.subject")]
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

    List<Identifier> IIdentifiable<List<Identifier>>.Identifier { get => Identifier; set => Identifier = value; }

    public override IDeepCopyable CopyTo(IDeepCopyable other)
    {
      var dest = other as BodyStructure;

      if (dest == null)
      {
        throw new ArgumentException("Can only copy to an object of the same type", "other");
      }

      base.CopyTo(dest);
      if(Identifier.Any()) dest.Identifier = new List<Hl7.Fhir.Model.Identifier>(Identifier.DeepCopy());
      if(ActiveElement != null) dest.ActiveElement = (Hl7.Fhir.Model.FhirBoolean)ActiveElement.DeepCopy();
      if(Morphology != null) dest.Morphology = (Hl7.Fhir.Model.CodeableConcept)Morphology.DeepCopy();
      if(IncludedStructure.Any()) dest.IncludedStructure = new List<Hl7.Fhir.Model.BodyStructure.IncludedStructureComponent>(IncludedStructure.DeepCopy());
      if(ExcludedStructure.Any()) dest.ExcludedStructure = new List<Hl7.Fhir.Model.BodyStructure.IncludedStructureComponent>(ExcludedStructure.DeepCopy());
      if(DescriptionElement != null) dest.DescriptionElement = (Hl7.Fhir.Model.Markdown)DescriptionElement.DeepCopy();
      if(Image.Any()) dest.Image = new List<Hl7.Fhir.Model.Attachment>(Image.DeepCopy());
      if(Patient != null) dest.Patient = (Hl7.Fhir.Model.ResourceReference)Patient.DeepCopy();
      return dest;
    }

    public override IDeepCopyable DeepCopy()
    {
      return CopyTo(new BodyStructure());
    }

    ///<inheritdoc />
    public override bool Matches(IDeepComparable other)
    {
      var otherT = other as BodyStructure;
      if(otherT == null) return false;

      if(!base.Matches(otherT)) return false;
      if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
      if( !DeepComparable.Matches(ActiveElement, otherT.ActiveElement)) return false;
      if( !DeepComparable.Matches(Morphology, otherT.Morphology)) return false;
      if( !DeepComparable.Matches(IncludedStructure, otherT.IncludedStructure)) return false;
      if( !DeepComparable.Matches(ExcludedStructure, otherT.ExcludedStructure)) return false;
      if( !DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
      if( !DeepComparable.Matches(Image, otherT.Image)) return false;
      if( !DeepComparable.Matches(Patient, otherT.Patient)) return false;

      return true;
    }

    public override bool IsExactly(IDeepComparable other)
    {
      var otherT = other as BodyStructure;
      if(otherT == null) return false;

      if(!base.IsExactly(otherT)) return false;
      if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
      if( !DeepComparable.IsExactly(ActiveElement, otherT.ActiveElement)) return false;
      if( !DeepComparable.IsExactly(Morphology, otherT.Morphology)) return false;
      if( !DeepComparable.IsExactly(IncludedStructure, otherT.IncludedStructure)) return false;
      if( !DeepComparable.IsExactly(ExcludedStructure, otherT.ExcludedStructure)) return false;
      if( !DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
      if( !DeepComparable.IsExactly(Image, otherT.Image)) return false;
      if( !DeepComparable.IsExactly(Patient, otherT.Patient)) return false;

      return true;
    }

    [IgnoreDataMember]
    public override IEnumerable<Base> Children
    {
      get
      {
        foreach (var item in base.Children) yield return item;
        foreach (var elem in Identifier) { if (elem != null) yield return elem; }
        if (ActiveElement != null) yield return ActiveElement;
        if (Morphology != null) yield return Morphology;
        foreach (var elem in IncludedStructure) { if (elem != null) yield return elem; }
        foreach (var elem in ExcludedStructure) { if (elem != null) yield return elem; }
        if (DescriptionElement != null) yield return DescriptionElement;
        foreach (var elem in Image) { if (elem != null) yield return elem; }
        if (Patient != null) yield return Patient;
      }
    }

    [IgnoreDataMember]
    public override IEnumerable<ElementValue> NamedChildren
    {
      get
      {
        foreach (var item in base.NamedChildren) yield return item;
        foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
        if (ActiveElement != null) yield return new ElementValue("active", ActiveElement);
        if (Morphology != null) yield return new ElementValue("morphology", Morphology);
        foreach (var elem in IncludedStructure) { if (elem != null) yield return new ElementValue("includedStructure", elem); }
        foreach (var elem in ExcludedStructure) { if (elem != null) yield return new ElementValue("excludedStructure", elem); }
        if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
        foreach (var elem in Image) { if (elem != null) yield return new ElementValue("image", elem); }
        if (Patient != null) yield return new ElementValue("patient", Patient);
      }
    }

    protected override bool TryGetValue(string key, out object value)
    {
      switch (key)
      {
        case "identifier":
          value = Identifier;
          return Identifier?.Any() == true;
        case "active":
          value = ActiveElement;
          return ActiveElement is not null;
        case "morphology":
          value = Morphology;
          return Morphology is not null;
        case "includedStructure":
          value = IncludedStructure;
          return IncludedStructure?.Any() == true;
        case "excludedStructure":
          value = ExcludedStructure;
          return ExcludedStructure?.Any() == true;
        case "description":
          value = DescriptionElement;
          return DescriptionElement is not null;
        case "image":
          value = Image;
          return Image?.Any() == true;
        case "patient":
          value = Patient;
          return Patient is not null;
        default:
          return base.TryGetValue(key, out value);
      }

    }

    protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
    {
      foreach (var kvp in base.GetElementPairs()) yield return kvp;
      if (Identifier?.Any() == true) yield return new KeyValuePair<string,object>("identifier",Identifier);
      if (ActiveElement is not null) yield return new KeyValuePair<string,object>("active",ActiveElement);
      if (Morphology is not null) yield return new KeyValuePair<string,object>("morphology",Morphology);
      if (IncludedStructure?.Any() == true) yield return new KeyValuePair<string,object>("includedStructure",IncludedStructure);
      if (ExcludedStructure?.Any() == true) yield return new KeyValuePair<string,object>("excludedStructure",ExcludedStructure);
      if (DescriptionElement is not null) yield return new KeyValuePair<string,object>("description",DescriptionElement);
      if (Image?.Any() == true) yield return new KeyValuePair<string,object>("image",Image);
      if (Patient is not null) yield return new KeyValuePair<string,object>("patient",Patient);
    }

  }

}

// end of file
