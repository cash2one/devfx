﻿/* Copyright(c) 2005-2011 R2@DevFx.NET, License(LGPL) */

namespace HTB.DevFx.Reflection
{
	internal interface IConstructorInvoker
	{
		object Invoke(params object[] parameters);
	}
}
