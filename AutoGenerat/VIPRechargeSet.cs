//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: VIPRechargeSet.proto
namespace Excel2Proto
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"VIPRechargeSet")]
  public partial class VIPRechargeSet : global::ProtoBuf.IExtensible
  {
    public VIPRechargeSet() {}
    
    private int _ID;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ID
    {
      get { return _ID; }
      set { _ID = value; }
    }
    private int _diamondGive;
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"diamondGive", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int diamondGive
    {
      get { return _diamondGive; }
      set { _diamondGive = value; }
    }
    private string _iconID;
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"iconID", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string iconID
    {
      get { return _iconID; }
      set { _iconID = value; }
    }
    private int _recommendFlag;
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"recommendFlag", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int recommendFlag
    {
      get { return _recommendFlag; }
      set { _recommendFlag = value; }
    }
    private int _sortId;
    [global::ProtoBuf.ProtoMember(13, IsRequired = true, Name=@"sortId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int sortId
    {
      get { return _sortId; }
      set { _sortId = value; }
    }
    private string _name;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string name
    {
      get { return _name; }
      set { _name = value; }
    }
    private int _isMore;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"isMore", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int isMore
    {
      get { return _isMore; }
      set { _isMore = value; }
    }
    private int _resetTime;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"resetTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int resetTime
    {
      get { return _resetTime; }
      set { _resetTime = value; }
    }
    private int _rmb;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"rmb", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int rmb
    {
      get { return _rmb; }
      set { _rmb = value; }
    }
    private int _jinDou;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"jinDou", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int jinDou
    {
      get { return _jinDou; }
      set { _jinDou = value; }
    }
    private int _diamondStatis;
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"diamondStatis", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int diamondStatis
    {
      get { return _diamondStatis; }
      set { _diamondStatis = value; }
    }
    private int _plamformType;
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"plamformType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int plamformType
    {
      get { return _plamformType; }
      set { _plamformType = value; }
    }
    private int _diamondSpecialGive;
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"diamondSpecialGive", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int diamondSpecialGive
    {
      get { return _diamondSpecialGive; }
      set { _diamondSpecialGive = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}