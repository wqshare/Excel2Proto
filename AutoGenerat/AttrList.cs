//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: AttrList.proto
namespace Excel2Proto
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"AttrList")]
  public partial class AttrList : global::ProtoBuf.IExtensible
  {
    public AttrList() {}
    
    private int _attrID;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"attrID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int attrID
    {
      get { return _attrID; }
      set { _attrID = value; }
    }
    private int _attrNum;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"attrNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int attrNum
    {
      get { return _attrNum; }
      set { _attrNum = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}