using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Lemon.Domain.Entities
{
    [Serializable]
    public class EntityNotFoundException : LemonException
    {
        /// <summary>
        /// 实体类类型
        /// </summary>
        public Type EntityType { get; set; }

        /// <summary>
        /// 主键
        /// </summary>
        public object Id { get; set; }

        public EntityNotFoundException()
        {

        }

        public EntityNotFoundException(SerializationInfo serializationInfo, StreamingContext context)
            : base(serializationInfo, context)
        {

        }

        public EntityNotFoundException(Type entityType, object id)
            : this(entityType, id, null)
        {

        }

        public EntityNotFoundException(Type entityType, object id, Exception innerException)
            : base($"There is no such an entity. Entity type: {entityType.FullName}, id: {id}", innerException)
        {
            EntityType = entityType;
            Id = id;
        }

        public EntityNotFoundException(string message)
            : base(message)
        {

        }

        public EntityNotFoundException(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }
}
