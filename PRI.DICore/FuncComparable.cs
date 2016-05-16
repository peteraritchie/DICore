using System;

namespace PRI.DICore
{
	/// <summary>
	/// A convenience class to create an instance of an IComparable{T} implementation
	/// for ordering/sorting comparison within collections based on a <see cref="Func{T,T,TResult}"/>
	/// or <see cref="Comparison{T}"/>
	/// </summary>
	/// <typeparam name="T">The type of the objects to compare</typeparam>
	public class FuncComparable<T> : IComparable<T>
	{
		private readonly T me;
		private readonly Comparison<T> compare;

		public FuncComparable(T me, Comparison<T> compare)
		{
			if (me == null) throw new ArgumentNullException(nameof(me));
			if (compare == null) throw new ArgumentNullException(nameof(compare));
			this.me = me;
			this.compare = compare;
		}

		public FuncComparable(T me, Func<T, T, int> compare)
			: this(me, (Comparison<T>) ((x, y) => compare(x, y)))
		{
		}

		public int CompareTo(T other)
		{
			return compare(me, other);
		}
	}
}