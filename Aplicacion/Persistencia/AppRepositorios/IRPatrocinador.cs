using System.Collections.Generic;
using Dominio;

namespace Persistencia
{
    public interface IRPatrocinador
    {

        public bool CrearPatrocinador(Patrocinador patrocinador);
        public Patrocinador BuscarPatrocinador(int Id);
        public bool EliminarPatrocinador(int Id);
        public bool ActualizarPatrocinador(Patrocinador patrocinador);
        public IEnumerable<Patrocinador> ListarPatrocinadores();
        public List<Patrocinador> ListarPatrocinadores1();
    }
}
        
    