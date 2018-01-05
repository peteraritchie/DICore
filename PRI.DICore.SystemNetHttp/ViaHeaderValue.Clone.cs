namespace PRI.DICore.SystemNetHttp
{
	public sealed partial class ViaHeaderValue
	{
		/// <summary>
		/// <see cref="System.Net.Http.Headers.ViaHeaderValue.System.ICloneable.Clone"/>
		/// </summary>
		object System.ICloneable.Clone()
		{
			return ((System.ICloneable) (this.containedObject)).Clone();
		}
	}
}