using BOFAChallenge.UI.Domain.Interfaces;
using BOFAChallenge.UI.Services;

namespace BOFAChallenge.UI.Dependencies
{
    public static class ServicesDependency
    {
        public static void AddServiceDependency(this IServiceCollection services)
        {
            services.AddSingleton<IValidationUser, ValidationUser>();
        }
    }
}