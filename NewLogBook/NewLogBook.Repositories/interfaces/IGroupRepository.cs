using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using NewLogBook.Abstracrions;
using NewLogBook.Entities;
using NewLogBook.Models;

namespace NewLogBook.Repositories.interfaces
{
    public interface IGroupRepository : IDbRepository<Group>
    {
        Task<List<Group>> ShowListGroups();
        Task<GroupModel> GetCreateGroup(IFacultyRepository facultyRepository);
        Task<bool> CreateGroupPost(GroupModel model);
        Task<GroupModel> GetEditGroup(IFacultyRepository facultyRepository, int? id);
        Task<bool> EditGroupPost(GroupModel model);
        Task<Group> DetailsGroup(int? id);
        Task<bool> DeleteGroup(int? id);
    }
}
