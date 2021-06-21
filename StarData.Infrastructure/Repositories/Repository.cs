//  Repository.cs
//
// Description: 
//       <Describe here>
//  Author:
//       Ryan Xu(XuChunlei) <hitxcl@gmail.com>
//  Create at:
//       15:49:6 21/6/2021
//
//  Copyright (c) 2021 XuChunlei
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using StarData.Core.Entities.Base;
using StarData.Core.Repositories;
using StarData.Infrastructure.Data;

namespace StarData.Infrastructure.Repositories
{
    public class Repository<E> : IRepository<E> where E : Entity
    {
        protected readonly StarDataContext _context;
        protected readonly ILogger _logger;
        private readonly IEnumerable<IDataValidator<E>> _validators;

        private bool _disposed;
        public Repository(StarDataContext context,
            IEnumerable<IDataValidator<E>> validators,
            ILogger<Repository<E>> logger)
        {
            _context = context;
            _validators = validators;
            _logger = logger;
        }

        public async Task<DataResult<E>> CreateAsync(E entity, CancellationToken cancellationToken = default)
        {
            // validate data for creation
            if (_validators != null)
            {
                foreach (var v in _validators)
                {
                    var result = await v.ValidateAsync(this, entity);
                    // return if errors exist
                    if (!result.Succeeded)
                    {
                        return result;
                    }
                }
            }
            // create if validate successful
            _context.Add(entity);
            await _context.SaveChangesAsync(cancellationToken);
            return DataResult<E>.Success;
        }

        public void Dispose()
        {
            _disposed = true;
        }

        public Task<DataResult<IReadOnlyList<E>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}
