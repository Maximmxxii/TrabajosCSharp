using Dominio;
using System.Collections.Generic;

namespace Persistencia
{
    public interface IRColegio
    {
       
        public bool CrearColegio(Colegio colegio);
        public Colegio BuscarColegio(int Id);
        public bool EliminarColegio(int Id);
        public bool ActualizarColegio(Colegio colegio);
        public IEnumerable<Colegio> ListarColegios();
        public List<Colegio> ListarColegios1();
    }

     /** COMENTARIOS MEJORADOS!!!
        *? Aqui podemos escribir un comentario azul o de pregunta
        *TODO aqui podemos asignar tareas pendientes a cada rol!
        *! ADVERTENCIA PARA REALIZAR DE PRIMERO
        *         === != ->
        */

}