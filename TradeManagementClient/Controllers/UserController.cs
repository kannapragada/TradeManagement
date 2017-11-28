using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using TradeManagementAPI.Models;

namespace TradeManagementClient.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        //public ActionResult Index()
        //{
        //    return View();
        //}

        string Baseurl = "http://localhost/TradeManagementAPI";      
        public async Task<ActionResult> Index()
        {  
            List<User> UserInfo = new List<User>();  
              
            using (var client = new HttpClient())  
            {  
                //Passing service base url  
                client.BaseAddress = new Uri(Baseurl);  
  
                
                client.DefaultRequestHeaders.Clear();  
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));  
                 
                //Sending request to find web api REST service resource GetAllUsers using HttpClient  
                HttpResponseMessage Res = await client.GetAsync("http://localhost/TradeManagementAPI/api/User/Get?id=1");  
  
                //Checking the response is successful or not which is sent using HttpClient  
                if (Res.IsSuccessStatusCode)  
                {  
                    //Storing the response details recieved from web api   
                    var UserResponse = Res.Content.ReadAsStringAsync().Result;  
  
                    //Deserializing the response recieved from web api and storing into the User list  
                    UserInfo = JsonConvert.DeserializeObject<List<User>>(UserResponse);  
  
                }  
                //returning the User list to view  
                return View(UserInfo);  
            }  
        }  
        

        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: User/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: User/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: User/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
