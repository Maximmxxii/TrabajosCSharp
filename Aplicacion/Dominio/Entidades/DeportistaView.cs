using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{

    public class DeportistaView
    {
        //[Key]
        public int Id {get; set;}        
        public string Documento  { get; set; }      
        public string Nombres  { get; set; }        
        public string Apellidos  { get; set; }        
        public string FechaNacimiento  { get; set; }                
        public string EPS  { get; set; }               
        public string Rh  { get; set; }        
        public string Celular  { get; set; }      
        public string Correo  { get; set; }        
        public string Direccion  { get; set; }    
        public string Genero  { get; set; }       
        public string Equipo { get; set; }
    }
}