using ServiceLayer.DTOs.Student;
using ServiceLayer.DTOs.StudentDetail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface IStudentService
    {
        Task CreateAsync(StudentDto studentDto);

        Task UpdateAsync(int Id, StudentEditDto st);
        Task DeleteAsync(int id);
        Task<List<StudentDto>> GetAllAsync();
        Task<StudentDto> GetAsync(int id);
    }
}
