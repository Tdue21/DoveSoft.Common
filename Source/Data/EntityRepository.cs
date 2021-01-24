// ****************************************************************************
// * The MIT License(MIT)
// * Copyright © 2020 Thomas Due
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

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DoveSoft.Common.Data
{
	/// <summary>
	/// </summary>
	/// <typeparam name="TEntity">The type of the entity.</typeparam>
	/// <typeparam name="TDbContext"></typeparam>
	/// <seealso cref="IRepository{TEntity}" />
	public sealed class EntityRepository<TDbContext, TEntity> : IRepository<TEntity>
		where TEntity : class
		where TDbContext : DbContext
	{
		private readonly IUnitOfWork _unitOfWork;
		private TDbContext _context;

		/// <summary>
		///     Initializes a new instance of the <see cref="EntityRepository{TDbContext, TEntity}" /> class.
		/// </summary>
		/// <param name="unitOfWork">The unit of work.</param>
		/// <exception cref="ArgumentNullException">unitOfWork</exception>
		public EntityRepository(IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
		}

		/// <summary>
		///     Gets the context.
		/// </summary>
		/// <value>
		///     The context.
		/// </value>
		private TDbContext Context =>
			_context ??= ((EntityUnitOfWork<TDbContext>) _unitOfWork).GetContext();

		/// <summary>
		///     Gets the set.
		/// </summary>
		/// <value>
		///     The set.
		/// </value>
		private DbSet<TEntity> Set => Context.Set<TEntity>();

		/// <summary>
		///     Inserts the specified entity.
		/// </summary>
		/// <param name="entity">The entity.</param>
		public void Insert(TEntity entity)
		{
			var entry = Context.Entry(entity);
			if (entry.State == EntityState.Detached) Set.Add(entity);
		}

		/// <summary>
		///     Inserts the asynchronous.
		/// </summary>
		/// <param name="entity">The entity.</param>
		/// <param name="cancellationToken">The cancellation token.</param>
		/// <returns></returns>
		public async Task InsertAsync(TEntity entity, CancellationToken cancellationToken = default)
		{
			var entry = Context.Entry(entity);
			if (entry.State == EntityState.Detached) await Set.AddAsync(entity, cancellationToken);
		}

		/// <summary>
		///     Updates the specified entity.
		/// </summary>
		/// <param name="entity">The entity.</param>
		public void Update(TEntity entity)
		{
			var entry = Context.Entry(entity);
			if (entry.State == EntityState.Detached) Set.Attach(entity);

			entry.State = EntityState.Modified;
		}

		/// <summary>
		///     Deletes the specified entity.
		/// </summary>
		/// <param name="entity">The entity.</param>
		public void Delete(TEntity entity)
		{
			var entry = Context.Entry(entity);
			if (entry.State == EntityState.Detached) Set.Attach(entity);

			Set.Remove(entity);
		}

		/// <summary>
		///     Finds the specified keys.
		/// </summary>
		/// <param name="keys">The keys.</param>
		/// <returns></returns>
		public TEntity Find(params object[] keys)
		{
			return Set.Find(keys);
		}

		/// <summary>
		///     Finds the asynchronous.
		/// </summary>
		/// <param name="keys">The keys.</param>
		/// <param name="cancellationToken">The cancellation token.</param>
		/// <returns></returns>
		public async Task<TEntity> FindAsync(object[] keys, CancellationToken cancellationToken = default)
		{
			return await Set.FindAsync(keys, cancellationToken);
		}

		/// <summary>
		///     Gets the query.
		/// </summary>
		/// <value>
		///     The query.
		/// </value>
		public IQueryable<TEntity> Query => Set;
	}
}