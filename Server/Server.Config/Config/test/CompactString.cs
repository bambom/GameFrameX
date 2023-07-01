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
public sealed partial class CompactString :  Bright.Config.BeanBase 
{
    public CompactString(JsonElement _json) 
    {
        Id = _json.GetProperty("id").GetInt32();
        S2 = _json.GetProperty("s2").GetString();
        S3 = _json.GetProperty("s3").GetString();
        PostInit();
    }

    public CompactString(int id, string s2, string s3 ) 
    {
        this.Id = id;
        this.S2 = s2;
        this.S3 = s3;
        PostInit();
    }

    public static CompactString DeserializeCompactString(JsonElement _json)
    {
        return new test.CompactString(_json);
    }

    public int Id { get; private set; }
    public string S2 { get; private set; }
    public string S3 { get; private set; }

    public const int __ID__ = 1968089240;
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
        + "S2:" + S2 + ","
        + "S3:" + S3 + ","
        + "}";
    }

    partial void PostInit();
    partial void PostResolve();
}
}
