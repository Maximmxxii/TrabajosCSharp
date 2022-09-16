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
    public class CreateModel : PageModel
    {
        private readonly IRTorneo _repoTor;
        private readonly IRMunicipio _repoMun;

        [BindProperty]
        public Torneo Torneo {get;set;}        
        public IEnumerable<Municipio> Municipios {get;set;}

        public CreateModel(IRMunicipio repoMun, IRTorneo repoTor)
        {
            this._repoMun = repoMun;
            this._repoTor = repoTor;
        }

        public ActionResult OnGet()
        {
            Municipios = _repoMun.ListarMunicipios();
            return Page();
        }

        public ActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                Municipios= _repoMun.ListarMunicipios();
                return Page();
            }
            bool Funciono=_repoTor.CrearTorneo(Torneo);
            if(Funciono)
            {
                return RedirectToPage("./Index");
            }
            else
            {
                Municipios= _repoMun.ListarMunicipios();
                ViewData["Error"]="El torneo ya se encuentra registrado";
                return Page();
            }
            
        }
    }
}