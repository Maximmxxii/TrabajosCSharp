using Dominio;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Persistencia
{
    public class RDeportista:IRDeportista
    {
        /**
        *? Atributos */
        private readonly AppContext _appContext;

        /**
        *? Metodos         */
        public RDeportista(AppContext appContext)
        {
            this._appContext = appContext;
        }

        public bool CrearDeportista(Deportista deportista)
        {
            bool Creado = false;           
            {
                try
                {
                    this._appContext.Deportistas.Add(deportista);
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

        public Deportista BuscarDeportista(int Id)
        {
             return  this._appContext.Deportistas.Find(Id);                        
        }

        public bool EliminarDeportista(int Id)
        {
            bool Eliminado = false;
            /**
            *? La variable var toma el tipo de dato que le asignen, var depor = "hola"; se volveria String depor.            */
            var depor  = this._appContext.Deportistas.Find(Id);            
            if (depor != null)
            {
                try
                {
                    this._appContext.Deportistas.Remove(depor);
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

        public bool ActualizarDeportista(Deportista deportista)
        {
            bool Actualizado = false;

            var entrena  = this._appContext.Deportistas.Find(deportista.Id);                 
            if (entrena != null)
            {                
                try
                {                    
                    entrena.Documento = deportista.Documento;
                    entrena.Nombres = deportista.Nombres;
                    entrena.Apellidos = deportista.Apellidos;
                    entrena.FechaNacimiento = deportista.FechaNacimiento;
                    entrena.EPS = deportista.EPS;
                    entrena.Rh = deportista.Rh;
                    entrena.Celular = deportista.Celular;
                    entrena.Correo = deportista.Correo;
                    entrena.Direccion = deportista.Direccion;   
                    entrena.Genero = deportista.Genero;  
                    entrena.EquipoId = deportista.EquipoId;                       
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

        public IEnumerable<Deportista> ListarDeportistas()
        {
            return _appContext.Deportistas;
        }

        public List<Deportista> ListarDeportistas1()
        {
            return _appContext.Deportistas.ToList();
        }       
    }
}