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
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DoveSoft.Common.Extensions
{
	public static class DbContextExtensions
	{
		/// <summary>
		/// Returns an <see cref="System.Collections.Generic.IEnumerable{T}"/> list of objects of the supplied <see cref="Microsoft.EntityFrameworkCore.EntityState"/>.
		/// </summary>
		/// <param name="context">The <see cref="Microsoft.EntityFrameworkCore.DbContext"/> to extract changes from.</param>
		/// <param name="state"></param>
		/// <returns></returns>
		public static IEnumerable<object> Changes(this DbContext context, EntityState state)
		{
			if (context == null) throw new ArgumentNullException(nameof(context));

			return context.ChangeTracker
				.Entries()
				.Where(x => x.State == state)
				.Select(x => x.Entity);
		}

		/// <summary>
		/// Saves and then detaches all entities from the <see cref="DbContext"/>.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <exception cref="System.ArgumentNullException">context</exception>
		public static async Task SaveAndDetachAllEntities(this DbContext context)
		{
			if (context == null) throw new ArgumentNullException(nameof(context));

			await context.SaveChangesAsync();

			context.ChangeTracker.Entries()
				.Where(e => e.State == EntityState.Added ||
				            e.State == EntityState.Modified ||
				            e.State == EntityState.Deleted ||
				            e.State == EntityState.Unchanged)
				.ToList()
				.ForEach(entry => entry.State = EntityState.Detached);
		}
	}
}