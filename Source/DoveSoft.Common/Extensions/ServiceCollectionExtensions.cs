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
// * FITNESS FOR A PARTICULAR PURPOSE AND NON-INFRINGEMENT. IN NO EVENT SHALL
// * THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS
// * IN THE SOFTWARE.
// ****************************************************************************

using System;
using System.Collections.Generic;
using DoveSoft.Common.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Serilog;

namespace DoveSoft.Common.Extensions
{
	public static class ServiceCollectionExtensions
	{
		public static IServiceCollection AddSerilogServices(this IServiceCollection services, Func<LoggerConfiguration, LoggerConfiguration> configuration)
		{
			Log.Logger = configuration.Invoke(new LoggerConfiguration())
			                          .CreateLogger();

			AppDomain.CurrentDomain.ProcessExit += (_, _) => Log.CloseAndFlush();

			return services.AddSingleton(Log.Logger);
		}


		public static IServiceCollection AddDataDependencyInjection<TDbContext>(this IServiceCollection collection)
			where TDbContext : DbContext
		{
			collection.AddScoped<IUnitOfWork, EntityUnitOfWork<TDbContext>>()
			          .AddScoped<IUnitOfWorkFactory, UnitOfWorkFactory>();

			return collection;
		}

		public static IServiceCollection AddDependencyInjection(this IServiceCollection collection, Action<Dictionary<Type, Type>> mappingCollection)
		{
			if (collection == null)
			{
				throw new ArgumentNullException(nameof(collection));
			}

			var mappings = new Dictionary<Type, Type>();
			mappingCollection.Invoke(mappings);
			foreach (var (key, value) in mappings)
			{
				collection.AddScoped(key, value);
			}

			return collection;
		}
	}
}