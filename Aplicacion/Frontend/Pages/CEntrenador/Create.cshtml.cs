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
    public class CreateModel : PageModel
    {
        //atributos
        private readonly IREntrenador _repoEnt;

        [BindProperty]
        public Entrenador Entrenador {get;set;}

        //Metodos
        //Constructor
        public CreateModel(IREntrenador repoEnt)
        {
            this._repoEnt = repoEnt;
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

            bool Funciono = _repoEnt.CrearEntrenador(Entrenador);

            if(!Funciono)
            {
                return RedirectToPage("./Index");
            }
            else
            {
                ViewData["Error"] =("Ya existe un Entrenador con esa Identificacion: " + Entrenador.Documento);    
                return Page();            
            }
        }        
    }
}
