using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    public class Entrenador
    {
        //[Key]
        public int Id { get; set; }


        [Required(ErrorMessage="El campo Documento es Obligatorio")]
        [MaxLength(12,ErrorMessage="El campo {0} no puede tener mas de {1} Caracteres")]
        [MinLength(7,ErrorMessage="El campo {0} no puede tener menos de {1} Caracteres")]
        public string Documento { get; set; }

        [Required(ErrorMessage="El campo Nombres es Obligatorio")]
        [MaxLength(50,ErrorMessage="El campo {0} no puede tener mas de {1} Caracteres")]
        [MinLength(3,ErrorMessage="El campo {0} no puede tener menos de {1} Caracteres")]
        public string Nombres   { get; set; }

        [Required(ErrorMessage="El campo Apellidos es Obligatorio")]
        [MaxLength(50,ErrorMessage="El campo {0} no puede tener mas de {1} Caracteres")]
        [MinLength(3,ErrorMessage="El campo {0} no puede tener menos de {1} Caracteres")]
        public string Apellidos   { get; set; }

        [Required(ErrorMessage="El campo Genero es Obligatorio")]
        [MaxLength(15,ErrorMessage="El campo {0} no puede tener mas de {1} Caracteres")]
        [MinLength(9,ErrorMessage="El campo {0} no puede tener menos de {1} Caracteres")]
        public string Genero   { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Celular   { get; set; }

        [Required(ErrorMessage="El campo Correo es Obligatorio")]
        [MaxLength(50,ErrorMessage="El campo {0} no puede tener mas de {1} Caracteres")]
        [MinLength(9,ErrorMessage="El campo {0} no puede tener menos de {1} Caracteres")]
        public string Correo   { get; set; }

        [Required(ErrorMessage="El campo Nacionalidad es Obligatorio")]
        [MaxLength(30,ErrorMessage="El campo {0} no puede tener mas de {1} Caracteres")]
        [MinLength(5,ErrorMessage="El campo {0} no puede tener menos de {1} Caracteres")]
        public string Nacionalidad   { get; set; }

        [Required(ErrorMessage="El campo Rh es Obligatorio")]
        [MaxLength(12,ErrorMessage="El campo {0} no puede tener mas de {1} Caracteres")]
        [MinLength(2,ErrorMessage="El campo {0} no puede tener menos de {1} Caracteres")]
        public string Rh   { get; set; }

        [Required(ErrorMessage="El campo Equipo Id es Obligatorio")]
        //LLave Foranea De relacion con Municipio
        public int EquipoId   { get; set; }
    }
}