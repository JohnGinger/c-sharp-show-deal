using Nancy;
using Nancy.Conventions;

namespace EndToEndCoding
{
    public class Bootstrapper1 : DefaultNancyBootstrapper
    {
        protected override void ConfigureConventions(NancyConventions nancyConventions)
        {
            nancyConventions.StaticContentsConventions.Add(StaticContentConventionBuilder.AddDirectory("Static", @"Static"));
            base.ConfigureConventions(nancyConventions);
        }
    }
}