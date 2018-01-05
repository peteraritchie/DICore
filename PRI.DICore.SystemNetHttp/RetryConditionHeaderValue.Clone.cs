namespace PRI.DICore.SystemNetHttp
{
	public sealed partial class RetryConditionHeaderValue
	{
		/// <summary>
		/// <see cref="System.Net.Http.Headers.RetryConditionHeaderValue.System.ICloneable.Clone"/>
		/// </summary>
		object System.ICloneable.Clone()
		{
			return ((System.ICloneable) (this.containedObject)).Clone();
		}
	}
}