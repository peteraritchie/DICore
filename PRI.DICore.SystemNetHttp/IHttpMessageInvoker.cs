//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace PRI.DICore.SystemNetHttp
{


	/// <summary>
	/// An interface to model an abstraction of <see cref="System.Net.Http.HttpMessageInvoker" />
	/// </summary>
	public interface IHttpMessageInvoker : System.IDisposable
	{

		System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> SendAsync(System.Net.Http.HttpRequestMessage request, System.Threading.CancellationToken cancellationToken);
	}
}
