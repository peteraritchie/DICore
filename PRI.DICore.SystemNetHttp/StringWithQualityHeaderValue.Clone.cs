namespace PRI.DICore.SystemNetHttp
{
	public sealed partial class StringWithQualityHeaderValue
	{
		/// <summary>
		/// <see cref="System.Net.Http.Headers.StringWithQualityHeaderValue.System.ICloneable.Clone"/>
		/// </summary>
		object System.ICloneable.Clone()
		{
			return ((System.ICloneable) (this.containedObject)).Clone();
		}
	}
}