//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: RedGiftSet.proto
namespace Excel2Proto
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RedGiftSet")]
  public partial class RedGiftSet : global::ProtoBuf.IExtensible
  {
    public RedGiftSet() {}
    
    private int _ID;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ID
    {
      get { return _ID; }
      set { _ID = value; }
    }
    private int _type;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int type
    {
      get { return _type; }
      set { _type = value; }
    }
    private int _data1;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"data1", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int data1
    {
      get { return _data1; }
      set { _data1 = value; }
    }
    private int _data2;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"data2", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int data2
    {
      get { return _data2; }
      set { _data2 = value; }
    }
    private int _score;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"score", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int score
    {
      get { return _score; }
      set { _score = value; }
    }
    private int _wrold_num;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"wrold_num", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int wrold_num
    {
      get { return _wrold_num; }
      set { _wrold_num = value; }
    }
    private int _friend_num;
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"friend_num", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int friend_num
    {
      get { return _friend_num; }
      set { _friend_num = value; }
    }
    private int _guild_num;
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"guild_num", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int guild_num
    {
      get { return _guild_num; }
      set { _guild_num = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}