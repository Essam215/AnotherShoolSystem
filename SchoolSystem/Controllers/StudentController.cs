using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolSystem.DTO_s;
using SchoolSystem.Models;
using SchoolSystem.Repos.Interface;

namespace SchoolSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public StudentController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        [HttpPost]
        public async Task<IActionResult> AddStudents(StudentDto dto)
        {
            var student =  _mapper.Map<Student>(dto);

           
            _unitOfWork.studentRepo.Add(student);

            
            await _unitOfWork.SaveChanges();

            return Created();
        }
        [HttpGet]
        
        public async Task<IActionResult> GetStudents()
        {
            var existingStudents = await _unitOfWork.studentRepo.GetAll();

            var studentDtos = _mapper.Map<List<GetStudentDto>>(existingStudents);

            return Ok(studentDtos);
        }
            [HttpGet("{id}")]
        public async Task<IActionResult> GetStudentById(int id)
        {
            var student = await _unitOfWork.studentRepo.GetById(id);

            if (student == null)
            {
                return NotFound();
            }

            var studentDto = _mapper.Map<GetStudentDto>(student);
            return Ok(studentDto);
        }
    }
}
