using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SL.Controllers
{
    public class Datos_PersonalesController : ApiController
    {
        [HttpGet]
        [Route("api/GetAll")]
        public IHttpActionResult GetAll()
        {

            ML.Response.Datos_PersonalesResponse request = BL.Datos_Personales.GetAll();

            return Ok(request.Datos_PersonalesList);


        }

        [HttpPost]
        [Route("api/Add")]
        public IHttpActionResult Add(ML.Entities.Datos_Personales datos_Personales)
        {

            ML.Response.Datos_PersonalesResponse request = BL.Datos_Personales.Add(datos_Personales);

            return Ok(request);


        }

        [HttpDelete]
        [Route("api/Delete/{ID}")]
        public IHttpActionResult Delete(int ID)
        {

            ML.Response.Datos_PersonalesResponse request = BL.Datos_Personales.Delete(ID);

            return Ok(request);


        }



    }
}
