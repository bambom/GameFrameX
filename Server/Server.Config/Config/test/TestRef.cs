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
public sealed partial class TestRef :  Bright.Config.BeanBase 
{
    public TestRef(JsonElement _json) 
    {
        Id = _json.GetProperty("id").GetInt32();
        X1 = _json.GetProperty("x1").GetInt32();
        X12 = _json.GetProperty("x1_2").GetInt32();
        X2 = _json.GetProperty("x2").GetInt32();
        X3 = _json.GetProperty("x3").GetInt32();
        X4 = _json.GetProperty("x4").GetInt32();
        { var __json0 = _json.GetProperty("a1"); int _n0 = __json0.GetArrayLength(); A1 = new int[_n0]; int __index0=0; foreach(JsonElement __e0 in __json0.EnumerateArray()) { int __v0;  __v0 = __e0.GetInt32();  A1[__index0++] = __v0; }   }
        { var __json0 = _json.GetProperty("a2"); int _n0 = __json0.GetArrayLength(); A2 = new int[_n0]; int __index0=0; foreach(JsonElement __e0 in __json0.EnumerateArray()) { int __v0;  __v0 = __e0.GetInt32();  A2[__index0++] = __v0; }   }
        { var __json0 = _json.GetProperty("b1"); B1 = new System.Collections.Generic.List<int>(__json0.GetArrayLength()); foreach(JsonElement __e0 in __json0.EnumerateArray()) { int __v0;  __v0 = __e0.GetInt32();  B1.Add(__v0); }   }
        { var __json0 = _json.GetProperty("b2"); B2 = new System.Collections.Generic.List<int>(__json0.GetArrayLength()); foreach(JsonElement __e0 in __json0.EnumerateArray()) { int __v0;  __v0 = __e0.GetInt32();  B2.Add(__v0); }   }
        { var __json0 = _json.GetProperty("c1"); C1 = new System.Collections.Generic.HashSet<int>(__json0.GetArrayLength()); foreach(JsonElement __e0 in __json0.EnumerateArray()) { int __v0;  __v0 = __e0.GetInt32();  C1.Add(__v0); }   }
        { var __json0 = _json.GetProperty("c2"); C2 = new System.Collections.Generic.HashSet<int>(__json0.GetArrayLength()); foreach(JsonElement __e0 in __json0.EnumerateArray()) { int __v0;  __v0 = __e0.GetInt32();  C2.Add(__v0); }   }
        { var __json0 = _json.GetProperty("d1"); D1 = new System.Collections.Generic.Dictionary<int, int>(__json0.GetArrayLength()); foreach(JsonElement __e0 in __json0.EnumerateArray()) { int _k0;  _k0 = __e0[0].GetInt32(); int _v0;  _v0 = __e0[1].GetInt32();  D1.Add(_k0, _v0); }   }
        { var __json0 = _json.GetProperty("d2"); D2 = new System.Collections.Generic.Dictionary<int, int>(__json0.GetArrayLength()); foreach(JsonElement __e0 in __json0.EnumerateArray()) { int _k0;  _k0 = __e0[0].GetInt32(); int _v0;  _v0 = __e0[1].GetInt32();  D2.Add(_k0, _v0); }   }
        E1 = _json.GetProperty("e1").GetInt32();
        E2 = _json.GetProperty("e2").GetInt64();
        E3 = _json.GetProperty("e3").GetString();
        F1 = _json.GetProperty("f1").GetInt32();
        F2 = _json.GetProperty("f2").GetInt64();
        F3 = _json.GetProperty("f3").GetString();
        S1 = test.RefDynamicBase.DeserializeRefDynamicBase(_json.GetProperty("s1"));
        PostInit();
    }

    public TestRef(int id, int x1, int x1_2, int x2, int x3, int x4, int[] a1, int[] a2, System.Collections.Generic.List<int> b1, System.Collections.Generic.List<int> b2, System.Collections.Generic.HashSet<int> c1, System.Collections.Generic.HashSet<int> c2, System.Collections.Generic.Dictionary<int, int> d1, System.Collections.Generic.Dictionary<int, int> d2, int e1, long e2, string e3, int f1, long f2, string f3, test.RefDynamicBase s1 ) 
    {
        this.Id = id;
        this.X1 = x1;
        this.X12 = x1_2;
        this.X2 = x2;
        this.X3 = x3;
        this.X4 = x4;
        this.A1 = a1;
        this.A2 = a2;
        this.B1 = b1;
        this.B2 = b2;
        this.C1 = c1;
        this.C2 = c2;
        this.D1 = d1;
        this.D2 = d2;
        this.E1 = e1;
        this.E2 = e2;
        this.E3 = e3;
        this.F1 = f1;
        this.F2 = f2;
        this.F3 = f3;
        this.S1 = s1;
        PostInit();
    }

    public static TestRef DeserializeTestRef(JsonElement _json)
    {
        return new test.TestRef(_json);
    }

    public int Id { get; private set; }
    public int X1 { get; private set; }
    public test.TestBeRef X1_Ref { get; private set; }
    public int X12 { get; private set; }
    public int X2 { get; private set; }
    public int X3 { get; private set; }
    public int X4 { get; private set; }
    public tag.TestTag X4_Ref { get; private set; }
    public int[] A1 { get; private set; }
    public test.TestBeRef[] A1_Ref { get; private set; }
    public int[] A2 { get; private set; }
    public test.TestBeRef[] A2_Ref { get; private set; }
    public System.Collections.Generic.List<int> B1 { get; private set; }
    public System.Collections.Generic.List<test.TestBeRef> B1_Ref { get; private set; }
    public System.Collections.Generic.List<int> B2 { get; private set; }
    public System.Collections.Generic.List<test.TestBeRef> B2_Ref { get; private set; }
    public System.Collections.Generic.HashSet<int> C1 { get; private set; }
    public System.Collections.Generic.HashSet<test.TestBeRef> C1_Ref { get; private set; }
    public System.Collections.Generic.HashSet<int> C2 { get; private set; }
    public System.Collections.Generic.HashSet<test.TestBeRef> C2_Ref { get; private set; }
    public System.Collections.Generic.Dictionary<int, int> D1 { get; private set; }
    public System.Collections.Generic.Dictionary<int, test.TestBeRef> D1_Ref { get; private set; }
    public System.Collections.Generic.Dictionary<int, int> D2 { get; private set; }
    public System.Collections.Generic.Dictionary<int, test.TestBeRef> D2_Ref { get; private set; }
    public int E1 { get; private set; }
    public long E2 { get; private set; }
    public string E3 { get; private set; }
    public int F1 { get; private set; }
    public long F2 { get; private set; }
    public string F3 { get; private set; }
    public test.RefDynamicBase S1 { get; private set; }

    public const int __ID__ = -543222491;
    public override int GetTypeId() => __ID__;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        this.X1_Ref = (_tables["test.TbTestBeRef"] as test.TbTestBeRef).GetOrDefault(X1);
        this.X4_Ref = (_tables["tag.TbTestTag"] as tag.TbTestTag).GetOrDefault(X4);
        { int __n = A1.Length; test.TbTestBeRef __table = (test.TbTestBeRef)_tables["test.TbTestBeRef"]; this.A1_Ref = new test.TestBeRef[__n]; for(int i = 0 ; i < __n ; i++) { this.A1_Ref[i] =  __table.GetOrDefault(A1[i]); } }
        { int __n = A2.Length; test.TbTestBeRef __table = (test.TbTestBeRef)_tables["test.TbTestBeRef"]; this.A2_Ref = new test.TestBeRef[__n]; for(int i = 0 ; i < __n ; i++) { this.A2_Ref[i] =  __table.GetOrDefault(A2[i]); } }
        { test.TbTestBeRef __table = (test.TbTestBeRef)_tables["test.TbTestBeRef"]; this.B1_Ref = new System.Collections.Generic.List<test.TestBeRef>(); foreach(var __e in B1) { this.B1_Ref.Add(__table.GetOrDefault(__e)); } }
        { test.TbTestBeRef __table = (test.TbTestBeRef)_tables["test.TbTestBeRef"]; this.B2_Ref = new System.Collections.Generic.List<test.TestBeRef>(); foreach(var __e in B2) { this.B2_Ref.Add(__table.GetOrDefault(__e)); } }
        { test.TbTestBeRef __table = (test.TbTestBeRef)_tables["test.TbTestBeRef"]; this.C1_Ref = new System.Collections.Generic.HashSet<test.TestBeRef>(); foreach(var __e in C1) { this.C1_Ref.Add(__table.GetOrDefault(__e)); } }
        { test.TbTestBeRef __table = (test.TbTestBeRef)_tables["test.TbTestBeRef"]; this.C2_Ref = new System.Collections.Generic.HashSet<test.TestBeRef>(); foreach(var __e in C2) { this.C2_Ref.Add(__table.GetOrDefault(__e)); } }
        { test.TbTestBeRef __table = (test.TbTestBeRef)_tables["test.TbTestBeRef"]; this.D1_Ref = new System.Collections.Generic.Dictionary<int, test.TestBeRef>(); foreach(var __e in D1) { this.D1_Ref.Add(__e.Key, __table.GetOrDefault(__e.Value)); } }
        { test.TbTestBeRef __table = (test.TbTestBeRef)_tables["test.TbTestBeRef"]; this.D2_Ref = new System.Collections.Generic.Dictionary<int, test.TestBeRef>(); foreach(var __e in D2) { this.D2_Ref.Add(__e.Key, __table.GetOrDefault(__e.Value)); } }
        S1?.Resolve(_tables);
        PostResolve();
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
        S1?.TranslateText(translator);
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "X1:" + X1 + ","
        + "X12:" + X12 + ","
        + "X2:" + X2 + ","
        + "X3:" + X3 + ","
        + "X4:" + X4 + ","
        + "A1:" + Bright.Common.StringUtil.CollectionToString(A1) + ","
        + "A2:" + Bright.Common.StringUtil.CollectionToString(A2) + ","
        + "B1:" + Bright.Common.StringUtil.CollectionToString(B1) + ","
        + "B2:" + Bright.Common.StringUtil.CollectionToString(B2) + ","
        + "C1:" + Bright.Common.StringUtil.CollectionToString(C1) + ","
        + "C2:" + Bright.Common.StringUtil.CollectionToString(C2) + ","
        + "D1:" + Bright.Common.StringUtil.CollectionToString(D1) + ","
        + "D2:" + Bright.Common.StringUtil.CollectionToString(D2) + ","
        + "E1:" + E1 + ","
        + "E2:" + E2 + ","
        + "E3:" + E3 + ","
        + "F1:" + F1 + ","
        + "F2:" + F2 + ","
        + "F3:" + F3 + ","
        + "S1:" + S1 + ","
        + "}";
    }

    partial void PostInit();
    partial void PostResolve();
}
}
