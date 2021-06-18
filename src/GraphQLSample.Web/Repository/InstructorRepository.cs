using System;
using System.Collections.Generic;
using GraphQLSample.Web.Models;

namespace GraphQLSample.Web.Repository
{
    public class InstructorRepository
    {
        private readonly List<InstructorModel> _instructors = new();

        public InstructorRepository()
        {
            _instructors.Add(new InstructorModel
            { Id = 1, FirstName = "Ali", LastName = "Rezaei", Age = 42, Email = "Ali@hotmail.com", HireDate = DateTime.Now.AddMonths(-5) });
            _instructors.Add(new InstructorModel
            { Id = 1, FirstName = "Sara", LastName = "Azimi", Age = 32, Email = "Sara@gmail.com", HireDate = DateTime.Now.AddYears(-1) });
            _instructors.Add(new InstructorModel
            { Id = 1, FirstName = "NazaninZahra", LastName = "Mardomi", Age = 29, Email = "NazaninZahra@gmail.com", HireDate = DateTime.Now.AddDays(-20) });
        }

        public List<InstructorModel> GetInstructors() => _instructors;
    }
}
