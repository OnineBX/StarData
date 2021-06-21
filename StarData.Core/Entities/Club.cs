//  Club.cs
//
// Description: 
//       <Describe here>
//  Author:
//       Ryan Xu(XuChunlei) <hitxcl@gmail.com>
//  Create at:
//       12:33:35 21/6/2021
//
//  Copyright (c) 2021 XuChunlei
using System;
using System.ComponentModel.DataAnnotations.Schema;
using StarData.Core.Entities.Base;

namespace StarData.Core.Entities
{
    public class Club : Entity
    {
        public Club()
        {
        }

        public string ClubName { get; set; }
        [Column(TypeName = "date")]
        public DateTime EstablishedTime { get; set; }
    }
}
