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
    public class DeleteModel : PageModel
    {
        //Atributos
        private readonly IRMunicipio _repoMunicipio;

        [BindProperty]
        public Municipio Municipio {get;set;}
        //Metodos
        public DeleteModel(IRMunicipio repoMunicipio)
        {
            this._repoMunicipio = repoMunicipio;
        }
        public ActionResult OnGet(int Id)
        {            
            Municipio = _repoMunicipio.BuscarMunicipio(Id);
            if(Municipio == null)
            {
                ViewData["Error"] = "Municipio No encontrado";
                return Page();
            }
            else
            {
                return Page();
            }
        }

        public ActionResult OnPost()
        {
            bool Funciono = _repoMunicipio.EliminarMunicipio(Municipio.Id);
            
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
