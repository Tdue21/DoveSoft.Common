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
using System.Collections.Generic;

namespace DoveSoft.Common.Data
{
	/// <summary>
	/// </summary>
	public static class RulesService
	{
		private static readonly List<Action<object>> InsertRules = new();
		private static readonly List<Action<object>> UpdateRules = new();
		private static readonly List<Action<object>> DeleteRules = new();

		/// <summary>
		/// </summary>
		/// <param name="insertRule"></param>
		public static void AddInsertRule(Action<object> insertRule)
		{
			InsertRules.Add(insertRule);
		}

		/// <summary>
		/// </summary>
		/// <param name="updateRule"></param>
		public static void AddUpdateRule(Action<object> updateRule)
		{
			UpdateRules.Add(updateRule);
		}

		/// <summary>
		/// </summary>
		/// <param name="deleteRule"></param>
		public static void AddDeleteRule(Action<object> deleteRule)
		{
			DeleteRules.Add(deleteRule);
		}

		/// <summary>
		/// </summary>
		/// <typeparam name="TEntity"></typeparam>
		/// <param name="insertRule"></param>
		public static void AddInsertRule<TEntity>(Action<TEntity> insertRule)
		{
			InsertRules.Add(x =>
			{
				if (x is TEntity entity)
				{
					insertRule(entity);
				}
			});
		}

		/// <summary>
		/// </summary>
		/// <typeparam name="TEntity"></typeparam>
		/// <param name="updateRule"></param>
		public static void AddUpdateRule<TEntity>(Action<TEntity> updateRule)
		{
			UpdateRules.Add(x =>
			{
				if (x is TEntity entity)
				{
					updateRule(entity);
				}
			});
		}

		/// <summary>
		/// </summary>
		/// <typeparam name="TEntity"></typeparam>
		/// <param name="deleteRule"></param>
		public static void AddDeleteRule<TEntity>(Action<TEntity> deleteRule)
		{
			DeleteRules.Add(x =>
			{
				if (x is TEntity entity)
				{
					deleteRule(entity);
				}
			});
		}

		/// <summary>
		/// </summary>
		/// <param name="inserting"></param>
		public static void ApplyInsertRules(IEnumerable<object> inserting)
		{
			foreach (var entity in inserting)
			{
				foreach (var rule in InsertRules)
				{
					rule(entity);
				}
			}
		}

		/// <summary>
		/// </summary>
		/// <param name="updating"></param>
		public static void ApplyUpdateRules(IEnumerable<object> updating)
		{
			foreach (var entity in updating)
			{
				foreach (var rule in UpdateRules)
				{
					rule(entity);
				}
			}
		}

		/// <summary>
		/// </summary>
		/// <param name="deleting"></param>
		public static void ApplyDeleteRules(IEnumerable<object> deleting)
		{
			foreach (var entity in deleting)
			{
				foreach (var rule in DeleteRules)
				{
					rule(entity);
				}
			}
		}
	}
}