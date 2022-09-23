using Dominio;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Persistencia
{
    public class RTorneo:IRTorneo
    {
        /**
        *? Atributos         */
        private readonly AppContext _appContext;

        /**
        *? Metodos         */
        public RTorneo(AppContext appContext)
        {
            this._appContext = appContext;
        }

        public bool CrearTorneo(Torneo torneo)
        {
            bool Creado = false;            
            try
            {
                this._appContext.Torneos.Add(torneo);                
                this._appContext.SaveChanges();
                Creado = true;                    
            }
            catch (Exception)
            {
                Creado = false;                     
            }      
            return Creado;
        }

        public Torneo BuscarTorneo(int Id)
        {            
            return this._appContext.Torneos.Find(Id);
        }

        public bool EliminarTorneo(int Id)
        {
            bool Eliminado = false;
            /**
            *? La variable var toma el tipo de dato que le asignen, var muni = "hola"; se volveria String muni.           */
            var tor  = this._appContext.Torneos.Find(Id);
            if (tor != null)
            {
                try
                {
                    this._appContext.Torneos.Remove(tor);
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

        public bool ActualizarTorneo(Torneo torneo)
        {
            bool Actualizado = false;
            var tor  = this._appContext.Torneos.Find(torneo.Id);
            if (tor != null)
            {
                try
                {
                    tor.Nombre = torneo.Nombre;
                    tor.Categoria = torneo.Categoria;
                    tor.Disciplina = torneo.Disciplina;
                    tor.FechaInicial = torneo.FechaInicial;
                    tor.FechaFinal = torneo.FechaFinal;
                    tor.MunicipioId = torneo.MunicipioId;
                    this._appContext.SaveChanges();
                    Actualizado = true;
                }
                catch(System.Exception)
                {
                    return Actualizado;
                }
            }
            return Actualizado;
        }
        
        public IEnumerable<Torneo> ListarTorneos()
        {
            return _appContext.Torneos;
        }

        public List<Torneo> ListarTorneos1()
        {
            return _appContext.Torneos.ToList();
        }    

    }
}