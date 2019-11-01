using System.Collections.Generic;
using ConfiguringApps.Infrastructure;
using Microsoft.AspNetCore.Mvc;
namespace ConfiguringApps.Controllers
{
    public class HomeController : Controller
    {
        private UptimeService uptime;
        public HomeController(UptimeService up) => uptime = up;

        public ViewResult Index(bool throwException = false)
        {
            if (throwException)
            {
                throw new System.NullReferenceException();
            }
            return View(new Dictionary<string, string>
            {
                ["Message"] = "This is the Index acti12on",
                ["Uptime"] = $"{uptime.Uptime}ms"
            });
        }
        public ViewResult Error() => View(nameof(Index),
            new Dictionary<string, string>
            {
                ["Message"] = "This is the Error action"
            });
    }

}