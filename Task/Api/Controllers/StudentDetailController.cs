using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.DTOs.StudentDetail;
using ServiceLayer.Services.Interfaces;

namespace Api.Controllers
{

    public class StudentDetailController : BaseController
    {
        private readonly IStudentDetailService _service;
        public StudentDetailController(IStudentDetailService service)
        {
            _service = service;
        }

        [HttpPost]
        [Route("CreateStudentDetail")]
        public async Task<IActionResult> Create([FromBody] StudentDetailDto studentDetailDto)
        {
            await _service.CreateAsync(studentDetailDto);
            return Ok();
        }
      

        [HttpDelete]
        [Route("DeleteStudentDetail/{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            await _service.DeleteAsync(id);

            return Ok();
        }
        [HttpPut]
        [Route("UpdateStudentDetail")]
        public async Task<IActionResult> Update([FromBody] StudentDetailEditDto studenDetailEditDto)
        {
            await _service.UpdateAsync(studenDetailEditDto.Id, studenDetailEditDto);
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
        [Route("GetAllStudentDetails")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _service.GetAllAsync();
            return Ok(result);
        }
        [HttpGet]
        [Route("GetStudentById/{id}")]
        public async Task<IActionResult> GetStudentById([FromRoute] int id)
        {
            var result = await _service.GetStudentByIdAsync(id);
            return Ok(result);
        }
    }
}