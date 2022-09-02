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
        public ActionResult OnGet (int Id)
        {
            
        }
        public void OnGet()
        {
        }
    }
}
