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
        public string RazonSocial {get; set;}
        
        [DataType(DataType.PhoneNumber)]
        public string Telefono  {get; set;}
         
        public string Direccion  {get; set;}
        public string Ciudad  {get; set;}
        

    }

}