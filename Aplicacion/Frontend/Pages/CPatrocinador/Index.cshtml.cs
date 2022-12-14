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
    public class IndexModel : PageModel
    {
        //Un Objeto como atributo Para hacer uso de los metodos de las Interfaces
        private readonly IRPatrocinador _repoPat;

        public IEnumerable<Patrocinador> Patrocinadores {get;set;}

        //metodos
        //constructor
        public IndexModel(IRPatrocinador repoPat)
        {
            this._repoPat = repoPat;
        }

        //se usa para enviar info al html o forms vacios
        public void OnGet()
        {
            Patrocinadores = _repoPat.ListarPatrocinadores();
        }
    }
}
