//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: GuildJobSet.proto
namespace Excel2Proto
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"GuildJobSet")]
  public partial class GuildJobSet : global::ProtoBuf.IExtensible
  {
    public GuildJobSet() {}
    
    private int _ID;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ID
    {
      get { return _ID; }
      set { _ID = value; }
    }
    private int _guildBattle;
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"guildBattle", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int guildBattle
    {
      get { return _guildBattle; }
      set { _guildBattle = value; }
    }
    private int _guildDonation;
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"guildDonation", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int guildDonation
    {
      get { return _guildDonation; }
      set { _guildDonation = value; }
    }
    private int _banSpeech;
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"banSpeech", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int banSpeech
    {
      get { return _banSpeech; }
      set { _banSpeech = value; }
    }
    private int _upgrade;
    [global::ProtoBuf.ProtoMember(13, IsRequired = true, Name=@"upgrade", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int upgrade
    {
      get { return _upgrade; }
      set { _upgrade = value; }
    }
    private int _activit;
    [global::ProtoBuf.ProtoMember(14, IsRequired = true, Name=@"activit", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int activit
    {
      get { return _activit; }
      set { _activit = value; }
    }
    private string _name;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string name
    {
      get { return _name; }
      set { _name = value; }
    }
    private int _isAdmin;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"isAdmin", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int isAdmin
    {
      get { return _isAdmin; }
      set { _isAdmin = value; }
    }
    private int _isCore;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"isCore", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int isCore
    {
      get { return _isCore; }
      set { _isCore = value; }
    }
    private int _powersGive;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"powersGive", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int powersGive
    {
      get { return _powersGive; }
      set { _powersGive = value; }
    }
    private int _recvMember;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"recvMember", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int recvMember
    {
      get { return _recvMember; }
      set { _recvMember = value; }
    }
    private int _expelMember;
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"expelMember", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int expelMember
    {
      get { return _expelMember; }
      set { _expelMember = value; }
    }
    private int _document;
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"document", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int document
    {
      get { return _document; }
      set { _document = value; }
    }
    private int _guildDevel;
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"guildDevel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int guildDevel
    {
      get { return _guildDevel; }
      set { _guildDevel = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}