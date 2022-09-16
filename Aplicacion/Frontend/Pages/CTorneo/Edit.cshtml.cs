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
    public class EditModel : PageModel
    {
        private readonly IRTorneo _repoTor;
        private readonly IRMunicipio _repoMun;

        [BindProperty]
        public Torneo Torneo {get;set;}        
        public IEnumerable<Municipio> Municipios {get;set;}

        public EditModel(IRMunicipio repoMun, IRTorneo repoTor)
        {
            this._repoMun = repoMun;
            this._repoTor = repoTor;
        }

        public ActionResult OnGet(int Id)
        {
            Torneo = _repoTor.BuscarTorneo(Id);
            if(Torneo != null)
            {
                Municipios = _repoMun.ListarMunicipios();
                return Page();
            }else
            {
                ViewData["Error"] = "Torneo No Existe";
                return Page();
            }
        }

        public ActionResult OnPost()
        {
             if(!ModelState.IsValid)
             {
                return Page();
             }

             bool Funciono = _repoTor.ActualizarTorneo(Torneo);
             if(Funciono)
             {
                return RedirectToPage("./Index");
             }else
             {
                ViewData ["Error"] = "No es posible Actualizar el Registro";
                return Page();
                
             }
        }
    }
}
