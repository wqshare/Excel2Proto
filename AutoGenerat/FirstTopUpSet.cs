//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: FirstTopUpSet.proto
namespace Excel2Proto
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"FirstTopUpSet")]
  public partial class FirstTopUpSet : global::ProtoBuf.IExtensible
  {
    public FirstTopUpSet() {}
    
    private int _ID;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ID
    {
      get { return _ID; }
      set { _ID = value; }
    }
    private int _DropId;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"DropId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int DropId
    {
      get { return _DropId; }
      set { _DropId = value; }
    }
    private int _ItemId;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"ItemId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ItemId
    {
      get { return _ItemId; }
      set { _ItemId = value; }
    }
    private int _ItemNum;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"ItemNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ItemNum
    {
      get { return _ItemNum; }
      set { _ItemNum = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}