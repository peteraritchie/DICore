namespace PRI.DICore.SystemNetHttp
{
	public sealed partial class AuthenticationHeaderValue
	{
		/// <summary>
		/// <see cref="System.Net.Http.Headers.AuthenticationHeaderValue.System.ICloneable.Clone"/>
		/// </summary>
		object System.ICloneable.Clone()
		{
			return ((System.ICloneable) (this.containedObject)).Clone();
		}
	}
}