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
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace DoveSoft.Common.Extensions
{
	/// <summary>
	/// 
	/// </summary>
	public static class TypeExtensions
	{
		/// <summary>
		/// Gets the first attribute.
		/// </summary>
		/// <typeparam name="TEnum">The type of the enum.</typeparam>
		/// <typeparam name="TAttribute">The type of the attribute.</typeparam>
		/// <param name="enumValue">The enum value.</param>
		/// <returns></returns>
		/// <exception cref="ArgumentException"></exception>
		public static TAttribute GetFirstAttribute<TEnum, TAttribute>(this TEnum enumValue) where TEnum : struct
		{
			var enumType = enumValue.GetType();

			if (!enumType.IsEnum)
			{
				throw new ArgumentException();
			}

			var field = enumType.GetField(enumValue.ToString() ?? string.Empty);
			return field is not null
					       ? field.GetCustomAttributes(typeof(TAttribute), false) is TAttribute[] attributes
							         ?
							         attributes.FirstOrDefault()
							         : default
					       : default;
		}

		/// <summary>
		/// Gets the description.
		/// </summary>
		/// <typeparam name="TEnum">The type of the enum.</typeparam>
		/// <param name="enumValue">The enum value.</param>
		/// <returns></returns>
		public static string GetDescription<TEnum>(this TEnum enumValue) where TEnum : struct
		{
			var attribute = enumValue.GetFirstAttribute<TEnum, DescriptionAttribute>();
			return attribute != null ? attribute.Description : enumValue.ToString();
		}

		/// <summary>
		/// Gets the attribute.
		/// </summary>
		/// <typeparam name="TAttr">The type of the attribute.</typeparam>
		/// <param name="propInfo">The property information.</param>
		/// <returns></returns>
		public static TAttr GetAttribute<TAttr>(this MemberInfo propInfo) where TAttr : Attribute
		{
			return propInfo?.GetCustomAttributes(true).OfType<TAttr>().FirstOrDefault();
		}
	}
}