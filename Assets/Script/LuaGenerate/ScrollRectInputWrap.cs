﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class ScrollRectInputWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(ScrollRectInput), typeof(UnityEngine.UI.ScrollRect));
		L.RegFunction("Init", Init);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("m_UIEventKey", get_m_UIEventKey, set_m_UIEventKey);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Init(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			ScrollRectInput obj = (ScrollRectInput)ToLua.CheckObject(L, 1, typeof(ScrollRectInput));
			string arg0 = ToLua.CheckString(L, 2);
			obj.Init(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.ToObject(L, 1);
			UnityEngine.Object arg1 = (UnityEngine.Object)ToLua.ToObject(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_m_UIEventKey(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			ScrollRectInput obj = (ScrollRectInput)o;
			string ret = obj.m_UIEventKey;
			LuaDLL.lua_pushstring(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index m_UIEventKey on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_m_UIEventKey(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			ScrollRectInput obj = (ScrollRectInput)o;
			string arg0 = ToLua.CheckString(L, 2);
			obj.m_UIEventKey = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index m_UIEventKey on a nil value" : e.Message);
		}
	}
}
