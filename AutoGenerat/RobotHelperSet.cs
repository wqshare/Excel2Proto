//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: RobotHelperSet.proto
// Note: requires additional types generated from: SkillGroup.proto
namespace Excel2Proto
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RobotHelperSet")]
  public partial class RobotHelperSet : global::ProtoBuf.IExtensible
  {
    public RobotHelperSet() {}
    
    private int _ID;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ID
    {
      get { return _ID; }
      set { _ID = value; }
    }
    private float _defence;
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"defence", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float defence
    {
      get { return _defence; }
      set { _defence = value; }
    }
    private float _critTimes;
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"critTimes", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float critTimes
    {
      get { return _critTimes; }
      set { _critTimes = value; }
    }
    private float _crit;
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"crit", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float crit
    {
      get { return _crit; }
      set { _crit = value; }
    }
    private int _tough;
    [global::ProtoBuf.ProtoMember(13, IsRequired = true, Name=@"tough", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int tough
    {
      get { return _tough; }
      set { _tough = value; }
    }
    private float _hit;
    [global::ProtoBuf.ProtoMember(14, IsRequired = true, Name=@"hit", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float hit
    {
      get { return _hit; }
      set { _hit = value; }
    }
    private float _dodge;
    [global::ProtoBuf.ProtoMember(15, IsRequired = true, Name=@"dodge", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float dodge
    {
      get { return _dodge; }
      set { _dodge = value; }
    }
    private float _damageSub;
    [global::ProtoBuf.ProtoMember(16, IsRequired = true, Name=@"damageSub", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float damageSub
    {
      get { return _damageSub; }
      set { _damageSub = value; }
    }
    private float _damageAdd;
    [global::ProtoBuf.ProtoMember(17, IsRequired = true, Name=@"damageAdd", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float damageAdd
    {
      get { return _damageAdd; }
      set { _damageAdd = value; }
    }
    private int _active;
    [global::ProtoBuf.ProtoMember(18, IsRequired = true, Name=@"active", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int active
    {
      get { return _active; }
      set { _active = value; }
    }
    private string _aiName;
    [global::ProtoBuf.ProtoMember(19, IsRequired = true, Name=@"aiName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string aiName
    {
      get { return _aiName; }
      set { _aiName = value; }
    }
    private string _name;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string name
    {
      get { return _name; }
      set { _name = value; }
    }
    private int _talkId;
    [global::ProtoBuf.ProtoMember(20, IsRequired = true, Name=@"talkId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int talkId
    {
      get { return _talkId; }
      set { _talkId = value; }
    }
    private int _fightCap;
    [global::ProtoBuf.ProtoMember(21, IsRequired = true, Name=@"fightCap", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int fightCap
    {
      get { return _fightCap; }
      set { _fightCap = value; }
    }
    private int _job;
    [global::ProtoBuf.ProtoMember(22, IsRequired = true, Name=@"job", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int job
    {
      get { return _job; }
      set { _job = value; }
    }
    private int _skillNum;
    [global::ProtoBuf.ProtoMember(23, IsRequired = true, Name=@"skillNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int skillNum
    {
      get { return _skillNum; }
      set { _skillNum = value; }
    }
    private readonly global::System.Collections.Generic.List<SkillGroup> _skillList = new global::System.Collections.Generic.List<SkillGroup>();
    [global::ProtoBuf.ProtoMember(24, Name=@"skillList", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<SkillGroup> skillList
    {
      get { return _skillList; }
    }
  
    private int _modelTimes;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"modelTimes", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int modelTimes
    {
      get { return _modelTimes; }
      set { _modelTimes = value; }
    }
    private int _monsterType;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"monsterType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int monsterType
    {
      get { return _monsterType; }
      set { _monsterType = value; }
    }
    private int _level;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int level
    {
      get { return _level; }
      set { _level = value; }
    }
    private string _avatarType;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"avatarType", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string avatarType
    {
      get { return _avatarType; }
      set { _avatarType = value; }
    }
    private int _avatarId;
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"avatarId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int avatarId
    {
      get { return _avatarId; }
      set { _avatarId = value; }
    }
    private float _hp;
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"hp", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float hp
    {
      get { return _hp; }
      set { _hp = value; }
    }
    private float _attack;
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"attack", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float attack
    {
      get { return _attack; }
      set { _attack = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}