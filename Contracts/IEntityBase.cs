using System;
namespace Contracts
{

    public interface IEntityBase<TKey>
    {
        TKey Id { get; }
    }
}
