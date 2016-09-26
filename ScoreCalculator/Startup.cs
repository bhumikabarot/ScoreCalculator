using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ScoreCalculator.Startup))]
namespace ScoreCalculator
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
           
        }
    }
}
