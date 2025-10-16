using StackExchange.Redis;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = DistributedApplication.CreateBuilder(args);

        var cache = builder.AddRedis("cache");

        #region Add the ASP.NET Core Web-API projects
        var helperApi = builder.AddProject<Projects.SiF_ASPNetCore_Helper_WebAPI>("SiF-ASPNetCore-Helper-WebAPI");
        var allAppDataApi = builder.AddProject<Projects.SiF_AppData_API>("SiF-AppData-API");

        // var aotWebApi = builder.AddProject<Projects.SiF_ASPNetCore_AOT_WebAPI>("SiF-ASPNetCore-AOT-WebAPI");
        // var grpcService = builder.AddProject<Projects.SiF_ASPNetCore_gRPC_Service>("SiF-ASPNetCore-gRPC-Service"); 
        #endregion Add the ASP.NET Core Web-API projects

        #region Add the Server-App projects
        //var mvcWebApp = builder.AddProject<Projects.SiF_ASPNetCore_MVC_WebApp>("SiF-ASPNetCore-MVC-WebApp")
        //var razorWebApp = builder.AddProject<Projects.SiF_ASPNetCore_Razor_WebApp>("SiF-ASPNetCore-Razor-WebApp")
        var blazorServer = builder.AddProject<Projects.SiF_Blazor_Server_App>("SiF-ASPNetCore-Blazor-Server-App")
        //var blazorWebApp = builder.AddProject<Projects.SiF_Blazor_Web_App>("SiF-ASPNetCore-Blazor-Web-App")
            .WithExternalHttpEndpoints()
            .WithReference(cache)
            .WaitFor(cache)
            .WithReference(helperApi)
            .WaitFor(helperApi)
            .WithReference(allAppDataApi)
            .WaitFor(allAppDataApi)
        ;
        #endregion Add the Server-App projects

        builder.Build().Run();
    }
}