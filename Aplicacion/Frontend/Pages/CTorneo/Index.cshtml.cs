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
        public List<TorneoView> TorneosView = new List<TorneoView>();

        public IndexModel(IRTorneo repoTor, IRMunicipio repoMun)
        {
            this._repoTor= repoTor;
            this._repoMun= repoMun;
        }

        public void OnGet()
        { //Traemos todos los municipios y los guardamos en lstMunicipios
            List<Municipio> lstMunicipios= _repoMun.ListarMunicipios1();
            Torneos = _repoTor.ListarTorneos();
            TorneoView tv = null;
            foreach (var t in Torneos)
            {
                tv = new TorneoView();
                foreach (var m in lstMunicipios)
                {
                    if(t.MunicipioId == m.Id)
                    {
                        tv.Municipio = m.Nombre;
                    }
                }
                tv.Id = t.Id;
                tv.Nombre = t.Nombre;
                tv.Categoria = t.Categoria;
                tv.Disciplina = t.Disciplina;
                tv.FechaInicial = t.FechaInicial;
                tv.FechaFinal = t.FechaFinal;
                TorneosView.Add(tv);

            }
        }
    }
}