//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: BossRaidLevelSet.proto
namespace Excel2Proto
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BossRaidLevelSet")]
  public partial class BossRaidLevelSet : global::ProtoBuf.IExtensible
  {
    public BossRaidLevelSet() {}
    
    private int _ID;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ID
    {
      get { return _ID; }
      set { _ID = value; }
    }
    private float _hpFactor;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"hpFactor", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float hpFactor
    {
      get { return _hpFactor; }
      set { _hpFactor = value; }
    }
    private float _attackFactor;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"attackFactor", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float attackFactor
    {
      get { return _attackFactor; }
      set { _attackFactor = value; }
    }
    private float _defenceFactor;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"defenceFactor", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float defenceFactor
    {
      get { return _defenceFactor; }
      set { _defenceFactor = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}