
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Text.Json;
using Server.Config.Core;


namespace cfg.test
{
public partial class TbExcelFromJsonMultiRow
{
    private readonly System.Collections.Generic.Dictionary<int, test.ExcelFromJsonMultiRow> _dataMap;
    private readonly System.Collections.Generic.List<test.ExcelFromJsonMultiRow> _dataList;
    
    public TbExcelFromJsonMultiRow(JsonElement _buf)
    {
        _dataMap = new System.Collections.Generic.Dictionary<int, test.ExcelFromJsonMultiRow>();
        _dataList = new System.Collections.Generic.List<test.ExcelFromJsonMultiRow>();
        
        foreach(JsonElement _ele in _buf.EnumerateArray())
        {
            test.ExcelFromJsonMultiRow _v;
            _v = test.ExcelFromJsonMultiRow.DeserializeExcelFromJsonMultiRow(_ele);
            _dataList.Add(_v);
            _dataMap.Add(_v.Id, _v);
        }
    }

    public System.Collections.Generic.Dictionary<int, test.ExcelFromJsonMultiRow> DataMap => _dataMap;
    public System.Collections.Generic.List<test.ExcelFromJsonMultiRow> DataList => _dataList;

    public test.ExcelFromJsonMultiRow GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public test.ExcelFromJsonMultiRow Get(int key) => _dataMap[key];
    public test.ExcelFromJsonMultiRow this[int key] => _dataMap[key];

    public void ResolveRef(Tables tables)
    {
        foreach(var _v in _dataList)
        {
            _v.ResolveRef(tables);
        }
    }

}

}