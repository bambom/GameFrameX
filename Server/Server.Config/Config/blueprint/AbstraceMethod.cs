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



namespace cfg.blueprint
{
public sealed partial class AbstraceMethod :  blueprint.Method 
{
    public AbstraceMethod(JsonElement _json)  : base(_json) 
    {
        PostInit();
    }

    public AbstraceMethod(string name, string desc, bool is_static, string return_type, System.Collections.Generic.List<blueprint.ParamInfo> parameters )  : base(name,desc,is_static,return_type,parameters) 
    {
        PostInit();
    }

    public static AbstraceMethod DeserializeAbstraceMethod(JsonElement _json)
    {
        return new blueprint.AbstraceMethod(_json);
    }


    public const int __ID__ = -392137809;
    public override int GetTypeId() => __ID__;

    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
        PostResolve();
    }

    public override void TranslateText(System.Func<string, string, string> translator)
    {
        base.TranslateText(translator);
    }

    public override string ToString()
    {
        return "{ "
        + "Name:" + Name + ","
        + "Desc:" + Desc + ","
        + "IsStatic:" + IsStatic + ","
        + "ReturnType:" + ReturnType + ","
        + "Parameters:" + Bright.Common.StringUtil.CollectionToString(Parameters) + ","
        + "}";
    }

    partial void PostInit();
    partial void PostResolve();
}
}
