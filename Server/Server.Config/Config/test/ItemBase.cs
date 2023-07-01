//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;
using System.Text.Json;



namespace cfg.test
{
public abstract partial class ItemBase :  Bright.Config.BeanBase 
{
    public ItemBase(JsonElement _json) 
    {
        Id = _json.GetProperty("id").GetInt32();
        Name = _json.GetProperty("name").GetString();
        Desc = _json.GetProperty("desc").GetString();
        PostInit();
    }

    public ItemBase(int id, string name, string desc ) 
    {
        this.Id = id;
        this.Name = name;
        this.Desc = desc;
        PostInit();
    }

    public static ItemBase DeserializeItemBase(JsonElement _json)
    {
        switch (_json.GetProperty("$type").GetString())
        {
            case "Item": return new test.Item(_json);
            case "Equipment": return new test.Equipment(_json);
            case "Decorator": return new test.Decorator(_json);
            default: throw new SerializationException();
        }
    }

    public int Id { get; private set; }
    public string Name { get; private set; }
    public string Desc { get; private set; }


    public virtual void Resolve(Dictionary<string, object> _tables)
    {
        PostResolve();
    }

    public virtual void TranslateText(System.Func<string, string, string> translator)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "Name:" + Name + ","
        + "Desc:" + Desc + ","
        + "}";
    }

    partial void PostInit();
    partial void PostResolve();
}
}
