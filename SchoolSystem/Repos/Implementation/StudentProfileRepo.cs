<<<<<<< HEAD
﻿using SchoolSystem.Data;
using SchoolSystem.Models;
using SchoolSystem.Repos.Interface;

namespace SchoolSystem.Repos.Implementation
{
    public class StudentProfileRepo : GenericRepo<StudentProfile>, IStudentProfile
    {
        public StudentProfileRepo(SchoolContext context) : base(context)
        {
        }
=======
﻿namespace SchoolSystem.Repos.Implementation
{
    public class StudentProfileRepo
    {
>>>>>>> c333d71e442dd746bc7d66a2c5ac64f88c9c2b3d
    }
}
