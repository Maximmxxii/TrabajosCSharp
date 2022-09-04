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
        /*Id
        Nombre
        Disciplina
        Ciudad
        Categoria
        Tecnico
        PatrocinadorId
        */
        /**
        *! Propiedad Navigacional
        */
        public List<Deportista> Deportistas {get; set;}

        /**
        *! Propiedad Navigacional
        */
        public List<TorneoEquipo> TorneosxEquipos {get; set;}
    }
}