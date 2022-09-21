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
    public class EditModel : PageModel
    {
        private readonly IREquipo _repoEqu;
        private readonly IRPatrocinador _repoPat;

        [BindProperty]
        public Equipo Equipo {get;set;}        
        public IEnumerable<Patrocinador> Patrocinadores {get;set;}

        public EditModel(IRPatrocinador repoPat, IREquipo repoEqu)
        {
            this._repoPat = repoPat;
            this._repoEqu = repoEqu;
        }

        public ActionResult OnGet(int Id)
        {
            Equipo = _repoEqu.BuscarEquipo(Id);
            if(Equipo != null)
            {
                Patrocinadores = _repoPat.ListarPatrocinadores();
                return Page();
            }else
            {
                Patrocinadores = _repoPat.ListarPatrocinadores();
                ViewData["Error"] = "Equipo No Existe";
                return Page();
            }
        }

        public ActionResult OnPost()
        {
            Patrocinadores = _repoPat.ListarPatrocinadores();
             if(!ModelState.IsValid)
             {
                
                return Page();
             }

             bool Funciono = _repoEqu.ActualizarEquipo(Equipo);
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
