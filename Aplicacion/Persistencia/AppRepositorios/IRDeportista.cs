using Dominio;
using System.Collections.Generic;

namespace Persistencia
{
    public interface IRDeportista
    {
       
        public bool CrearDeportista(Deportista deportista);
        public Deportista BuscarDeportista(int Id);
        public bool EliminarDeportista(int Id);
        public bool ActualizarDeportista(Deportista deportista);
        public IEnumerable<Deportista> ListarDeportistas();
        public List<Deportista> ListarDeportistas1();
    }

     /** COMENTARIOS MEJORADOS!!!
        *? Aqui podemos escribir un comentario azul o de pregunta
        *TODO aqui podemos asignar tareas pendientes a cada rol!
        *! ADVERTENCIA PARA REALIZAR DE PRIMERO
        *         === != ->
        */

}