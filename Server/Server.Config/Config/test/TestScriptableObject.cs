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
public sealed partial class TestScriptableObject :  Bright.Config.BeanBase 
{
    public TestScriptableObject(JsonElement _json) 
    {
        Id = _json.GetProperty("id").GetInt32();
        Desc = _json.GetProperty("desc").GetString();
        Rate = _json.GetProperty("rate").GetSingle();
        Num = _json.GetProperty("num").GetInt32();
        { var _json0 = _json.GetProperty("v2"); float __x; __x = _json0.GetProperty("x").GetSingle(); float __y; __y = _json0.GetProperty("y").GetSingle(); V2 = new System.Numerics.Vector2(__x, __y); }
        { var _json0 = _json.GetProperty("v3"); float __x; __x = _json0.GetProperty("x").GetSingle(); float __y; __y = _json0.GetProperty("y").GetSingle(); float __z; __z = _json0.GetProperty("z").GetSingle();  V3 = new System.Numerics.Vector3(__x, __y,__z); }
        { var _json0 = _json.GetProperty("v4"); float __x; __x = _json0.GetProperty("x").GetSingle(); float __y; __y = _json0.GetProperty("y").GetSingle(); float __z; __z = _json0.GetProperty("z").GetSingle();  float __w; __w = _json0.GetProperty("w").GetSingle(); V4 = new System.Numerics.Vector4(__x, __y, __z, __w); }
        PostInit();
    }

    public TestScriptableObject(int id, string desc, float rate, int num, System.Numerics.Vector2 v2, System.Numerics.Vector3 v3, System.Numerics.Vector4 v4 ) 
    {
        this.Id = id;
        this.Desc = desc;
        this.Rate = rate;
        this.Num = num;
        this.V2 = v2;
        this.V3 = v3;
        this.V4 = v4;
        PostInit();
    }

    public static TestScriptableObject DeserializeTestScriptableObject(JsonElement _json)
    {
        return new test.TestScriptableObject(_json);
    }

    public int Id { get; private set; }
    public string Desc { get; private set; }
    public float Rate { get; private set; }
    public int Num { get; private set; }
    public System.Numerics.Vector2 V2 { get; private set; }
    public System.Numerics.Vector3 V3 { get; private set; }
    public System.Numerics.Vector4 V4 { get; private set; }

    public const int __ID__ = -1896814350;
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
        + "Id:" + Id + ","
        + "Desc:" + Desc + ","
        + "Rate:" + Rate + ","
        + "Num:" + Num + ","
        + "V2:" + V2 + ","
        + "V3:" + V3 + ","
        + "V4:" + V4 + ","
        + "}";
    }

    partial void PostInit();
    partial void PostResolve();
}
}
