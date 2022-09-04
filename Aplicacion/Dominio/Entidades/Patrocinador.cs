using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    
    public class Patrocinador
    {
        //[Key]
        public int Id {get;set;}

        [Required(ErrorMessage="El campo Nombre es Obligatorio")]
        [MaxLength(15,ErrorMessage="El campo {0} no puede tener mas de {1} Caracteres")]
        [MinLength(8,ErrorMessage="El campo {0} no puede tener menos de {1} Caracteres")]
        public string Identificacion {get;set;}

        [Required(ErrorMessage="El campo Nombre es Obligatorio")]
        [MaxLength(40,ErrorMessage="El campo {0} no puede tener mas de {1} Caracteres")]
        [MinLength(3,ErrorMessage="El campo {0} no puede tener menos de {1} Caracteres")]
        public string Nombre {get;set;}

        [Required(ErrorMessage="El campo Marca es Obligatorio")]
        [MaxLength(40,ErrorMessage="El campo {0} no puede tener mas de {1} Caracteres")]
        [MinLength(3,ErrorMessage="El campo {0} no puede tener menos de {1} Caracteres")]
        public string Marca {get;set;}

        [Required(ErrorMessage="El campo Tipo Persona es Obligatorio")]
        [MaxLength(40,ErrorMessage="El campo {0} no puede tener mas de {1} Caracteres")]
        [MinLength(3,ErrorMessage="El campo {0} no puede tener menos de {1} Caracteres")]
        public string TipoPersona {get;set;}

        [Required(ErrorMessage="El campo Direccion es Obligatorio")]
        [MaxLength(40,ErrorMessage="El campo {0} no puede tener mas de {1} Caracteres")]
        [MinLength(7,ErrorMessage="El campo {0} no puede tener menos de {1} Caracteres")]
        public string Direccion {get;set;}
        
        [DataType(DataType.PhoneNumber)]
        public string Telefono {get;set;}

        /**
        *! Propiedad Navigacional
        */
        public List<Equipo> Equipos {get; set;}

    }

}


