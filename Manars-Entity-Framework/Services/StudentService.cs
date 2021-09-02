using Manars_Entity_Framework.Data;
using Manars_Entity_Framework.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manars_Entity_Framework.Services
{ // Crud operation happen in Services
    public class StudentService : IStudentService //everytime we update the interface we should re-impliment 
    {
        private readonly SchoolContext _context; //this context how going to connect to db
        //underscore is to point to local values
        public StudentService(SchoolContext context)
        {
            _context = context;
        }
        public Student CreateStudent(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
            return student;
        }

        public Student DeleteStudent(int id)
        {
            var student = GetStudentByid(id);
            _context.Students.Remove(student);
            _context.SaveChanges();
            return student;

        }

        public List<Student> GetAllStudents()
        {
            return _context.Students.ToList();
        }

        public Student GetStudentByid(int id)
        {
            return _context.Students.Find(id);
        }

      

        public bool IsStudentExist(int id)
        {
            return _context.Students.Any(x => x.ID == id);

        }

        public Student UpdateStudent( Student student)
        {
            //var st = _context.Update(student);  this line do the same code down
            var stu = _context.Students.Attach(student);
            stu.State = EntityState.Modified;
            _context.SaveChanges();
            return student;
        }
    }
}
