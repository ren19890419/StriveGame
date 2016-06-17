﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using System.Collections.Generic;
using LuaInterface;

public static class DelegateFactory
{
	delegate Delegate DelegateValue(LuaFunction func);
	static Dictionary<Type, DelegateValue> dict = new Dictionary<Type, DelegateValue>();

	static DelegateFactory()
	{
		Register();
	}

	[NoToLuaAttribute]
	public static void Register()
	{
		dict.Clear();
		dict.Add(typeof(System.Action), System_Action);
		dict.Add(typeof(UnityEngine.Events.UnityAction), UnityEngine_Events_UnityAction);
		dict.Add(typeof(UnityEngine.Application.LogCallback), UnityEngine_Application_LogCallback);
		dict.Add(typeof(UnityEngine.Application.AdvertisingIdentifierCallback), UnityEngine_Application_AdvertisingIdentifierCallback);
		dict.Add(typeof(UnityEngine.Camera.CameraCallback), UnityEngine_Camera_CameraCallback);
		dict.Add(typeof(UnityEngine.AudioClip.PCMReaderCallback), UnityEngine_AudioClip_PCMReaderCallback);
		dict.Add(typeof(UnityEngine.AudioClip.PCMSetPositionCallback), UnityEngine_AudioClip_PCMSetPositionCallback);
		dict.Add(typeof(UnityEngine.RectTransform.ReapplyDrivenProperties), UnityEngine_RectTransform_ReapplyDrivenProperties);
		dict.Add(typeof(UnityEngine.UI.InputField.OnValidateInput), UnityEngine_UI_InputField_OnValidateInput);
		dict.Add(typeof(System.Action<NotiData>), System_Action_NotiData);
		dict.Add(typeof(System.Action<UnityEngine.Object[]>), System_Action_UnityEngine_Objects);
		dict.Add(typeof(KBEngine.NetworkInterface.ConnectCallback), KBEngine_NetworkInterface_ConnectCallback);
		dict.Add(typeof(EasyJoystick.JoystickMoveStartHandler), EasyJoystick_JoystickMoveStartHandler);
		dict.Add(typeof(EasyJoystick.JoystickMoveHandler), EasyJoystick_JoystickMoveHandler);
		dict.Add(typeof(EasyJoystick.JoystickMoveEndHandler), EasyJoystick_JoystickMoveEndHandler);
		dict.Add(typeof(EasyJoystick.JoystickTouchStartHandler), EasyJoystick_JoystickTouchStartHandler);
		dict.Add(typeof(EasyJoystick.JoystickTapHandler), EasyJoystick_JoystickTapHandler);
		dict.Add(typeof(EasyJoystick.JoystickDoubleTapHandler), EasyJoystick_JoystickDoubleTapHandler);
		dict.Add(typeof(EasyJoystick.JoystickTouchUpHandler), EasyJoystick_JoystickTouchUpHandler);
	}

    [NoToLuaAttribute]
    public static Delegate CreateDelegate(Type t, LuaFunction func = null)
    {
        DelegateValue create = null;

        if (!dict.TryGetValue(t, out create))
        {
            throw new LuaException(string.Format("Delegate {0} not register", LuaMisc.GetTypeName(t)));            
        }
        
        return create(func);        
    }

    [NoToLuaAttribute]
    public static Delegate RemoveDelegate(Delegate obj, LuaFunction func)
    {
        LuaState state = func.GetLuaState();
        Delegate[] ds = obj.GetInvocationList();

        for (int i = 0; i < ds.Length; i++)
        {
            LuaDelegate ld = ds[i].Target as LuaDelegate;

            if (ld != null && ld.func == func)
            {
                obj = Delegate.Remove(obj, ds[i]);
                state.DelayDispose(ld.func);
                break;
            }
        }

        return obj;
    }

	class System_Action_Event : LuaDelegate
	{
		public System_Action_Event(LuaFunction func) : base(func) { }

		public void Call()
		{
			func.Call();
		}
	}

	public static Delegate System_Action(LuaFunction func)
	{
		if (func == null)
		{
			System.Action fn = delegate { };
			return fn;
		}

		System.Action d = (new System_Action_Event(func)).Call;
		return d;
	}

	class UnityEngine_Events_UnityAction_Event : LuaDelegate
	{
		public UnityEngine_Events_UnityAction_Event(LuaFunction func) : base(func) { }

		public void Call()
		{
			func.Call();
		}
	}

	public static Delegate UnityEngine_Events_UnityAction(LuaFunction func)
	{
		if (func == null)
		{
			UnityEngine.Events.UnityAction fn = delegate { };
			return fn;
		}

		UnityEngine.Events.UnityAction d = (new UnityEngine_Events_UnityAction_Event(func)).Call;
		return d;
	}

	class UnityEngine_Application_LogCallback_Event : LuaDelegate
	{
		public UnityEngine_Application_LogCallback_Event(LuaFunction func) : base(func) { }

		public void Call(string param0,string param1,UnityEngine.LogType param2)
		{
			func.BeginPCall();
			func.Push(param0);
			func.Push(param1);
			func.Push(param2);
			func.PCall();
			func.EndPCall();
		}
	}

	public static Delegate UnityEngine_Application_LogCallback(LuaFunction func)
	{
		if (func == null)
		{
			UnityEngine.Application.LogCallback fn = delegate { };
			return fn;
		}

		UnityEngine.Application.LogCallback d = (new UnityEngine_Application_LogCallback_Event(func)).Call;
		return d;
	}

	class UnityEngine_Application_AdvertisingIdentifierCallback_Event : LuaDelegate
	{
		public UnityEngine_Application_AdvertisingIdentifierCallback_Event(LuaFunction func) : base(func) { }

		public void Call(string param0,bool param1,string param2)
		{
			func.BeginPCall();
			func.Push(param0);
			func.Push(param1);
			func.Push(param2);
			func.PCall();
			func.EndPCall();
		}
	}

	public static Delegate UnityEngine_Application_AdvertisingIdentifierCallback(LuaFunction func)
	{
		if (func == null)
		{
			UnityEngine.Application.AdvertisingIdentifierCallback fn = delegate { };
			return fn;
		}

		UnityEngine.Application.AdvertisingIdentifierCallback d = (new UnityEngine_Application_AdvertisingIdentifierCallback_Event(func)).Call;
		return d;
	}

	class UnityEngine_Camera_CameraCallback_Event : LuaDelegate
	{
		public UnityEngine_Camera_CameraCallback_Event(LuaFunction func) : base(func) { }

		public void Call(UnityEngine.Camera param0)
		{
			func.BeginPCall();
			func.Push(param0);
			func.PCall();
			func.EndPCall();
		}
	}

	public static Delegate UnityEngine_Camera_CameraCallback(LuaFunction func)
	{
		if (func == null)
		{
			UnityEngine.Camera.CameraCallback fn = delegate { };
			return fn;
		}

		UnityEngine.Camera.CameraCallback d = (new UnityEngine_Camera_CameraCallback_Event(func)).Call;
		return d;
	}

	class UnityEngine_AudioClip_PCMReaderCallback_Event : LuaDelegate
	{
		public UnityEngine_AudioClip_PCMReaderCallback_Event(LuaFunction func) : base(func) { }

		public void Call(float[] param0)
		{
			func.BeginPCall();
			func.Push(param0);
			func.PCall();
			func.EndPCall();
		}
	}

	public static Delegate UnityEngine_AudioClip_PCMReaderCallback(LuaFunction func)
	{
		if (func == null)
		{
			UnityEngine.AudioClip.PCMReaderCallback fn = delegate { };
			return fn;
		}

		UnityEngine.AudioClip.PCMReaderCallback d = (new UnityEngine_AudioClip_PCMReaderCallback_Event(func)).Call;
		return d;
	}

	class UnityEngine_AudioClip_PCMSetPositionCallback_Event : LuaDelegate
	{
		public UnityEngine_AudioClip_PCMSetPositionCallback_Event(LuaFunction func) : base(func) { }

		public void Call(int param0)
		{
			func.BeginPCall();
			func.Push(param0);
			func.PCall();
			func.EndPCall();
		}
	}

	public static Delegate UnityEngine_AudioClip_PCMSetPositionCallback(LuaFunction func)
	{
		if (func == null)
		{
			UnityEngine.AudioClip.PCMSetPositionCallback fn = delegate { };
			return fn;
		}

		UnityEngine.AudioClip.PCMSetPositionCallback d = (new UnityEngine_AudioClip_PCMSetPositionCallback_Event(func)).Call;
		return d;
	}

	class UnityEngine_RectTransform_ReapplyDrivenProperties_Event : LuaDelegate
	{
		public UnityEngine_RectTransform_ReapplyDrivenProperties_Event(LuaFunction func) : base(func) { }

		public void Call(UnityEngine.RectTransform param0)
		{
			func.BeginPCall();
			func.Push(param0);
			func.PCall();
			func.EndPCall();
		}
	}

	public static Delegate UnityEngine_RectTransform_ReapplyDrivenProperties(LuaFunction func)
	{
		if (func == null)
		{
			UnityEngine.RectTransform.ReapplyDrivenProperties fn = delegate { };
			return fn;
		}

		UnityEngine.RectTransform.ReapplyDrivenProperties d = (new UnityEngine_RectTransform_ReapplyDrivenProperties_Event(func)).Call;
		return d;
	}

	class UnityEngine_UI_InputField_OnValidateInput_Event : LuaDelegate
	{
		public UnityEngine_UI_InputField_OnValidateInput_Event(LuaFunction func) : base(func) { }

		public char Call(string param0,int param1,char param2)
		{
			func.BeginPCall();
			func.Push(param0);
			func.Push(param1);
			func.Push(param2);
			func.PCall();
			char ret = (char)func.CheckNumber();
			func.EndPCall();
			return ret;
		}
	}

	public static Delegate UnityEngine_UI_InputField_OnValidateInput(LuaFunction func)
	{
		if (func == null)
		{
			UnityEngine.UI.InputField.OnValidateInput fn = delegate { return '\0'; };
			return fn;
		}

		UnityEngine.UI.InputField.OnValidateInput d = (new UnityEngine_UI_InputField_OnValidateInput_Event(func)).Call;
		return d;
	}

	class System_Action_NotiData_Event : LuaDelegate
	{
		public System_Action_NotiData_Event(LuaFunction func) : base(func) { }

		public void Call(NotiData param0)
		{
			func.BeginPCall();
			func.PushObject(param0);
			func.PCall();
			func.EndPCall();
		}
	}

	public static Delegate System_Action_NotiData(LuaFunction func)
	{
		if (func == null)
		{
			System.Action<NotiData> fn = delegate { };
			return fn;
		}

		System.Action<NotiData> d = (new System_Action_NotiData_Event(func)).Call;
		return d;
	}

	class System_Action_UnityEngine_Objects_Event : LuaDelegate
	{
		public System_Action_UnityEngine_Objects_Event(LuaFunction func) : base(func) { }

		public void Call(UnityEngine.Object[] param0)
		{
			func.BeginPCall();
			func.Push(param0);
			func.PCall();
			func.EndPCall();
		}
	}

	public static Delegate System_Action_UnityEngine_Objects(LuaFunction func)
	{
		if (func == null)
		{
			System.Action<UnityEngine.Object[]> fn = delegate { };
			return fn;
		}

		System.Action<UnityEngine.Object[]> d = (new System_Action_UnityEngine_Objects_Event(func)).Call;
		return d;
	}

	class KBEngine_NetworkInterface_ConnectCallback_Event : LuaDelegate
	{
		public KBEngine_NetworkInterface_ConnectCallback_Event(LuaFunction func) : base(func) { }

		public void Call(string param0,int param1,bool param2,object param3)
		{
			func.BeginPCall();
			func.Push(param0);
			func.Push(param1);
			func.Push(param2);
			func.Push(param3);
			func.PCall();
			func.EndPCall();
		}
	}

	public static Delegate KBEngine_NetworkInterface_ConnectCallback(LuaFunction func)
	{
		if (func == null)
		{
			KBEngine.NetworkInterface.ConnectCallback fn = delegate { };
			return fn;
		}

		KBEngine.NetworkInterface.ConnectCallback d = (new KBEngine_NetworkInterface_ConnectCallback_Event(func)).Call;
		return d;
	}

	class EasyJoystick_JoystickMoveStartHandler_Event : LuaDelegate
	{
		public EasyJoystick_JoystickMoveStartHandler_Event(LuaFunction func) : base(func) { }

		public void Call(MovingJoystick param0)
		{
			func.BeginPCall();
			func.PushObject(param0);
			func.PCall();
			func.EndPCall();
		}
	}

	public static Delegate EasyJoystick_JoystickMoveStartHandler(LuaFunction func)
	{
		if (func == null)
		{
			EasyJoystick.JoystickMoveStartHandler fn = delegate { };
			return fn;
		}

		EasyJoystick.JoystickMoveStartHandler d = (new EasyJoystick_JoystickMoveStartHandler_Event(func)).Call;
		return d;
	}

	class EasyJoystick_JoystickMoveHandler_Event : LuaDelegate
	{
		public EasyJoystick_JoystickMoveHandler_Event(LuaFunction func) : base(func) { }

		public void Call(MovingJoystick param0)
		{
			func.BeginPCall();
			func.PushObject(param0);
			func.PCall();
			func.EndPCall();
		}
	}

	public static Delegate EasyJoystick_JoystickMoveHandler(LuaFunction func)
	{
		if (func == null)
		{
			EasyJoystick.JoystickMoveHandler fn = delegate { };
			return fn;
		}

		EasyJoystick.JoystickMoveHandler d = (new EasyJoystick_JoystickMoveHandler_Event(func)).Call;
		return d;
	}

	class EasyJoystick_JoystickMoveEndHandler_Event : LuaDelegate
	{
		public EasyJoystick_JoystickMoveEndHandler_Event(LuaFunction func) : base(func) { }

		public void Call(MovingJoystick param0)
		{
			func.BeginPCall();
			func.PushObject(param0);
			func.PCall();
			func.EndPCall();
		}
	}

	public static Delegate EasyJoystick_JoystickMoveEndHandler(LuaFunction func)
	{
		if (func == null)
		{
			EasyJoystick.JoystickMoveEndHandler fn = delegate { };
			return fn;
		}

		EasyJoystick.JoystickMoveEndHandler d = (new EasyJoystick_JoystickMoveEndHandler_Event(func)).Call;
		return d;
	}

	class EasyJoystick_JoystickTouchStartHandler_Event : LuaDelegate
	{
		public EasyJoystick_JoystickTouchStartHandler_Event(LuaFunction func) : base(func) { }

		public void Call(MovingJoystick param0)
		{
			func.BeginPCall();
			func.PushObject(param0);
			func.PCall();
			func.EndPCall();
		}
	}

	public static Delegate EasyJoystick_JoystickTouchStartHandler(LuaFunction func)
	{
		if (func == null)
		{
			EasyJoystick.JoystickTouchStartHandler fn = delegate { };
			return fn;
		}

		EasyJoystick.JoystickTouchStartHandler d = (new EasyJoystick_JoystickTouchStartHandler_Event(func)).Call;
		return d;
	}

	class EasyJoystick_JoystickTapHandler_Event : LuaDelegate
	{
		public EasyJoystick_JoystickTapHandler_Event(LuaFunction func) : base(func) { }

		public void Call(MovingJoystick param0)
		{
			func.BeginPCall();
			func.PushObject(param0);
			func.PCall();
			func.EndPCall();
		}
	}

	public static Delegate EasyJoystick_JoystickTapHandler(LuaFunction func)
	{
		if (func == null)
		{
			EasyJoystick.JoystickTapHandler fn = delegate { };
			return fn;
		}

		EasyJoystick.JoystickTapHandler d = (new EasyJoystick_JoystickTapHandler_Event(func)).Call;
		return d;
	}

	class EasyJoystick_JoystickDoubleTapHandler_Event : LuaDelegate
	{
		public EasyJoystick_JoystickDoubleTapHandler_Event(LuaFunction func) : base(func) { }

		public void Call(MovingJoystick param0)
		{
			func.BeginPCall();
			func.PushObject(param0);
			func.PCall();
			func.EndPCall();
		}
	}

	public static Delegate EasyJoystick_JoystickDoubleTapHandler(LuaFunction func)
	{
		if (func == null)
		{
			EasyJoystick.JoystickDoubleTapHandler fn = delegate { };
			return fn;
		}

		EasyJoystick.JoystickDoubleTapHandler d = (new EasyJoystick_JoystickDoubleTapHandler_Event(func)).Call;
		return d;
	}

	class EasyJoystick_JoystickTouchUpHandler_Event : LuaDelegate
	{
		public EasyJoystick_JoystickTouchUpHandler_Event(LuaFunction func) : base(func) { }

		public void Call(MovingJoystick param0)
		{
			func.BeginPCall();
			func.PushObject(param0);
			func.PCall();
			func.EndPCall();
		}
	}

	public static Delegate EasyJoystick_JoystickTouchUpHandler(LuaFunction func)
	{
		if (func == null)
		{
			EasyJoystick.JoystickTouchUpHandler fn = delegate { };
			return fn;
		}

		EasyJoystick.JoystickTouchUpHandler d = (new EasyJoystick_JoystickTouchUpHandler_Event(func)).Call;
		return d;
	}

}

