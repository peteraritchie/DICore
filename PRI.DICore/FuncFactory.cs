using System;

namespace PRI.DICore
{
	/// <summary>
	/// A convenience class to create an instance of an IFactory{T} implementation
	/// for creating instances of <typeparamref name="T"/> based on a <see cref="Func{TIn, TOut}"/>
	/// </summary>
	/// <typeparam name="T">The type of the objects to create</typeparam>
	class FuncFactory<T> : IFactory<T> where T : class
	{
		private readonly Func<object, T> func;

		public FuncFactory(Func<object, T> func)
		{
			this.func = func;
		}

		public T Create(object context)
		{
			return func(context);
		}
	}
}