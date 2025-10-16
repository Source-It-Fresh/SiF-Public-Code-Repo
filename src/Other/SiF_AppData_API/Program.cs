using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;
using SourceItFresh.Areas.Base_Discover.Data;
using SourceItFresh.Areas.Configure_PaidServices.Data;
using SourceItFresh.Areas.Configure_Settings.Data;
using SourceItFresh.Areas.Core_Help.Data;
using SourceItFresh.Areas.Core_Identity.Data;
using SourceItFresh.Areas.Core_Login.Data;
using SourceItFresh.Areas.CustomIdentity;
using SourceItFresh.Areas.CustomIdentity.Models;
using SourceItFresh.Areas.Manage_Commodities.Data;
using SourceItFresh.Areas.Manage_Farm.Data;
using SourceItFresh.Areas.ManageOrg_Accounts.Data;
using SourceItFresh.Areas.ManageOrg_ActionLogs.Data;
using SourceItFresh.Areas.ManageOrg_TraderEntity.Data;
using SourceItFresh.Areas.Market_Consumer.Data;
using SourceItFresh.Areas.Market_Vendor.Data;
using Microsoft.Extensions.Hosting;

namespace SiF_AppData_API;

public class Program
{
    public static void Main(string[] args)
    {
        #region InitGlobalVars
        var builder = WebApplication.CreateBuilder(args);
        var services = builder.Services;
        var configuration = builder.Configuration;
        #endregion InitGlobalVars

        #region AzureKeyVault
        //builder.Host.ConfigureAppConfiguration((context, config) =>
        //{
        //    if (!context.HostingEnvironment.IsDevelopment())
        //    {
        //        // string keyVaultEndpoint = Environment.GetEnvironmentVariable("VaultUri");
        //        // string keyVaultEndpoint = configuration["KeyVault_EndPoint"];

        //        //string keyVaultEndpoint = "https://sif-key-vault.vault.azure.net/";
        //        string keyVaultEndpoint = "https://sif-staging-key-vault.vault.azure.net/";

        //        if (!string.IsNullOrEmpty(keyVaultEndpoint))
        //        {
        //            //var azureServiceTokenProvider = new AzureServiceTokenProvider();
        //            //var keyVaultClient = new KeyVaultClient(new KeyVaultClient.AuthenticationCallback(azureServiceTokenProvider.KeyVaultTokenCallback));
        //            //config.AddAzureKeyVault(new Uri(keyVaultEndpoint), keyVaultClient, new DefaultKeyVaultSecretManager());

        //            var secretClient = new SecretClient(new Uri(keyVaultEndpoint), new DefaultAzureCredential());
        //            config.AddAzureKeyVault(secretClient, new KeyVaultSecretManager());
        //        }
        //        else
        //        {
        //            throw new Exception("KeyVault ISSUE");
        //        }
        //    }
        //});
        #endregion AzureKeyVault

        // Add shared Aspire service defaults
        builder.AddServiceDefaults();
        //builder.AddRedisOutputCache("cache");

        #region SetupContainerConnections
        // ToDo: Add services to the container.
        // var TEST = configuration["ConnectionStrings:AppDataConnection"];
        builder.Services.AddProblemDetails();
        #endregion SetupContainerConnections

        builder.Services.AddControllers();
        // builder.Services.AddEndpointsApiExplorer();

        // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi        
        builder.Services.AddOpenApi();

        #region DbContext 4 services
        // var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
        // builder.Services.AddDbContext<SIF_Data_DbContext>(options => options.UseSqlServer(connectionString));

        // ToDo: Move DbContext to service APIs (in container).

        builder.Services.AddDbContext<SIF_Core_Identity_DbContext>(options => options.UseSqlServer(configuration["ConnectionStrings:IdentityConnection"]));
        //builder.Services.AddDbContext<SIF_Data_DbContext>(options => options.UseSqlServer(configuration["ConnectionStrings:AppDataConnection"]));

        builder.Services.AddDbContext<SIF_Core_Help_DbContext>(options => options.UseSqlServer(configuration["ConnectionStrings:AppDataConnection"]));
        builder.Services.AddDbContext<SIF_Core_Login_DbContext>(options => options.UseSqlServer(configuration["ConnectionStrings:AppDataConnection"]));

        builder.Services.AddDbContext<SIF_TrefleData_DbContext>(options => options.UseSqlServer(configuration["ConnectionStrings:AppDataConnection"]));

        builder.Services.AddDbContext<SiF_Base_Discover_DbContext>(options => options.UseSqlServer(configuration["ConnectionStrings:AppDataConnection"]));
        //builder.Services.AddDbContext<SiF_Base_Learn_DbContext>(options => options.UseSqlServer(configuration["ConnectionStrings:AppDataConnection"]));

        //builder.Services.AddDbContext<SiF_Configure_AddIns_DbContext>(options => options.UseSqlServer(configuration["ConnectionStrings:AppDataConnection"]));
        builder.Services.AddDbContext<SiF_Configure_Settings_DbContext>(options => options.UseSqlServer(configuration["ConnectionStrings:AppDataConnection"]));
        builder.Services.AddDbContext<SiF_Configure_PaidServices_DbContext>(options => options.UseSqlServer(configuration["ConnectionStrings:AppDataConnection"]));
        builder.Services.AddDbContext<SiF_ManageOrg_TraderEntity_DbContext>(options => options.UseSqlServer(configuration["ConnectionStrings:AppDataConnection"]));
        builder.Services.AddDbContext<SiF_ManageOrg_ActionLogs_DbContext>(options => options.UseSqlServer(configuration["ConnectionStrings:AppDataConnection"]));
        builder.Services.AddDbContext<SiF_ManageOrg_Accounts_DbContext>(options => options.UseSqlServer(configuration["ConnectionStrings:AppDataConnection"]));
        builder.Services.AddDbContext<SiF_Manage_Farm_DbContext>(options => options.UseSqlServer(configuration["ConnectionStrings:AppDataConnection"]));
        builder.Services.AddDbContext<SiF_Manage_Commodities_DbContext>(options => options.UseSqlServer(configuration["ConnectionStrings:AppDataConnection"]));
        builder.Services.AddDbContext<SiF_Market_Consumer_DbContext>(options => options.UseSqlServer(configuration["ConnectionStrings:AppDataConnection"]));
        builder.Services.AddDbContext<SiF_Market_Vendor_DbContext>(options => options.UseSqlServer(configuration["ConnectionStrings:AppDataConnection"]));
        #endregion DbContext 4 services

        #region IdentityConfig       
        Action<IdentityOptions> identityOptions = options =>
        {
            options.User = new UserOptions
            {
                AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+",
                RequireUniqueEmail = true,
            };

            options.Password = new PasswordOptions
            {
                RequiredLength = 7,
                RequireUppercase = true,
                RequireLowercase = true,
                RequireDigit = true,
                RequireNonAlphanumeric = false,
                RequiredUniqueChars = 1
            };

            options.SignIn = new SignInOptions
            {
                RequireConfirmedAccount = true,
                RequireConfirmedEmail = true
            };

            options.Lockout = new LockoutOptions
            {
                DefaultLockoutTimeSpan = TimeSpan.FromMinutes(7),
                MaxFailedAccessAttempts = 3,
                AllowedForNewUsers = true
            };
        };

        //builder.Services.AddIdentityCore<SIF_ApplicationUser>(identityOptions)
        //    .AddRoles<SIF_ApplicationRole>()
        //    .AddDefaultUI()
        //    .AddDefaultTokenProviders()
        //    .AddEntityFrameworkStores<SIF_Core_Identity_DbContext>();

        //builder.Services.AddIdentity<SIF_ApplicationUser, SIF_ApplicationRole>(identityOptions)
        //    //.AddRoles<SIF_ApplicationRole>()
        //    .AddDefaultUI()
        //    .AddDefaultTokenProviders()
        //    .AddEntityFrameworkStores<SIF_Core_Identity_DbContext>();

        //builder.Services.AddDefaultIdentity<SIF_ApplicationUser>(identityOptions)
        //    .AddRoles<SIF_ApplicationRole>()
        //    //.AddDefaultUI()
        //    //.AddDefaultTokenProviders()
        //    .AddEntityFrameworkStores<SIF_Core_Identity_DbContext>();

        builder.Services.AddIdentityApiEndpoints<SIF_ApplicationUser>(identityOptions)
            .AddRoles<SIF_ApplicationRole>()
            //.AddDefaultUI()
            .AddDefaultTokenProviders()
            .AddEntityFrameworkStores<SIF_Core_Identity_DbContext>();
        #endregion IdentityConfig

        #region Authentication
        builder.Services.AddAuthentication(options =>
        {
            // options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            options.DefaultScheme = IdentityConstants.ApplicationScheme;
            options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
            options.DefaultChallengeScheme = IdentityConstants.ApplicationScheme;
        })
        //.AddIdentityCookies()
        //.AddCookie("Identity.Bearer", options =>
        //{
        //    options.Cookie.Name = "Identity.Bearer";
        //    options.Cookie.HttpOnly = true;
        //    options.Cookie.SameSite = SameSiteMode.Strict;
        //    options.Cookie.SecurePolicy = CookieSecurePolicy.Always;
        //})
        ;
        #endregion Authentication

        #region ConfigureCookie
        //builder.Services.ConfigureApplicationCookie(options =>
        //{
        //    // Cookie settings
        //    options.Cookie.HttpOnly = true;
        //    options.ExpireTimeSpan = TimeSpan.FromMinutes(7);

        //    options.LoginPath = "/Identity/Account/Login";
        //    options.AccessDeniedPath = "/Identity/Account/AccessDenied";
        //    options.SlidingExpiration = true;
        //});
        #endregion ConfigureCookie

        #region Authorization_Policies
        builder.Services.AddAuthorization(options =>
        {
            //options.AddPolicy("Founders", policy => policy.RequireClaim("EmployeeNumber", "1", "2", "3", "4", "5"));

            options.AddPolicy(Policies.IsAdmin, Policies.IsAdminPolicy());
            options.AddPolicy(Policies.IsUser, Policies.IsUserPolicy());

            //ToDo: Use reflection to get additional assembly module areas

            options.AddPolicy("ViewIdentity", policy => policy.RequireClaim("ViewIdentity"));
            options.AddPolicy("AddIdentity", policy => policy.RequireClaim("AddIdentity"));
            options.AddPolicy("EditIdentity", policy => policy.RequireClaim("EditIdentity"));
            options.AddPolicy("DeleteIdentity", policy => policy.RequireClaim("DeleteIdentity"));

            options.AddPolicy("ViewExampleSpace", policy => policy.RequireClaim("ViewExampleSpace"));
            options.AddPolicy("AddExampleSpace", policy => policy.RequireClaim("AddExampleSpace"));
            options.AddPolicy("EditExampleSpace", policy => policy.RequireClaim("EditExampleSpace"));
            options.AddPolicy("DeleteExampleSpace", policy => policy.RequireClaim("DeleteExampleSpace"));
        });
        #endregion Authorization_Policies


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
            options.DocumentTitle = "SiF_AppData_API Documentation";
        });

        app.UseHttpsRedirection();

        app.UseAuthentication();
        app.UseAuthorization();

        app.MapIdentityApi<SIF_ApplicationUser>();
        app.MapControllers();

        app.Run();
    }
}