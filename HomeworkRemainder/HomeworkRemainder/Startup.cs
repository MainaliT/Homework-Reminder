using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HomeworkRemainder.Startup))]
namespace HomeworkRemainder
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
