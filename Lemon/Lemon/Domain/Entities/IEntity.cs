using System;
using System.Collections.Generic;
using System.Text;

namespace Lemon.Domain.Entities
{
    /// <summary>
    /// 实体类接口
    /// </summary>
    public interface IEntity : IEntity<int>
    {
    }

    /// <summary>
    /// 实体类接口
    /// </summary>
    /// <typeparam name="TPrimaryKey"></typeparam>
    public interface IEntity<TPrimaryKey>
    {
        TPrimaryKey Id { get; set; }
    }
}
