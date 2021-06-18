using System.Collections.Generic;
using GraphQLSample.Web.Models;

namespace GraphQLSample.Web.Repository
{
    public class StudentRepository
    {
        private readonly List<StudentModel> _students = new();

        public StudentRepository()
        {
            _students.Add(new StudentModel
                {Id = 1, FirstName = "Saeed", LastName = "Mardomi", Age = 27, Email = "saeedmardomi@hotmail.com"});
            _students.Add(new StudentModel
                { Id = 1, FirstName = "Vahid", LastName = "Mardomi", Age = 23, Email = "vahidmardomi@gmail.com" });
            _students.Add(new StudentModel
                { Id = 1, FirstName = "Katy", LastName = "Perry", Age = 36, Email = "KatyPerry@gmail.com" });
        }

        public List<StudentModel> GetStudents() => _students;
    }
}
