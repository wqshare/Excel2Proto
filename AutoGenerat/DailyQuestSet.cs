//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: DailyQuestSet.proto
namespace Excel2Proto
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DailyQuestSet")]
  public partial class DailyQuestSet : global::ProtoBuf.IExtensible
  {
    public DailyQuestSet() {}
    
    private int _ID;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ID
    {
      get { return _ID; }
      set { _ID = value; }
    }
    private int _exp;
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"exp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int exp
    {
      get { return _exp; }
      set { _exp = value; }
    }
    private int _gold;
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"gold", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int gold
    {
      get { return _gold; }
      set { _gold = value; }
    }
    private int _diamond;
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"diamond", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int diamond
    {
      get { return _diamond; }
      set { _diamond = value; }
    }
    private int _power;
    [global::ProtoBuf.ProtoMember(13, IsRequired = true, Name=@"power", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int power
    {
      get { return _power; }
      set { _power = value; }
    }
    private int _dropId;
    [global::ProtoBuf.ProtoMember(14, IsRequired = true, Name=@"dropId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int dropId
    {
      get { return _dropId; }
      set { _dropId = value; }
    }
    private string _name;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string name
    {
      get { return _name; }
      set { _name = value; }
    }
    private int _show;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"show", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int show
    {
      get { return _show; }
      set { _show = value; }
    }
    private int _prevId;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"prevId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int prevId
    {
      get { return _prevId; }
      set { _prevId = value; }
    }
    private int _type;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int type
    {
      get { return _type; }
      set { _type = value; }
    }
    private int _recvLevel;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"recvLevel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int recvLevel
    {
      get { return _recvLevel; }
      set { _recvLevel = value; }
    }
    private int _data1;
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"data1", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int data1
    {
      get { return _data1; }
      set { _data1 = value; }
    }
    private int _data2;
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"data2", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int data2
    {
      get { return _data2; }
      set { _data2 = value; }
    }
    private string _desc;
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"desc", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string desc
    {
      get { return _desc; }
      set { _desc = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}