namespace PRI.DICore.SystemNetHttp
{
	public sealed partial class NameValueHeaderValue
	{
		/// <summary>
		/// <see cref="System.Net.Http.Headers.NameValueHeaderValue.System.ICloneable.Clone"/>
		/// </summary>
		object System.ICloneable.Clone()
		{
			return ((System.ICloneable) (this.containedObject)).Clone();
		}
	}
}