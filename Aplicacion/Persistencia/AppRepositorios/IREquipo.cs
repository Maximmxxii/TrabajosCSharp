using Dominio;
using System.Collections.Generic;

namespace Persistencia
{
    public interface IREquipo
    {
       
        public bool CrearEquipo(Equipo equipo);
        public Equipo BuscarEquipo(int Id);
        public bool EliminarEquipo(int Id);
        public bool ActualizarEquipo(Equipo equipo);
        public IEnumerable<Equipo> ListarEquipos();
        public List<Equipo> ListarEquipos1();
    }

     /** COMENTARIOS MEJORADOS!!!
        *? Aqui podemos escribir un comentario azul o de pregunta
        *TODO aqui podemos asignar tareas pendientes a cada rol!
        *! ADVERTENCIA PARA REALIZAR DE PRIMERO
        *         === != ->
        */

}