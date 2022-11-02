using DomainLayer.Entities;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Repositories
{
    public class StudentDetailRepository : Repository<StudentDetail>, IStudentDetailRepository
    {
        private readonly AppDbContext _context;
        private readonly DbSet<StudentDetail> entities;
        public StudentDetailRepository(AppDbContext context) : base(context)
        {
            _context = context;
            entities = context.Set<StudentDetail>();
        }

        public async Task<StudentDetail> GetStudentById(int id)
        {
            StudentDetail entity = await entities.FirstOrDefaultAsync(m => m.StudentId == id);
            if (entity is null) throw new NullReferenceException();
            return entity;
        }
    }
}
