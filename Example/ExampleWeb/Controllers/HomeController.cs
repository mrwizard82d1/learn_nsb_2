using System.Collections.Generic;
using System.Text;
using System.Web.Mvc;
using UserService.Messages.Commands;

namespace ExampleWeb.Controllers
{
    public class HomeController : Controller
    {
        public static Queue<string> Subscribers = new Queue<string>();

        // GET: Home
        public ActionResult Index()
        {
            return Json(new
            {
                text = "Hello, NService Bus World!",
                subscribers = Subscribers
            });
        }

        public ActionResult CreateUser(string name, string email)
        {
            var cmd = new CreateNewUserCmd
            {
                Name = name,
                EmailAddress = email
            };

            ServiceBus.Bus.Send(cmd);

            return Json(new
            {
                sent = cmd,
                subscribers = Subscribers
            });
        }

        protected override JsonResult Json(object data, string contentType, Encoding contentEncoding, JsonRequestBehavior behavior)
        {
            return base.Json(data, contentType, contentEncoding, JsonRequestBehavior.AllowGet);
        }
    }
}