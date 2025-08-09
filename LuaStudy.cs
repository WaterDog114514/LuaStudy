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
        //�޲��޷���
        var method1 = luamgr.Global.Get<LuaFunction>("method1");
        method1.Call();
        //�в��޷���
        var method2 = luamgr.Global.Get<LuaFunction>("method2");
        method2.Call("ɵ�²���");
        //��һ����
        var method3 = luamgr.Global.Get<LuaFunction>("method3");
        print(method3.Call()[0]);
    }
}
