//  StarDataCollectionExtension.cs
//
// Description: 
//       <Describe here>
//  Author:
//       Ryan Xu(XuChunlei) <hitxcl@gmail.com>
//  Create at:
//       20:27:6 21/6/2021
//
//  Copyright (c) 2021 XuChunlei
using System;
using System.Runtime.CompilerServices;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using StarData.Core.Repositories;
using StarData.Infrastructure.Repositories;

namespace StarData.Infrastructure.Data
{
    public static class StarDataCollectionExtension
    {
        public static void AddStarDataCore(this IServiceCollection services)
        {
            services.TryAddScoped(typeof(IRepository<>), typeof(Repository<>));
        }
    }
}
