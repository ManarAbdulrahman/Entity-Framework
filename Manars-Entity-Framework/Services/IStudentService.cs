using Manars_Entity_Framework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manars_Entity_Framework.Services
{
    public interface IStudentService
    {
        // Student is the Class in Model 
        List<Student> GetAllStudents();
        Student GetStudentByid(int id);

        Student CreateStudent(Student student);
        Student UpdateStudent(Student student);
        bool IsStudentExist(int id);
        Student DeleteStudent(int id);
    }
}
