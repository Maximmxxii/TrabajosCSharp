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
    public class EditModel : PageModel
    {
        //atributos
        private readonly IRPatrocinador _repoPat;

        [BindProperty]
        public Patrocinador Patrocinador {get;set;}

        //Metodos
        //Constructor
        public EditModel(IRPatrocinador repoPat)
        {
            this._repoPat = repoPat;
        }

        public ActionResult OnGet(int Id)
        {
            Patrocinador = _repoPat.BuscarPatrocinador(Id);
            return Page();
        }

        public ActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            
            bool Funciono = _repoPat.ActualizarPatrocinador(Patrocinador);
            
            if(Funciono)
            {
                return RedirectToPage("./Index");
            }
            else
            {
                ViewData["Error"] = "Existe un Patrocinador con la Identificación:  " + Patrocinador.Identificacion;
                return Page();
            }
        }
    }
}
