using DomainLayer.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace RepositoryLayer.Repositories.Interfaces
{
    public interface IStudentDetailRepository : IRepository<StudentDetail>
    {
        Task<StudentDetail> GetStudentById(int id);
    }
}
