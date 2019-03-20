using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NewLogBook.AppContext;
using NewLogBook.Entities;
using NewLogBook.Models;
using NewLogBook.Repositories.interfaces;

namespace NewLogBook.Repositories
{
    public class GroupRepository : DbRepository<Group>, IGroupRepository
    {
        public GroupRepository(AppDbContext context) : base(context)
        {
            
        }

        public async Task<GroupModel> GetCreateGroup(IFacultyRepository facultyRepository)
        {
            var faculty = await facultyRepository.AllItems.ToListAsync();
            GroupModel groupModel = new GroupModel();
            groupModel.Faculties = faculty;
            return groupModel.Clone() as GroupModel;
        }

        public async Task<bool> CreateGroupPost(GroupModel model)
        {
            Group group = new Group{Name = model.Name, FacultyId = Int32.Parse(model.FacultyId)};
            return await AddItemAsync(group);
        }

        public async Task<GroupModel> GetEditGroup(IFacultyRepository facultyRepository, int? id)
        {
            if (id == null)
            {
                return null;
            }

            var group = await AllItems.Include(f => f.Faculty).FirstOrDefaultAsync(z => z.Id == id);
            if (group == null)
            {
                return null;
            }
            GroupModel model = new GroupModel
            {
                Id = group.Id,
                Name = group.Name,
                Faculty = group.Faculty,
                Faculties = await facultyRepository.ToListAsync()
            };
            return model.Clone() as GroupModel;
        }

        public async Task<bool> EditGroupPost(GroupModel model)
        {
            var group = await GetItemAsync(model.Id);
            group.Name = model.Name;
            group.FacultyId = Int32.Parse(model.FacultyId);
            return await UpdateItem(group);
        }

        public async Task<Group> DetailsGroup(int? id)
        {
            if (id == null)
            {
                return null;
            }

            var group = AllItems.Include(f => f.Faculty).Include(s => s.Students)
                .FirstOrDefaultAsync(z => z.Id == id);
            if (group == null)
            {
                return null;
            }

            return await group as Group;
        }

        public async Task<bool> DeleteGroup(int? id)
        {
            return await DeleteItemAsync(id);
        }

        public async Task<List<Group>> ShowListGroups()
        {
            return await AllItems.Include(f => f.Faculty).ToListAsync();
        }
    }
}
