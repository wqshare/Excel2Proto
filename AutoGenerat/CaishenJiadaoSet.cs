//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: CaishenJiadaoSet.proto
namespace Excel2Proto
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CaishenJiadaoSet")]
  public partial class CaishenJiadaoSet : global::ProtoBuf.IExtensible
  {
    public CaishenJiadaoSet() {}
    
    private int _ID;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ID
    {
      get { return _ID; }
      set { _ID = value; }
    }
    private int _getDiamondMin;
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"getDiamondMin", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int getDiamondMin
    {
      get { return _getDiamondMin; }
      set { _getDiamondMin = value; }
    }
    private int _getDiamondMax;
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"getDiamondMax", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int getDiamondMax
    {
      get { return _getDiamondMax; }
      set { _getDiamondMax = value; }
    }
    private int _startYear;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"startYear", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int startYear
    {
      get { return _startYear; }
      set { _startYear = value; }
    }
    private int _startMonth;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"startMonth", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int startMonth
    {
      get { return _startMonth; }
      set { _startMonth = value; }
    }
    private int _startDay;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"startDay", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int startDay
    {
      get { return _startDay; }
      set { _startDay = value; }
    }
    private int _endYear;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"endYear", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int endYear
    {
      get { return _endYear; }
      set { _endYear = value; }
    }
    private int _endMonth;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"endMonth", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int endMonth
    {
      get { return _endMonth; }
      set { _endMonth = value; }
    }
    private int _endDay;
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"endDay", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int endDay
    {
      get { return _endDay; }
      set { _endDay = value; }
    }
    private string _content;
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"content", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string content
    {
      get { return _content; }
      set { _content = value; }
    }
    private int _price;
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"price", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int price
    {
      get { return _price; }
      set { _price = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}