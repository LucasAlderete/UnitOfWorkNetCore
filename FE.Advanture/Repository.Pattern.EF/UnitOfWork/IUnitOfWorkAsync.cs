﻿using Repository.Pattern.EF.Repositories;
using System.Threading;
using System.Threading.Tasks;

namespace Repository.Pattern.EF.UnitOfWork
{
    public interface IUnitOfWorkAsync : IUnitOfWork
    {
        Task<int> SaveChangesAsync();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        IRepositoryAsync<TEntity> RepositoryAsync<TEntity>() where TEntity : class;
    }
}
