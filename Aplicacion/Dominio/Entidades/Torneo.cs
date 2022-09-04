using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    public class Torneo
    {
        //[Key]
        public int Id {get;set;}

        [Required(ErrorMessage="El campo Nombre es Obligatorio")]
        [MaxLength(30,ErrorMessage="El campo {0} no puede tener mas de {1} Caracteres")]
        [MinLength(6,ErrorMessage="El campo {0} no puede tener menos de {1} Caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage="El campo Categoria es Obligatorio")]
        [MaxLength(40,ErrorMessage="El campo {0} no puede tener mas de {1} Caracteres")]
        [MinLength(4,ErrorMessage="El campo {0} no puede tener menos de {1} Caracteres")]
        public string Categoria { get; set; }

        [Required(ErrorMessage="El campo Disciplina es Obligatorio")]
        [MaxLength(15,ErrorMessage="El campo {0} no puede tener mas de {1} Caracteres")]
        [MinLength(6,ErrorMessage="El campo {0} no puede tener menos de {1} Caracteres")]
        public string Disciplina { get; set; }

        [Required(ErrorMessage="El campo Fecha Inicial es Obligatorio")]
        [DataType(DataType.Date)]
        public DateTime FechaInicial { get; set; }

        [Required(ErrorMessage="El campo Fecha Final es Obligatorio")]
        [DataType(DataType.Date)]
        public DateTime FechaFinal { get; set; }

        [Required(ErrorMessage="El campo Municipio ID es Obligatorio")]   
        //LLave Foranea De relacion con Municipio
        public int MunicipioId{ get; set; }

        /**
        *! Propiedad Navigacional Para Juez
        */
        public List<Juez> Jueces {get; set;}

        /**
        *! Propiedad Navigacional Para TorneoEquipo
        */
        public List<TorneoEquipo> TorneosXEquipos {get; set;}

        /**
        *! Propiedad Navigacional Para Escenarios
        */
        public List<Escenario> Escenarios {get; set;}
        
        }
}