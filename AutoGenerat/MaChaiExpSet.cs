//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: MaChaiExpSet.proto
namespace Excel2Proto
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"MaChaiExpSet")]
  public partial class MaChaiExpSet : global::ProtoBuf.IExtensible
  {
    public MaChaiExpSet() {}
    
    private int _ID;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ID
    {
      get { return _ID; }
      set { _ID = value; }
    }
    private int _q1Exp;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"q1Exp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int q1Exp
    {
      get { return _q1Exp; }
      set { _q1Exp = value; }
    }
    private int _q2Exp;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"q2Exp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int q2Exp
    {
      get { return _q2Exp; }
      set { _q2Exp = value; }
    }
    private int _q3Exp;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"q3Exp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int q3Exp
    {
      get { return _q3Exp; }
      set { _q3Exp = value; }
    }
    private int _q4Exp;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"q4Exp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int q4Exp
    {
      get { return _q4Exp; }
      set { _q4Exp = value; }
    }
    private int _tq1Exp;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"tq1Exp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int tq1Exp
    {
      get { return _tq1Exp; }
      set { _tq1Exp = value; }
    }
    private int _tq2Exp;
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"tq2Exp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int tq2Exp
    {
      get { return _tq2Exp; }
      set { _tq2Exp = value; }
    }
    private int _tq3Exp;
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"tq3Exp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int tq3Exp
    {
      get { return _tq3Exp; }
      set { _tq3Exp = value; }
    }
    private int _tq4Exp;
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"tq4Exp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int tq4Exp
    {
      get { return _tq4Exp; }
      set { _tq4Exp = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}