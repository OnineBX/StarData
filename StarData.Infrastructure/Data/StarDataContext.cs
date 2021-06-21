//  StarDataContext.cs
//
// Description: 
//       <Describe here>
//  Author:
//       Ryan Xu(XuChunlei) <hitxcl@gmail.com>
//  Create at:
//       11:15:28 21/6/2021
//
//  Copyright (c) 2021 XuChunlei
using System;
using Microsoft.EntityFrameworkCore;
using StarData.Core.Entities;

namespace StarData.Infrastructure.Data
{
    public class StarDataContext : DbContext
    {
        public StarDataContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Nation>().ToTable("Nation");
            builder.Entity<Player>().ToTable("Player");
            //builder.Entity<MatchCategory>().ToTable("MatchCategory");
            //builder.Entity<MatchSeason>().ToTable("MatchSeason");
            //builder.Entity<Match>().ToTable("Match");
            //builder.Entity<Performance>().ToTable("Performance");
        }
    }
}
