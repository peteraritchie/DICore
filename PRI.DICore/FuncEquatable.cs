using System;

namespace PRI.DICore
{
	/// <summary>
	/// A convenience class to create an instance of an IEquatable{T} implementation
	/// for determining equality of instances based on a <see cref="Func{T,T,TResult}"/>.
	/// </summary>
	/// <typeparam name="T">The type of the objects to compare</typeparam>
	public class FuncEquatable<T> : IEquatable<T>
	{
		private readonly T me;
		private readonly Func<T, T, bool> equals;

		public FuncEquatable(T me, Func<T, T, bool> @equals)
		{
			if (me == null) throw new ArgumentNullException(nameof(me));
			if (@equals == null) throw new ArgumentNullException(nameof(@equals));
			this.me = me;
			this.@equals = @equals;
		}

		public bool Equals(T other)
		{
			return @equals(me, other);
		}
	}
}