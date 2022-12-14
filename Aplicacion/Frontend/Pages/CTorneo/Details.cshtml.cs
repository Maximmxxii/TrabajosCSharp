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
    public class DetailsModel : PageModel
    {
      private readonly IRTorneo _repoTor; //Repositorios que usaremos
      private readonly IRMunicipio _repoMun; //Repositorios que usaremos

      [BindProperty] //Propiedades Vinculadas
      public Torneo Torneo {get;set;} // este Torneo es el que usamos en .htmlcs en: asp-for="Torneo.FechaFinal"
      public Municipio Municipio {get;set;}

      public DetailsModel (IRMunicipio repoMun, IRTorneo repoTor)
      {
          this._repoTor = repoTor;
          this._repoMun = repoMun;
      }

      public ActionResult OnGet(int Id) // ActionResult retorna una Accion 
      {//OnGet Se encarga de mostrar, se conecta sentido back - front  y el onPost es desde desde el front hacia el back
          Torneo = _repoTor.BuscarTorneo(Id);          
          if (Torneo != null)           
          {
            Municipio = _repoMun.BuscarMunicipio(Torneo.MunicipioId); 
            return Page();
          }
          else
          {
            ViewData["Error"] = "Registro no Encontrado";
            return Page();
          }
                     
      }
    }
}
