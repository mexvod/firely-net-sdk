// <auto-generated/>
// Contents of: hl7.fhir.r4b.expansions#4.3.0, hl7.fhir.r4b.core#4.3.0

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
  /// A Diagnostic report - a combination of request information, atomic results, images, interpretation, as well as formatted reports
  /// </summary>
  /// <remarks>
  /// The findings and interpretation of diagnostic  tests performed on patients, groups of patients, devices, and locations, and/or specimens derived from these. The report includes clinical context such as requesting and provider information, and some mix of atomic results, images, textual and coded interpretations, and formatted representation of diagnostic reports.
  /// This is intended to capture a single report and is not suitable for use in displaying summary information that covers multiple reports.  For example, this resource has not been designed for laboratory cumulative reporting formats nor detailed structured reports for sequencing.
  /// </remarks>
  [Serializable]
  [DataContract]
  [FhirType("DiagnosticReport","http://hl7.org/fhir/StructureDefinition/DiagnosticReport", IsResource=true)]
  public partial class DiagnosticReport : Hl7.Fhir.Model.DomainResource, IIdentifiable<List<Identifier>>
  {
    /// <summary>
    /// FHIR Type Name
    /// </summary>
    public override string TypeName { get { return "DiagnosticReport"; } }

    /// <summary>
    /// The status of the diagnostic report.
    /// (url: http://hl7.org/fhir/ValueSet/diagnostic-report-status)
    /// (system: http://hl7.org/fhir/diagnostic-report-status)
    /// </summary>
    [FhirEnumeration("DiagnosticReportStatus", "http://hl7.org/fhir/ValueSet/diagnostic-report-status", "http://hl7.org/fhir/diagnostic-report-status")]
    public enum DiagnosticReportStatus
    {
      /// <summary>
      /// The existence of the report is registered, but there is nothing yet available.
      /// (system: http://hl7.org/fhir/diagnostic-report-status)
      /// </summary>
      [EnumLiteral("registered"), Description("Registered")]
      Registered,
      /// <summary>
      /// This is a partial (e.g. initial, interim or preliminary) report: data in the report may be incomplete or unverified.
      /// (system: http://hl7.org/fhir/diagnostic-report-status)
      /// </summary>
      [EnumLiteral("partial"), Description("Partial")]
      Partial,
      /// <summary>
      /// Verified early results are available, but not all  results are final.
      /// (system: http://hl7.org/fhir/diagnostic-report-status)
      /// </summary>
      [EnumLiteral("preliminary"), Description("Preliminary")]
      Preliminary,
      /// <summary>
      /// The report is complete and verified by an authorized person.
      /// (system: http://hl7.org/fhir/diagnostic-report-status)
      /// </summary>
      [EnumLiteral("final"), Description("Final")]
      Final,
      /// <summary>
      /// Subsequent to being final, the report has been modified.  This includes any change in the results, diagnosis, narrative text, or other content of a report that has been issued.
      /// (system: http://hl7.org/fhir/diagnostic-report-status)
      /// </summary>
      [EnumLiteral("amended"), Description("Amended")]
      Amended,
      /// <summary>
      /// Subsequent to being final, the report has been modified  to correct an error in the report or referenced results.
      /// (system: http://hl7.org/fhir/diagnostic-report-status)
      /// </summary>
      [EnumLiteral("corrected"), Description("Corrected")]
      Corrected,
      /// <summary>
      /// Subsequent to being final, the report has been modified by adding new content. The existing content is unchanged.
      /// (system: http://hl7.org/fhir/diagnostic-report-status)
      /// </summary>
      [EnumLiteral("appended"), Description("Appended")]
      Appended,
      /// <summary>
      /// The report is unavailable because the measurement was not started or not completed (also sometimes called \"aborted\").
      /// (system: http://hl7.org/fhir/diagnostic-report-status)
      /// </summary>
      [EnumLiteral("cancelled"), Description("Cancelled")]
      Cancelled,
      /// <summary>
      /// The report has been withdrawn following a previous final release.  This electronic record should never have existed, though it is possible that real-world decisions were based on it. (If real-world activity has occurred, the status should be \"cancelled\" rather than \"entered-in-error\".).
      /// (system: http://hl7.org/fhir/diagnostic-report-status)
      /// </summary>
      [EnumLiteral("entered-in-error"), Description("Entered in Error")]
      EnteredInError,
      /// <summary>
      /// The authoring/source system does not know which of the status values currently applies for this observation. Note: This concept is not to be used for \"other\" - one of the listed statuses is presumed to apply, but the authoring/source system does not know which.
      /// (system: http://hl7.org/fhir/diagnostic-report-status)
      /// </summary>
      [EnumLiteral("unknown"), Description("Unknown")]
      Unknown,
    }

    /// <summary>
    /// Key images associated with this report
    /// </summary>
    /// <remarks>
    /// A list of key images associated with this report. The images are generally created during the diagnostic process, and may be directly of the patient, or of treated specimens (i.e. slides of interest).
    /// </remarks>
    [Serializable]
    [DataContract]
    [FhirType("DiagnosticReport#Media", IsNestedType=true)]
    [BackboneType("DiagnosticReport.media")]
    public partial class MediaComponent : Hl7.Fhir.Model.BackboneElement
    {
      /// <summary>
      /// FHIR Type Name
      /// </summary>
      public override string TypeName { get { return "DiagnosticReport#Media"; } }

      /// <summary>
      /// Comment about the image (e.g. explanation)
      /// </summary>
      [FhirElement("comment", Order=40)]
      [DataMember]
      public Hl7.Fhir.Model.FhirString CommentElement
      {
        get { return _CommentElement; }
        set { _CommentElement = value; OnPropertyChanged("CommentElement"); }
      }

      private Hl7.Fhir.Model.FhirString _CommentElement;

      /// <summary>
      /// Comment about the image (e.g. explanation)
      /// </summary>
      /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
      [IgnoreDataMember]
      public string Comment
      {
        get { return CommentElement != null ? CommentElement.Value : null; }
        set
        {
          if (value == null)
            CommentElement = null;
          else
            CommentElement = new Hl7.Fhir.Model.FhirString(value);
          OnPropertyChanged("Comment");
        }
      }

      /// <summary>
      /// Reference to the image source
      /// </summary>
      [FhirElement("link", InSummary=true, Order=50)]
      [CLSCompliant(false)]
      [References("Media")]
      [Cardinality(Min=1,Max=1)]
      [DataMember]
      public Hl7.Fhir.Model.ResourceReference Link
      {
        get { return _Link; }
        set { _Link = value; OnPropertyChanged("Link"); }
      }

      private Hl7.Fhir.Model.ResourceReference _Link;

      public override IDeepCopyable CopyTo(IDeepCopyable other)
      {
        var dest = other as MediaComponent;

        if (dest == null)
        {
          throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        base.CopyTo(dest);
        if(CommentElement != null) dest.CommentElement = (Hl7.Fhir.Model.FhirString)CommentElement.DeepCopy();
        if(Link != null) dest.Link = (Hl7.Fhir.Model.ResourceReference)Link.DeepCopy();
        return dest;
      }

      public override IDeepCopyable DeepCopy()
      {
        return CopyTo(new MediaComponent());
      }

      ///<inheritdoc />
      public override bool Matches(IDeepComparable other)
      {
        var otherT = other as MediaComponent;
        if(otherT == null) return false;

        if(!base.Matches(otherT)) return false;
        if( !DeepComparable.Matches(CommentElement, otherT.CommentElement)) return false;
        if( !DeepComparable.Matches(Link, otherT.Link)) return false;

        return true;
      }

      public override bool IsExactly(IDeepComparable other)
      {
        var otherT = other as MediaComponent;
        if(otherT == null) return false;

        if(!base.IsExactly(otherT)) return false;
        if( !DeepComparable.IsExactly(CommentElement, otherT.CommentElement)) return false;
        if( !DeepComparable.IsExactly(Link, otherT.Link)) return false;

        return true;
      }

      [IgnoreDataMember]
      public override IEnumerable<Base> Children
      {
        get
        {
          foreach (var item in base.Children) yield return item;
          if (CommentElement != null) yield return CommentElement;
          if (Link != null) yield return Link;
        }
      }

      [IgnoreDataMember]
      public override IEnumerable<ElementValue> NamedChildren
      {
        get
        {
          foreach (var item in base.NamedChildren) yield return item;
          if (CommentElement != null) yield return new ElementValue("comment", CommentElement);
          if (Link != null) yield return new ElementValue("link", Link);
        }
      }

      protected override bool TryGetValue(string key, out object value)
      {
        switch (key)
        {
          case "comment":
            value = CommentElement;
            return CommentElement is not null;
          case "link":
            value = Link;
            return Link is not null;
          default:
            return base.TryGetValue(key, out value);
        }

      }

      protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
      {
        foreach (var kvp in base.GetElementPairs()) yield return kvp;
        if (CommentElement is not null) yield return new KeyValuePair<string,object>("comment",CommentElement);
        if (Link is not null) yield return new KeyValuePair<string,object>("link",Link);
      }

    }

    /// <summary>
    /// Business identifier for report
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
    /// What was requested
    /// </summary>
    [FhirElement("basedOn", Order=100)]
    [CLSCompliant(false)]
    [References("CarePlan","ImmunizationRecommendation","MedicationRequest","NutritionOrder","ServiceRequest")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.ResourceReference> BasedOn
    {
      get { if(_BasedOn==null) _BasedOn = new List<Hl7.Fhir.Model.ResourceReference>(); return _BasedOn; }
      set { _BasedOn = value; OnPropertyChanged("BasedOn"); }
    }

    private List<Hl7.Fhir.Model.ResourceReference> _BasedOn;

    /// <summary>
    /// registered | partial | preliminary | final +
    /// </summary>
    [FhirElement("status", InSummary=true, IsModifier=true, Order=110, FiveWs="FiveWs.status")]
    [DeclaredType(Type = typeof(Code))]
    [Binding("DiagnosticReportStatus")]
    [Cardinality(Min=1,Max=1)]
    [DataMember]
    public Code<Hl7.Fhir.Model.DiagnosticReport.DiagnosticReportStatus> StatusElement
    {
      get { return _StatusElement; }
      set { _StatusElement = value; OnPropertyChanged("StatusElement"); }
    }

    private Code<Hl7.Fhir.Model.DiagnosticReport.DiagnosticReportStatus> _StatusElement;

    /// <summary>
    /// registered | partial | preliminary | final +
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public Hl7.Fhir.Model.DiagnosticReport.DiagnosticReportStatus? Status
    {
      get { return StatusElement != null ? StatusElement.Value : null; }
      set
      {
        if (value == null)
          StatusElement = null;
        else
          StatusElement = new Code<Hl7.Fhir.Model.DiagnosticReport.DiagnosticReportStatus>(value);
        OnPropertyChanged("Status");
      }
    }

    /// <summary>
    /// Service category
    /// </summary>
    [FhirElement("category", InSummary=true, Order=120, FiveWs="FiveWs.class")]
    [Binding("DiagnosticServiceSection")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.CodeableConcept> Category
    {
      get { if(_Category==null) _Category = new List<Hl7.Fhir.Model.CodeableConcept>(); return _Category; }
      set { _Category = value; OnPropertyChanged("Category"); }
    }

    private List<Hl7.Fhir.Model.CodeableConcept> _Category;

    /// <summary>
    /// Name/Code for this diagnostic report
    /// </summary>
    [FhirElement("code", InSummary=true, Order=130, FiveWs="FiveWs.what[x]")]
    [Binding("DiagnosticReportCodes")]
    [Cardinality(Min=1,Max=1)]
    [DataMember]
    public Hl7.Fhir.Model.CodeableConcept Code
    {
      get { return _Code; }
      set { _Code = value; OnPropertyChanged("Code"); }
    }

    private Hl7.Fhir.Model.CodeableConcept _Code;

    /// <summary>
    /// The subject of the report - usually, but not always, the patient
    /// </summary>
    [FhirElement("subject", InSummary=true, Order=140, FiveWs="FiveWs.subject")]
    [CLSCompliant(false)]
    [References("Patient","Group","Device","Location","Organization","Procedure","Practitioner","Medication","Substance")]
    [DataMember]
    public Hl7.Fhir.Model.ResourceReference Subject
    {
      get { return _Subject; }
      set { _Subject = value; OnPropertyChanged("Subject"); }
    }

    private Hl7.Fhir.Model.ResourceReference _Subject;

    /// <summary>
    /// Health care event when test ordered
    /// </summary>
    [FhirElement("encounter", InSummary=true, Order=150, FiveWs="FiveWs.context")]
    [CLSCompliant(false)]
    [References("Encounter")]
    [DataMember]
    public Hl7.Fhir.Model.ResourceReference Encounter
    {
      get { return _Encounter; }
      set { _Encounter = value; OnPropertyChanged("Encounter"); }
    }

    private Hl7.Fhir.Model.ResourceReference _Encounter;

    /// <summary>
    /// Clinically relevant time/time-period for report
    /// </summary>
    [FhirElement("effective", InSummary=true, Order=160, Choice=ChoiceType.DatatypeChoice, FiveWs="FiveWs.done[x]")]
    [CLSCompliant(false)]
    [AllowedTypes(typeof(Hl7.Fhir.Model.FhirDateTime),typeof(Hl7.Fhir.Model.Period))]
    [DataMember]
    public Hl7.Fhir.Model.DataType Effective
    {
      get { return _Effective; }
      set { _Effective = value; OnPropertyChanged("Effective"); }
    }

    private Hl7.Fhir.Model.DataType _Effective;

    /// <summary>
    /// DateTime this version was made
    /// </summary>
    [FhirElement("issued", InSummary=true, Order=170, FiveWs="FiveWs.recorded")]
    [DataMember]
    public Hl7.Fhir.Model.Instant IssuedElement
    {
      get { return _IssuedElement; }
      set { _IssuedElement = value; OnPropertyChanged("IssuedElement"); }
    }

    private Hl7.Fhir.Model.Instant _IssuedElement;

    /// <summary>
    /// DateTime this version was made
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public DateTimeOffset? Issued
    {
      get { return IssuedElement != null ? IssuedElement.Value : null; }
      set
      {
        if (value == null)
          IssuedElement = null;
        else
          IssuedElement = new Hl7.Fhir.Model.Instant(value);
        OnPropertyChanged("Issued");
      }
    }

    /// <summary>
    /// Responsible Diagnostic Service
    /// </summary>
    [FhirElement("performer", InSummary=true, Order=180, FiveWs="FiveWs.actor")]
    [CLSCompliant(false)]
    [References("Practitioner","PractitionerRole","Organization","CareTeam")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.ResourceReference> Performer
    {
      get { if(_Performer==null) _Performer = new List<Hl7.Fhir.Model.ResourceReference>(); return _Performer; }
      set { _Performer = value; OnPropertyChanged("Performer"); }
    }

    private List<Hl7.Fhir.Model.ResourceReference> _Performer;

    /// <summary>
    /// Primary result interpreter
    /// </summary>
    [FhirElement("resultsInterpreter", InSummary=true, Order=190, FiveWs="FiveWs.actor")]
    [CLSCompliant(false)]
    [References("Practitioner","PractitionerRole","Organization","CareTeam")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.ResourceReference> ResultsInterpreter
    {
      get { if(_ResultsInterpreter==null) _ResultsInterpreter = new List<Hl7.Fhir.Model.ResourceReference>(); return _ResultsInterpreter; }
      set { _ResultsInterpreter = value; OnPropertyChanged("ResultsInterpreter"); }
    }

    private List<Hl7.Fhir.Model.ResourceReference> _ResultsInterpreter;

    /// <summary>
    /// Specimens this report is based on
    /// </summary>
    [FhirElement("specimen", Order=200)]
    [CLSCompliant(false)]
    [References("Specimen")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.ResourceReference> Specimen
    {
      get { if(_Specimen==null) _Specimen = new List<Hl7.Fhir.Model.ResourceReference>(); return _Specimen; }
      set { _Specimen = value; OnPropertyChanged("Specimen"); }
    }

    private List<Hl7.Fhir.Model.ResourceReference> _Specimen;

    /// <summary>
    /// Observations
    /// </summary>
    [FhirElement("result", Order=210)]
    [CLSCompliant(false)]
    [References("Observation")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.ResourceReference> Result
    {
      get { if(_Result==null) _Result = new List<Hl7.Fhir.Model.ResourceReference>(); return _Result; }
      set { _Result = value; OnPropertyChanged("Result"); }
    }

    private List<Hl7.Fhir.Model.ResourceReference> _Result;

    /// <summary>
    /// Reference to full details of imaging associated with the diagnostic report
    /// </summary>
    [FhirElement("imagingStudy", Order=220)]
    [CLSCompliant(false)]
    [References("ImagingStudy")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.ResourceReference> ImagingStudy
    {
      get { if(_ImagingStudy==null) _ImagingStudy = new List<Hl7.Fhir.Model.ResourceReference>(); return _ImagingStudy; }
      set { _ImagingStudy = value; OnPropertyChanged("ImagingStudy"); }
    }

    private List<Hl7.Fhir.Model.ResourceReference> _ImagingStudy;

    /// <summary>
    /// Key images associated with this report
    /// </summary>
    [FhirElement("media", InSummary=true, Order=230)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.DiagnosticReport.MediaComponent> Media
    {
      get { if(_Media==null) _Media = new List<Hl7.Fhir.Model.DiagnosticReport.MediaComponent>(); return _Media; }
      set { _Media = value; OnPropertyChanged("Media"); }
    }

    private List<Hl7.Fhir.Model.DiagnosticReport.MediaComponent> _Media;

    /// <summary>
    /// Clinical conclusion (interpretation) of test results
    /// </summary>
    [FhirElement("conclusion", Order=240)]
    [DataMember]
    public Hl7.Fhir.Model.FhirString ConclusionElement
    {
      get { return _ConclusionElement; }
      set { _ConclusionElement = value; OnPropertyChanged("ConclusionElement"); }
    }

    private Hl7.Fhir.Model.FhirString _ConclusionElement;

    /// <summary>
    /// Clinical conclusion (interpretation) of test results
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string Conclusion
    {
      get { return ConclusionElement != null ? ConclusionElement.Value : null; }
      set
      {
        if (value == null)
          ConclusionElement = null;
        else
          ConclusionElement = new Hl7.Fhir.Model.FhirString(value);
        OnPropertyChanged("Conclusion");
      }
    }

    /// <summary>
    /// Codes for the clinical conclusion of test results
    /// </summary>
    [FhirElement("conclusionCode", Order=250)]
    [Binding("AdjunctDiagnosis")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.CodeableConcept> ConclusionCode
    {
      get { if(_ConclusionCode==null) _ConclusionCode = new List<Hl7.Fhir.Model.CodeableConcept>(); return _ConclusionCode; }
      set { _ConclusionCode = value; OnPropertyChanged("ConclusionCode"); }
    }

    private List<Hl7.Fhir.Model.CodeableConcept> _ConclusionCode;

    /// <summary>
    /// Entire report as issued
    /// </summary>
    [FhirElement("presentedForm", Order=260)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.Attachment> PresentedForm
    {
      get { if(_PresentedForm==null) _PresentedForm = new List<Hl7.Fhir.Model.Attachment>(); return _PresentedForm; }
      set { _PresentedForm = value; OnPropertyChanged("PresentedForm"); }
    }

    private List<Hl7.Fhir.Model.Attachment> _PresentedForm;

    List<Identifier> IIdentifiable<List<Identifier>>.Identifier { get => Identifier; set => Identifier = value; }

    public override IDeepCopyable CopyTo(IDeepCopyable other)
    {
      var dest = other as DiagnosticReport;

      if (dest == null)
      {
        throw new ArgumentException("Can only copy to an object of the same type", "other");
      }

      base.CopyTo(dest);
      if(Identifier.Any()) dest.Identifier = new List<Hl7.Fhir.Model.Identifier>(Identifier.DeepCopy());
      if(BasedOn.Any()) dest.BasedOn = new List<Hl7.Fhir.Model.ResourceReference>(BasedOn.DeepCopy());
      if(StatusElement != null) dest.StatusElement = (Code<Hl7.Fhir.Model.DiagnosticReport.DiagnosticReportStatus>)StatusElement.DeepCopy();
      if(Category.Any()) dest.Category = new List<Hl7.Fhir.Model.CodeableConcept>(Category.DeepCopy());
      if(Code != null) dest.Code = (Hl7.Fhir.Model.CodeableConcept)Code.DeepCopy();
      if(Subject != null) dest.Subject = (Hl7.Fhir.Model.ResourceReference)Subject.DeepCopy();
      if(Encounter != null) dest.Encounter = (Hl7.Fhir.Model.ResourceReference)Encounter.DeepCopy();
      if(Effective != null) dest.Effective = (Hl7.Fhir.Model.DataType)Effective.DeepCopy();
      if(IssuedElement != null) dest.IssuedElement = (Hl7.Fhir.Model.Instant)IssuedElement.DeepCopy();
      if(Performer.Any()) dest.Performer = new List<Hl7.Fhir.Model.ResourceReference>(Performer.DeepCopy());
      if(ResultsInterpreter.Any()) dest.ResultsInterpreter = new List<Hl7.Fhir.Model.ResourceReference>(ResultsInterpreter.DeepCopy());
      if(Specimen.Any()) dest.Specimen = new List<Hl7.Fhir.Model.ResourceReference>(Specimen.DeepCopy());
      if(Result.Any()) dest.Result = new List<Hl7.Fhir.Model.ResourceReference>(Result.DeepCopy());
      if(ImagingStudy.Any()) dest.ImagingStudy = new List<Hl7.Fhir.Model.ResourceReference>(ImagingStudy.DeepCopy());
      if(Media.Any()) dest.Media = new List<Hl7.Fhir.Model.DiagnosticReport.MediaComponent>(Media.DeepCopy());
      if(ConclusionElement != null) dest.ConclusionElement = (Hl7.Fhir.Model.FhirString)ConclusionElement.DeepCopy();
      if(ConclusionCode.Any()) dest.ConclusionCode = new List<Hl7.Fhir.Model.CodeableConcept>(ConclusionCode.DeepCopy());
      if(PresentedForm.Any()) dest.PresentedForm = new List<Hl7.Fhir.Model.Attachment>(PresentedForm.DeepCopy());
      return dest;
    }

    public override IDeepCopyable DeepCopy()
    {
      return CopyTo(new DiagnosticReport());
    }

    ///<inheritdoc />
    public override bool Matches(IDeepComparable other)
    {
      var otherT = other as DiagnosticReport;
      if(otherT == null) return false;

      if(!base.Matches(otherT)) return false;
      if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
      if( !DeepComparable.Matches(BasedOn, otherT.BasedOn)) return false;
      if( !DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
      if( !DeepComparable.Matches(Category, otherT.Category)) return false;
      if( !DeepComparable.Matches(Code, otherT.Code)) return false;
      if( !DeepComparable.Matches(Subject, otherT.Subject)) return false;
      if( !DeepComparable.Matches(Encounter, otherT.Encounter)) return false;
      if( !DeepComparable.Matches(Effective, otherT.Effective)) return false;
      if( !DeepComparable.Matches(IssuedElement, otherT.IssuedElement)) return false;
      if( !DeepComparable.Matches(Performer, otherT.Performer)) return false;
      if( !DeepComparable.Matches(ResultsInterpreter, otherT.ResultsInterpreter)) return false;
      if( !DeepComparable.Matches(Specimen, otherT.Specimen)) return false;
      if( !DeepComparable.Matches(Result, otherT.Result)) return false;
      if( !DeepComparable.Matches(ImagingStudy, otherT.ImagingStudy)) return false;
      if( !DeepComparable.Matches(Media, otherT.Media)) return false;
      if( !DeepComparable.Matches(ConclusionElement, otherT.ConclusionElement)) return false;
      if( !DeepComparable.Matches(ConclusionCode, otherT.ConclusionCode)) return false;
      if( !DeepComparable.Matches(PresentedForm, otherT.PresentedForm)) return false;

      return true;
    }

    public override bool IsExactly(IDeepComparable other)
    {
      var otherT = other as DiagnosticReport;
      if(otherT == null) return false;

      if(!base.IsExactly(otherT)) return false;
      if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
      if( !DeepComparable.IsExactly(BasedOn, otherT.BasedOn)) return false;
      if( !DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
      if( !DeepComparable.IsExactly(Category, otherT.Category)) return false;
      if( !DeepComparable.IsExactly(Code, otherT.Code)) return false;
      if( !DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
      if( !DeepComparable.IsExactly(Encounter, otherT.Encounter)) return false;
      if( !DeepComparable.IsExactly(Effective, otherT.Effective)) return false;
      if( !DeepComparable.IsExactly(IssuedElement, otherT.IssuedElement)) return false;
      if( !DeepComparable.IsExactly(Performer, otherT.Performer)) return false;
      if( !DeepComparable.IsExactly(ResultsInterpreter, otherT.ResultsInterpreter)) return false;
      if( !DeepComparable.IsExactly(Specimen, otherT.Specimen)) return false;
      if( !DeepComparable.IsExactly(Result, otherT.Result)) return false;
      if( !DeepComparable.IsExactly(ImagingStudy, otherT.ImagingStudy)) return false;
      if( !DeepComparable.IsExactly(Media, otherT.Media)) return false;
      if( !DeepComparable.IsExactly(ConclusionElement, otherT.ConclusionElement)) return false;
      if( !DeepComparable.IsExactly(ConclusionCode, otherT.ConclusionCode)) return false;
      if( !DeepComparable.IsExactly(PresentedForm, otherT.PresentedForm)) return false;

      return true;
    }

    [IgnoreDataMember]
    public override IEnumerable<Base> Children
    {
      get
      {
        foreach (var item in base.Children) yield return item;
        foreach (var elem in Identifier) { if (elem != null) yield return elem; }
        foreach (var elem in BasedOn) { if (elem != null) yield return elem; }
        if (StatusElement != null) yield return StatusElement;
        foreach (var elem in Category) { if (elem != null) yield return elem; }
        if (Code != null) yield return Code;
        if (Subject != null) yield return Subject;
        if (Encounter != null) yield return Encounter;
        if (Effective != null) yield return Effective;
        if (IssuedElement != null) yield return IssuedElement;
        foreach (var elem in Performer) { if (elem != null) yield return elem; }
        foreach (var elem in ResultsInterpreter) { if (elem != null) yield return elem; }
        foreach (var elem in Specimen) { if (elem != null) yield return elem; }
        foreach (var elem in Result) { if (elem != null) yield return elem; }
        foreach (var elem in ImagingStudy) { if (elem != null) yield return elem; }
        foreach (var elem in Media) { if (elem != null) yield return elem; }
        if (ConclusionElement != null) yield return ConclusionElement;
        foreach (var elem in ConclusionCode) { if (elem != null) yield return elem; }
        foreach (var elem in PresentedForm) { if (elem != null) yield return elem; }
      }
    }

    [IgnoreDataMember]
    public override IEnumerable<ElementValue> NamedChildren
    {
      get
      {
        foreach (var item in base.NamedChildren) yield return item;
        foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
        foreach (var elem in BasedOn) { if (elem != null) yield return new ElementValue("basedOn", elem); }
        if (StatusElement != null) yield return new ElementValue("status", StatusElement);
        foreach (var elem in Category) { if (elem != null) yield return new ElementValue("category", elem); }
        if (Code != null) yield return new ElementValue("code", Code);
        if (Subject != null) yield return new ElementValue("subject", Subject);
        if (Encounter != null) yield return new ElementValue("encounter", Encounter);
        if (Effective != null) yield return new ElementValue("effective", Effective);
        if (IssuedElement != null) yield return new ElementValue("issued", IssuedElement);
        foreach (var elem in Performer) { if (elem != null) yield return new ElementValue("performer", elem); }
        foreach (var elem in ResultsInterpreter) { if (elem != null) yield return new ElementValue("resultsInterpreter", elem); }
        foreach (var elem in Specimen) { if (elem != null) yield return new ElementValue("specimen", elem); }
        foreach (var elem in Result) { if (elem != null) yield return new ElementValue("result", elem); }
        foreach (var elem in ImagingStudy) { if (elem != null) yield return new ElementValue("imagingStudy", elem); }
        foreach (var elem in Media) { if (elem != null) yield return new ElementValue("media", elem); }
        if (ConclusionElement != null) yield return new ElementValue("conclusion", ConclusionElement);
        foreach (var elem in ConclusionCode) { if (elem != null) yield return new ElementValue("conclusionCode", elem); }
        foreach (var elem in PresentedForm) { if (elem != null) yield return new ElementValue("presentedForm", elem); }
      }
    }

    protected override bool TryGetValue(string key, out object value)
    {
      switch (key)
      {
        case "identifier":
          value = Identifier;
          return Identifier?.Any() == true;
        case "basedOn":
          value = BasedOn;
          return BasedOn?.Any() == true;
        case "status":
          value = StatusElement;
          return StatusElement is not null;
        case "category":
          value = Category;
          return Category?.Any() == true;
        case "code":
          value = Code;
          return Code is not null;
        case "subject":
          value = Subject;
          return Subject is not null;
        case "encounter":
          value = Encounter;
          return Encounter is not null;
        case "effective":
          value = Effective;
          return Effective is not null;
        case "issued":
          value = IssuedElement;
          return IssuedElement is not null;
        case "performer":
          value = Performer;
          return Performer?.Any() == true;
        case "resultsInterpreter":
          value = ResultsInterpreter;
          return ResultsInterpreter?.Any() == true;
        case "specimen":
          value = Specimen;
          return Specimen?.Any() == true;
        case "result":
          value = Result;
          return Result?.Any() == true;
        case "imagingStudy":
          value = ImagingStudy;
          return ImagingStudy?.Any() == true;
        case "media":
          value = Media;
          return Media?.Any() == true;
        case "conclusion":
          value = ConclusionElement;
          return ConclusionElement is not null;
        case "conclusionCode":
          value = ConclusionCode;
          return ConclusionCode?.Any() == true;
        case "presentedForm":
          value = PresentedForm;
          return PresentedForm?.Any() == true;
        default:
          return base.TryGetValue(key, out value);
      }

    }

    protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
    {
      foreach (var kvp in base.GetElementPairs()) yield return kvp;
      if (Identifier?.Any() == true) yield return new KeyValuePair<string,object>("identifier",Identifier);
      if (BasedOn?.Any() == true) yield return new KeyValuePair<string,object>("basedOn",BasedOn);
      if (StatusElement is not null) yield return new KeyValuePair<string,object>("status",StatusElement);
      if (Category?.Any() == true) yield return new KeyValuePair<string,object>("category",Category);
      if (Code is not null) yield return new KeyValuePair<string,object>("code",Code);
      if (Subject is not null) yield return new KeyValuePair<string,object>("subject",Subject);
      if (Encounter is not null) yield return new KeyValuePair<string,object>("encounter",Encounter);
      if (Effective is not null) yield return new KeyValuePair<string,object>("effective",Effective);
      if (IssuedElement is not null) yield return new KeyValuePair<string,object>("issued",IssuedElement);
      if (Performer?.Any() == true) yield return new KeyValuePair<string,object>("performer",Performer);
      if (ResultsInterpreter?.Any() == true) yield return new KeyValuePair<string,object>("resultsInterpreter",ResultsInterpreter);
      if (Specimen?.Any() == true) yield return new KeyValuePair<string,object>("specimen",Specimen);
      if (Result?.Any() == true) yield return new KeyValuePair<string,object>("result",Result);
      if (ImagingStudy?.Any() == true) yield return new KeyValuePair<string,object>("imagingStudy",ImagingStudy);
      if (Media?.Any() == true) yield return new KeyValuePair<string,object>("media",Media);
      if (ConclusionElement is not null) yield return new KeyValuePair<string,object>("conclusion",ConclusionElement);
      if (ConclusionCode?.Any() == true) yield return new KeyValuePair<string,object>("conclusionCode",ConclusionCode);
      if (PresentedForm?.Any() == true) yield return new KeyValuePair<string,object>("presentedForm",PresentedForm);
    }

  }

}

// end of file
