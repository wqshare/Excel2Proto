//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: ComposeItem.proto
namespace Excel2Proto
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ComposeItem")]
  public partial class ComposeItem : global::ProtoBuf.IExtensible
  {
    public ComposeItem() {}
    
    private int _itemID;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"itemID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int itemID
    {
      get { return _itemID; }
      set { _itemID = value; }
    }
    private int _itemNum;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"itemNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int itemNum
    {
      get { return _itemNum; }
      set { _itemNum = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}