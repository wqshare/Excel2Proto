//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: SkillCDSet.proto
namespace Excel2Proto
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SkillCDSet")]
  public partial class SkillCDSet : global::ProtoBuf.IExtensible
  {
    public SkillCDSet() {}
    
    private int _ID;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ID
    {
      get { return _ID; }
      set { _ID = value; }
    }
    private int _needItgemNum;
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"needItgemNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int needItgemNum
    {
      get { return _needItgemNum; }
      set { _needItgemNum = value; }
    }
    private int _fightNum;
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"fightNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int fightNum
    {
      get { return _fightNum; }
      set { _fightNum = value; }
    }
    private int _totalfightNum;
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"totalfightNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int totalfightNum
    {
      get { return _totalfightNum; }
      set { _totalfightNum = value; }
    }
    private int _skillSort;
    [global::ProtoBuf.ProtoMember(13, IsRequired = true, Name=@"skillSort", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int skillSort
    {
      get { return _skillSort; }
      set { _skillSort = value; }
    }
    private string _SkillName;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"SkillName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string SkillName
    {
      get { return _SkillName; }
      set { _SkillName = value; }
    }
    private int _Job;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Job", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Job
    {
      get { return _Job; }
      set { _Job = value; }
    }
    private int _UnLockLevel;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"UnLockLevel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int UnLockLevel
    {
      get { return _UnLockLevel; }
      set { _UnLockLevel = value; }
    }
    private string _SkillDesc;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"SkillDesc", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string SkillDesc
    {
      get { return _SkillDesc; }
      set { _SkillDesc = value; }
    }
    private int _SkillCD;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"SkillCD", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int SkillCD
    {
      get { return _SkillCD; }
      set { _SkillCD = value; }
    }
    private int _needGold;
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"needGold", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int needGold
    {
      get { return _needGold; }
      set { _needGold = value; }
    }
    private int _level;
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int level
    {
      get { return _level; }
      set { _level = value; }
    }
    private int _needItemLevel;
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"needItemLevel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int needItemLevel
    {
      get { return _needItemLevel; }
      set { _needItemLevel = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}