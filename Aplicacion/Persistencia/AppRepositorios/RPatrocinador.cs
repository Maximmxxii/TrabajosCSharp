using Dominio;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Persistencia
{
    public class RPatrocinador: IRPatrocinador
    {
        /**
        *? Atributos 
        */
        private readonly AppContext _appContext;

        /**
        *? Metodos 
        */
        public RPatrocinador(AppContext appContext)
        {
            this._appContext = appContext;
        }

        public bool CrearPatrocinador(Patrocinador patrocinador)
        {
            bool Creado = false;            
            bool Ex = Existe(patrocinador);
            if(!Ex)
            {
                 try
                {
                    this._appContext.Patrocinadores.Add(patrocinador);
                    this._appContext.SaveChanges();
                    Creado = true;                    
                }
                catch (System.Exception)
                {
                    Creado = false;                     
                }
            }
            
            return Creado;
        }

        public Patrocinador BuscarPatrocinador(int Id)
        {
            Patrocinador patrocinador  = this._appContext.Patrocinadores.Find(Id);

            return patrocinador;            
        }

        public bool EliminarPatrocinador(int Id)
        {
            bool Eliminado = false;
            /**
            *? La variable var toma el tipo de dato que le asignen, var muni = "hola"; se volveria String muni.
            */
            var pat  = this._appContext.Patrocinadores.Find(Id);
            if (pat != null)
            {
                try
                {
                    this._appContext.Patrocinadores.Remove(pat);
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

        public bool ActualizarPatrocinador(Patrocinador patrocinador)
        {
            bool Actualizado = false;
            var pat  = this._appContext.Patrocinadores.Find(patrocinador.Id);           
            if (pat != null)
            {
                bool Ex = Existe(patrocinador);
                //if(!Ex)
                //{
                    try
                    {
                        pat.Identificacion = patrocinador.Identificacion;
                        pat.Nombre = patrocinador.Nombre;
                        pat.Marca = patrocinador.Marca;
                        pat.TipoPersona = patrocinador.TipoPersona;
                        pat.Direccion = patrocinador.Direccion;
                        pat.Telefono = patrocinador.Telefono;
                        this._appContext.SaveChanges();
                        Actualizado = true;
                    }
                    catch (System.Exception)
                    {
                        return Actualizado;
                    }    
                //}
            }    
            
            return Actualizado;        
        }

        public IEnumerable<Patrocinador> ListarPatrocinadores()
        {
            return _appContext.Patrocinadores;
        }

        public List<Patrocinador> ListarPatrocinadores1()
        {
            return _appContext.Patrocinadores.ToList();
        }

        private bool Existe(Patrocinador patro)
        {
            bool Ex = false;
            var pat = _appContext.Patrocinadores.FirstOrDefault(p => p.Identificacion == patro.Identificacion);
            if (pat != null)
            {
                Ex = true;
            }
            return Ex;
        }

    }
}