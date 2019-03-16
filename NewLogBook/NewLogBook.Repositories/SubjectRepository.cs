using System;
using System.Collections.Generic;
using System.Text;
using NewLogBook.AppContext;
using NewLogBook.Entities;
using NewLogBook.Repositories.interfaces;

namespace NewLogBook.Repositories
{
    public class SubjectRepository : DbRepository<Subject>, ISubjectRepository
    {
        public SubjectRepository(AppDbContext context) : base(context)
        {
            
        }
    }
}
