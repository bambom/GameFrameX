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
public sealed partial class DateTimeRange :  Bright.Config.BeanBase 
{
    public DateTimeRange(JsonElement _json) 
    {
        StartTime = _json.GetProperty("start_time").GetInt64();
        EndTime = _json.GetProperty("end_time").GetInt64();
        PostInit();
    }

    public DateTimeRange(long start_time, long end_time ) 
    {
        this.StartTime = start_time;
        this.EndTime = end_time;
        PostInit();
    }

    public static DateTimeRange DeserializeDateTimeRange(JsonElement _json)
    {
        return new test.DateTimeRange(_json);
    }

    public long StartTime { get; private set; }
    public long StartTime_Millis => StartTime * 1000L;
    public long EndTime { get; private set; }
    public long EndTime_Millis => EndTime * 1000L;

    public const int __ID__ = 495315430;
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
