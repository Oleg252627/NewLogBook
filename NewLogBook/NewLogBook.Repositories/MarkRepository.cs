using System;
using System.Collections.Generic;
using System.Text;
using NewLogBook.Abstracrions;
using NewLogBook.AppContext;
using NewLogBook.Entities;
using NewLogBook.Repositories.interfaces;

namespace NewLogBook.Repositories
{
    public class MarkRepository : DbRepository<Mark>, IMarkRepository
    {
        public MarkRepository(AppDbContext context) : base(context)
        {
            
        }
    }
}
