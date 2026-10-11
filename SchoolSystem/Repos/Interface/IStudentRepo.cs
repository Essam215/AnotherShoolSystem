using SchoolSystem.Models;
using static System.Net.WebRequestMethods;

namespace SchoolSystem.Repos.Interface
{
    public interface IStudentRepo : IGenericRepo<Student>
    {
        Task<List<Student>> SearchByName(string name);
        Task<List<Student>> FilterByGender(string gender);
        Task<List<Student>> Pagination(int page, int pageSize);
    }
}