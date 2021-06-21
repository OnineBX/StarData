//  EntityBase.cs
//
// Description: 
//       <Describe here>
//  Author:
//       Ryan Xu(XuChunlei) <hitxcl@gmail.com>
//  Create at:
//       11:24:13 21/6/2021
//
//  Copyright (c) 2021 XuChunlei
using System;
namespace StarData.Core.Entities
{
    public abstract class EntityBase<TID> : IEntityBase<TID>
    {
        public EntityBase()
        {
        }

        public virtual TID Id { get; protected set; }
    }
}
