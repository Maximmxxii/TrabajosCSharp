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
    public class DetailsModel : PageModel
    {
      private readonly IREquipo _repoEqu; //Repositorios que usaremos
      private readonly IRPatrocinador _repoPat; //Repositorios que usaremos

      [BindProperty] //Propiedades Vinculadas
      public Equipo Equipo {get;set;} // este Equipo es el que usamos en .htmlcs en: asp-for="Equipo.FechaFinal"
      public Patrocinador Patrocinador {get;set;}

      public DetailsModel (IREquipo repoEqu, IRPatrocinador repoPat)
      {
          this._repoEqu = repoEqu;
          this._repoPat = repoPat;
      }

      public ActionResult OnGet(int Id) // ActionResult retorna una Accion 
      {//OnGet Se encarga de mostrar, se conecta sentido back - front  y el onPost es desde desde el front hacia el back
          Equipo = _repoEqu.BuscarEquipo(Id);          
          if (Equipo != null)           
          {
            Patrocinador = _repoPat.BuscarPatrocinador(Equipo.PatrocinadorId); 
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
