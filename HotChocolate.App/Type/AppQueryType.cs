using HotChocolate.Types;
using HotChocolate.Types.Relay;
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
            descriptor.Field("stringList")
                .Type<ListType<StringType>>()
                //.UsePaging<ListType<StringType>>()
                //.UseFiltering()
                //.UseSorting()
                .Resolver(() => {
                    return new Query().GetStringList();
                 })
                ; 
        }
    }

    public class Query
    {
        public string Hello() => "World from Pradeep";

        public List<string> GetStringList()
        {
            return new List<string> 
            { 
                "Pradeep",
                "Raj",
                "Thapaliya"
            };

        }
    }
}
