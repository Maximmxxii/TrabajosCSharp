using Dominio;
using System.Collections.Generic;

namespace Persistencia
{
    public interface IRTorneo
    {
       
        public bool CrearTorneo(Torneo torneo);
        public Torneo BuscarTorneo(int Id);
        public bool EliminarTorneo(int Id);
        public bool ActualizarTorneo(Torneo torneo);
        public IEnumerable<Torneo> ListarTorneos();
        public List<Torneo> ListarTorneos1();
    }

     /** COMENTARIOS MEJORADOS!!!
        *? Aqui podemos escribir un comentario azul o de pregunta
        *TODO aqui podemos asignar tareas pendientes a cada rol!
        *! ADVERTENCIA PARA REALIZAR DE PRIMERO
        *         === != ->
        */

}