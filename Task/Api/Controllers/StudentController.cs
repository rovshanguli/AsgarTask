using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.DTOs.Student;
using ServiceLayer.DTOs.StudentDetail;
using ServiceLayer.Services.Interfaces;

namespace Api.Controllers
{

    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class StudentController : BaseController
    {
        private readonly IStudentService _service;
        private readonly ICurrentUser _currentUser;
        public StudentController(IStudentService service, ICurrentUser currentUser)
        {
            _service = service;
            _currentUser = currentUser;
        }


        [HttpPost]
        [Route("CreateStudent")]
        public async Task<IActionResult> Create([FromBody] StudentDto studentDto)
        {
            await _service.CreateAsync(studentDto);
            return Ok();
        }


        [HttpDelete]
        [Route("DeleteStudent/{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            await _service.DeleteAsync(id);

            return Ok();
        }
        [HttpPut]
        [Route("UpdateStudent")]
        public async Task<IActionResult> Update([FromBody] StudentEditDto studenEditDto)
        {
            await _service.UpdateAsync(studenEditDto.Id, studenEditDto);
            return Ok();
        }

        [HttpGet]
        [Route("GetById/{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var result = await _service.GetAsync(id);
            return Ok(result);
        }

        [HttpGet]
        [Route("GetAllStudents")]
        public async Task<IActionResult> GetAll()
        {
            var user = _currentUser.GetCurrentUser();

            var result = await _service.GetAllAsync();
            return Ok(result);
        }
    }
}
