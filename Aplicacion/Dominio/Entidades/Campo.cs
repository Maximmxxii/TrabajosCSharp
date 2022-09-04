using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Dominio
{
    public class Campo
    {
        public int Id { get; set; }
        
        public string Nombre { get; set; }
        public string Disciplina { get; set; }
        public int Capacidad { get; set; }
        public int EscenarioId { get; set; }

    }
}