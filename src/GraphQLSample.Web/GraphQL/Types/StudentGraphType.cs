using GraphQL.Types;
using GraphQLSample.Web.Models;

namespace GraphQLSample.Web.GraphQL.Types
{
    public sealed class StudentGraphType : ObjectGraphType<StudentModel>
    {
        public StudentGraphType()
        {
            Field(a => a.Id);
            Field(a => a.FirstName);
            Field(a => a.LastName);
            Field(a => a.Age);
            Field(a => a.Email);
        }
    }
}
