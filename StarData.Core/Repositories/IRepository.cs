//  IRepository.cs
//
// Description: 
//       <Describe here>
//  Author:
//       Ryan Xu(XuChunlei) <hitxcl@gmail.com>
//  Create at:
//       13:35:58 21/6/2021
//
//  Copyright (c) 2021 XuChunlei
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using StarData.Core.Entities.Base;

namespace StarData.Core.Repositories
{
    public interface IRepository<E> : IDisposable where E : Entity
    {
        Task<DataResult<IReadOnlyList<E>>> GetAllAsync();
        Task<DataResult<E>> CreateAsync(E entity, CancellationToken cancellationToken = default);
    }
}
