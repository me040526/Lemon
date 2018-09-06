using System;
using System.Collections.Generic;
using System.Text;

namespace Lemon.Domain.Entities
{
    public interface ISoftDelete
    {
        /// <summary>
        /// 标记是否已删除
        /// </summary>
        bool IsDeleted { get; set; }
    }
}
