//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: LevelRewardSet.proto
namespace Excel2Proto
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"LevelRewardSet")]
  public partial class LevelRewardSet : global::ProtoBuf.IExtensible
  {
    public LevelRewardSet() {}
    
    private int _ID;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ID
    {
      get { return _ID; }
      set { _ID = value; }
    }
    private int _arenaGold;
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"arenaGold", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int arenaGold
    {
      get { return _arenaGold; }
      set { _arenaGold = value; }
    }
    private int _level;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int level
    {
      get { return _level; }
      set { _level = value; }
    }
    private int _Conditions;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Conditions", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Conditions
    {
      get { return _Conditions; }
      set { _Conditions = value; }
    }
    private string _desc;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"desc", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string desc
    {
      get { return _desc; }
      set { _desc = value; }
    }
    private int _dropId;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"dropId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int dropId
    {
      get { return _dropId; }
      set { _dropId = value; }
    }
    private int _diamond;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"diamond", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int diamond
    {
      get { return _diamond; }
      set { _diamond = value; }
    }
    private int _gold;
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"gold", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int gold
    {
      get { return _gold; }
      set { _gold = value; }
    }
    private int _dragonSoul;
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"dragonSoul", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int dragonSoul
    {
      get { return _dragonSoul; }
      set { _dragonSoul = value; }
    }
    private int _liemingGold;
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"liemingGold", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int liemingGold
    {
      get { return _liemingGold; }
      set { _liemingGold = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}