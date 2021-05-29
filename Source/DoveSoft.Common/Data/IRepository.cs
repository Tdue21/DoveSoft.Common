// ****************************************************************************
// * The MIT License(MIT)
// * Copyright © 2021 DoveSoft
// *
// * Permission is hereby granted, free of charge, to any person obtaining a
// * copy of this software and associated documentation files (the “Software”),
// * to deal in the Software without restriction, including without limitation
// * the rights to use, copy, modify, merge, publish, distribute, sublicense,
// * and/or sell copies of the Software, and to permit persons to whom the
// * Software is furnished to do so, subject to the following conditions:
// *
// * The above copyright notice and this permission notice shall be included in
// * all copies or substantial portions of the Software.
// *
// * THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS
// * OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
// * THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS
// * IN THE SOFTWARE.
// ****************************************************************************

using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DoveSoft.Common.Data
{
	/// <summary>
	/// </summary>
	/// <typeparam name="TEntity">The type of the entity.</typeparam>
	public interface IRepository<TEntity> where TEntity : class
	{
		/// <summary>
		///     Gets the query.
		/// </summary>
		/// <value>
		///     The query.
		/// </value>
		IQueryable<TEntity> Query { get; }

		/// <summary>
		///     Inserts the specified entity.
		/// </summary>
		/// <param name="entity">The entity.</param>
		void Insert(TEntity entity);

		/// <summary>
		///     Inserts the asynchronous.
		/// </summary>
		/// <param name="entity">The entity.</param>
		/// <param name="cancellationToken">The cancellation token.</param>
		/// <returns></returns>
		Task InsertAsync(TEntity entity, CancellationToken cancellationToken = default);

		/// <summary>
		///     Updates the specified entity.
		/// </summary>
		/// <param name="entity">The entity.</param>
		void Update(TEntity entity);

		/// <summary>
		///     Deletes the specified entity.
		/// </summary>
		/// <param name="entity">The entity.</param>
		void Delete(TEntity entity);

		/// <summary>
		///     Finds the specified keys.
		/// </summary>
		/// <param name="keys">The keys.</param>
		/// <returns></returns>
		TEntity Find(params object[] keys);

		/// <summary>
		///     Finds the asynchronous.
		/// </summary>
		/// <param name="keys">The keys.</param>
		/// <param name="cancellationToken">The cancellation token.</param>
		/// <returns></returns>
		Task<TEntity> FindAsync(object[] keys, CancellationToken cancellationToken = default);
	}
}