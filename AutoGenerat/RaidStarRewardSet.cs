//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: RaidStarRewardSet.proto
namespace Excel2Proto
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RaidStarRewardSet")]
  public partial class RaidStarRewardSet : global::ProtoBuf.IExtensible
  {
    public RaidStarRewardSet() {}
    
    private int _ID;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ID
    {
      get { return _ID; }
      set { _ID = value; }
    }
    private int _mapType;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"mapType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int mapType
    {
      get { return _mapType; }
      set { _mapType = value; }
    }
    private int _sectionId;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"sectionId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int sectionId
    {
      get { return _sectionId; }
      set { _sectionId = value; }
    }
    private int _rewardNum;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"rewardNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int rewardNum
    {
      get { return _rewardNum; }
      set { _rewardNum = value; }
    }
    private int _gold;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"gold", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int gold
    {
      get { return _gold; }
      set { _gold = value; }
    }
    private int _diamond;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"diamond", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int diamond
    {
      get { return _diamond; }
      set { _diamond = value; }
    }
    private int _propId;
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"propId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int propId
    {
      get { return _propId; }
      set { _propId = value; }
    }
    private int _propNum;
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"propNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int propNum
    {
      get { return _propNum; }
      set { _propNum = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}