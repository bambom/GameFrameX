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
public sealed partial class InnerGroup :  Bright.Config.BeanBase 
{
    public InnerGroup(JsonElement _json) 
    {
        Y1 = _json.GetProperty("y1").GetInt32();
        Y3 = _json.GetProperty("y3").GetInt32();
        Y4 = _json.GetProperty("y4").GetInt32();
        PostInit();
    }

    public InnerGroup(int y1, int y3, int y4 ) 
    {
        this.Y1 = y1;
        this.Y3 = y3;
        this.Y4 = y4;
        PostInit();
    }

    public static InnerGroup DeserializeInnerGroup(JsonElement _json)
    {
        return new test.InnerGroup(_json);
    }

    public int Y1 { get; private set; }
    public int Y3 { get; private set; }
    public int Y4 { get; private set; }

    public const int __ID__ = -587873083;
    public override int GetTypeId() => __ID__;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        PostResolve();
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "Y1:" + Y1 + ","
        + "Y3:" + Y3 + ","
        + "Y4:" + Y4 + ","
        + "}";
    }

    partial void PostInit();
    partial void PostResolve();
}
}
