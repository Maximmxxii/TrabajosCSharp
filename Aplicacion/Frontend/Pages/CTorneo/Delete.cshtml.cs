using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;

namespace Frontend.Pages.CTorneo
{
    public class DeleteModel : PageModel
    {
        private readonly IRTorneo _repoTor;
        private readonly IRMunicipio _repoMun;

        [BindProperty]
        public Torneo Torneo {get;set;}
        public Municipio Municipio {get;set;}

        public DeleteModel (IRTorneo repoTor, IRMunicipio repoMun)
        {
            this._repoTor = repoTor;
            this._repoMun = repoMun;
        }

        public ActionResult OnGet(int Id)
        {
            Torneo = _repoTor.BuscarTorneo(Id);
            if(Torneo != null)
            {
                Municipio = _repoMun.BuscarMunicipio(Torneo.MunicipioId);
                return Page();
            }
            else
            {
                ViewData["Error"] = "Registro no Encontrado";
                return Page();
            }            
        }

        public ActionResult OnPost()
        {
            bool Funciono = _repoTor.EliminarTorneo(Torneo.Id);
            
            if(Funciono)
            {
                return RedirectToPage("./Index");
            }
            else
            {
                Municipio = _repoMun.BuscarMunicipio(Torneo.MunicipioId);
                ViewData["Error"] = "No es posible eliminar este registro";
                return Page();
            }
        }
    }
}
