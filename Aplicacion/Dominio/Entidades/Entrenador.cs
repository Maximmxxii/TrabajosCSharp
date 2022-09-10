using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    public class Entrenador
    {
        //[Key]
        public int Id { get; set; }


        [Required(ErrorMessage="El campo Documento es Obligatorio")]
        [MaxLength(15,ErrorMessage="El campo {0} no puede tener mas de {1} Caracteres")]
        [MinLength(8
        ,ErrorMessage="El campo {0} no puede tener menos de {1} Caracteres")]
        [RegularExpression("[0-9]*",ErrorMessage="Solo se permiten numeros")] 
        public string Documento { get; set;}

        [Required(ErrorMessage="El campo Nombres es Obligatorio")]
        [MaxLength(30,ErrorMessage="El campo {0} no puede tener mas de {1} Caracteres")]
        [MinLength(3,ErrorMessage="El campo {0} no puede tener menos de {1} Caracteres")]
        [RegularExpression("[A-Za-z ]*",ErrorMessage="Solo se permiten letras")] 
        public string Nombres { get; set; }

        [Required(ErrorMessage="El campo Apellidos es Obligatorio")]
        [MaxLength(30,ErrorMessage="El campo {0} no puede tener mas de {1} Caracteres")]
        [MinLength(3,ErrorMessage="El campo {0} no puede tener menos de {1} Caracteres")]
        public string Apellidos { get; set; }

        [Required(ErrorMessage="El campo Genero es Obligatorio")]
        [MaxLength(10,ErrorMessage="El campo {0} no puede tener mas de {1} Caracteres")]
        [MinLength(1,ErrorMessage="El campo {0} no puede tener menos de {1} Caracteres")]
        [RegularExpression("[A-Za-z]*",ErrorMessage="Solo se permiten letras")] 
        public string Genero { get; set; }

        [Required(ErrorMessage="El campo Celular es Obligatorio")]
        [Range(3000000000,3509999999, ErrorMessage="Escriba Un Numero Valido")]
        public string Celular { get; set; }

        [Required(ErrorMessage="El campo Correo es Obligatorio")]        
        [DataType(DataType.EmailAddress)]
        public string Correo { get; set; }
               
        [RegularExpression("[A-Za-z]*",ErrorMessage="Solo se permiten letras")]
        public string Nacionalidad { get; set; }

        [Required(ErrorMessage="El campo Rh es Obligatorio")]        
        public string Rh { get; set; }

        //LLave Foranea De relacion con Municipio
        public int EquipoId { get; set; }
    }
}