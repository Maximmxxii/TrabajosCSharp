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
    public class EditModel : PageModel
    {
        private readonly IREntrenador _repEntre;
        private readonly IREquipo _repoEqui;

        [BindProperty]
        public Entrenador Entrenador {get;set;}        
        public IEnumerable<Equipo> Equipos {get;set;}

        public EditModel(IREquipo repoEqui, IREntrenador repoEntre)
        {
            this._repoEqui = repoEqui;
            this._repEntre = repoEntre;
        }

        public ActionResult OnGet(int Id)
        {
            Entrenador = _repEntre.BuscarEntrenador(Id);
            if(Entrenador != null)
            {
                Equipos = _repoEqui.ListarEquipos();
                return Page();
            }else
            {
                ViewData["Error"] = "Entrenador No Existe";
                return Page();
            }
        }

        public ActionResult OnPost()
        {
             if(!ModelState.IsValid)
             {
                return Page();
             }

             bool Funciono = _repEntre.ActualizarEntrenador(Entrenador);
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
