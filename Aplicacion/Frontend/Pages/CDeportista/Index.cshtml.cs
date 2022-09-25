using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;

namespace Frontend.Pages.CDeportista
{
    public class IndexModel : PageModel
    {
        //Un Objeto como atributo Para hacer uso de los metodos de las Interfaces
        private readonly IRDeportista _repoDepor;
        private readonly IREquipo _repoEqu;

        [BindProperty]
        public IEnumerable<Deportista> Deportistas {get;set;}
        public List<DeportistaView> DeportistaView = new List<DeportistaView>();

        //metodos
        //constructor
        public IndexModel(IRDeportista repoDepor, IREquipo repoEqu)
        {
            this._repoDepor = repoDepor;
            this._repoEqu = repoEqu;
        }

        //se usa para enviar info al html o forms vacios
        public void OnGet()
        {
            List<Equipo> lstEquipos = _repoEqu.ListarEquipos1();
            Deportistas = _repoDepor.ListarDeportistas();
            DeportistaView dv = null;

            foreach (var d in Deportistas)
            {
                dv = new DeportistaView();
                foreach (var eq in lstEquipos)
                {
                    if (d.EquipoId == eq.Id)
                    {
                        dv.Equipo = eq.Nombre;                        
                    }                    
                }
                dv.Id = d.Id;
                dv.Documento = d.Documento;
                dv.Nombres = d.Nombres;
                dv.Apellidos = d.Apellidos;                
                DeportistaView.Add(dv);
                
            }
        }
    }
}
