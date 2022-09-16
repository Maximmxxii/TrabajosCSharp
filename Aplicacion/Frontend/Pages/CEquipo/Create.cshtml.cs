using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;

namespace Frontend.Pages.CEquipo
{
    public class CreateModel : PageModel
    {
        private readonly IREquipo _repoEqu;
        private readonly IRPatrocinador _repoPat;

        [BindProperty]
        public Equipo Equipo {get;set;}        
        public IEnumerable<Patrocinador> Patrocinadores {get;set;}

        public CreateModel(IRPatrocinador repoPat, IREquipo repoEqu)
        {
            this._repoPat = repoPat;
            this._repoEqu = repoEqu;
        }

        public ActionResult OnGet()
        {
            Patrocinadores = _repoPat.ListarPatrocinadores();
            return Page();
        }

        public ActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                Patrocinadores = _repoPat.ListarPatrocinadores();
                return Page();
            }
            bool funciono =_repoEqu.CrearEquipo(Equipo);
            if(funciono)
            {
                return RedirectToPage("./Index");
            }
            else
            {
                Patrocinadores = _repoPat.ListarPatrocinadores();
                ViewData["Error"]="El Equipo ya se encuentra registrado";
                return Page();
            }
            
        }
    }
}
