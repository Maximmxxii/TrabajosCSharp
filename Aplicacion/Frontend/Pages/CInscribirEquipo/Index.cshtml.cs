using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;


namespace Frontend.Pages.CInscribirEquipo
{
    public class IndexModel : PageModel
    {
        private readonly IRTorneoEquipo _repoTorEqu;
        private readonly IRTorneo _repoTor;
        private readonly IREquipo _repoEqu;

        [BindProperty]
        public IEnumerable<TorneoEquipo> TorneoEquipos {get;set;}

        public List<TorneoEquipoView> TorneoEquiposV = new List<TorneoEquipoView>();

        public IndexModel(IRTorneoEquipo repoTorEqu, IREquipo repoEqu, IRTorneo repoTor)
        {
            this._repoTorEqu = repoTorEqu;
            this._repoTor = repoTor;
            this._repoEqu = repoEqu;
        }
        public void OnGet()
        {
            TorneoEquipos = _repoTorEqu.ListarTorneoEquipos();
            List<Torneo> Torneos = _repoTor.ListarTorneos1();
            List<Equipo> Equipos = _repoEqu.ListarEquipos1();
            TorneoEquipoView tev = null;

            foreach (var te in TorneoEquipos)
            {
                tev = new TorneoEquipoView();
                foreach (var t in Torneos)
                {
                    if(te.TorneoId == t.Id)
                    {
                        tev.Torneo = t.Nombre;
                        tev.TorneoId = t.Id;
                    }
                }

                foreach (var e in Equipos)
                {
                    if(te.EquipoId == e.Id)
                    {
                        tev.Equipo = e.Nombre;
                        tev.EquipoId = e.Id;

                    }                   
                }
                TorneoEquiposV.Add(tev);
            }
        }
    }
}
