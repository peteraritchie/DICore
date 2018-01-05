namespace PRI.DICore.SystemNetHttp
{
	public sealed partial class RangeHeaderValue
	{
		/// <summary>
		/// <see cref="System.Net.Http.Headers.RangeHeaderValue.System.ICloneable.Clone"/>
		/// </summary>
		object System.ICloneable.Clone()
		{
			return ((System.ICloneable) (this.containedObject)).Clone();
		}
	}
}