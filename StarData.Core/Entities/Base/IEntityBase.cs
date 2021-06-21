//  IEntityBase.cs
//
// Description: 
//       <Describe here>
//  Author:
//       Ryan Xu(XuChunlei) <hitxcl@gmail.com>
//  Create at:
//       11:20:55 21/6/2021
//
//  Copyright (c) 2021 XuChunlei
using System;
namespace StarData.Core.Entities
{
    public interface IEntityBase<TID>
    {
        TID Id { get; }
    }
}
