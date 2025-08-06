﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Api.Application.Interfaces.Repositories;
using Api.Domain.Common;
using Microsoft.EntityFrameworkCore;

namespace Api.Persistence.Repositories
{
    public class WriteRepository<T> : IWriteRepository<T> where T : class,IEntityBase,new()
    {
        private readonly DbContext dbContext;
        public WriteRepository(DbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        private DbSet<T> Table { get => dbContext.Set<T>(); }
        async Task IWriteRepository<T>.AddAsync(T entity)
        {
            await Table.AddAsync(entity);
        }

        async Task IWriteRepository<T>.AddRangeAsync(IList<T> entity)
        {
            await Table.AddRangeAsync(entity);
        }

        public async Task HardDeleteAsync(T entity)
        {
            await Task.Run(() => Table.Remove(entity));
        }

        public async Task<T> UpdateAsync(T entity)
        {
            await Task.Run(()=> Table.Update(entity));
            return entity;
        }
        public async Task HardDeleteRangeAsync(IList<T> entity)
        {
            await Task.Run(() => Table.RemoveRange(entity));
        }

    }
}
