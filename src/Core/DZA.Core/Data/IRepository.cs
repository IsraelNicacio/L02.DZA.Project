using DZA.Core.DomainObjects;

namespace DZA.Core.Data;

public interface IRepository<T> where T : IAggregateRoot
{ }
