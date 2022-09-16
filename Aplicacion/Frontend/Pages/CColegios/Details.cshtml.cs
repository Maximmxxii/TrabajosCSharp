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
    public class DetailsModel : PageModel
    {
        //atributos
        private readonly IRColegio _repoCol;

        [BindProperty]
        public Colegio Colegio {get;set;}

        //Metodos
        //Constructor
        public DetailsModel(IRColegio repoCol)
        {
            this._repoCol = repoCol;
        }

        public ActionResult OnGet(int Id)
        {
            Colegio = _repoCol.BuscarColegio(Id);
            return Page();
        }
    }
}
