using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HorarioApi.Models;
using MySql.Data.MySqlClient;


namespace HorarioApi.DAL
{
    public class HorarioDAL
    {
        private Conexion conex = new Conexion();
        public List<Horario> GetMatriculas()
        {
            List<Horario> LstHorarios = new List<Horario>();
            MySqlCommand cmd = new MySqlCommand("select * from horario", conex.GetConnection());
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    LstHorarios.Add(new Horario()
                    {
                        NroHorario = Convert.ToInt32(reader["nro_horario"]),
                        DiaMateria = DateTime.Parse(reader["dia_materia"].ToString()),
                        CicloHorario = Convert.ToInt32(reader["ciclo_horario"])
                    });
                }
            }
            return LstHorarios;
        }
    }
}