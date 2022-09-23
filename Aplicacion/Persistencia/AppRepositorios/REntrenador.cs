using Dominio;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Persistencia
{
    public class REntrenador: IREntrenador
    {
        /**
        *? Atributos 
        */
        private readonly AppContext _appContext;

        /**
        *? Metodos 
        */
        public REntrenador(AppContext appContext)
        {
            this._appContext = appContext;
        }

        public bool CrearEntrenador(Entrenador entrenador)
        {
            bool Creado = false;           
            {
                try
                {
                    this._appContext.Entrenadores.Add(entrenador);
                    this._appContext.SaveChanges();
                    Creado = true;                    
                }
                catch (Exception)
                {
                    Creado = false;                     
                }
            }
            
            return Creado;
        }

        public Entrenador BuscarEntrenador(int Id)
        {
             return  this._appContext.Entrenadores.Find(Id);                        
        }

        public bool EliminarEntrenador(int Id)
        {
            bool Eliminado = false;
            /**
            *? La variable var toma el tipo de dato que le asignen, var muni = "hola"; se volveria String muni.            */
            var entre  = this._appContext.Entrenadores.Find(Id);            
            if (entre != null)
            {
                try
                {
                    this._appContext.Entrenadores.Remove(entre);
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

        public bool ActualizarEntrenador(Entrenador entrenador)
        {
            bool Actualizado = false;
            var entre  = this._appContext.Entrenadores.Find(entrenador.Id);           
            if (entre != null)
            {                
                try
                {                    
                    entre.Documento = entrenador.Documento;
                    entre.Nombres = entrenador.Nombres;
                    entre.Apellidos = entrenador.Apellidos;
                    entre.Genero = entrenador.Genero;
                    entre.Celular = entrenador.Celular;
                    entre.Correo = entrenador.Correo;
                    entre.Nacionalidad = entrenador.Nacionalidad;
                    entre.Rh = entrenador.Rh;
                    entre.EquipoId = entrenador.EquipoId;                        
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

        public IEnumerable<Entrenador> ListarEntrenadores()
        {
            return _appContext.Entrenadores;
        }

        public List<Entrenador> ListarEntrenadores1()
        {
            return _appContext.Entrenadores.ToList();
        }       
    }
}