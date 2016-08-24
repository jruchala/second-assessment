using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(jruchala_secondassessment.Startup))]
namespace jruchala_secondassessment
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
