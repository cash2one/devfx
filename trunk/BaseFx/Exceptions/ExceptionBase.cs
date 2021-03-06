﻿/* Copyright(c) 2005-2011 R2@DevFx.NET, License(LGPL) */

using System;
using System.Runtime.Serialization;

namespace HTB.DevFx.Exceptions
{
	/// <summary>
	/// 异常模块异常，框架的基础异常类，所有的异常请从本类派生
	/// </summary>
	[Serializable]
	public class ExceptionBase : Exception
	{
		/// <summary>
		/// 构造函数
		/// </summary>
		public ExceptionBase() : this(0, null, null) {
		}

		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name="message">异常消息</param>
		/// <param name="innerException">内部异常</param>
		public ExceptionBase(string message, Exception innerException) : this(0, message, innerException) {
		}

		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name="message">异常消息</param>
		public ExceptionBase(string message) : this(0, message) {
		}

		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name="errorNo">异常编号</param>
		/// <param name="message">异常消息</param>
		public ExceptionBase(int errorNo, string message) : this(errorNo, message, null) {
		}

		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name="errorNo">异常编号</param>
		/// <param name="message">异常消息</param>
		/// <param name="innerException">内部异常</param>
		public ExceptionBase(int errorNo, string message, Exception innerException) : base(message, innerException) {
			this.ErrorNo = errorNo;
		}

		/// <summary>
		/// 序列化和反序列化时的构造函数
		/// </summary>
		/// <param name="info">The System.Runtime.Serialization.SerializationInfo that holds the serialized object data about the exception being thrown.</param>
		/// <param name="context">The System.Runtime.Serialization.StreamingContext that contains contextual information about the source or destination.</param>
		protected ExceptionBase(SerializationInfo info, StreamingContext context) : base(info, context) {
		}

		/// <summary>
		/// 异常编号
		/// </summary>
		public int ErrorNo { get; protected set; }

		/// <summary>
		/// 查找原始的异常
		/// </summary>
		/// <param name="e">异常</param>
		/// <returns>原始的异常</returns>
		public static Exception FindSourceException(Exception e) {
			var e1 = e;
			while(e1 != null) {
				e = e1;
				e1 = e1.InnerException;
			}
			return e;
		}

		/// <summary>
		/// 从异常树种查找指定类型的异常
		/// </summary>
		/// <param name="e">异常</param>
		/// <param name="expectedExceptionType">期待的异常类型</param>
		/// <returns>所要求的异常，如果找不到，返回null</returns>
		public static Exception FindSourceException(Exception e, Type expectedExceptionType) {
			while(e != null) {
				if(e.GetType() == expectedExceptionType) {
					return e;
				}
				e = e.InnerException;
			}
			return null;
		}
	}
}