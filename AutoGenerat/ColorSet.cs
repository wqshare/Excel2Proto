//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: ColorSet.proto
namespace Excel2Proto
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ColorSet")]
  public partial class ColorSet : global::ProtoBuf.IExtensible
  {
    public ColorSet() {}
    
    private int _ID;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ID
    {
      get { return _ID; }
      set { _ID = value; }
    }
    private int _r;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"r", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int r
    {
      get { return _r; }
      set { _r = value; }
    }
    private int _g;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"g", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int g
    {
      get { return _g; }
      set { _g = value; }
    }
    private int _b;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"b", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int b
    {
      get { return _b; }
      set { _b = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}