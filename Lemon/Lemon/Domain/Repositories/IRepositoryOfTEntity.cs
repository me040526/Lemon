using Lemon.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lemon.Domain.Repositories
{
    /// <summary>
    /// 仓储类接口
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface IRepository<TEntity> : IRepository<TEntity, int> where TEntity : class, IEntity<int>
    {
    }
}
