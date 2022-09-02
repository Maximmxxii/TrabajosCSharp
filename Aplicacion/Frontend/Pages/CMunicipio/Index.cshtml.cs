using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;

namespace Frontend.Pages.CMunicipio
{
    public class IndexModel : PageModel
    {
        //Un Objeto como atributo Para hacer uso de los metodos de las Interfaces
        private readonly IRMunicipio _repoMunicipio;

        public IEnumerable<Municipio> Municipios {get;set;}

        //metodos
        //constructor
        public IndexModel(IRMunicipio repoMunicipio)
        {
            this._repoMunicipio = repoMunicipio;
        }

        //se usa para enviar info al html o forms vacios
        public void OnGet()
        {
            Municipios = _repoMunicipio.ListarMunicipios();
        }
    }
}
