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
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace DoveSoft.Common.Extensions
{
	/// <summary>
	/// 
	/// </summary>
	public static class StringExtensions
	{
		/// <summary>
		/// Converts a normal <see cref="System.String" /> to a <see cref="System.Security.SecureString"/>.
		/// </summary>
		/// <param name="unsafeString">A string value.</param>
		/// <returns>A SecureString value.</returns>
		public static SecureString ToSecureString(this string unsafeString)
		{
			if (unsafeString == null)
			{
				throw new ArgumentNullException(nameof(unsafeString));
			}

			var securePassword = new SecureString();
			unsafeString.ToList().ForEach(c => securePassword.AppendChar(c));
			securePassword.MakeReadOnly();

			return securePassword;
		}

		/// <summary>
		/// Converts a <see cref="System.Security.SecureString"/> to a normal <see cref="System.String" />.
		/// </summary>
		/// <param name="secureString">A SecureString value.</param>
		/// <returns>An insecure string value.</returns>
		public static string FromSecureString(this SecureString secureString)
		{
			if (secureString == null)
			{
				throw new ArgumentNullException(nameof(secureString));
			}

			var unmanagedString = IntPtr.Zero;
			try
			{
				unmanagedString = Marshal.SecureStringToGlobalAllocUnicode(secureString);
				return Marshal.PtrToStringUni(unmanagedString);
			}
			finally
			{
				Marshal.ZeroFreeGlobalAllocUnicode(unmanagedString);
			}

		}

		/// <summary>
		/// Escapes both single- and double-quotes in a <see cref="System.String"/>.
		/// </summary>
		/// <param name="input">Unescaped string.</param>
		/// <returns>String with escaped quotes.</returns>
		public static string ToSafeString(this string input) => $"'{input.Replace("'", "''").Replace("\"", "\"\"")}'";

		/// <summary>
		/// Appends a divider <see cref="System.String"/> to a StringBuilder. The divider is default a 50 characters long string of dashes.
		/// </summary>
		/// <param name="builder">The <see cref="System.Text.StringBuilder"/> object.</param>
		/// <param name="divider">The <see cref="System.Char"/> value to use as a divider.</param>
		/// <param name="length">The length of the divider string.</param>
		/// <returns>A string consisting of the divider character. Default: 50 dashes.</returns>
		public static StringBuilder AppendDivider(this StringBuilder builder, char divider = '-', int length = 50) => builder.AppendLine("".PadRight(length, divider));
	}
}