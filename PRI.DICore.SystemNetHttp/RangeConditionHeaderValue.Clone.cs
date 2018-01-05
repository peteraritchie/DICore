namespace PRI.DICore.SystemNetHttp
{
	public sealed partial class RangeConditionHeaderValue
	{
		/// <summary>
		/// <see cref="System.Net.Http.Headers.RangeConditionHeaderValue.System.ICloneable.Clone"/>
		/// </summary>
		object System.ICloneable.Clone()
		{
			return ((System.ICloneable) (this.containedObject)).Clone();
		}
	}
}