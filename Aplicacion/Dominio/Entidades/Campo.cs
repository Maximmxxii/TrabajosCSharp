using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Dominio
{
    public class Campo
    {
        public int Id { get; set; }
        
        [RegularExpression("[A-Za-z ]*",ErrorMessage="Solo se permiten letras.")]
        public string Nombre { get; set; }

        [RegularExpression("[A-Za-z ]*",ErrorMessage="Solo se permiten letras.")]
        public string Disciplina { get; set; }

        [RegularExpression("[0-9]*",ErrorMessage="Solo se permiten numeros")] 
        public int Capacidad { get; set; }


        public int EscenarioId { get; set; }

    }
}