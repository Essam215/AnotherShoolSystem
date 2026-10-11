using Microsoft.EntityFrameworkCore;
using SchoolSystem.Data;
using SchoolSystem.Models;
using SchoolSystem.Repos.Interface;


namespace SchoolSystem.Repos.Implementation
{
    public class StudentRepo : GenericRepo<Student>, IStudentRepo
    {
        private readonly SchoolContext _context;

        public StudentRepo(SchoolContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<Student>> FilterByGender(string gender)
        {
            return await _context.Students
                .Where(s => s.Gender == gender)
                .ToListAsync();
        }

        public async Task<List<Student>> Pagination(int page, int pageSize)
        {
            return await _context.Students
               .OrderBy(s => s.Id)
               .Skip((page - 1) * pageSize)
               .Take(pageSize)
               .ToListAsync();
        }

        public async Task<List<Student>> SearchByName(string name)
        {
            return await _context.Students.Where(s => s.FullName.Contains(name)).ToListAsync();
        }
    }
}