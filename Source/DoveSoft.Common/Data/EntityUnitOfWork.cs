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

using System;
using System.Threading;
using System.Threading.Tasks;
using DoveSoft.Common.Extensions;
using Microsoft.EntityFrameworkCore;

namespace DoveSoft.Common.Data
{
	/// <summary>
	///     Entity Framework Core specific <see cref="IUnitOfWork" /> implementation.
	/// </summary>
	/// <seealso cref="IUnitOfWork" />
	public class EntityUnitOfWork<TDbContext> : /*Disposable, */ IUnitOfWork where TDbContext : DbContext
	{
		private readonly TDbContext _context;
		//private readonly bool _ownContext;

		/// <summary>
		///     Initializes a new instance of the <see cref="EntityUnitOfWork{TDbContext}" /> class.
		/// </summary>
		public EntityUnitOfWork()
		{
			_context = Activator.CreateInstance<TDbContext>();
			//_ownContext = true;
		}

		/// <summary>
		///     Initializes a new instance of the <see cref="EntityUnitOfWork{TDbContext}" /> class.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <exception cref="ArgumentNullException">context</exception>
		public EntityUnitOfWork(TDbContext context)
		{
			_context = context ?? throw new ArgumentNullException(nameof(context));
			//_ownContext = false;
		}

		// <summary>
		// Gets a value indicating whether this instance has ended.
		// </summary>
		// <value>
		// <c>true</c> if this instance has ended; otherwise, <c>false</c>.
		// </value>
//		public bool HasEnded { get; private set; }

		/// <summary>
		///     Gets the <see cref="IRepository{TEntity}" /> repository for the type supplied.
		/// </summary>
		/// <typeparam name="TEntity">The type of the entity.</typeparam>
		/// <returns></returns>
		public IRepository<TEntity> GetRepository<TEntity>() where TEntity : class
		{
			return new EntityRepository<TDbContext, TEntity>(this);
		}

		/// <summary>
		///     Saves the changes.
		/// </summary>
		/// <returns></returns>
		/// <exception cref="ObjectDisposedException">Unit of Work has been disposed.</exception>
		public int SaveChanges()
		{
			//if (HasEnded)
			//{
			//	throw new ObjectDisposedException("Unit of Work has been disposed.");
			//}

			if (_context == null)
			{
				throw new NullReferenceException("DbContext has not been set.");
			}

			RulesService.ApplyInsertRules(_context.Changes(EntityState.Added));
			RulesService.ApplyDeleteRules(_context.Changes(EntityState.Modified));
			RulesService.ApplyUpdateRules(_context.Changes(EntityState.Deleted));

			return _context.SaveChanges();
		}

		/// <summary>
		///     Saves the changes asynchronous.
		/// </summary>
		/// <param name="cancellationToken">The cancellation token.</param>
		/// <returns></returns>
		/// <exception cref="ObjectDisposedException">Unit of Work has been disposed.</exception>
		public async Task<int> SaveChangesAsync(CancellationToken cancellationToken)
		{
			//if (HasEnded)
			//{
			//	throw new ObjectDisposedException("Unit of Work has been disposed.");
			//}

			if (_context == null)
			{
				throw new NullReferenceException("DbContext has not been set.");
			}

			RulesService.ApplyInsertRules(_context.Changes(EntityState.Added));
			RulesService.ApplyDeleteRules(_context.Changes(EntityState.Modified));
			RulesService.ApplyUpdateRules(_context.Changes(EntityState.Deleted));

			return await _context.SaveChangesAsync(cancellationToken);
		}

		/// <summary>
		///     Returns the current DbContext object.
		/// </summary>
		/// <typeparam name="TDbContext">The type of the database context.</typeparam>
		/// <returns></returns>
		/// <exception cref="ObjectDisposedException">Unit of Work has been disposed.</exception>
		public TDbContext GetContext() /*!HasEnded ?*/
		{
			return _context ?? /*:*/ throw new ObjectDisposedException("Unit of Work has been disposed.");
		}

		// <summary>
		// Releases unmanaged and - optionally - managed resources.
		// </summary>
		// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
		//protected override void Dispose(bool disposing)
		//{
		//	if (!HasEnded)
		//	{
		//		if (disposing && _ownContext)
		//		{
		//			_context?.Dispose();
		//		}
		//		HasEnded = true;
		//	}
		//}
	}
}