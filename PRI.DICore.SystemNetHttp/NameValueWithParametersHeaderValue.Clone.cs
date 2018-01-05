namespace PRI.DICore.SystemNetHttp
{
	public sealed partial class NameValueWithParametersHeaderValue
	{
		/// <summary>
		/// <see cref="System.Net.Http.Headers.NameValueWithParametersHeaderValue.System.ICloneable.Clone"/>
		/// </summary>
		object System.ICloneable.Clone()
		{
			return ((System.ICloneable) (this.containedObject)).Clone();
		}
	}
}