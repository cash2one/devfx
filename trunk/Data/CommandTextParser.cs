﻿/* Copyright(c) 2005-2011 R2@DevFx.NET, License(LGPL) */

using System.Collections;
using HTB.DevFx.Data.Config;

namespace HTB.DevFx.Data
{
	public class CommandTextParser : ICommandTextParser
	{
		protected CommandTextParser() { }

		protected virtual string GetCommandText(IStatementSetting statement, IDictionary parameters) {
			return statement.StatementText.ConfigSetting.Value.Value;
		}

		#region ICommandTextParser Members

		string ICommandTextParser.GetCommandText(IStatementSetting statement, IDictionary parameters) {
			return this.GetCommandText(statement, parameters);
		}

		#endregion
	}
}
