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
	/// Default implementation of <sealso cref="IEntityTagHeaderValue" />
	/// </summary>
	public sealed partial class EntityTagHeaderValue : IEntityTagHeaderValue
	{

		private System.Net.Http.Headers.EntityTagHeaderValue containedObject;

		public EntityTagHeaderValue(System.Net.Http.Headers.EntityTagHeaderValue containedObject)
		{
			if ((containedObject == null))
			{
				throw new System.ArgumentNullException("containedObject");
			}
			this.containedObject = containedObject;
		}

		/// <summary>
		/// <see cref="System.Net.Http.Headers.EntityTagHeaderValue.Tag"/>
		/// </summary>
		public string Tag
		{
			get
			{
				return this.containedObject.Tag;
			}
		}

		/// <summary>
		/// <see cref="System.Net.Http.Headers.EntityTagHeaderValue.IsWeak"/>
		/// </summary>
		public bool IsWeak
		{
			get
			{
				return this.containedObject.IsWeak;
			}
		}

		/// <summary>
		/// <see cref="System.Net.Http.Headers.EntityTagHeaderValue.ToString"/>
		/// </summary>
		public override string ToString()
		{
			return this.containedObject.ToString();
		}

		/// <summary>
		/// <see cref="System.Net.Http.Headers.EntityTagHeaderValue.Equals"/>
		/// </summary>
		public override bool Equals(object obj)
		{
			return this.containedObject.Equals(obj);
		}

		/// <summary>
		/// <see cref="System.Net.Http.Headers.EntityTagHeaderValue.GetHashCode"/>
		/// </summary>
		public override int GetHashCode()
		{
			return this.containedObject.GetHashCode();
		}
	}
}
