//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: ItemAttrSet.proto
namespace Excel2Proto
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ItemAttrSet")]
  public partial class ItemAttrSet : global::ProtoBuf.IExtensible
  {
    public ItemAttrSet() {}
    
    private int _ID;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ID
    {
      get { return _ID; }
      set { _ID = value; }
    }
    private int _CanSell;
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"CanSell", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int CanSell
    {
      get { return _CanSell; }
      set { _CanSell = value; }
    }
    private int _currencyType;
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"currencyType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int currencyType
    {
      get { return _currencyType; }
      set { _currencyType = value; }
    }
    private int _SalePrice;
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"SalePrice", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int SalePrice
    {
      get { return _SalePrice; }
      set { _SalePrice = value; }
    }
    private int _ComposeID;
    [global::ProtoBuf.ProtoMember(13, IsRequired = true, Name=@"ComposeID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ComposeID
    {
      get { return _ComposeID; }
      set { _ComposeID = value; }
    }
    private int _stackNum;
    [global::ProtoBuf.ProtoMember(14, IsRequired = true, Name=@"stackNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int stackNum
    {
      get { return _stackNum; }
      set { _stackNum = value; }
    }
    private int _ItemColor;
    [global::ProtoBuf.ProtoMember(15, IsRequired = true, Name=@"ItemColor", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ItemColor
    {
      get { return _ItemColor; }
      set { _ItemColor = value; }
    }
    private string _IconID;
    [global::ProtoBuf.ProtoMember(16, IsRequired = true, Name=@"IconID", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string IconID
    {
      get { return _IconID; }
      set { _IconID = value; }
    }
    private string _ItemDesc;
    [global::ProtoBuf.ProtoMember(17, IsRequired = true, Name=@"ItemDesc", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string ItemDesc
    {
      get { return _ItemDesc; }
      set { _ItemDesc = value; }
    }
    private string _name;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string name
    {
      get { return _name; }
      set { _name = value; }
    }
    private int _ItemType;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"ItemType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ItemType
    {
      get { return _ItemType; }
      set { _ItemType = value; }
    }
    private int _Uselimit;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Uselimit", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Uselimit
    {
      get { return _Uselimit; }
      set { _Uselimit = value; }
    }
    private int _UseResult;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"UseResult", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int UseResult
    {
      get { return _UseResult; }
      set { _UseResult = value; }
    }
    private int _limitVal;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"limitVal", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int limitVal
    {
      get { return _limitVal; }
      set { _limitVal = value; }
    }
    private int _canBuy;
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"canBuy", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int canBuy
    {
      get { return _canBuy; }
      set { _canBuy = value; }
    }
    private int _buyType;
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"buyType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int buyType
    {
      get { return _buyType; }
      set { _buyType = value; }
    }
    private int _buyPrice;
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"buyPrice", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int buyPrice
    {
      get { return _buyPrice; }
      set { _buyPrice = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}