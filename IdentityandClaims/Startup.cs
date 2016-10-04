using Owin;

//[assembly: OwinStartupAttribute(typeof(IdentityandClaims.Startup))]
namespace IdentityandClaims
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
