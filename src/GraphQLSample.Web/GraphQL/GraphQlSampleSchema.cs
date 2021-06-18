using System;
using GraphQL.Types;
using Microsoft.Extensions.DependencyInjection;

namespace GraphQLSample.Web.GraphQL
{
    public class GraphQlSampleSchema : Schema
    {
        public GraphQlSampleSchema(IServiceProvider provider) : base(provider)
        {
            Query = provider.GetRequiredService<GraphQlSampleQuery>();
        }

    }
}
