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



namespace cfg.error
{
public abstract partial class ErrorStyle :  Bright.Config.BeanBase 
{
    public ErrorStyle(JsonElement _json) 
    {
        PostInit();
    }

    public ErrorStyle() 
    {
        PostInit();
    }

    public static ErrorStyle DeserializeErrorStyle(JsonElement _json)
    {
        switch (_json.GetProperty("$type").GetString())
        {
            case "ErrorStyleTip": return new error.ErrorStyleTip(_json);
            case "ErrorStyleMsgbox": return new error.ErrorStyleMsgbox(_json);
            case "ErrorStyleDlgOk": return new error.ErrorStyleDlgOk(_json);
            case "ErrorStyleDlgOkCancel": return new error.ErrorStyleDlgOkCancel(_json);
            default: throw new SerializationException();
        }
    }



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
        + "}";
    }

    partial void PostInit();
    partial void PostResolve();
}
}