<<<<<<< HEAD
﻿using SchoolSystem.Data;
using SchoolSystem.Models;
using SchoolSystem.Repos.Interface;

namespace SchoolSystem.Repos.Implementation
{
    public class CourseRepo : GenericRepo<Course>, ICourseRepo
    {
        public CourseRepo(SchoolContext context) : base(context)
        {
        }
=======
﻿namespace SchoolSystem.Repos.Implementation
{
    public class CourseRepo
    {
>>>>>>> c333d71e442dd746bc7d66a2c5ac64f88c9c2b3d
    }
}
