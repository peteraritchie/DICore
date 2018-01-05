namespace PRI.DICore.SystemNetHttp
{
	public sealed partial class RangeItemHeaderValue
	{
		/// <summary>
		/// <see cref="System.Net.Http.Headers.RangeItemHeaderValue.System.ICloneable.Clone"/>
		/// </summary>
		object System.ICloneable.Clone()
		{
			return ((System.ICloneable) (this.containedObject)).Clone();
		}
	}
}