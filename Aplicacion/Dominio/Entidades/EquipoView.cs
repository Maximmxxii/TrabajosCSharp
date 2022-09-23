using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    public class EquipoView
    {        
        public int Id { get; set; }        
        public string Nombre { get; set; }        
        public string Disciplina { get; set; }        
        public string Ciudad { get; set; }
        public string Categoria { get; set; }       
        //Llave Foranea para la relacion Con Patrocinador        
        public string Patrocinador { get; set; }
        
    }
}