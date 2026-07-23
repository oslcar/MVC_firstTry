using MVC_Project.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Web;

namespace MVC_Project.Repositories
{
    public class RepositoryBase<Entity> : IRepositoryBase<Entity> where Entity : class
    {
        protected readonly EmployeeContext _context;

        public RepositoryBase(EmployeeContext context)
        {
            _context = context;
        }
        public Entity Get(int id)
        {
            return _context.Set<Entity>().Find(id);
        }
        public IQueryable<Entity> GetAll()
        {
            return _context.Set<Entity>();
        }
        public IQueryable<Entity> Find(Expression<Func<Entity, bool>> predicate)
        {
            return _context.Set<Entity>().Where(predicate);
        }

        public void Add(Entity entity)
        {
            _context.Set<Entity>().Add(entity);
        }
        public void AddRange(IEnumerable<Entity> entities)
        {
            _context.Set<Entity>().AddRange(entities);
        }
        public void Remove(Entity entity)
        {
            _context.Set<Entity>().Remove(entity);
        }
        public void RemoveRange(IEnumerable<Entity> entities)
        {
            _context.Set<Entity>().RemoveRange(entities);
        }
        public async Task Update()
        {
            await _context.SaveChangesAsync();
        }
    }
}