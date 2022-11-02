using ServiceLayer.DTOs.StudentDetail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface IStudentDetailService
    {
        Task CreateAsync(StudentDetailDto studentDetailDto);

        Task UpdateAsync(int Id, StudentDetailEditDto category);
        Task DeleteAsync(int id);
        Task<List<StudentDetailDto>> GetAllAsync();
        Task<StudentDetailDto> GetAsync(int id);
        Task<StudentDetailDto> GetStudentByIdAsync(int id);
    }
}
