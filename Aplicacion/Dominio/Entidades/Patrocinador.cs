using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    
    public class Patrocinador
    {
       
        public int Id {get;set;}

        [Required(ErrorMessage="El campo Nombre es Obligatorio")]
        [MaxLength(15,ErrorMessage="El campo {0} no puede tener mas de {1} Caracteres")]
        [MinLength(8,ErrorMessage="El campo {0} no puede tener menos de {1} Caracteres")]
        public string Identificacion {get;set;}

        [Required(ErrorMessage="El campo Nombre es Obligatorio")]
        [MaxLength(40,ErrorMessage="El campo {0} no puede tener mas de {1} Caracteres")]
        [MinLength(3,ErrorMessage="El campo {0} no puede tener menos de {1} Caracteres")]
        public string Name {get;set;}

        [Required(ErrorMessage="El campo Nombre es Obligatorio")]
        public string Marca {get;set;}
        public string TipoPersona {get;set;}
        public string Direccion {get;set;}
        public string Telefono {get;set;}

    }

}


