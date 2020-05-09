using Microsoft.Extensions.Configuration;

namespace ode2Food.Services
{
    public interface IGreeter
    {
        string greetingsOfTheDay();
    }

    public class Greeter : IGreeter
    {
        private IConfiguration _confoguration;
        public Greeter(IConfiguration configuration)
        {
            _confoguration = configuration;
        }

        public string greetingsOfTheDay()
        {
            if (!string.IsNullOrEmpty(_confoguration["greeting"]))
                return _confoguration["greeting"];
            else
                return "Greetings fellow developers";
        }

    }
}