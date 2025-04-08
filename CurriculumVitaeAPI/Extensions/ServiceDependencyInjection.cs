using CurriculumVitaeMiddleware.Contract.Repository;
using CurriculumVitaeMiddleware.Contract.Service;
using CurriculumVitaeRepository;
using CurriculumVitaeService;

namespace CurriculumVitaeAPI.Extensions
{
    public static class ServiceDependencyInjection
    {
        public static IServiceCollection AddDependencyInjection(this IServiceCollection services) => services.DependencyInjection()
                                                                                                             .AddServiceAutenticacionApi();



        private static IServiceCollection DependencyInjection(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IServiceFactory, ServiceFactory>();
            return services;
        }

        private static IServiceCollection AddServiceAutenticacionApi(this IServiceCollection services)
        {
            //services.AddAuthentication(options =>
            //{
            //    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            //    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            //}).AddJwtBearer(options =>
            //{
            //    options.RequireHttpsMetadata = false;
            //    options.SaveToken = true;
            //    options.TokenValidationParameters = new TokenValidationParameters
            //    {
            //        ValidateIssuerSigningKey = true,
            //        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Environment.GetEnvironmentVariable(CommonConst.SecretKeyJwt))),
            //        ValidateIssuer = false,
            //        ValidateAudience = false
            //    };
            //});

            return services;
        }
    }
}
