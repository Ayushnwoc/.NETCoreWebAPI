using System;
using System.Collections.Generic;
using System.Linq;
using EntityAPI.Models;

namespace EntityAPI.Repositories
{
    public class MockEntityRepository : IEntityRepository
    {
        private readonly List<Entity> _entities;

        public MockEntityRepository()
        {
            // Initialize mock data
            _entities = new List<Entity>
            {
                new Entity { Id = "1", Names = new List<Name> { new Name { FirstName = "John", Surname = "Doe" } } },
                new Entity { Id = "2", Names = new List<Name> { new Name { FirstName = "Jane", Surname = "Smith" } } },
                // Add more entities as needed
            };
        }

        public IEnumerable<Entity> GetEntities()
        {
            return _entities;
        }

        public Entity GetEntityById(string id)
        {
            return _entities.FirstOrDefault(e => e.Id == id);
        }
    }
}
