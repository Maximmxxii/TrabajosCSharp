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
    public class DeleteModel : PageModel
    {
        private readonly IREntrenador _repoEntre;
        private readonly IREquipo _repoEqui;

        [BindProperty]
        public Entrenador Entrenador {get;set;}
        public Equipo Equipo {get;set;}

        public DeleteModel (IREntrenador repoEntre, IREquipo repoEqui)
        {
            this._repoEntre = repoEntre;
            this._repoEqui = repoEqui;
        }

        public ActionResult OnGet(int Id)
        {
            Entrenador = _repoEntre.BuscarEntrenador(Id);
            if(Entrenador != null)
            {
                Equipo = _repoEqui.BuscarEquipo(Entrenador.EquipoId);
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
            bool Funciono = _repoEntre.EliminarEntrenador(Entrenador.Id);
            
            if(Funciono)
            {
                return RedirectToPage("./Index");
            }
            else
            {
                Equipo = _repoEqui.BuscarEquipo(Entrenador.EquipoId);
                ViewData["Error"] = "No es posible eliminar este registro";
                return Page();
            }
        }
    }
}
