using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;

namespace Frontend.Pages.CEquipo
{
   public class IndexModel : PageModel
    {
        private readonly IREquipo _repoEqu;//Usaré Metodos de la Intenfaz Torneo
        private readonly IRPatrocinador _repoPat;

        [BindProperty]
        public IEnumerable<Equipo> Equipos {get;set;}
        //public List<TorneoView> TorneosView = new List<TorneosView>();

        public IndexModel(IREquipo repoEqu, IRPatrocinador repoPat)
        {
            this._repoEqu= repoEqu;
            this._repoPat= repoPat;
        }

        public void OnGet()
        {
            List<Patrocinador> lstPatrocinadores = _repoPat.ListarPatrocinadores1();
            Equipos = _repoEqu.ListarEquipos();
        }
    }
}
