using BlowOut.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace BlowOut.Controllers
{
    public class ContactController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.msg = "Please call Support at " + "<u><strong>801-555-1212. </strong></u>" + " Thank you!";
            return View();
        }

        public ActionResult Email(string name, string email)
        {
            ViewBag.msg = "Thank you " + name + ". We will send an email to " + email;
            return View("Index");
        }

        //web api
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Index(EmailModel model)
        {
            using (var client = new HttpClient())
            {
                //Passing service base url    
                client.BaseAddress = new Uri(Baseurl);

                client.DefaultRequestHeaders.Clear();
                //Define request data format    
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service using HttpClient    
                HttpResponseMessage Res = await client.PostAsJsonAsync("api/email/send-email", model);

                //Checking the response is successful or not which is sent using HttpClient    
                if (Res.IsSuccessStatusCode)
                {
                    return View("Success");
                }
                else
                {
                    return View("Error");
                }
            }
        }
    }
}