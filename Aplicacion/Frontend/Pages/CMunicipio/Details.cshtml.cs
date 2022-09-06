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
    public class DetailsModel : PageModel
    {
        //atributos
        private readonly IRMunicipio _repoMunicipio;

        [BindProperty]
        public Municipio Municipio {get;set;}

        //Metodos
        //Constructor
        public DetailsModel(IRMunicipio repoMunicipio)
        {
            this._repoMunicipio = repoMunicipio;
        }

        public ActionResult OnGet(int Id)
        {
            Municipio = _repoMunicipio.BuscarMunicipio(Id);
            return Page();
        }
    }
}
