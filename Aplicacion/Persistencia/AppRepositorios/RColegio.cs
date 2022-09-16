using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio;

namespace Persistencia
{
    public class RColegio: IRColegio
    {
        /**
        *? Atributos 
        */
        private readonly AppContext _appContext;

        /**
        *? Metodos 
        */
        public RColegio(AppContext appContext)
        {
            this._appContext = appContext;
        }

        public bool CrearColegio(Colegio colegio)
        {
            bool Creado = false;            
            
            try
            {
                this._appContext.Colegios.Add(colegio);
                this._appContext.SaveChanges();
                Creado = true;                    
            }
            catch (System.Exception)
            {
                Creado = false;                     
            }      
            
            return Creado;
        }

        public Colegio BuscarColegio(int Id)
        {
            Colegio colegio = this._appContext.Colegios.Find(Id);

            return colegio;            
        }

        public bool EliminarColegio(int Id)
        {
            bool Eliminado = false;
            /**
            *? La variable var toma el tipo de dato que le asignen, var muni = "hola"; se volveria String muni.
            */
            var Col  = this._appContext.Colegios.Find(Id);
            if (Col != null)
            {
                try
                {
                    this._appContext.Colegios.Remove(Col);
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

        public bool ActualizarColegio(Colegio colegio)
        {
            bool Actualizado = false;
            var Col  = this._appContext.Colegios.Find(colegio.Id);           
            if (Col != null)
            {
                try
                {
                    Col.NIT = colegio.NIT;
                    Col.RazonSocial = colegio.RazonSocial;
                    Col.Telefono = colegio.Telefono;
                    Col.Direccion = colegio.Direccion;
                    Col.Ciudad = colegio.Ciudad;
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

        public IEnumerable<Colegio> ListarColegios()
        {
            return _appContext.Colegios;
        }

        public List<Colegio> ListarColegios1()
        {
            return _appContext.Colegios.ToList();
        }

        /*private bool Existe(Colegio col)
        {
            bool Ex = false;
            var Col = _appContext.Colegios.FirstOrDefault(m => m.Nombre == col.Nombre);
            if (Col != null)
            {
                Ex = true;
            }
            return Ex;
        }*/
    }
}