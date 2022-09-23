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
    public class DeleteModel : PageModel
    {
        private readonly IREquipo _repoEqu; //Repositorios que usaremos
      private readonly IRPatrocinador _repoPat; //Repositorios que usaremos

        [BindProperty]
        public Equipo Equipo {get;set;} // este Equipo es el que usamos en .htmlcs en: asp-for="Equipo.FechaFinal"
        public Patrocinador Patrocinador {get;set;}

        public DeleteModel (IREquipo repoEqu, IRPatrocinador repoPat)
        {
            this._repoEqu = repoEqu;
            this._repoPat = repoPat;
        }

        public ActionResult OnGet(int Id)
        {
            Equipo = _repoEqu.BuscarEquipo(Id);
            if(Equipo != null)
            {
                Patrocinador = _repoPat.BuscarPatrocinador(Equipo.PatrocinadorId);
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
            bool Funciono = _repoEqu.EliminarEquipo(Equipo.Id);
            
            if(Funciono)
            {
                return RedirectToPage("./Index");
            }
            else
            {
                Patrocinador = _repoPat.BuscarPatrocinador(Equipo.PatrocinadorId);
                ViewData["Error"] = "No es posible eliminar este registro";
                return Page();
            }
        }
    }
}
