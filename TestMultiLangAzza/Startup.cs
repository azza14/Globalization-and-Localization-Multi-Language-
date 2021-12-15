using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestMultiLangAzza.Startup))]
namespace TestMultiLangAzza
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
