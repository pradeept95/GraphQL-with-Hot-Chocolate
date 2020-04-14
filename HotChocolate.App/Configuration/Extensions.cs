using HotChocolate.App.Type;
using HotChocolate.AspNetCore;
using HotChocolate.AspNetCore.Voyager;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace HotChocolate.App.Configuration
{
    public static class Extensions
    {
        public static IServiceCollection AddAppGraphQL(this IServiceCollection services)
        {
            services.AddGraphQL(
              SchemaBuilder.New()
                  .AddQueryType<AppQueryType>()
                  //.AddQueryType<EmployeeQueryType>()
                  );


            return services;
        }

        public static IApplicationBuilder UseAppGraphQL(this IApplicationBuilder app)
        {
            app.UseGraphQL()
               .UsePlayground()
               .UseVoyager();
            return app;
        }
    }
}
