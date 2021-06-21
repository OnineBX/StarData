//  Match.cs
//
// Description: 
//       <Describe here>
//  Author:
//       Ryan Xu(XuChunlei) <hitxcl@gmail.com>
//  Create at:
//       13:5:28 21/6/2021
//
//  Copyright (c) 2021 XuChunlei
using System;
namespace StarData.Core.Entities
{
    public class Match : EntityBase<int>
    {
        public Match()
        {
        }

        public int SeasonId { get; set; }
        public MatchSeason Season { get; set; }

        public int Round { get; set; }

        public int HostTeamId { get; set; }
        public Club HostTeam { get; set; }

        public int GuestTeamId { get; set; }
        public Club GuestTeam { get; set; }

        public int HostGoal { get; set; }

        public int GuestGoal { get; set; }

        public DateTime Time { get; set; }
    }
}
