using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HorarioApi.BLL;
using HorarioApi.Models;
using System.Web.Http;
using System.Web.Http.Cors;


namespace HorarioApi.Controllers
{
    public class HorariosController
    {

        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [RoutePrefix("api")]
        public class MatriculasController : ApiController
        {
            private HorarioBLL negocio = new HorarioBLL();

            [HttpGet]
            [Route("horarios")]
            public List<Horario> ListadoMatriculas()
            {
                return negocio.GetMatriculas();
            }
        }
    }
}