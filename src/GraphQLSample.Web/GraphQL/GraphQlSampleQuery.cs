using GraphQL.Types;
using GraphQLSample.Web.GraphQL.Types;
using GraphQLSample.Web.Repository;

namespace GraphQLSample.Web.GraphQL
{
    public class GraphQlSampleQuery : ObjectGraphType
    {
        public GraphQlSampleQuery()
        {
            var studentRepository = new StudentRepository();

            Field<ListGraphType<StudentGraphType>>(
                name: "students",
                resolve:  _ =>  studentRepository.GetStudents()
            );

            var instructorRepository = new InstructorRepository();

            Field<ListGraphType<InstructorGraphType>>(
                name: "instructors",
                resolve: _ => instructorRepository.GetInstructors()
            );
        }
    }
}
