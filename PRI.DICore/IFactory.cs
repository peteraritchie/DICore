namespace PRI.DICore
{
	/// <summary>
	/// A generic interface to model and abstract factory of <typeparamref name="T"/> instances
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public interface IFactory<out T> where T : class
	{
		T Create(object context);
	}
}