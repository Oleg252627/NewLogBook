using System;
using System.Collections.Generic;
using System.Text;
using NewLogBook.AppContext;
using NewLogBook.Entities;
using NewLogBook.Repositories.interfaces;

namespace NewLogBook.Repositories
{
    public class GroupRepository : DbRepository<Group>, IGroupRepository
    {
        public GroupRepository(AppDbContext context) : base(context)
        {
            
        }
    }
}
