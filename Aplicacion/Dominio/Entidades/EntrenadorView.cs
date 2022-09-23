using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    public class EntrenadorView
    {
        //[Key]
        public int Id { get; set; }         
        public string Documento { get; set;}        
        public string Nombres { get; set; }        
        public string Apellidos { get; set; }
        //LLave Foranea De relacion con Municipio
        public string Equipo { get; set; }
    }
}