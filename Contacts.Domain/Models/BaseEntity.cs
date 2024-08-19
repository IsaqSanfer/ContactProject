using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Domain.Models;

public abstract class BaseEntity
{
    public int Id { get; private set; }
}
