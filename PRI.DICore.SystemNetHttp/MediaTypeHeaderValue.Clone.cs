namespace PRI.DICore.SystemNetHttp
{
	public sealed partial class MediaTypeHeaderValue
	{
		/// <summary>
		/// <see cref="System.Net.Http.Headers.MediaTypeHeaderValue.System.ICloneable.Clone"/>
		/// </summary>
		object System.ICloneable.Clone()
		{
			return ((System.ICloneable) (this.containedObject)).Clone();
		}
	}
}