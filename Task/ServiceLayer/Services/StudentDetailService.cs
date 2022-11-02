using AutoMapper;
using DomainLayer.Entities;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.DTOs.Student;
using ServiceLayer.DTOs.StudentDetail;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace ServiceLayer.Services
{
    public class StudentDetailService : IStudentDetailService
    {
        private readonly IStudentDetailRepository _repository;
        private readonly IMapper _mapper;
        public StudentDetailService(IStudentDetailRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task CreateAsync(StudentDetailDto studentDetailDto)
        {
            var model = _mapper.Map<StudentDetail>(studentDetailDto);
            await _repository.CreateAsync(model);
        }
        
        public async Task DeleteAsync(int id)
        {
            var studentdetail = await _repository.GetAsync(id);
            await _repository.DeleteAsync(studentdetail);
        }

        public async Task<List<StudentDetailDto>> GetAllAsync()
        {
            var model = await _repository.GetAllAsync();
            var res = _mapper.Map<List<StudentDetailDto>>(model);
            return res;
        }

        public async Task<StudentDetailDto> GetAsync(int id)
        {
            var model = await _repository.GetAsync(id);
            var res = _mapper.Map<StudentDetailDto>(model);
            return res;
        }

        public async Task<StudentDetailDto> GetStudentByIdAsync(int id)
        {
            var model = await _repository.GetStudentById(id);
            var res = _mapper.Map<StudentDetailDto>(model);
            return res;
        }

        public async Task UpdateAsync(int Id, StudentDetailEditDto studentDetailEditDto)
        {
            var entity = await _repository.GetAsync(Id);

            _mapper.Map(studentDetailEditDto, entity);

            await _repository.UpdateAsync(entity);
        }
    }
}
