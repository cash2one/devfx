﻿/* Copyright(c) 2005-2011 R2@DevFx.NET, License(LGPL) */

namespace HTB.DevFx.Core
{
	public interface IObjectServiceContext : IObjectContext
	{
		IObjectService ObjectService { get; }
	}
}
