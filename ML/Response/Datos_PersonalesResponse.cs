using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML.Response
{
    public class Datos_PersonalesResponse
    {
        public int Code { get; set; }
        public string Message { get; set; }

        public List<ML.Entities.Datos_Personales> Datos_PersonalesList { get; set; }
    }
}
