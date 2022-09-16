using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    public class TorneoView
    {
        //[Key]
        public int Id {get;set;}        
        public string Nombre { get; set; }        
        public string Categoria { get; set; }
        public string Disciplina { get; set; }
        public DateTime FechaInicial { get; set; }
        public DateTime FechaFinal { get; set; }
        //LLave Foranea De relacion con Municipio
        public string Municipio{ get; set; }

        }
}