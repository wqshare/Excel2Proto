//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: SendMailSet.proto
namespace Excel2Proto
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SendMailSet")]
  public partial class SendMailSet : global::ProtoBuf.IExtensible
  {
    public SendMailSet() {}
    
    private int _ID;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ID
    {
      get { return _ID; }
      set { _ID = value; }
    }
    private string _title;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"title", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string title
    {
      get { return _title; }
      set { _title = value; }
    }
    private string _sender;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"sender", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string sender
    {
      get { return _sender; }
      set { _sender = value; }
    }
    private string _content;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"content", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string content
    {
      get { return _content; }
      set { _content = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}