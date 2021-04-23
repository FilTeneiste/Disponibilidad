using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Net.Http.Formatting;

namespace SL.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {

            HttpClient clientHttp = new HttpClient();
            clientHttp.BaseAddress = new Uri("https://localhost:44372/");

            var request = clientHttp.GetAsync("api/GetAll").Result;

            if (request.IsSuccessStatusCode)
            {
                var DatosInfo = request.Content.ReadAsStringAsync().Result;
                var Listado = JsonConvert.DeserializeObject<List<ML.Entities.Datos_Personales>>(DatosInfo);
                return View(Listado);
            }
            return View();

        }

        public ActionResult Agregar(int id = 0)
        {
            return View(new ML.Entities.Datos_Personales());
        }

        [HttpPost]
        public ActionResult Agregar(ML.Entities.Datos_Personales datos_Personales)
        {
            HttpClient clientHttp = new HttpClient();
            clientHttp.BaseAddress = new Uri("https://localhost:44372/");

            var request = clientHttp.PostAsync("api/Add", datos_Personales, new JsonMediaTypeFormatter()).Result;

            if (request.IsSuccessStatusCode)
            {
                var DatosInfo = request.Content.ReadAsStringAsync().Result;
                var Listado = JsonConvert.DeserializeObject<ML.Entities.Datos_Personales>(DatosInfo);
                return View(Listado);
            }


            return View();
        }

        [HttpGet]
        public ActionResult Delete(int ID)
        {


            HttpClient clientHttp = new HttpClient();
            clientHttp.BaseAddress = new Uri("https://localhost:44372/");

            var request = clientHttp.DeleteAsync("api/Delete/" + ID).Result;

  
            if (request.IsSuccessStatusCode)
            {
                
                var DatosInfo = request.Content.ReadAsStringAsync().Result;
                var Listado = JsonConvert.DeserializeObject<ML.Entities.Datos_Personales>(DatosInfo);
                return RedirectToAction("Index");
            }

            return View();
        }



        //public ActionResult Delete(ML.Entities.Datos_Personales datos_Personales)
        //{

        //    return View("Delete");
        //}

        //[HttpGet]
        //public ActionResult Delete(ML.Entities.Datos_Personales datos_Personales, int id)
        //{


        //    HttpClient clientHttp = new HttpClient();
        //    clientHttp.BaseAddress = new Uri("https://localhost:44372/");

        //    var request = clientHttp.DeleteAsync("api/Delete" + id.ToString());

        //    request.Wait();

        //    var result = request.Result; 

        //    if (result.IsSuccessStatusCode)
        //    {
        //        return RedirectToAction("Index");
        //        //        var DatosInfo = result.Content.ReadAsStringAsync().Result;
        //        //        var Listado = JsonConvert.DeserializeObject<ML.Entities.Datos_Personales>(DatosInfo);
        //        //        return View(Listado);
        //    }


        //    return RedirectToAction("Index");
        //}


        public ActionResult Editar()
        {

            return View("Editar");
        }

        //public void Guardar(ML.Entities.Datos_Personales datos_Personales)
        //{
        //    if (datos_Personales != null)
        //    {

        //    }
        //}

        //[HttpPost]
        //public string Post(ML.Entities.Datos_Personales datos_Personales)
        //{
            
        //    //BL.Datos_Personales.Add(datos_Personales);
        //    //return ML.Entities.Datos_Personales.Datos();

        //}

    }    
}

