using Dominio;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Persistencia
{
    public class RTorneoEquipo:IRTorneoEquipo
    {
        /**
          *? Atributos        */
        private readonly AppContext _appContext;

        /**
          *? Metodos        */
        public RTorneoEquipo(AppContext appContext)
        {
            this._appContext = appContext;
        }

        public bool CrearTorneoEquipo(TorneoEquipo obj)
        {
            bool Creado = false;
            bool ex = Existe(obj);
            try
            {
                this._appContext.TorneoEquipos.Add(obj);
                this._appContext.SaveChanges();
                Creado = true;                    
            }
            catch (Exception)
            {
                Creado = false;                     
            }      
            return Creado;
        }

        public TorneoEquipo BuscarTorneoEquipo(int IdT, int IdE)
        {
            return this._appContext.TorneoEquipos.FirstOrDefault(t => t.TorneoId ==IdT 
                                                                 && t.EquipoId == IdE);                                    
        }

        public bool EliminarTorneoEquipo(int IdT, int IdE)
        { 
            bool Eliminado = false;
            /**
            *? La variable var toma el tipo de dato que le asignen, var muni = "hola"; se volveria String muni.       */
            var torequ  = this._appContext.TorneoEquipos.FirstOrDefault(t => t.TorneoId == IdT 
                                                                        && t.EquipoId == IdE);             
            if (torequ != null)
            {
                try
                {
                    this._appContext.TorneoEquipos.Remove(torequ);
                    this._appContext.SaveChanges();
                    Eliminado = true;
                }
                catch (System.Exception)
                {
                    Eliminado = false;
                }                
            }
            return Eliminado;
        }
        
        public IEnumerable<TorneoEquipo> ListarTorneoEquipos()
        {
            return _appContext.TorneoEquipos;
        }

        
        private bool Existe(TorneoEquipo obj)
        {
            bool Ex = false;
            var torequ = _appContext.TorneoEquipos.FirstOrDefault(t => t.EquipoId == obj.EquipoId
                                                                 && t.TorneoId == obj.TorneoId);
            if (torequ != null)
            {
                Ex = true;
            }
            return Ex;
        }
    }
}