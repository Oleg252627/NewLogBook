using System;
using System.Collections.Generic;
using System.Text;
using NewLogBook.AppContext;
using NewLogBook.Entities;
using NewLogBook.Repositories.interfaces;

namespace NewLogBook.Repositories
{
    public class DepartamentRepository : DbRepository<Departament>, IDepartamentRepository
    {
        public DepartamentRepository(AppDbContext context) : base(context)
        {
            
        }
    }
}
