﻿/* Copyright(c) 2005-2011 R2@DevFx.NET, License(LGPL) */

namespace HTB.DevFx.Esb.Config
{
	internal interface IObjectSettingInternal : IObjectSetting
	{
		object ObjectInstance { get; set; }
	}
}
