//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: MaChaiSupportOpenSet.proto
namespace Excel2Proto
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"MaChaiSupportOpenSet")]
  public partial class MaChaiSupportOpenSet : global::ProtoBuf.IExtensible
  {
    public MaChaiSupportOpenSet() {}
    
    private int _ID;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ID
    {
      get { return _ID; }
      set { _ID = value; }
    }
    private int _Level;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Level
    {
      get { return _Level; }
      set { _Level = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}