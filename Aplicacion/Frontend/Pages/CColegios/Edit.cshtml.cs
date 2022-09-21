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
    public class EditModel : PageModel
    {
        //atributos
        private readonly IRColegio _repoCol;

        [BindProperty]
        public Colegio Colegio {get;set;}

        //Metodos
        //Constructor
        public EditModel(IRColegio repoCol)
        {
            this._repoCol = repoCol;
        }

        public ActionResult OnGet(int Id)
        {
            Colegio = _repoCol.BuscarColegio(Id);
            return Page();
        }

        public ActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            
            bool Funciono = _repoCol.ActualizarColegio(Colegio);
            
            if(Funciono)
            {
                return RedirectToPage("./Index");
            }
            else
            {
                ViewData["Error"] = "Existe un Colegio con el Nombre:  " + Colegio.RazonSocial;
                return Page();
            }
        }
    }
}
