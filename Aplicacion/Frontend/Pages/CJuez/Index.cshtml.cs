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
    public class IndexModel : PageModel
    {
        //Un Objeto como atributo Para hacer uso de los metodos de las Interfaces
        private readonly IRJuez _repoJue;

        public IEnumerable<Juez> Jueces {get;set;}

        //metodos
        //constructor
        public IndexModel(IRJuez repoJue)
        {
            this._repoJue = repoJue;
        }

        //se usa para enviar info al html o forms vacios
        public void OnGet()
        {
            Jueces = _repoJue.ListarJueces();
        }
    }
}
