namespace PRI.DICore.SystemNetHttp
{
	public sealed partial class CacheControlHeaderValue
	{
		/// <summary>
		/// <see cref="System.Net.Http.Headers.CacheControlHeaderValue.System.ICloneable.Clone"/>
		/// </summary>
		object System.ICloneable.Clone()
		{
			return ((System.ICloneable) (this.containedObject)).Clone();
		}
	}
}