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
    public class CreateModel : PageModel
    {
        //atributos
        private readonly IRDeportista _repoDepor;
        private readonly IREquipo _repoEqu;

        [BindProperty]
        public IEnumerable<Deportista> Deportistas {get;set;}
        public Deportista Deportista {get;set;}
        public List<DeportistaView> DeportistaView = new List<DeportistaView>();
        public IEnumerable<Equipo> Equipos {get;set;}

        //Metodos
        //Constructor
        public CreateModel(IRDeportista repoDepor, IREquipo repoEqu)
        {
            this._repoDepor = repoDepor;
            this._repoEqu = repoEqu;

        }

        //envia informacion o nuevas vistas al usuario
        public ActionResult  OnGet()
        {
            Equipos = _repoEqu.ListarEquipos();
            return Page();
        }

        public ActionResult OnPost()
        {
            //Validamos los datos que se están ingresando.
            if(!ModelState.IsValid)
            {
                Equipos = _repoEqu.ListarEquipos();
                return Page();
            }

            bool Funciono = _repoDepor.CrearDeportista(Deportista);

            if(Funciono)
            {
                return RedirectToPage("./Index");
            }
            else
            {
                Equipos = _repoEqu.ListarEquipos();
                ViewData["Error"] =("los campos Documento y Equipo no se pueden repetir");    
                return Page();            
            }
        }        
    }
}
