namespace PRI.DICore.SystemNetHttp
{
	public sealed partial class WarningHeaderValue
	{
		/// <summary>
		/// <see cref="System.Net.Http.Headers.WarningHeaderValue.System.ICloneable.Clone"/>
		/// </summary>
		object System.ICloneable.Clone()
		{
			return ((System.ICloneable) (this.containedObject)).Clone();
		}
	}
}