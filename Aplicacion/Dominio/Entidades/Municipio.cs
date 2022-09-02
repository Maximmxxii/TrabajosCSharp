using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; 
/** 
*! Para poder usar el DataAnnotations, debemos tirar en la consola: dotnet add package System.ComponentModel.Annotations --version 5.0.0
*/

namespace Dominio
{
    public class Municipio
    {
        //[key]
        public  int Id  {get; set;}

        //Anotaciones, deben llevar using System.ComponentModel.DataAnnotations;
        [Required(ErrorMessage="El campo Nombre es Obligatorio")]
        [MaxLength(30,ErrorMessage="El campo {0} no puede tener mas de {1} Caracteres")]
        [MinLength(5,ErrorMessage="El campo {0} no puede tener menos de {1} Caracteres")]
        public string Nombre {get; set;}

        //[Required(ErrorMessage="El campo Nombre es Obligatorio")]
        [MaxLength(50,ErrorMessage="El campo {0} no puede tener mas de {1} Caracteres")]
        [MinLength(2,ErrorMessage="El campo {0} no puede tener menos de {1} Caracteres")]
        public string Secretaria {get; set;}
        /**
        *! Propiedad Navigacional
        */
        public List<Torneo> Torneos {get; set;}
    } 
    

}