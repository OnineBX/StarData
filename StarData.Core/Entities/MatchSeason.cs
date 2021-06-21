//  Match.cs
//
// Description: 
//       <Describe here>
//  Author:
//       Ryan Xu(XuChunlei) <hitxcl@gmail.com>
//  Create at:
//       13:0:10 21/6/2021
//
//  Copyright (c) 2021 XuChunlei
using System;
using StarData.Core.Entities.Base;

namespace StarData.Core.Entities
{
    public class MatchSeason : Entity
    {
        public MatchSeason()
        {
        }
        public MatchCategory Category { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
    }
}
