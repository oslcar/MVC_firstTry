using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Project.Repositories
{
    public interface IRepositoryBase<Entity> where Entity : class
    {
        Entity Get(int id);
        IQueryable<Entity> GetAll();
        IQueryable<Entity> Find(Expression<Func<Entity, bool>> predicate);
        
        void Add(Entity entity);
        void AddRange(IEnumerable<Entity> entities);
        void Remove(Entity entity);
        void RemoveRange(IEnumerable<Entity> entities);
    }
}