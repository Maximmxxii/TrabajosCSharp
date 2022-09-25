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
    public class DetailsModel : PageModel
    {
      private readonly IREntrenador _repoEntre; //Repositorios que usaremos
      private readonly IREquipo _repoEqu; //Repositorios que usaremos

      [BindProperty] //Propiedades Vinculadas
      public Entrenador Entrenador {get;set;} // este Entrenador es el que usamos en .htmlcs en: asp-for="Entrenador.FechaFinal"
      public Equipo Equipo {get;set;}

      public DetailsModel (IREquipo repoEqu, IREntrenador repoEntre)
      {
          this._repoEntre = repoEntre;
          this._repoEqu = repoEqu;
      }

      public ActionResult OnGet(int Id) // ActionResult retorna una Accion 
      {//OnGet Se encarga de mostrar, se conecta sentido back - front  y el onPost es desde desde el front hacia el back
          Entrenador = _repoEntre.BuscarEntrenador(Id);          
          if (Entrenador != null)           
          {
            Equipo = _repoEqu.BuscarEquipo(Entrenador.EquipoId); 
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