using Dominio;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Persistencia
{
    public class RMunicipio: IRMunicipio
    {
        /**
        *? Atributos 
        */
        private readonly AppContext _appContext;

        /**
        *? Metodos 
        */
        public RMunicipio(AppContext appContext)
        {
            this._appContext = appContext;
        }

        public bool CrearMunicipio(Municipio municipio)
        {
            bool Creado = false;            
            
            try
            {
                this._appContext.Municipios.Add(municipio);
                this._appContext.SaveChanges();
                Creado = true;                    
            }
            catch (System.Exception)
            {
                Creado = false;                     
            }
        
            
            return Creado;
        }

        public Municipio BuscarMunicipio(int Id)
        {
            Municipio municipio = this._appContext.Municipios.Find(Id);

            return municipio;            
        }

        public bool EliminarMunicipio(int Id)
        {
            bool Eliminado = false;
            /**
            *? La variable var toma el tipo de dato que le asignen, var muni = "hola"; se volveria String muni.
            */
            var muni  = this._appContext.Municipios.Find(Id);
            if (muni != null)
            {
                try
                {
                    this._appContext.Municipios.Remove(muni);
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

        public bool ActualizarMunicipio(Municipio municipio)
        {
            bool Actualizado = false;
            var muni  = this._appContext.Municipios.Find(municipio.Id);           
            if (muni != null)
            {
                try
                {
                    muni.Nombre = municipio.Nombre;
                    muni.Secretaria = municipio.Secretaria;
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

        public IEnumerable<Municipio> ListarMunicipios()
        {
            return _appContext.Municipios;
        }

        public List<Municipio> ListarMunicipios1()
        {
            return _appContext.Municipios.ToList();
        }

        

    }
}