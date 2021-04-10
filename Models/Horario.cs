using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HorarioApi.Models
{
    public class Horario
    {
        public int NroHorario { get; set; }
        public DateTime DiaMateria { get; set; }
        public int CicloHorario { get; set; }
    }
}