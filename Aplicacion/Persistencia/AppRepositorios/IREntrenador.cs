using Dominio;
using System.Collections.Generic;

namespace Persistencia
{
    public interface IREntrenador
    {
       
        public bool CrearEntrenador(Entrenador entrenador);
        public Entrenador BuscarEntrenador(int Id);
        public bool EliminarEntrenador(int Id);
        public bool ActualizarEntrenador(Entrenador entrenador);
        public IEnumerable<Entrenador> ListarEntrenadores();
        public List<Entrenador> ListarEntrenadores1();
    }

     /** COMENTARIOS MEJORADOS!!!
        *? Aqui podemos escribir un comentario azul o de pregunta
        *TODO aqui podemos asignar tareas pendientes a cada rol!
        *! ADVERTENCIA PARA REALIZAR DE PRIMERO
        *         === != ->
        */

}