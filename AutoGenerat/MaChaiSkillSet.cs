//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: MaChaiSkillSet.proto
namespace Excel2Proto
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"MaChaiSkillSet")]
  public partial class MaChaiSkillSet : global::ProtoBuf.IExtensible
  {
    public MaChaiSkillSet() {}
    
    private int _ID;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ID
    {
      get { return _ID; }
      set { _ID = value; }
    }
    private string _name;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string name
    {
      get { return _name; }
      set { _name = value; }
    }
    private string _desc;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"desc", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string desc
    {
      get { return _desc; }
      set { _desc = value; }
    }
    private int _level;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int level
    {
      get { return _level; }
      set { _level = value; }
    }
    private float _attackRatio;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"attackRatio", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float attackRatio
    {
      get { return _attackRatio; }
      set { _attackRatio = value; }
    }
    private float _damageRatio;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"damageRatio", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float damageRatio
    {
      get { return _damageRatio; }
      set { _damageRatio = value; }
    }
    private string _conid;
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"conid", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string conid
    {
      get { return _conid; }
      set { _conid = value; }
    }
    private int _fc;
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"fc", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int fc
    {
      get { return _fc; }
      set { _fc = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}