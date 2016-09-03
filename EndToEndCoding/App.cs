using Nancy;

namespace EndToEndCoding
{
    public class App : NancyModule
    {
        public App()
        {
            Get["/"] = _ => "Hello!";
        }
    }
}