//  IDataValidator.cs
//
// Description: 
//       <Describe here>
//  Author:
//       Ryan Xu(XuChunlei) <hitxcl@gmail.com>
//  Create at:
//       16:20:35 21/6/2021
//
//  Copyright (c) 2021 XuChunlei
using System;
using System.Threading.Tasks;
using StarData.Core.Entities.Base;

namespace StarData.Core.Repositories
{
    public interface IDataValidator<E> where E : Entity
    {
        Task<DataResult<E>> ValidateAsync(IRepository<E> repository, E entity);
    }
}
