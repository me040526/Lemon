using System;
using System.Collections.Generic;
using System.Text;

namespace Lemon.Domain.Entities
{
    public interface IPassivable
    {
        /// <summary>
        /// True: 启用
        /// False: 禁用
        /// </summary>
        bool IsActive { get; set; }
    }
}
