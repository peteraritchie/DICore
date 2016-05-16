using System;
using System.Collections.Generic;

namespace PRI.DICore
{
	/// <summary>
	/// A convenience class to create an instance of an IComparer{T} implementation
	/// for comparison within collections based on a <see cref="Func{T,T,TResult}"/>
	/// or <see cref="Comparison{T}"/>.
	/// </summary>
	/// <typeparam name="T">The type of the objects to compare</typeparam>
	public class FuncComparer<T> : Comparer<T>
	{
		private readonly Comparison<T> compare;

		public FuncComparer(Comparison<T> compare)
		{
			if (compare == null) throw new ArgumentNullException(nameof(compare));
			this.compare = compare;
		}

		public FuncComparer(Func<T,T,int> compare)
			: this((Comparison<T>)((x, y) => compare(x, y)))
		{
		}

		public override int Compare(T x, T y)
		{
			return compare(x, y);
		}
	}
}