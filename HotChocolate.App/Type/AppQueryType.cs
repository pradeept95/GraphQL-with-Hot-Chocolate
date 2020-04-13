using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotChocolate.App.Type
{
    class AppQueryType : ObjectType<Query>
    {
        protected override void Configure(IObjectTypeDescriptor<Query> descriptor)
        {
            descriptor.Field(f => f.Hello()).Type<NonNullType<StringType>>();
            descriptor.Field("foo").Type<StringType>().Resolver(() => "bar"); 
        }
    }

    public class Query
    {
        public string Hello() => "World from Pradeep";
    }
}
