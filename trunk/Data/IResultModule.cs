﻿/* Copyright(c) 2005-2011 R2@DevFx.NET, License(LGPL) */

namespace HTB.DevFx.Data
{
	public interface IResultModule
	{
		void OnResultExecute(IDbResultContext ctx);
	}
}
