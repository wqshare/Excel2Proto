//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: ClickGoldProbabilitySet.proto
namespace Excel2Proto
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ClickGoldProbabilitySet")]
  public partial class ClickGoldProbabilitySet : global::ProtoBuf.IExtensible
  {
    public ClickGoldProbabilitySet() {}
    
    private int _ID;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ID
    {
      get { return _ID; }
      set { _ID = value; }
    }
    private float _probability;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"probability", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float probability
    {
      get { return _probability; }
      set { _probability = value; }
    }
    private int _limit;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"limit", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int limit
    {
      get { return _limit; }
      set { _limit = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}