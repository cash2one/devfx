﻿/* Copyright(c) 2005-2011 R2@DevFx.NET, License(LGPL) */

using HTB.DevFx.Config;

namespace HTB.DevFx.Core.Config
{
	public interface IStartupSetting : IConfigSettingRequired
	{
		ICoreSetting CoreSetting { get; }
	}
}
