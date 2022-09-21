using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;

namespace Frontend.Pages.CColegios
{
    public class DeleteModel : PageModel
    {
        //Atributos
        private readonly IRColegio _repoCol;

        [BindProperty]
        public Colegio Colegio {get;set;}
        //Metodos
        public DeleteModel(IRColegio repoCol)
        {
            this._repoCol = repoCol;
        }
        public ActionResult OnGet(int Id)
        {            
            Colegio = _repoCol.BuscarColegio(Id);
            if(Colegio == null)
            {
                ViewData["Error"] = "Colegio No encontrado";
                return Page();
            }
            else
            {
                return Page();
            }
        }

        public ActionResult OnPost()
        {
            bool Funciono = _repoCol.EliminarColegio(Colegio.Id);
            
            if(Funciono)
            {
                return RedirectToPage("./Index");
            }
            else
            {
                ViewData["Error"] = "No es posible eliminar este registro";
                return Page();
            }
        }
        
    }
}
