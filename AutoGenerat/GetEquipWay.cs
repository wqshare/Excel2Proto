//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: GetEquipWay.proto
// Note: requires additional types generated from: EquipWay.proto
namespace Excel2Proto
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"GetEquipWay")]
  public partial class GetEquipWay : global::ProtoBuf.IExtensible
  {
    public GetEquipWay() {}
    
    private int _ID;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ID
    {
      get { return _ID; }
      set { _ID = value; }
    }
    private int _getWayDecid;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"getWayDecid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int getWayDecid
    {
      get { return _getWayDecid; }
      set { _getWayDecid = value; }
    }
    private string _name;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string name
    {
      get { return _name; }
      set { _name = value; }
    }
    private int _WayNum;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"WayNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int WayNum
    {
      get { return _WayNum; }
      set { _WayNum = value; }
    }
    private readonly global::System.Collections.Generic.List<EquipWay> _WayS = new global::System.Collections.Generic.List<EquipWay>();
    [global::ProtoBuf.ProtoMember(5, Name=@"WayS", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<EquipWay> WayS
    {
      get { return _WayS; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}