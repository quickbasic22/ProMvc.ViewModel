using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProMvc5.ViewModel.Startup))]
namespace ProMvc5.ViewModel
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
