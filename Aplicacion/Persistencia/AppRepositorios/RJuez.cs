using Dominio;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Persistencia
{
    public class RJuez: IRJuez
    {
         /**
        *? Atributos         */
        private readonly AppContext _appContext;

        /**
        *? Metodos         */
        public RJuez(AppContext appContext)
        {
            this._appContext = appContext;
        }

        public bool CrearJuez(Juez juez)
        {
            bool Creado = false;            
            
            try
            {
                this._appContext.Jueces.Add(juez);
                this._appContext.SaveChanges();
                Creado = true;                    
            }
            catch (System.Exception)
            {
                Creado = false;                     
            }
        
            
            return Creado;
        }

        public Juez BuscarJuez(int Id)
        {
            Juez juez = this._appContext.Jueces.Find(Id);
            return juez;            
        }

        public bool EliminarJuez(int Id)
        {
            bool Eliminado = false;
            /**
            *? La variable var toma el tipo de dato que le asignen, var muni = "hola"; se volveria String muni.            */
            var jue  = this._appContext.Jueces.Find(Id);
            if (jue != null)
            {
                try
                {
                    this._appContext.Jueces.Remove(jue);
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

        public bool ActualizarJuez(Juez juez)
        {
            bool Actualizado = false;
            var jue  = this._appContext.Jueces.Find(juez.Id);           
            if (jue != null)
            {
                try
                {
                    jue.Documento = juez.Documento;
                    jue.Nombres = juez.Nombres;
                    jue.Apellidos = juez.Apellidos;
                    jue.Genero = juez.Genero;
                    jue.ARL = juez.ARL;
                    jue.Celular = juez.Celular;
                    jue.Correo = juez.Correo;
                    jue.TorneoId = juez.TorneoId;
                    jue.ColegioId = juez.ColegioId;
                    this._appContext.SaveChanges();
                    Actualizado = true;
                }
                catch (System.Exception)
                {
                    return Actualizado;
                }    
                
            }    
            
            return Actualizado;        
        }

        public IEnumerable<Juez> ListarJueces()
        {
            return _appContext.Jueces;
        }

        public List<Juez> ListarJueces1()
        {
            return _appContext.Jueces.ToList();
        }
        
    }
}