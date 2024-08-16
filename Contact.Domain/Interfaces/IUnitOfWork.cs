using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact.Domain.Interfaces;

public interface IUnifOfWork
{
    Task Commit();
}