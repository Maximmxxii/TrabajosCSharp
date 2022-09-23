using Dominio;
using System.Collections.Generic;

namespace Persistencia
{
    public interface IRTorneoEquipo
    {
       
        public bool CrearTorneoEquipo(TorneoEquipo obj);
        public TorneoEquipo BuscarTorneoEquipo(int IdT, int IdE);
        public bool EliminarTorneoEquipo(int IdT, int IdE);      
        public IEnumerable<TorneoEquipo> ListarTorneoEquipos();

    }

     /** COMENTARIOS MEJORADOS!!!
        *? Aqui podemos escribir un comentario azul o de pregunta
        *TODO aqui podemos asignar tareas pendientes a cada rol!
        *! ADVERTENCIA PARA REALIZAR DE PRIMERO
        *         === != ->
        */

}