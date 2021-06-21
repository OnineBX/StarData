//  Performance.cs
//
// Description: 
//       <Describe here>
//  Author:
//       Ryan Xu(XuChunlei) <hitxcl@gmail.com>
//  Create at:
//       13:13:59 21/6/2021
//
//  Copyright (c) 2021 XuChunlei
using System;
using StarData.Core.Entities.Base;

namespace StarData.Core.Entities
{
    public class Performance : Entity
    {
        public Performance()
        {
        }

        public int PlayerId { get; set; }
        public Player Player { get; set; }

        public int MatchId { get; set; }
        public Match Match { get; set; }

        public bool IsSubstitution { get; set; }

        public int ParticipationTime { get; set; }
    }
}
