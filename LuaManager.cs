using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using XLua;
using static XLua.LuaEnv;

public class LuaManager
{
    public static LuaManager instance = new LuaManager();
    private LuaEnv env;
    public LuaTable Global => env.Global;
    private LuaManager()
    {
        instance = this;
        Inti();
    }
    //执行命令
    public object[] DoString(string commad)
    {
        return env.DoString(commad);
    }
    public object[] DoScript(string FileName)
    {
        return DoString($"require('{FileName}')");
    }
    private void Inti()
    {
        env = new LuaEnv();
        //自定义加载路径
        env.AddLoader(LoadResourceLuaByte);
    }
    private byte[] LoadResourceLuaByte(ref string fileName)
    {
        if (string.IsNullOrEmpty(fileName))
            return null;
        var path = Path.Combine(Application.dataPath, "Lua", fileName + ".lua");
        return File.Exists(path) ? File.ReadAllBytes(path) : null;
    }

}
