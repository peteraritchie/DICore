namespace PRI.DICore.SystemNetHttp
{
	public sealed partial class ProductHeaderValue
	{
		/// <summary>
		/// <see cref="System.Net.Http.Headers.ProductHeaderValue.System.ICloneable.Clone"/>
		/// </summary>
		object System.ICloneable.Clone()
		{
			return ((System.ICloneable) (this.containedObject)).Clone();
		}
	}
}