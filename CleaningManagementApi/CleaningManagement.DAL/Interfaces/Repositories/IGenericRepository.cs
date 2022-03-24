﻿using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CleaningManagement.DAL.Interfaces.Repositories
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        Task<TEntity> Create(TEntity entity, CancellationToken ct);
        Task<IEnumerable<TEntity>> Get(CancellationToken ct);
        Task<TEntity> GetById(Guid id, CancellationToken ct);
        Task<TEntity> Update(TEntity entity, CancellationToken ct);
        Task Delete(Guid id, CancellationToken ct);
    }
}
