using Dominio;
using System.Collections.Generic;

namespace Persistencia
{
    public interface IRMunicipio
    {
       
        public bool CrearMunicipio(Municipio municipio);
        public Municipio BuscarMunicipio(int Id);
        public bool EliminarMunicipio(int Id);
        public bool ActualizarMunicipio(Municipio municipio);
        public IEnumerable<Municipio> ListarMunicipios();
        public List<Municipio> ListarMunicipios1();
    }

     /** COMENTARIOS MEJORADOS!!!
        *? Aqui podemos escribir un comentario azul o de pregunta
        *TODO aqui podemos asignar tareas pendientes a cada rol!
        *! ADVERTENCIA PARA REALIZAR DE PRIMERO
        *         === != ->
        */

}