//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: IwillBeStrongSet.proto
// Note: requires additional types generated from: UiNumItems.proto
namespace Excel2Proto
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"IwillBeStrongSet")]
  public partial class IwillBeStrongSet : global::ProtoBuf.IExtensible
  {
    public IwillBeStrongSet() {}
    
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
    private int _IsShowLevel;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"IsShowLevel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int IsShowLevel
    {
      get { return _IsShowLevel; }
      set { _IsShowLevel = value; }
    }
    private string _icon;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"icon", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string icon
    {
      get { return _icon; }
      set { _icon = value; }
    }
    private int _uiId;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"uiId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int uiId
    {
      get { return _uiId; }
      set { _uiId = value; }
    }
    private int _uiNums;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"uiNums", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int uiNums
    {
      get { return _uiNums; }
      set { _uiNums = value; }
    }
    private readonly global::System.Collections.Generic.List<UiNumItems> _UiItems = new global::System.Collections.Generic.List<UiNumItems>();
    [global::ProtoBuf.ProtoMember(7, Name=@"UiItems", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<UiNumItems> UiItems
    {
      get { return _UiItems; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}