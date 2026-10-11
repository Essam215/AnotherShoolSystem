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
<<<<<<< HEAD
        [HttpPut]
        public async Task<IActionResult> UpdateStudent(UpdateStudentDto dto, int id)
        {
            var std = await _unitOfWork.studentRepo.GetById(id);
            if (std == null) return NotFound();
            _mapper.Map(dto, std);
            _unitOfWork.studentRepo.Update(std);
            await _unitOfWork.SaveChanges();
            return NoContent();
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteStudent(int id)
        {
            var std = await _unitOfWork.studentRepo.GetById(id);
            if (std == null) return NotFound();
            _unitOfWork.studentRepo.Delete(std);
            await _unitOfWork.SaveChanges();
            return NoContent();
        }
        [HttpGet("search")]
        public async Task<IActionResult> SearchStudents(string name)
        {
            var students = await _unitOfWork.studentRepo.SearchByName(name);

            return Ok(students);
        }
        [HttpGet("filter")]
        public async Task<IActionResult> FilterByGender(string gender)
        {
            var stds = await _unitOfWork.studentRepo.FilterByGender(gender);
            return Ok(stds);
        }
=======
>>>>>>> c333d71e442dd746bc7d66a2c5ac64f88c9c2b3d
    }
}
