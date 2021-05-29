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
using Microsoft.Extensions.DependencyInjection;

namespace DoveSoft.Common.Data
{
	/// <summary>
	/// Implementation of the <see cref="IUnitOfWorkFactory"/> interface.
	/// </summary>
	/// <seealso cref="IUnitOfWorkFactory" />
	public class UnitOfWorkFactory : IUnitOfWorkFactory
	{
		private readonly IServiceProvider _serviceProvider;
		private IUnitOfWork _unitOfWork;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="serviceProvider"></param>
		public UnitOfWorkFactory(IServiceProvider serviceProvider)
		{
			_serviceProvider = serviceProvider;
		}

		/// <summary>
		///     Creates an instance of <see cref="IUnitOfWork" />
		/// </summary>
		/// <returns></returns>
		public IUnitOfWork Create()
		{
			if (_unitOfWork == null)
			{
				_unitOfWork = _serviceProvider.GetRequiredService<IUnitOfWork>();
				_unitOfWork.Disposing += UnitOfWorkOnDisposing;
			}

			return _unitOfWork;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void UnitOfWorkOnDisposing(object sender, EventArgs e)
		{
			if (_unitOfWork != null)
			{
				if (sender != _unitOfWork)
				{
					throw new InvalidOperationException("Sender for ending unit of work mismatched.");
				}

				_unitOfWork.Disposing -= UnitOfWorkOnDisposing;
				_unitOfWork = null;
			}
		}
	}
}