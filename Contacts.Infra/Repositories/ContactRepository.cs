using Contacts.Domain.Models;
using Contacts.Infra.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Infra.Repositories;

public class ContactRepository : Repository<Contact>
{
    public ContactRepository(AppDbContext context) : base(context) { }

    public override Contact GetById(int id)
    {
        var item = _context.Set<Contact>().Where(c => c.Id == id);

        if (item.Any())
            return item.First();

        return null;
    }

    public override IEnumerable<Contact> GetAll()
    {
        var item = _context.Set<Contact>();

        return item.Any() ? item.ToList() : new List<Contact>();
    }
}
