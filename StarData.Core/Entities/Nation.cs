//  Nation.cs
//
// Description: 
//       <Describe here>
//  Author:
//       Ryan Xu(XuChunlei) <hitxcl@gmail.com>
//  Create at:
//       12:27:55 21/6/2021
//
//  Copyright (c) 2021 XuChunlei
using System;
using StarData.Core.Entities.Base;

namespace StarData.Core.Entities
{
    public class Nation : Entity
    {
        public Nation()
        {
        }

        public string Name { get; set; }
    }
}
