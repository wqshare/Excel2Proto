//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: ShiZhuangAttr.proto
namespace Excel2Proto
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ShiZhuangAttr")]
  public partial class ShiZhuangAttr : global::ProtoBuf.IExtensible
  {
    public ShiZhuangAttr() {}
    
    private int _attrType;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"attrType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int attrType
    {
      get { return _attrType; }
      set { _attrType = value; }
    }
    private int _attrVal;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"attrVal", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int attrVal
    {
      get { return _attrVal; }
      set { _attrVal = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}