using Contacts.Domain.Interfaces;
using Contacts.Domain.Models;
using Contacts.Infra.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Infra.Repositories;

public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
{
    protected readonly AppDbContext _context;
    public Repository(AppDbContext context)
    {
        _context = context;
    }

    public virtual TEntity GetById(int id)
    {
        var item = _context.Set<TEntity>().Where(e => e.Id == id);

        if (item.Any())
            return item.FirstOrDefault();

        return null;
    }

    public virtual IEnumerable<TEntity> GetAll()
    {
        var item = _context.Set<TEntity>();

        if (item.Any())
            return item.ToList();

        return new List<TEntity>();
    }

    public virtual void Save(TEntity entity)
    {
        _context.Set<TEntity>().Add(entity);
    }
}
