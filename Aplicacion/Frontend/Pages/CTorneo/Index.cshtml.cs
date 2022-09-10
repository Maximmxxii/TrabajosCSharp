using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;

namespace Frontend.Pages.CTorneo
{
    public class IndexModel : PageModel
    {
        private readonly IRTorneo _repoTor;//Usaré Metodos de la Intenfaz Torneo
        private readonly IRMunicipio _repoMun;

        [BindProperty]
        public IEnumerable<Torneo> Torneos {get;set;}
        //public List<TorneoView> TorneosView = new List<TorneosView>();

        public IndexModel(IRTorneo repoTor, IRMunicipio repoMun)
        {
            this._repoTor= repoTor;
            this._repoMun= repoMun;
        }

        public void OnGet()
        {
            List<Municipio> lstMunicipios= _repoMun.ListarMunicipios1();
            Torneos= _repoTor.ListarTorneos();
        }
    }
}