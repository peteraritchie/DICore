namespace PRI.DICore.SystemNetHttp
{
	public sealed partial class ContentDispositionHeaderValue
	{
		/// <summary>
		/// <see cref="System.Net.Http.Headers.ContentDispositionHeaderValue.System.ICloneable.Clone"/>
		/// </summary>
		object System.ICloneable.Clone()
		{
			return ((System.ICloneable) (this.containedObject)).Clone();
		}
	}
}