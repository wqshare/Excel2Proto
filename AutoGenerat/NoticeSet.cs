//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: NoticeSet.proto
namespace Excel2Proto
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"NoticeSet")]
  public partial class NoticeSet : global::ProtoBuf.IExtensible
  {
    public NoticeSet() {}
    
    private int _ID;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ID
    {
      get { return _ID; }
      set { _ID = value; }
    }
    private int _descID1;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"descID1", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int descID1
    {
      get { return _descID1; }
      set { _descID1 = value; }
    }
    private int _descID2;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"descID2", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int descID2
    {
      get { return _descID2; }
      set { _descID2 = value; }
    }
    private int _descID3;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"descID3", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int descID3
    {
      get { return _descID3; }
      set { _descID3 = value; }
    }
    private int _descID4;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"descID4", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int descID4
    {
      get { return _descID4; }
      set { _descID4 = value; }
    }
    private int _conditionID;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"conditionID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int conditionID
    {
      get { return _conditionID; }
      set { _conditionID = value; }
    }
    private int _conditionsVal1;
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"conditionsVal1", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int conditionsVal1
    {
      get { return _conditionsVal1; }
      set { _conditionsVal1 = value; }
    }
    private int _conditionsVal2;
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"conditionsVal2", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int conditionsVal2
    {
      get { return _conditionsVal2; }
      set { _conditionsVal2 = value; }
    }
    private int _conditionsVal3;
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"conditionsVal3", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int conditionsVal3
    {
      get { return _conditionsVal3; }
      set { _conditionsVal3 = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}