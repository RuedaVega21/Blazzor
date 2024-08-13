using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraApp.Library
{
    public class CursoCLS
    {
        public int idcurso {  get; set; }

        [Required(ErrorMessage = "Ingrese el nombre del curso")]
        public string nombrecurso { get; set; }

        [Range(1,10, ErrorMessage ="Debe ingresar creditos de 1 a 10" )]
        public int numerocreditos { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Seleccione una opción")]
        public int idcarrera {  get; set; }
            
    }
}
