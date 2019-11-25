using Pidev.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;

namespace Pidev.Controllers
{
    public class EmployeController : Controller
    {
       
        public ActionResult Index()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:8415");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync("api/employes").Result;
            if (response.IsSuccessStatusCode)
            {
                ViewBag.result = response.Content.ReadAsAsync <IEnumerable<Employee>> ().Result;
            }
            else
            {
                ViewBag.result = "error";
            }
            return View();

        }

        [HttpGet]
        public ActionResult Create()
        {
            return View("create");

        }
        [HttpPost]
        public ActionResult Create( Employee evm)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:8415");
            client.PostAsJsonAsync<Employee>("api/employes",evm).ContinueWith((postTask) => postTask.Result.EnsureSuccessStatusCode());
            return RedirectToAction("Index");
        }

    }
}