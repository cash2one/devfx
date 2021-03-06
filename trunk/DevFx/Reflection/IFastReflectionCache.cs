﻿/* Copyright(c) 2005-2011 R2@DevFx.NET, License(LGPL) */

namespace HTB.DevFx.Reflection
{
	internal interface IFastReflectionCache<TKey, TValue>
	{
		TValue Get(TKey key);
	}
}