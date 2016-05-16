using System;
using System.Collections.Generic;

namespace PRI.DICore
{
	/// <summary>
	/// A convenience class to create an instance of an IEqualityComparer{T} implementation
	/// for equality comparison within collections based on a <see cref="Func{T,T,TResult}"/>
	/// for equality and a or <see cref="Func{T,TResult}"/> for a hash
	/// </summary>
	/// <typeparam name="T">The type of the objects to compare</typeparam>
	public class FuncEqualityComparer<T> : EqualityComparer<T>
	{
		private readonly Func<T, T, bool> equals;
		private readonly Func<T, int> hash;

		public FuncEqualityComparer(Func<T, T, bool> @equals, Func<T, int> hash)
		{
			if (@equals == null) throw new ArgumentNullException(nameof(@equals));
			if (hash == null) throw new ArgumentNullException(nameof(hash));
			this.@equals = @equals;
			this.hash = hash;
		}

		public override bool Equals(T x, T y)
		{
			return @equals(x, y);
		}

		public override int GetHashCode(T obj)
		{
			return hash(obj);
		}
	}
}