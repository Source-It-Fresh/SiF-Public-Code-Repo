using Microsoft.Extensions.Hosting;
using Scalar.AspNetCore;

namespace SiF_ASPNetCore_Helper_WebAPI;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add shared Aspire service defaults
        builder.AddServiceDefaults();

        // Add services to the container.

        builder.Services.AddControllers();
        // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
        builder.Services.AddOpenApi();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.MapOpenApi();

            //.../swagger/index.html
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/openapi/v1.json", "API V1");
            });

            //.../scalar/v1/
            app.MapScalarApiReference();

        }

        //.../api-docs/index.html
        app.UseReDoc(options =>
        {
            options.SpecUrl = "/openapi/v1.json";
            options.DocumentTitle = "SiF_ASPNetCore_Helper_WebAPI Documentation";
        });

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}