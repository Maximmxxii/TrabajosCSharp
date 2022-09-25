using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    public class TorneoEquipo
    {
        //Llave primaria compuesta
        [Required(ErrorMessage="El campo {0} es Obligatorio")]
        public int TorneoId { get; set; }
        [Required(ErrorMessage="El campo {0} es Obligatorio")]
        public int EquipoId { get; set; }

        // Propiedad Navigacionales
        public Torneo Torneo {get; set;}
        public Equipo Equipo {get;set;}
    }

 }