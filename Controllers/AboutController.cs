using Microsoft.AspNetCore.Mvc;

namespace ode2Food.Controllers
{
    [Route("test/[controller]/[action]")]
    public class AboutController
    {
        
        public string Phone()
        {
            return "+9779801242490";
        }

        
        public string Address()
        {
            return "Bhimsengola,Old Baneshwore,Kathmandu,Nepal";
        }
    }
}
