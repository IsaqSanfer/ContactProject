﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Domain.Interfaces;

public interface IRepository<TEntity> where TEntity : class
{
    TEntity GetById(int id);
    IEnumerable<TEntity> GetAll();
    void Save(TEntity entity);
}
