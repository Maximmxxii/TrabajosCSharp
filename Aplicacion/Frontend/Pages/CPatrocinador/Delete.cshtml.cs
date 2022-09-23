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
    public class DeleteModel : PageModel
    {
        //Atributos
        private readonly IRPatrocinador _repoPat;

        [BindProperty]
        public Patrocinador Patrocinador {get;set;}
        //Metodos
        public DeleteModel(IRPatrocinador repoPat)
        {
            this._repoPat = repoPat;
        }
        
        public ActionResult OnGet(int Id)
        {            
            Patrocinador = _repoPat.BuscarPatrocinador(Id);
            if(Patrocinador == null)
            {
                ViewData["Error"] = "Patrocinador No encontrado";
                return Page();
            }
            else
            {
                return Page();
            }
        }

        public ActionResult OnPost()
        {
            bool Funciono = _repoPat.EliminarPatrocinador(Patrocinador.Id);
            
            if(Funciono)
            {
                return RedirectToPage("./Index");
            }
            else
            {
                ViewData["Error"] = "No es posible eliminar este registro, favor revisar su relacion con equipos";
                return Page();
            }
        }
        
    }
}
