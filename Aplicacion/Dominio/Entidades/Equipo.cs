using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    public class Equipo
    {        
        public int Id { get; set; }

        [Required(ErrorMessage="El campo Nombre es Obligatorio")]
        [MaxLength(30,ErrorMessage="El campo {0} no puede tener mas de {1} Caracteres")]
        [MinLength(4,ErrorMessage="El campo {0} no puede tener menos de {1} Caracteres")]
        [RegularExpression("[A-Za-z0-9]*",ErrorMessage="Solo se permiten letras y numeros")]
        public string Nombre { get; set; }

        [Required(ErrorMessage="El campo Disciplina es Obligatorio")]
        [MaxLength(15,ErrorMessage="El campo {0} no puede tener mas de {1} Caracteres")]
        [MinLength(3,ErrorMessage="El campo {0} no puede tener menos de {1} Caracteres")]
        [RegularExpression("[A-Za-z0-9]*",ErrorMessage="Solo se permiten letras y numeros")]        
        public string Disciplina { get; set; }

        [Required(ErrorMessage="El campo Ciudad es Obligatorio")]
        [MaxLength(30,ErrorMessage="El campo {0} no puede tener mas de {1} Caracteres")]
        [MinLength(3,ErrorMessage="El campo {0} no puede tener menos de {1} Caracteres")]
        [RegularExpression("[A-Za-z ]*",ErrorMessage="Solo se permiten letras.")] 
        public string Ciudad { get; set; }

        [Required(ErrorMessage="El campo Disciplina es Obligatorio")]
        [MaxLength(15,ErrorMessage="El campo {0} no puede tener mas de {1} Caracteres")]
        [MinLength(3,ErrorMessage="El campo {0} no puede tener menos de {1} Caracteres")]
        [RegularExpression("[A-Za-z0-9]*",ErrorMessage="Solo se permiten letras y numeros")] 
        public string Categoria { get; set; }

        //Propiedad Navigacional para la relacion Con Entrenador
        public Entrenador Tecnico { get; set;}
 
        //Llave Foranea para la relacion Con Patrocinador
        [Required(ErrorMessage="El campo PatrocinadorId es Obligatorio")]
        public int PatrocinadorId { get; set; }
        
        /**
        *! Propiedad Navigacional
        */
        public List<Deportista> Deportistas {get; set;}

        /**
        *! Propiedad Navigacional Para TorneoEquipo
        */
        public List<TorneoEquipo> TorneoEquipos {get; set;}
    }
}