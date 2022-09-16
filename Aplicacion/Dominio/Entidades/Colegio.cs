using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    public class Colegio
    {
        //[Key]
        public int Id {get; set;}

        [Required(ErrorMessage="El campo NIT es Obligatorio")]
        [MaxLength(12,ErrorMessage="El campo {0} no puede tener mas de {1} Caracteres")]
        [MinLength(9,ErrorMessage="El campo {0} no puede tener menos de {1} Caracteres")]
        public string NIT {get; set;}

        [Required(ErrorMessage="El campo RazonSocial es Obligatorio")]
        [MaxLength(50,ErrorMessage="El campo {0} no puede tener mas de {1} Caracteres")]
        [MinLength(2,ErrorMessage="El campo {0} no puede tener menos de {1} Caracteres")]
        [RegularExpression("[A-Za-z ]*",ErrorMessage="Solo se permiten letras.")]
        public string RazonSocial {get; set;}
        
        [DataType(DataType.PhoneNumber)]
        [RegularExpression("[0-9]*",ErrorMessage="Solo se permiten numeros")] 
        public string Telefono  {get; set;}
         
        [Required(ErrorMessage="El campo Direccion es Obligatorio")]
        [MaxLength(40,ErrorMessage="El campo {0} no puede tener mas de {1} Caracteres")]
        [MinLength(7,ErrorMessage="El campo {0} no puede tener menos de {1} Caracteres")]
        public string Direccion  {get; set;}

        [Required(ErrorMessage="El campo Ciudad es Obligatorio")]
        [MaxLength(40,ErrorMessage="El campo {0} no puede tener mas de {1} Caracteres")]
        [MinLength(4,ErrorMessage="El campo {0} no puede tener menos de {1} Caracteres")]
        [RegularExpression("[A-Za-z ]*",ErrorMessage="Solo se permiten letras.")]
        public string Ciudad  {get; set;}
        

    }

}