using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;

namespace Frontend.Pages.CEntrenador
{
    public class IndexModel : PageModel
    {
        //Un Objeto como atributo Para hacer uso de los metodos de las Interfaces
        private readonly IREntrenador _repoEntre;
        private readonly IREquipo _repoEqu;

        [BindProperty]
        public IEnumerable<Entrenador> Entrenadores {get;set;}
        public List<EntrenadorView> EntrenadoresView = new List<EntrenadorView>();


        //metodos
        //constructor
        public IndexModel(IREntrenador repoEntre, IREquipo repoEqu)
        {
            this._repoEntre = repoEntre;
            this._repoEqu = repoEqu;
        }

        //se usa para enviar info al html o forms vacios
        public void OnGet()
        {
            List<Equipo> lstEquipos = _repoEqu.ListarEquipos1();
            Entrenadores = _repoEntre.ListarEntrenadores();
            EntrenadorView ev = null;

            foreach (var e in Entrenadores)
            {
                ev = new EntrenadorView();
                foreach (var eq in lstEquipos)
                {
                    if (e.EquipoId == eq.Id)
                    {
                        ev.Equipo = eq.Nombre;                        
                    }                    
                }
                ev.Id = e.Id;
                ev.Documento = e.Documento;
                ev.Nombres = e.Nombres;
                ev.Apellidos = e.Apellidos;
                EntrenadoresView.Add(ev);
                
            }
        }
    }
}
