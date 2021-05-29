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

namespace DoveSoft.Common.Data
{
	/// <summary>
	/// 
	/// </summary>
	public abstract class AbstractEntity
	{
		/// <summary>Default constructor. Protected due to being abstract. </summary>
		protected AbstractEntity()
		{
			// ReSharper disable VirtualMemberCallInConstructor
			Init();
			// ReSharper restore VirtualMemberCallInConstructor
		}

		/// <summary>Protected constructor with required data.</summary>
		/// <param name="id">Id of entity.</param>
		protected AbstractEntity(Guid id) : this() => Id = id;

		/// <summary>Id of entity. Identity field and required.</summary>
		public Guid Id { get; set; }

		/// <summary>Timestamp for creation of entity.</summary>
		public DateTime? Created { get; set; }

		/// <summary>Timestamp for last update of entity.</summary>
		public DateTime? Updated { get; set; }

		/// <summary>
		/// Used for initiating an inheriting entity.
		/// </summary>
		protected virtual void Init() { }
	}
}