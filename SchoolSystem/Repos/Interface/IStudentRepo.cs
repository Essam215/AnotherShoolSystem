<<<<<<< HEAD
﻿using SchoolSystem.Models;
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
=======
﻿namespace SchoolSystem.Repos.Interface
{
    public interface IStudentRepo
    {
    }
}
>>>>>>> c333d71e442dd746bc7d66a2c5ac64f88c9c2b3d
