using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;

namespace Frontend.Pages.CInscribirEquipo
{
    public class CreateModel : PageModel
    {
        private readonly IRTorneoEquipo _repoTorEqu;
        private readonly IRTorneo _repoTor;
        private readonly IREquipo _repoEqu;

        [BindProperty]
        public TorneoEquipo TorneoEquipo {get;set;}        
        public IEnumerable<Torneo> Torneos {get;set;}
        public IEnumerable<Equipo> Equipos {get;set;}

         public CreateModel(IRTorneoEquipo repoTorEqu, IREquipo repoEqu, IRTorneo repoTor)
        {
            this._repoTorEqu = repoTorEqu;
            this._repoEqu = repoEqu;
            this._repoTor = repoTor;
        }

        public ActionResult OnGet()
        {
            Torneos = _repoTor.ListarTorneos();
            Equipos = _repoEqu.ListarEquipos();
            if(Torneos.Count()>0 && Equipos.Count()>0)
            {
                return Page();
            }
            else 
            {
                ViewData["Error"] ="No hay Equipos O Torneos Suficientes para realizar esta Operación";
                return Page();
            }
        }

        public ActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                Torneos = _repoTor.ListarTorneos();
                Equipos = _repoEqu.ListarEquipos();
                return Page();
            }

            bool Funciono = _repoTorEqu.CrearTorneoEquipo(TorneoEquipo);
            if(Funciono)
            {
                return RedirectToPage("./Index");
            }
            else 
            {
                Torneos = _repoTor.ListarTorneos();
                Equipos = _repoEqu.ListarEquipos();
                ViewData["Error"] = "El equipo ya se encuentra registrado en el torneo";
                return Page();
            }
        }
    }
}
