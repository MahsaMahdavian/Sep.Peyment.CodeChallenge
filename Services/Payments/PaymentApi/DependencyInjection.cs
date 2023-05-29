namespace Payments.PaymentApi
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services, IConfiguration configuration)
        {
            //return services
            //    .Scan(selector => selector
            //        .FromAssemblyOf<PeymentService>()
            //        .AddClasses(filter => filter.Where(x => x.Name.EndsWith("Service")))
            //        .AsImplementedInterfaces()
            //        .WithScopedLifetime()
            //    );
        }
    }
}
