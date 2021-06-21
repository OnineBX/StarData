//  Player.cs
//
// Description: 
//       <Describe here>
//  Author:
//       Ryan Xu(XuChunlei) <hitxcl@gmail.com>
//  Create at:
//       11:27:34 21/6/2021
//
//  Copyright (c) 2021 XuChunlei
using System;
using StarData.Core.Entities.Base;

namespace StarData.Core.Entities
{
    public class Player : Entity
    {
        public Player()
        {
        }

        public string Name { get; set; }
        public string DateOfBirth { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public int NationId { get; set; }
        public Nation Nation { get; set; }
    }
}
