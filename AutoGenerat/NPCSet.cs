//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: NPCSet.proto
namespace Excel2Proto
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"NPCSet")]
  public partial class NPCSet : global::ProtoBuf.IExtensible
  {
    public NPCSet() {}
    
    private int _ID;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ID
    {
      get { return _ID; }
      set { _ID = value; }
    }
    private string _ResourcePath;
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"ResourcePath", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string ResourcePath
    {
      get { return _ResourcePath; }
      set { _ResourcePath = value; }
    }
    private string _Name;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Name
    {
      get { return _Name; }
      set { _Name = value; }
    }
    private int _City;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"City", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int City
    {
      get { return _City; }
      set { _City = value; }
    }
    private int _NPCFunction;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"NPCFunction", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int NPCFunction
    {
      get { return _NPCFunction; }
      set { _NPCFunction = value; }
    }
    private int _SerialNum;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"SerialNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int SerialNum
    {
      get { return _SerialNum; }
      set { _SerialNum = value; }
    }
    private int _HeadIconSize;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"HeadIconSize", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int HeadIconSize
    {
      get { return _HeadIconSize; }
      set { _HeadIconSize = value; }
    }
    private int _posX;
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"posX", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int posX
    {
      get { return _posX; }
      set { _posX = value; }
    }
    private int _posY;
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"posY", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int posY
    {
      get { return _posY; }
      set { _posY = value; }
    }
    private int _avataId;
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"avataId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int avataId
    {
      get { return _avataId; }
      set { _avataId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}