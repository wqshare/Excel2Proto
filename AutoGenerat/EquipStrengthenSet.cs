//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: EquipStrengthenSet.proto
namespace Excel2Proto
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"EquipStrengthenSet")]
  public partial class EquipStrengthenSet : global::ProtoBuf.IExtensible
  {
    public EquipStrengthenSet() {}
    
    private int _ID;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ID
    {
      get { return _ID; }
      set { _ID = value; }
    }
    private float _Crit;
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"Crit", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float Crit
    {
      get { return _Crit; }
      set { _Crit = value; }
    }
    private float _Toug;
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"Toug", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float Toug
    {
      get { return _Toug; }
      set { _Toug = value; }
    }
    private float _DamageAdd;
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"DamageAdd", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float DamageAdd
    {
      get { return _DamageAdd; }
      set { _DamageAdd = value; }
    }
    private int _materialID;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"materialID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int materialID
    {
      get { return _materialID; }
      set { _materialID = value; }
    }
    private float _propGlodValue;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"propGlodValue", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float propGlodValue
    {
      get { return _propGlodValue; }
      set { _propGlodValue = value; }
    }
    private float _Hp;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Hp", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float Hp
    {
      get { return _Hp; }
      set { _Hp = value; }
    }
    private float _Attack;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Attack", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float Attack
    {
      get { return _Attack; }
      set { _Attack = value; }
    }
    private float _Defence;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"Defence", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float Defence
    {
      get { return _Defence; }
      set { _Defence = value; }
    }
    private float _DamageReduce;
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"DamageReduce", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float DamageReduce
    {
      get { return _DamageReduce; }
      set { _DamageReduce = value; }
    }
    private float _Accurate;
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"Accurate", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float Accurate
    {
      get { return _Accurate; }
      set { _Accurate = value; }
    }
    private float _Dodge;
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"Dodge", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float Dodge
    {
      get { return _Dodge; }
      set { _Dodge = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}