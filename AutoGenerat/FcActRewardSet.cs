//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: FcActRewardSet.proto
// Note: requires additional types generated from: FcActRewardItem.proto
namespace Excel2Proto
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"FcActRewardSet")]
  public partial class FcActRewardSet : global::ProtoBuf.IExtensible
  {
    public FcActRewardSet() {}
    
    private int _ID;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ID
    {
      get { return _ID; }
      set { _ID = value; }
    }
    private int _limitLow;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"limitLow", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int limitLow
    {
      get { return _limitLow; }
      set { _limitLow = value; }
    }
    private int _num;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"num", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int num
    {
      get { return _num; }
      set { _num = value; }
    }
    private readonly global::System.Collections.Generic.List<FcActRewardItem> _itemData = new global::System.Collections.Generic.List<FcActRewardItem>();
    [global::ProtoBuf.ProtoMember(4, Name=@"itemData", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<FcActRewardItem> itemData
    {
      get { return _itemData; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}