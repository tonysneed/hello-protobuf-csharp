// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Weather/Weather.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HelloProtobufCSharp.v1.Models {

  /// <summary>Holder for reflection information generated from Weather/Weather.proto</summary>
  public static partial class WeatherReflection {

    #region Descriptor
    /// <summary>File descriptor for Weather/Weather.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static WeatherReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVXZWF0aGVyL1dlYXRoZXIucHJvdG8SB3dlYXRoZXIaH2dvb2dsZS9wcm90",
            "b2J1Zi90aW1lc3RhbXAucHJvdG8iZwoLV2VhdGhlckRhdGESDwoHc3VtbWFy",
            "eRgBIAEoCRIUCgx0ZW1wZXJhdHVyZUYYAiABKAUSMQoNZGF0ZVRpbWVTdGFt",
            "cBgDIAEoCzIaLmdvb2dsZS5wcm90b2J1Zi5UaW1lc3RhbXBCIKoCHUhlbGxv",
            "UHJvdG9idWZDU2hhcnAudjEuTW9kZWxzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HelloProtobufCSharp.v1.Models.WeatherData), global::HelloProtobufCSharp.v1.Models.WeatherData.Parser, new[]{ "Summary", "TemperatureF", "DateTimeStamp" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class WeatherData : pb::IMessage<WeatherData> {
    private static readonly pb::MessageParser<WeatherData> _parser = new pb::MessageParser<WeatherData>(() => new WeatherData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<WeatherData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HelloProtobufCSharp.v1.Models.WeatherReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public WeatherData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public WeatherData(WeatherData other) : this() {
      summary_ = other.summary_;
      temperatureF_ = other.temperatureF_;
      dateTimeStamp_ = other.dateTimeStamp_ != null ? other.dateTimeStamp_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public WeatherData Clone() {
      return new WeatherData(this);
    }

    /// <summary>Field number for the "summary" field.</summary>
    public const int SummaryFieldNumber = 1;
    private string summary_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Summary {
      get { return summary_; }
      set {
        summary_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "temperatureF" field.</summary>
    public const int TemperatureFFieldNumber = 2;
    private int temperatureF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int TemperatureF {
      get { return temperatureF_; }
      set {
        temperatureF_ = value;
      }
    }

    /// <summary>Field number for the "dateTimeStamp" field.</summary>
    public const int DateTimeStampFieldNumber = 3;
    private global::Google.Protobuf.WellKnownTypes.Timestamp dateTimeStamp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp DateTimeStamp {
      get { return dateTimeStamp_; }
      set {
        dateTimeStamp_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as WeatherData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(WeatherData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Summary != other.Summary) return false;
      if (TemperatureF != other.TemperatureF) return false;
      if (!object.Equals(DateTimeStamp, other.DateTimeStamp)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Summary.Length != 0) hash ^= Summary.GetHashCode();
      if (TemperatureF != 0) hash ^= TemperatureF.GetHashCode();
      if (dateTimeStamp_ != null) hash ^= DateTimeStamp.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Summary.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Summary);
      }
      if (TemperatureF != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(TemperatureF);
      }
      if (dateTimeStamp_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(DateTimeStamp);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Summary.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Summary);
      }
      if (TemperatureF != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(TemperatureF);
      }
      if (dateTimeStamp_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DateTimeStamp);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(WeatherData other) {
      if (other == null) {
        return;
      }
      if (other.Summary.Length != 0) {
        Summary = other.Summary;
      }
      if (other.TemperatureF != 0) {
        TemperatureF = other.TemperatureF;
      }
      if (other.dateTimeStamp_ != null) {
        if (dateTimeStamp_ == null) {
          DateTimeStamp = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        DateTimeStamp.MergeFrom(other.DateTimeStamp);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Summary = input.ReadString();
            break;
          }
          case 16: {
            TemperatureF = input.ReadInt32();
            break;
          }
          case 26: {
            if (dateTimeStamp_ == null) {
              DateTimeStamp = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(DateTimeStamp);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
