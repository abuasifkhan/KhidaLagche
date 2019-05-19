using Microsoft.AspNetCore.Mvc;

namespace KhidhaLagche.Controllers
{
    [Route("About")]
    public class AboutController : Controller
    {
        [Route("")]
        public string Phone()
        {
            return "09238403298";
        }

        [Route("Address")]
        public string Address()
        {
            return "slajfldasjf";
        }
    }
}