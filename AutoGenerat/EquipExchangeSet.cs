//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: EquipExchangeSet.proto
namespace Excel2Proto
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"EquipExchangeSet")]
  public partial class EquipExchangeSet : global::ProtoBuf.IExtensible
  {
    public EquipExchangeSet() {}
    
    private int _ID;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ID
    {
      get { return _ID; }
      set { _ID = value; }
    }
    private int _dropId;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"dropId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int dropId
    {
      get { return _dropId; }
      set { _dropId = value; }
    }
    private int _itemId;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"itemId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int itemId
    {
      get { return _itemId; }
      set { _itemId = value; }
    }
    private string _name;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string name
    {
      get { return _name; }
      set { _name = value; }
    }
    private int _num;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"num", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int num
    {
      get { return _num; }
      set { _num = value; }
    }
    private int _probability;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"probability", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int probability
    {
      get { return _probability; }
      set { _probability = value; }
    }
    private int _materialID;
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"materialID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int materialID
    {
      get { return _materialID; }
      set { _materialID = value; }
    }
    private int _materialNum;
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"materialNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int materialNum
    {
      get { return _materialNum; }
      set { _materialNum = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}