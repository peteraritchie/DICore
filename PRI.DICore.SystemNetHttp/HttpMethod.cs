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
	/// Default implementation of <sealso cref="IHttpMethod" />
	/// </summary>
	public sealed partial class HttpMethod : IHttpMethod
	{

		private System.Net.Http.HttpMethod containedObject;

		public HttpMethod(System.Net.Http.HttpMethod containedObject)
		{
			if ((containedObject == null))
			{
				throw new System.ArgumentNullException("containedObject");
			}
			this.containedObject = containedObject;
		}

		/// <summary>
		/// <see cref="System.Net.Http.HttpMethod.Method"/>
		/// </summary>
		public string Method
		{
			get
			{
				return this.containedObject.Method;
			}
		}

		/// <summary>
		/// <see cref="System.Net.Http.HttpMethod.Equals"/>
		/// </summary>
		public bool Equals(System.Net.Http.HttpMethod other)
		{
			return this.containedObject.Equals(other);
		}

		/// <summary>
		/// <see cref="System.Net.Http.HttpMethod.Equals"/>
		/// </summary>
		public override bool Equals(object obj)
		{
			return this.containedObject.Equals(obj);
		}

		/// <summary>
		/// <see cref="System.Net.Http.HttpMethod.GetHashCode"/>
		/// </summary>
		public override int GetHashCode()
		{
			return this.containedObject.GetHashCode();
		}

		/// <summary>
		/// <see cref="System.Net.Http.HttpMethod.ToString"/>
		/// </summary>
		public override string ToString()
		{
			return this.containedObject.ToString();
		}
	}
}
