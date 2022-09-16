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
    public class CreateModel : PageModel
    {
        //atributos
        private readonly IRColegio _repoCol;

        [BindProperty]
        public Colegio Colegio {get;set;}

        //Metodos
        //Constructor
        public CreateModel(IRColegio repoCol)
        {
            this._repoCol = repoCol;
        }

        //envia informacion o nuevas vistas al usuario
        public ActionResult  OnGet()
        {
            return Page();
        }

        public ActionResult OnPost()
        {
            //Validamos los datos que se están ingresando.
            if(!ModelState.IsValid)
            {
                return Page();
            }

            bool Funciono = _repoCol.CrearColegio(Colegio);

            if(Funciono)
            {
                return RedirectToPage("./Index");
            }
            else
            {
                ViewData["Error"] =("Ya existe un Colegio con el nombre:" + Colegio.RazonSocial);    
                return Page();            
            }
        }        
    }
}
