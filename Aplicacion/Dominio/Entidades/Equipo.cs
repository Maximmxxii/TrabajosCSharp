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

        public string Nombre { get; set; }
        public string Disciplina { get; set; }
        public string Ciudad { get; set; }
        public string Categoria { get; set; }
        public Entrenador Tecnico { get; set;}
        public int PatrocinadorId { get; set; }
        
        /**
        *! Propiedad Navigacional
        */
        public List<Deportista> Deportistas {get; set;}

        /**
        *! Propiedad Navigacional
        */
        //public List<TorneoEquipo> TorneosXEquipos {get; set;}
    }
}