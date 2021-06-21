//  StarDataInitializer.cs
//
// Description: 
//       <Describe here>
//  Author:
//       Ryan Xu(XuChunlei) <hitxcl@gmail.com>
//  Create at:
//       13:27:1 21/6/2021
//
//  Copyright (c) 2021 XuChunlei
using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using StarData.Core.Entities;
using StarData.Core.Repositories;

namespace StarData.Infrastructure.Data
{
    public class StarDataInitializer
    {
        public static async Task Initialize(IServiceProvider services)
        {
            // Nation data
            using (IRepository<Nation> repo = services.GetRequiredService<IRepository<Nation>>())
            {
                await repo.CreateAsync(new Nation { Name = "Han" });
                await repo.CreateAsync(new Nation { Name = "Hui" });
                await repo.CreateAsync(new Nation { Name = "Uyghur" });
                await repo.CreateAsync(new Nation { Name = "Man" });
            }
        }
    }
}
