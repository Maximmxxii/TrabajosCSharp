using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    //[Index(nameof(Identificacion), IsUnique = true)] //Validamos que un indice sea unico y no se repita OJO asi sirve para 
    // la version 5
    public class Patrocinador
    {
        //[Key]
        public int Id {get;set;}

        [Required(ErrorMessage="El campo Nombre es Obligatorio")]
        [MaxLength(15,ErrorMessage="El campo {0} no puede tener mas de {1} Caracteres")]
        [MinLength(8,ErrorMessage="El campo {0} no puede tener menos de {1} Caracteres")]
        [RegularExpression("[0-9]*",ErrorMessage="Solo se permiten numeros")] 
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
        [RegularExpression("[0-9]*",ErrorMessage="Solo se permiten numeros")] 
        public string Telefono {get;set;}

        /**
        *! Propiedad Navigacional para la Relacion Equipo
        */
        public List<Equipo> Equipos {get; set;}

        


    }

}


