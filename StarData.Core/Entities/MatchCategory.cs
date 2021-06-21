//  MatchCategory.cs
//
// Description: 
//       <Describe here>
//  Author:
//       Ryan Xu(XuChunlei) <hitxcl@gmail.com>
//  Create at:
//       12:58:3 21/6/2021
//
//  Copyright (c) 2021 XuChunlei
using System;
using StarData.Core.Entities.Base;

namespace StarData.Core.Entities
{
    public class MatchCategory : Entity
    {
        public MatchCategory()
        {
        }

        public string Name { get; set; }
    }
}
