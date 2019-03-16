using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NewLogBook.Abstracrions;
using NewLogBook.AppContext;
using NewLogBook.Entities;
using NewLogBook.Models;
using NewLogBook.Repositories.interfaces;

namespace NewLogBook.Repositories
{
    public class FacultyRepository : DbRepository<Faculty>, IFacultyRepository
    {
        public FacultyRepository(AppDbContext context) :base(context)
        {
            
        }

        public async Task<bool> CreateFaculty(FacultyModel faculty)
        {
            Faculty facul = new Faculty {Name = faculty.Name};
          return await AddItemAsync(facul);
        }

        public async Task<bool> DeleteFaculty(int? id)
        {
            if (id == null)
            {
                return false;
            }

            if (await DeleteItemAsync(id))
            {
                return true;
            }

            return false;
        }

        public Task<Faculty> DetailsFaculty(int? id)
        {
            if (id == null)
            {
                return null;
            }

            var faculty =  AllItems.Include(z => z.Groups).FirstOrDefaultAsync(z => z.Id == id);
            if (faculty == null)
            {
                return null;
            }

            return faculty;
        }

        public async Task<bool> EditFaculty(FacultyModel faculty)
        {
            var facul = await GetItemAsync(faculty.id);
            facul.Name = faculty.Name;
            return await UpdateItem(facul);
        }

        public async Task<FacultyModel> FindFaculty(int? id)
        {
            if (id == null)
            {
                return null;
            }
            var faculty = await GetItemAsync(id);
            if (faculty == null)
            {
                return null;
            }
            FacultyModel model = new FacultyModel { id = faculty.Id, Name = faculty.Name };
            return model;

        }
    }
    
}
