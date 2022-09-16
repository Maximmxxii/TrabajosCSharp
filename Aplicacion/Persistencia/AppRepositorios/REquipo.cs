using Dominio;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Persistencia
{
    public class REquipo: IREquipo
    {
        /**
        *? Atributos 
        */
        private readonly AppContext _appContext;

        /**
        *? Metodos 
        */
        public REquipo(AppContext appContext)
        {
            this._appContext = appContext;
        }

        public bool CrearEquipo(Equipo equipo)
        {
            bool Creado = false;
            try
            {
                this._appContext.Equipos.Add(equipo);
                this._appContext.SaveChanges();
                Creado = true;                    
            }
            catch (System.Exception)
            {
                Creado = false;                     
            }      
            return Creado;
        }

        public Equipo BuscarEquipo(int Id)
        {
            Equipo equipo = this._appContext.Equipos.Find(Id);

            return equipo;            
        }

        public bool EliminarEquipo(int Id)
        {
            bool Eliminado = false;
            /**
            *? La variable var toma el tipo de dato que le asignen, var muni = "hola"; se volveria String muni.
            */
            var equi  = this._appContext.Equipos.Find(Id);
            if (equi != null)
            {
                try
                {
                    this._appContext.Equipos.Remove(equi);
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

        public bool ActualizarEquipo(Equipo equipo)
        {
            bool Actualizado = false;
            var equi  = this._appContext.Equipos.Find(equipo.Id);           
            if (equi != null)
            {
                try
                {
                    equi.Nombre = equipo.Nombre;
                    equi.Disciplina = equipo.Disciplina;
                    equi.Ciudad = equipo.Ciudad;
                    equi.Categoria = equipo.Categoria;
                    equi.Tecnico = equipo.Tecnico;
                    equi.PatrocinadorId = equipo.PatrocinadorId;
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

        public IEnumerable<Equipo> ListarEquipos()
        {
            return _appContext.Equipos;
        }

        public List<Equipo> ListarEquipos1()
        {
            return _appContext.Equipos.ToList();
        }

        private bool Existe(Equipo Equi)
        {
            bool Ex = false;
            var torne = _appContext.Equipos.FirstOrDefault(e => e.Nombre == Equi.Nombre);
            if (torne != null)
            {
                Ex = true;
            }
            return Ex;
        }

    }
}