using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;

namespace Frontend.Pages.CPatrocinador
{
    public class CreateModel : PageModel
    {
        //atributos
        private readonly IRPatrocinador _repoPat;
        [BindProperty]
        public Patrocinador Patrocinador {get;set;}

        //Metodos
        //Constructor
        public CreateModel(IRPatrocinador repoPat)
        {
            this._repoPat = repoPat;
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

            bool Funciono = _repoPat.CrearPatrocinador(Patrocinador);

            if(Funciono)
            {
                return RedirectToPage("./Index");
            }
            else
            {
                ViewData["Error"] =("Ya existe un Patrocinador con esa Identificacion:" + Patrocinador.Identificacion);    
                return Page();            
            }
        }        
    }
}
