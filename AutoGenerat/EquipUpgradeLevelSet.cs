//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: EquipUpgradeLevelSet.proto
// Note: requires additional types generated from: EquipUpgradeMaterial.proto
namespace Excel2Proto
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"EquipUpgradeLevelSet")]
  public partial class EquipUpgradeLevelSet : global::ProtoBuf.IExtensible
  {
    public EquipUpgradeLevelSet() {}
    
    private int _ID;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ID
    {
      get { return _ID; }
      set { _ID = value; }
    }
    private int _diamond;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"diamond", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int diamond
    {
      get { return _diamond; }
      set { _diamond = value; }
    }
    private int _gold;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"gold", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int gold
    {
      get { return _gold; }
      set { _gold = value; }
    }
    private string _name;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string name
    {
      get { return _name; }
      set { _name = value; }
    }
    private int _dstId;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"dstId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int dstId
    {
      get { return _dstId; }
      set { _dstId = value; }
    }
    private int _num;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"num", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int num
    {
      get { return _num; }
      set { _num = value; }
    }
    private readonly global::System.Collections.Generic.List<EquipUpgradeMaterial> _material = new global::System.Collections.Generic.List<EquipUpgradeMaterial>();
    [global::ProtoBuf.ProtoMember(7, Name=@"material", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<EquipUpgradeMaterial> material
    {
      get { return _material; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}