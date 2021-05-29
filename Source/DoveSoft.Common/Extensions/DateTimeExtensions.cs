// ****************************************************************************
// * The MIT License(MIT)
// * Copyright © 2021 Thomas Due
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

namespace DoveSoft.Common.Extensions
{
	/// <summary>
	/// 
	/// </summary>
	public static class DateTimeExtensions
	{
		/// <summary>
		/// Extension method that calculates the start of the month from the current <see cref="DateTime"/>.
		/// </summary>
		/// <param name="dateTime">The current <see cref="DateTime"/>.</param>
		/// <returns>A DateTime representing the start of the month.</returns>
		public static DateTime StartOfMonth(this DateTime dateTime) => new(dateTime.Year, dateTime.Month, 1, 0, 0, 0, 0, 0);

		/// <summary>
		/// Extension method that calculates the end of the month from the current <see cref="DateTime"/>.
		/// </summary>
		/// <param name="dateTime">The current <see cref="DateTime"/>.</param>
		/// <returns>A DateTime representing the end of the month.</returns>
		public static DateTime EndOfMonth(this DateTime dateTime) => dateTime.Date
		                                                                     .AddDays(DateTime.DaysInMonth(dateTime.Year, dateTime.Month) - dateTime.Day)
		                                                                     .Add(new TimeSpan(23, 59, 59, 999));

		/// <summary>
		/// Extension method that calculates the start of the year from the current <see cref="DateTime"/>.
		/// </summary>
		/// <param name="dateTime">The current <see cref="DateTime"/>.</param>
		/// <returns>A DateTime representing the start of the year.</returns>
		public static DateTime StartOfYear(this DateTime dateTime) => new(dateTime.Year, 1, 1, 0, 0, 0, 0);

		/// <summary>
		/// Extension method that calculates the end of the year from the current <see cref="DateTime"/>.
		/// </summary>
		/// <param name="dateTime">The current <see cref="DateTime"/>.</param>
		/// <returns>A DateTime representing the end of the year.</returns>
		public static DateTime EndOfYear(this DateTime dateTime) => new(dateTime.Year, 12, 31, 23, 59, 59, 999);
	}
}