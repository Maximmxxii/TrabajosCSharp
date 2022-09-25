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
    public class DeleteModel : PageModel
    {
        private readonly IRTorneoEquipo _repoTorEqu;
        private readonly IRTorneo _repoTor;
        private readonly IREquipo _repoEqu;

        [BindProperty]
        public TorneoEquipo TorneoEquipo {get;set;}
        public Torneo Torneo {get;set;}
        public Equipo Equipo {get;set;}

        public DeleteModel(IRTorneoEquipo repoTorEqu, IREquipo repoEqu, IRTorneo repoTor)
        {
            this._repoTorEqu = repoTorEqu;
            this._repoTor = repoTor;
            this._repoEqu = repoEqu;
        }

        public ActionResult OnGet(int IdT, int IdE)
        {
            TorneoEquipo = _repoTorEqu.BuscarTorneoEquipo(IdT,IdE);
            Torneo = _repoTor.BuscarTorneo(IdT);
            Equipo = _repoEqu.BuscarEquipo(IdE);

            if(TorneoEquipo != null)
            {
                return Page();
            }
            else
            {
                ViewData["Error"] ="Registro no Encontrado";
                return Page();
            }
        }
        public ActionResult OnPost()
        {
            bool Funciono = _repoTorEqu.EliminarTorneoEquipo(TorneoEquipo.TorneoId, TorneoEquipo.EquipoId);
            if(Funciono)
            {
                return RedirectToPage("./Index");
            }
            else
            {
                ViewData["Error"] = "El Equipo no se puede retirar del Torneo";
                return Page();
            }
        }
    }
}
