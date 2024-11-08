using System.Globalization;

namespace Criptografia.web.Configuration
{
    public static  class MvcConfiguration
    {
        public static void AddMvcConfiguration(this WebApplicationBuilder builder)
        {
            var cultureInfo = new CultureInfo("pt-BR");
            CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
            CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;

            builder.Services.AddControllersWithViews()
                .AddJsonOptions(options => options.JsonSerializerOptions.PropertyNamingPolicy = null);

            builder.Services
                .AddRazorPages()
                .AddDataAnnotationsLocalization()
                .AddRazorRuntimeCompilation();
        }
    }
}
