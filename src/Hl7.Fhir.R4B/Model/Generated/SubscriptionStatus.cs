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
  /// Status information about a Subscription provided during event notification
  /// </summary>
  /// <remarks>
  /// The SubscriptionStatus resource describes the state of a Subscription during notifications.
  /// </remarks>
  [Serializable]
  [DataContract]
  [FhirType("SubscriptionStatus","http://hl7.org/fhir/StructureDefinition/SubscriptionStatus", IsResource=true)]
  public partial class SubscriptionStatus : Hl7.Fhir.Model.DomainResource
  {
    /// <summary>
    /// FHIR Type Name
    /// </summary>
    public override string TypeName { get { return "SubscriptionStatus"; } }

    /// <summary>
    /// The type of notification represented by the status message.
    /// (url: http://hl7.org/fhir/ValueSet/subscription-notification-type)
    /// (system: http://hl7.org/fhir/subscription-notification-type)
    /// </summary>
    [FhirEnumeration("SubscriptionNotificationType", "http://hl7.org/fhir/ValueSet/subscription-notification-type", "http://hl7.org/fhir/subscription-notification-type")]
    public enum SubscriptionNotificationType
    {
      /// <summary>
      /// The status was generated as part of the setup or verification of a communications channel.
      /// (system: http://hl7.org/fhir/subscription-notification-type)
      /// </summary>
      [EnumLiteral("handshake"), Description("Handshake")]
      Handshake,
      /// <summary>
      /// The status was generated to perform a heartbeat notification to the subscriber.
      /// (system: http://hl7.org/fhir/subscription-notification-type)
      /// </summary>
      [EnumLiteral("heartbeat"), Description("Heartbeat")]
      Heartbeat,
      /// <summary>
      /// The status was generated for an event to the subscriber.
      /// (system: http://hl7.org/fhir/subscription-notification-type)
      /// </summary>
      [EnumLiteral("event-notification"), Description("Event Notification")]
      EventNotification,
      /// <summary>
      /// The status was generated in response to a status query/request.
      /// (system: http://hl7.org/fhir/subscription-notification-type)
      /// </summary>
      [EnumLiteral("query-status"), Description("Query Status")]
      QueryStatus,
      /// <summary>
      /// The status was generated in response to an event query/request.
      /// (system: http://hl7.org/fhir/subscription-notification-type)
      /// </summary>
      [EnumLiteral("query-event"), Description("Query Event")]
      QueryEvent,
    }

    /// <summary>
    /// Detailed information about any events relevant to this notification
    /// </summary>
    /// <remarks>
    /// Detailed information about events relevant to this subscription notification.
    /// </remarks>
    [Serializable]
    [DataContract]
    [FhirType("SubscriptionStatus#NotificationEvent", IsNestedType=true)]
    [BackboneType("SubscriptionStatus.notificationEvent")]
    public partial class NotificationEventComponent : Hl7.Fhir.Model.BackboneElement
    {
      /// <summary>
      /// FHIR Type Name
      /// </summary>
      public override string TypeName { get { return "SubscriptionStatus#NotificationEvent"; } }

      /// <summary>
      /// Event number
      /// </summary>
      [FhirElement("eventNumber", Order=40)]
      [Cardinality(Min=1,Max=1)]
      [DataMember]
      public Hl7.Fhir.Model.FhirString EventNumberElement
      {
        get { return _EventNumberElement; }
        set { _EventNumberElement = value; OnPropertyChanged("EventNumberElement"); }
      }

      private Hl7.Fhir.Model.FhirString _EventNumberElement;

      /// <summary>
      /// Event number
      /// </summary>
      /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
      [IgnoreDataMember]
      public string EventNumber
      {
        get { return EventNumberElement != null ? EventNumberElement.Value : null; }
        set
        {
          if (value == null)
            EventNumberElement = null;
          else
            EventNumberElement = new Hl7.Fhir.Model.FhirString(value);
          OnPropertyChanged("EventNumber");
        }
      }

      /// <summary>
      /// The instant this event occurred
      /// </summary>
      [FhirElement("timestamp", Order=50)]
      [DataMember]
      public Hl7.Fhir.Model.Instant TimestampElement
      {
        get { return _TimestampElement; }
        set { _TimestampElement = value; OnPropertyChanged("TimestampElement"); }
      }

      private Hl7.Fhir.Model.Instant _TimestampElement;

      /// <summary>
      /// The instant this event occurred
      /// </summary>
      /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
      [IgnoreDataMember]
      public DateTimeOffset? Timestamp
      {
        get { return TimestampElement != null ? TimestampElement.Value : null; }
        set
        {
          if (value == null)
            TimestampElement = null;
          else
            TimestampElement = new Hl7.Fhir.Model.Instant(value);
          OnPropertyChanged("Timestamp");
        }
      }

      /// <summary>
      /// The focus of this event
      /// </summary>
      [FhirElement("focus", Order=60)]
      [CLSCompliant(false)]
      [References("Resource")]
      [DataMember]
      public Hl7.Fhir.Model.ResourceReference Focus
      {
        get { return _Focus; }
        set { _Focus = value; OnPropertyChanged("Focus"); }
      }

      private Hl7.Fhir.Model.ResourceReference _Focus;

      /// <summary>
      /// Additional context for this event
      /// </summary>
      [FhirElement("additionalContext", Order=70)]
      [CLSCompliant(false)]
      [References("Resource")]
      [Cardinality(Min=0,Max=-1)]
      [DataMember]
      public List<Hl7.Fhir.Model.ResourceReference> AdditionalContext
      {
        get { if(_AdditionalContext==null) _AdditionalContext = new List<Hl7.Fhir.Model.ResourceReference>(); return _AdditionalContext; }
        set { _AdditionalContext = value; OnPropertyChanged("AdditionalContext"); }
      }

      private List<Hl7.Fhir.Model.ResourceReference> _AdditionalContext;

      public override IDeepCopyable CopyTo(IDeepCopyable other)
      {
        var dest = other as NotificationEventComponent;

        if (dest == null)
        {
          throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        base.CopyTo(dest);
        if(EventNumberElement != null) dest.EventNumberElement = (Hl7.Fhir.Model.FhirString)EventNumberElement.DeepCopy();
        if(TimestampElement != null) dest.TimestampElement = (Hl7.Fhir.Model.Instant)TimestampElement.DeepCopy();
        if(Focus != null) dest.Focus = (Hl7.Fhir.Model.ResourceReference)Focus.DeepCopy();
        if(AdditionalContext.Any()) dest.AdditionalContext = new List<Hl7.Fhir.Model.ResourceReference>(AdditionalContext.DeepCopy());
        return dest;
      }

      public override IDeepCopyable DeepCopy()
      {
        return CopyTo(new NotificationEventComponent());
      }

      ///<inheritdoc />
      public override bool Matches(IDeepComparable other)
      {
        var otherT = other as NotificationEventComponent;
        if(otherT == null) return false;

        if(!base.Matches(otherT)) return false;
        if( !DeepComparable.Matches(EventNumberElement, otherT.EventNumberElement)) return false;
        if( !DeepComparable.Matches(TimestampElement, otherT.TimestampElement)) return false;
        if( !DeepComparable.Matches(Focus, otherT.Focus)) return false;
        if( !DeepComparable.Matches(AdditionalContext, otherT.AdditionalContext)) return false;

        return true;
      }

      public override bool IsExactly(IDeepComparable other)
      {
        var otherT = other as NotificationEventComponent;
        if(otherT == null) return false;

        if(!base.IsExactly(otherT)) return false;
        if( !DeepComparable.IsExactly(EventNumberElement, otherT.EventNumberElement)) return false;
        if( !DeepComparable.IsExactly(TimestampElement, otherT.TimestampElement)) return false;
        if( !DeepComparable.IsExactly(Focus, otherT.Focus)) return false;
        if( !DeepComparable.IsExactly(AdditionalContext, otherT.AdditionalContext)) return false;

        return true;
      }

      [IgnoreDataMember]
      public override IEnumerable<Base> Children
      {
        get
        {
          foreach (var item in base.Children) yield return item;
          if (EventNumberElement != null) yield return EventNumberElement;
          if (TimestampElement != null) yield return TimestampElement;
          if (Focus != null) yield return Focus;
          foreach (var elem in AdditionalContext) { if (elem != null) yield return elem; }
        }
      }

      [IgnoreDataMember]
      public override IEnumerable<ElementValue> NamedChildren
      {
        get
        {
          foreach (var item in base.NamedChildren) yield return item;
          if (EventNumberElement != null) yield return new ElementValue("eventNumber", EventNumberElement);
          if (TimestampElement != null) yield return new ElementValue("timestamp", TimestampElement);
          if (Focus != null) yield return new ElementValue("focus", Focus);
          foreach (var elem in AdditionalContext) { if (elem != null) yield return new ElementValue("additionalContext", elem); }
        }
      }

      protected override bool TryGetValue(string key, out object value)
      {
        switch (key)
        {
          case "eventNumber":
            value = EventNumberElement;
            return EventNumberElement is not null;
          case "timestamp":
            value = TimestampElement;
            return TimestampElement is not null;
          case "focus":
            value = Focus;
            return Focus is not null;
          case "additionalContext":
            value = AdditionalContext;
            return AdditionalContext?.Any() == true;
          default:
            return base.TryGetValue(key, out value);
        }

      }

      protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
      {
        foreach (var kvp in base.GetElementPairs()) yield return kvp;
        if (EventNumberElement is not null) yield return new KeyValuePair<string,object>("eventNumber",EventNumberElement);
        if (TimestampElement is not null) yield return new KeyValuePair<string,object>("timestamp",TimestampElement);
        if (Focus is not null) yield return new KeyValuePair<string,object>("focus",Focus);
        if (AdditionalContext?.Any() == true) yield return new KeyValuePair<string,object>("additionalContext",AdditionalContext);
      }

    }

    /// <summary>
    /// requested | active | error | off | entered-in-error
    /// </summary>
    [FhirElement("status", InSummary=true, Order=90, FiveWs="FiveWs.status")]
    [DeclaredType(Type = typeof(Code))]
    [Binding("SubscriptionStatus")]
    [DataMember]
    public Code<Hl7.Fhir.Model.SubscriptionStatusCodes> StatusElement
    {
      get { return _StatusElement; }
      set { _StatusElement = value; OnPropertyChanged("StatusElement"); }
    }

    private Code<Hl7.Fhir.Model.SubscriptionStatusCodes> _StatusElement;

    /// <summary>
    /// requested | active | error | off | entered-in-error
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public Hl7.Fhir.Model.SubscriptionStatusCodes? Status
    {
      get { return StatusElement != null ? StatusElement.Value : null; }
      set
      {
        if (value == null)
          StatusElement = null;
        else
          StatusElement = new Code<Hl7.Fhir.Model.SubscriptionStatusCodes>(value);
        OnPropertyChanged("Status");
      }
    }

    /// <summary>
    /// handshake | heartbeat | event-notification | query-status | query-event
    /// </summary>
    [FhirElement("type", InSummary=true, IsModifier=true, Order=100, FiveWs="FiveWs.what[x]")]
    [DeclaredType(Type = typeof(Code))]
    [Binding("SubscriptionNotificationType")]
    [Cardinality(Min=1,Max=1)]
    [DataMember]
    public Code<Hl7.Fhir.Model.SubscriptionStatus.SubscriptionNotificationType> TypeElement
    {
      get { return _TypeElement; }
      set { _TypeElement = value; OnPropertyChanged("TypeElement"); }
    }

    private Code<Hl7.Fhir.Model.SubscriptionStatus.SubscriptionNotificationType> _TypeElement;

    /// <summary>
    /// handshake | heartbeat | event-notification | query-status | query-event
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public Hl7.Fhir.Model.SubscriptionStatus.SubscriptionNotificationType? Type
    {
      get { return TypeElement != null ? TypeElement.Value : null; }
      set
      {
        if (value == null)
          TypeElement = null;
        else
          TypeElement = new Code<Hl7.Fhir.Model.SubscriptionStatus.SubscriptionNotificationType>(value);
        OnPropertyChanged("Type");
      }
    }

    /// <summary>
    /// Events since the Subscription was created
    /// </summary>
    [FhirElement("eventsSinceSubscriptionStart", InSummary=true, Order=110)]
    [DataMember]
    public Hl7.Fhir.Model.FhirString EventsSinceSubscriptionStartElement
    {
      get { return _EventsSinceSubscriptionStartElement; }
      set { _EventsSinceSubscriptionStartElement = value; OnPropertyChanged("EventsSinceSubscriptionStartElement"); }
    }

    private Hl7.Fhir.Model.FhirString _EventsSinceSubscriptionStartElement;

    /// <summary>
    /// Events since the Subscription was created
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string EventsSinceSubscriptionStart
    {
      get { return EventsSinceSubscriptionStartElement != null ? EventsSinceSubscriptionStartElement.Value : null; }
      set
      {
        if (value == null)
          EventsSinceSubscriptionStartElement = null;
        else
          EventsSinceSubscriptionStartElement = new Hl7.Fhir.Model.FhirString(value);
        OnPropertyChanged("EventsSinceSubscriptionStart");
      }
    }

    /// <summary>
    /// Detailed information about any events relevant to this notification
    /// </summary>
    [FhirElement("notificationEvent", Order=120)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.SubscriptionStatus.NotificationEventComponent> NotificationEvent
    {
      get { if(_NotificationEvent==null) _NotificationEvent = new List<Hl7.Fhir.Model.SubscriptionStatus.NotificationEventComponent>(); return _NotificationEvent; }
      set { _NotificationEvent = value; OnPropertyChanged("NotificationEvent"); }
    }

    private List<Hl7.Fhir.Model.SubscriptionStatus.NotificationEventComponent> _NotificationEvent;

    /// <summary>
    /// Reference to the Subscription responsible for this notification
    /// </summary>
    [FhirElement("subscription", InSummary=true, Order=130, FiveWs="FiveWs.why[x]")]
    [CLSCompliant(false)]
    [References("Subscription")]
    [Cardinality(Min=1,Max=1)]
    [DataMember]
    public Hl7.Fhir.Model.ResourceReference Subscription
    {
      get { return _Subscription; }
      set { _Subscription = value; OnPropertyChanged("Subscription"); }
    }

    private Hl7.Fhir.Model.ResourceReference _Subscription;

    /// <summary>
    /// Reference to the SubscriptionTopic this notification relates to
    /// </summary>
    [FhirElement("topic", InSummary=true, Order=140)]
    [DataMember]
    public Hl7.Fhir.Model.Canonical TopicElement
    {
      get { return _TopicElement; }
      set { _TopicElement = value; OnPropertyChanged("TopicElement"); }
    }

    private Hl7.Fhir.Model.Canonical _TopicElement;

    /// <summary>
    /// Reference to the SubscriptionTopic this notification relates to
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string Topic
    {
      get { return TopicElement != null ? TopicElement.Value : null; }
      set
      {
        if (value == null)
          TopicElement = null;
        else
          TopicElement = new Hl7.Fhir.Model.Canonical(value);
        OnPropertyChanged("Topic");
      }
    }

    /// <summary>
    /// List of errors on the subscription
    /// </summary>
    [FhirElement("error", InSummary=true, Order=150)]
    [Binding("SubscriptionError")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.CodeableConcept> Error
    {
      get { if(_Error==null) _Error = new List<Hl7.Fhir.Model.CodeableConcept>(); return _Error; }
      set { _Error = value; OnPropertyChanged("Error"); }
    }

    private List<Hl7.Fhir.Model.CodeableConcept> _Error;

    public override IDeepCopyable CopyTo(IDeepCopyable other)
    {
      var dest = other as SubscriptionStatus;

      if (dest == null)
      {
        throw new ArgumentException("Can only copy to an object of the same type", "other");
      }

      base.CopyTo(dest);
      if(StatusElement != null) dest.StatusElement = (Code<Hl7.Fhir.Model.SubscriptionStatusCodes>)StatusElement.DeepCopy();
      if(TypeElement != null) dest.TypeElement = (Code<Hl7.Fhir.Model.SubscriptionStatus.SubscriptionNotificationType>)TypeElement.DeepCopy();
      if(EventsSinceSubscriptionStartElement != null) dest.EventsSinceSubscriptionStartElement = (Hl7.Fhir.Model.FhirString)EventsSinceSubscriptionStartElement.DeepCopy();
      if(NotificationEvent.Any()) dest.NotificationEvent = new List<Hl7.Fhir.Model.SubscriptionStatus.NotificationEventComponent>(NotificationEvent.DeepCopy());
      if(Subscription != null) dest.Subscription = (Hl7.Fhir.Model.ResourceReference)Subscription.DeepCopy();
      if(TopicElement != null) dest.TopicElement = (Hl7.Fhir.Model.Canonical)TopicElement.DeepCopy();
      if(Error.Any()) dest.Error = new List<Hl7.Fhir.Model.CodeableConcept>(Error.DeepCopy());
      return dest;
    }

    public override IDeepCopyable DeepCopy()
    {
      return CopyTo(new SubscriptionStatus());
    }

    ///<inheritdoc />
    public override bool Matches(IDeepComparable other)
    {
      var otherT = other as SubscriptionStatus;
      if(otherT == null) return false;

      if(!base.Matches(otherT)) return false;
      if( !DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
      if( !DeepComparable.Matches(TypeElement, otherT.TypeElement)) return false;
      if( !DeepComparable.Matches(EventsSinceSubscriptionStartElement, otherT.EventsSinceSubscriptionStartElement)) return false;
      if( !DeepComparable.Matches(NotificationEvent, otherT.NotificationEvent)) return false;
      if( !DeepComparable.Matches(Subscription, otherT.Subscription)) return false;
      if( !DeepComparable.Matches(TopicElement, otherT.TopicElement)) return false;
      if( !DeepComparable.Matches(Error, otherT.Error)) return false;

      return true;
    }

    public override bool IsExactly(IDeepComparable other)
    {
      var otherT = other as SubscriptionStatus;
      if(otherT == null) return false;

      if(!base.IsExactly(otherT)) return false;
      if( !DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
      if( !DeepComparable.IsExactly(TypeElement, otherT.TypeElement)) return false;
      if( !DeepComparable.IsExactly(EventsSinceSubscriptionStartElement, otherT.EventsSinceSubscriptionStartElement)) return false;
      if( !DeepComparable.IsExactly(NotificationEvent, otherT.NotificationEvent)) return false;
      if( !DeepComparable.IsExactly(Subscription, otherT.Subscription)) return false;
      if( !DeepComparable.IsExactly(TopicElement, otherT.TopicElement)) return false;
      if( !DeepComparable.IsExactly(Error, otherT.Error)) return false;

      return true;
    }

    [IgnoreDataMember]
    public override IEnumerable<Base> Children
    {
      get
      {
        foreach (var item in base.Children) yield return item;
        if (StatusElement != null) yield return StatusElement;
        if (TypeElement != null) yield return TypeElement;
        if (EventsSinceSubscriptionStartElement != null) yield return EventsSinceSubscriptionStartElement;
        foreach (var elem in NotificationEvent) { if (elem != null) yield return elem; }
        if (Subscription != null) yield return Subscription;
        if (TopicElement != null) yield return TopicElement;
        foreach (var elem in Error) { if (elem != null) yield return elem; }
      }
    }

    [IgnoreDataMember]
    public override IEnumerable<ElementValue> NamedChildren
    {
      get
      {
        foreach (var item in base.NamedChildren) yield return item;
        if (StatusElement != null) yield return new ElementValue("status", StatusElement);
        if (TypeElement != null) yield return new ElementValue("type", TypeElement);
        if (EventsSinceSubscriptionStartElement != null) yield return new ElementValue("eventsSinceSubscriptionStart", EventsSinceSubscriptionStartElement);
        foreach (var elem in NotificationEvent) { if (elem != null) yield return new ElementValue("notificationEvent", elem); }
        if (Subscription != null) yield return new ElementValue("subscription", Subscription);
        if (TopicElement != null) yield return new ElementValue("topic", TopicElement);
        foreach (var elem in Error) { if (elem != null) yield return new ElementValue("error", elem); }
      }
    }

    protected override bool TryGetValue(string key, out object value)
    {
      switch (key)
      {
        case "status":
          value = StatusElement;
          return StatusElement is not null;
        case "type":
          value = TypeElement;
          return TypeElement is not null;
        case "eventsSinceSubscriptionStart":
          value = EventsSinceSubscriptionStartElement;
          return EventsSinceSubscriptionStartElement is not null;
        case "notificationEvent":
          value = NotificationEvent;
          return NotificationEvent?.Any() == true;
        case "subscription":
          value = Subscription;
          return Subscription is not null;
        case "topic":
          value = TopicElement;
          return TopicElement is not null;
        case "error":
          value = Error;
          return Error?.Any() == true;
        default:
          return base.TryGetValue(key, out value);
      }

    }

    protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
    {
      foreach (var kvp in base.GetElementPairs()) yield return kvp;
      if (StatusElement is not null) yield return new KeyValuePair<string,object>("status",StatusElement);
      if (TypeElement is not null) yield return new KeyValuePair<string,object>("type",TypeElement);
      if (EventsSinceSubscriptionStartElement is not null) yield return new KeyValuePair<string,object>("eventsSinceSubscriptionStart",EventsSinceSubscriptionStartElement);
      if (NotificationEvent?.Any() == true) yield return new KeyValuePair<string,object>("notificationEvent",NotificationEvent);
      if (Subscription is not null) yield return new KeyValuePair<string,object>("subscription",Subscription);
      if (TopicElement is not null) yield return new KeyValuePair<string,object>("topic",TopicElement);
      if (Error?.Any() == true) yield return new KeyValuePair<string,object>("error",Error);
    }

  }

}

// end of file
