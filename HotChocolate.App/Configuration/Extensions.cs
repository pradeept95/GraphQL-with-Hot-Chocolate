using HotChocolate.App.Type;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotChocolate.App.Configuration
{
    public static class Extensions
    {
        public static IServiceCollection AddAppGraphQL(this IServiceCollection services)
        {
            services.AddGraphQL(
              SchemaBuilder.New()
                  .AddQueryType<AppQueryType>());

            return services;
        }
    }
}
