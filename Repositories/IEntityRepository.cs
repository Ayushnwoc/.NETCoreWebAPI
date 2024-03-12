using System.Collections.Generic;

namespace EntityAPI.Repositories
{
    public interface IEntityRepository
    {
        IEnumerable<Models.Entity> GetEntities();
        Models.Entity GetEntityById(string id);
    }
}
