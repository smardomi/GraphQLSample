﻿using System;

namespace GraphQLSample.Web.Models
{
    public class InstructorModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public DateTime HireDate { get; set; }

    }
}
