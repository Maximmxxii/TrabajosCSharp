using Dominio;
using System.Collections.Generic;

namespace Persistencia
{
    public interface IRJuez
    {
       
        public bool CrearJuez(Juez juez);
        public Juez BuscarJuez(int Id);
        public bool EliminarJuez(int Id);
        public bool ActualizarJuez(Juez juez);
        public IEnumerable<Juez> ListarJueces();
        public List<Juez> ListarJueces1();
    }

     /** COMENTARIOS MEJORADOS!!!
        *? Aqui podemos escribir un comentario azul o de pregunta
        *TODO aqui podemos asignar tareas pendientes a cada rol!
        *! ADVERTENCIA PARA REALIZAR DE PRIMERO
        *         === != ->
        */

}