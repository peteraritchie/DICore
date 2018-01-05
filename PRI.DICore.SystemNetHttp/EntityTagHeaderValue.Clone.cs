namespace PRI.DICore.SystemNetHttp
{
	public sealed partial class EntityTagHeaderValue
	{
		/// <summary>
		/// <see cref="System.Net.Http.Headers.EntityTagHeaderValue.System.ICloneable.Clone"/>
		/// </summary>
		object System.ICloneable.Clone()
		{
			return ((System.ICloneable) (this.containedObject)).Clone();
		}
	}
}