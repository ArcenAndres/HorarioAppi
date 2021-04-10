using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HorarioApi.DAL;
using HorarioApi.Models;

namespace HorarioApi.BLL
{
    public class HorarioBLL
    {
        private HorarioDAL datos = new HorarioDAL();
        public List<Horario> GetMatriculas()
        {
            return datos.GetMatriculas();
        }

    }
}