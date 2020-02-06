using System;
using Contracts;
namespace Entities.Models
{
    public abstract class EntityBase<Tkey> 
    {
        public virtual Tkey Id { get; protected set; }
    }
}
