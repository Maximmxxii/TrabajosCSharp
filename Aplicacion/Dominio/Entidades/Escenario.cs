using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Dominio
{
    public class Escenario
    {        

        public int Id { get; set; }
        
        public string Nombre { get; set; }
        public string Direccion { get; set; }

        [RegularExpression("[0-9]*",ErrorMessage="Solo se permiten numeros")] 
        public int Espectadores { get; set; }
        public int TorneoId { get; set; }

        /**
        *! Propiedad Navigacional
        */
        public List<Campo> Campos {get; set;}
    }
}