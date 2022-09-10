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
    public class IndexModel : PageModel
    {
        //Un Objeto como atributo Para hacer uso de los metodos de las Interfaces
        private readonly IREntrenador _repoEntre;

        public IEnumerable<Entrenador> Entrenadores {get;set;}

        //metodos
        //constructor
        public IndexModel(IREntrenador repoEntre)
        {
            this._repoEntre = repoEntre;
        }

        //se usa para enviar info al html o forms vacios
        public void OnGet()
        {
            Entrenadores = _repoEntre.ListarEntrenadores();
        }
    }
}
