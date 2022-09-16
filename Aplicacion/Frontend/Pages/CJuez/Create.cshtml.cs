using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;

namespace Frontend.Pages.CJuez
{
    public class CreateModel : PageModel
    {
        //atributos
        private readonly IRJuez _repoJue;

        [BindProperty]
        public Juez Juez {get;set;}

        //Metodos
        //Constructor
        public CreateModel(IRJuez repoJue)
        {
            this._repoJue = repoJue;
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

            bool Funciono = _repoJue.CrearJuez(Juez);

            if(Funciono)
            {
                return RedirectToPage("./Index");
            }
            else
            {
                ViewData["Error"] =("Ya existe un Juez con el Documento:" + Juez.Documento);    
                return Page();            
            }
        }        
    }
}
