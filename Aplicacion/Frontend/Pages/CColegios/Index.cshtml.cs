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
     public class IndexModel : PageModel
    {
        //Un Objeto como atributo Para hacer uso de los metodos de las Interfaces
        private readonly IRColegio _repoCol;

        public IEnumerable<Colegio> Colegios {get;set;}

        //metodos
        //constructor
        public IndexModel(IRColegio repoCol)
        {
            this._repoCol = repoCol;
        }

        //se usa para enviar info al html o forms vacios
        public void OnGet()
        {
            Colegios = _repoCol.ListarColegios();
        }
    }
}
