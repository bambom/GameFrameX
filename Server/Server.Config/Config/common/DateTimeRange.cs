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



namespace cfg.common
{
public sealed partial class DateTimeRange :  Bright.Config.BeanBase 
{
    public DateTimeRange(JsonElement _json) 
    {
        { if (_json.TryGetProperty("start_time", out var _j) && _j.ValueKind != JsonValueKind.Null) { StartTime = _j.GetInt64(); } else { StartTime = null; } }
        { if (_json.TryGetProperty("end_time", out var _j) && _j.ValueKind != JsonValueKind.Null) { EndTime = _j.GetInt64(); } else { EndTime = null; } }
        PostInit();
    }

    public DateTimeRange(long? start_time, long? end_time ) 
    {
        this.StartTime = start_time;
        this.EndTime = end_time;
        PostInit();
    }

    public static DateTimeRange DeserializeDateTimeRange(JsonElement _json)
    {
        return new common.DateTimeRange(_json);
    }

    public long? StartTime { get; private set; }
    public long? EndTime { get; private set; }

    public const int __ID__ = 1642200959;
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
        + "StartTime:" + StartTime + ","
        + "EndTime:" + EndTime + ","
        + "}";
    }

    partial void PostInit();
    partial void PostResolve();
}
}
