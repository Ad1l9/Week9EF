using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskEF.DAL;
using TaskEF.Models;

namespace TaskEF.Services
{
    internal class StudentService
    {
        private static readonly AppDbContext _context = new();

        public List<Student> GetAll()
        {
            return _context.Students.ToList();
        }

        public Student? GetById(int id)
        {
            return _context.Students.Find(id);
        }

        public void Create(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            if (GetById(id) != null)
            {
                _context.Students.Remove(GetById(id));
                _context.SaveChanges();
            }
        }
    }
}
