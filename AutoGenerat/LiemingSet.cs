//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: LiemingSet.proto
namespace Excel2Proto
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"LiemingSet")]
  public partial class LiemingSet : global::ProtoBuf.IExtensible
  {
    public LiemingSet() {}
    
    private int _ID;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ID
    {
      get { return _ID; }
      set { _ID = value; }
    }
    private int _price;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"price", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int price
    {
      get { return _price; }
      set { _price = value; }
    }
    private int _lockPrice;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"lockPrice", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int lockPrice
    {
      get { return _lockPrice; }
      set { _lockPrice = value; }
    }
    private int _upgradeProbability;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"upgradeProbability", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int upgradeProbability
    {
      get { return _upgradeProbability; }
      set { _upgradeProbability = value; }
    }
    private int _upgradeLockProbability;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"upgradeLockProbability", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int upgradeLockProbability
    {
      get { return _upgradeLockProbability; }
      set { _upgradeLockProbability = value; }
    }
    private int _minggeID;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"minggeID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int minggeID
    {
      get { return _minggeID; }
      set { _minggeID = value; }
    }
    private int _minggeLockID;
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"minggeLockID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int minggeLockID
    {
      get { return _minggeLockID; }
      set { _minggeLockID = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}