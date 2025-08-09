using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using XLua;
public class LuaStudy : MonoBehaviour
{
    private void Start()
    {
        var luamgr = LuaManager.instance;
        luamgr.DoScript("methodTest");
        //无参无返回
        var method1 = luamgr.Global.Get<LuaFunction>("method1");
        method1.Call();
        //有参无返回
        var method2 = luamgr.Global.Get<LuaFunction>("method2");
        method2.Call("傻呗参数");
        //有一返回
        var method3 = luamgr.Global.Get<LuaFunction>("method3");
        print(method3.Call()[0]);
    }
}
