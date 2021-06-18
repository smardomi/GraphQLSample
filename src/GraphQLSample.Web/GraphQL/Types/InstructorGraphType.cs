using GraphQL.Types;
using GraphQLSample.Web.Models;

namespace GraphQLSample.Web.GraphQL.Types
{
    public sealed class InstructorGraphType : ObjectGraphType<InstructorModel>
    {
        public InstructorGraphType()
        {
            Field(a => a.Id);
            Field(a => a.FirstName);
            Field(a => a.LastName);
            Field(a => a.Age);
            Field(a => a.Email);
            Field(a => a.HireDate);
        }
    }
}
