//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: DNSSet.proto
namespace Excel2Proto
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DNSSet")]
  public partial class DNSSet : global::ProtoBuf.IExtensible
  {
    public DNSSet() {}
    
    private int _ID;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ID
    {
      get { return _ID; }
      set { _ID = value; }
    }
    private string _dns;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"dns", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string dns
    {
      get { return _dns; }
      set { _dns = value; }
    }
    private string _ipAddr;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"ipAddr", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string ipAddr
    {
      get { return _ipAddr; }
      set { _ipAddr = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}