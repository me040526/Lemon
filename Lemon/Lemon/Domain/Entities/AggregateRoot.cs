﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lemon.Domain.Entities
{
    public class AggregateRoot : AggregateRoot<int>, IAggregateRoot
    {
    }

    public class AggregateRoot<TPrimaryKey> : Entity<TPrimaryKey>, IAggregateRoot<TPrimaryKey>
    {
        public AggregateRoot()
        {
            
        }
    }
}
