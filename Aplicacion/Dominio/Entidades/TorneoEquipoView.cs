using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    public class TorneoEquipoView
    {
        //Llave primaria compuesta
       
        public int TorneoId { get; set; }        
        public int EquipoId { get; set; }

   
        public string Torneo {get; set;}
        public string Equipo {get;set;}
    }
}