using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;

namespace Frontend.Pages.CMunicipio
{
    public class CreateModel : PageModel
    {

        //atributos
        private readonly IRMunicipio _repoMunicipio;

        [BindProperty]
        public Municipio Municipio {get;set;}

        //Metodos
        //Constructor
        public CreateModel(IRMunicipio repoMunicipio)
        {
            this._repoMunicipio = repoMunicipio;
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

            bool Funciono = _repoMunicipio.CrearMunicipio(Municipio);

            if(Funciono)
            {
                return RedirectToPage("./Index");
            }
            else
            {
                ViewData["Error"] =("Ya existe un municipio con el nombre:" + Municipio.Nombre);    
                return Page();            
            }
        }        
    }
}
