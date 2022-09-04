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
    public class EditModel : PageModel
    {
        //atributos
        private readonly IRMunicipio _repoMunicipio;

        [BindProperty]
        public Municipio Municipio {get;set;}

        //Metodos
        //Constructor
        public EditModel(IRMunicipio repoMunicipio)
        {
            this._repoMunicipio = repoMunicipio;
        }

        public ActionResult OnGet(int Id)
        {
            Municipio = _repoMunicipio.BuscarMunicipio(Id);
            return Page();
        }

        public ActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            
            bool Funciono = _repoMunicipio.ActualizarMunicipio(Municipio);
            
            if(!Funciono)
            {
                return RedirectToPage("./Index");
            }
            else
            {
                ViewData["Error"] = "Existe un Municipio con el Nombre." + Municipio.Nombre;
                return Page();
            }
        }
    }
}
