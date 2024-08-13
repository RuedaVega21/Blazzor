using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MiPrimeraApp.Library
{
    public class CarreraCLS
    {
        [Required(ErrorMessage = "Ingrese el Id")]
        public int idcarrera { get; set; }


        [Required(ErrorMessage = "Ingrese el nombre de la carrera")]
        [MaxLength(100,ErrorMessage ="El nombre de la carrera no puede pasar de los 100 caracteres")]
        [MinLength(3, ErrorMessage = "El nombre de la carrera no puede tener menos de 3 caracteres")]
        public string nombrecarrera { get; set; }
        
        [Required(ErrorMessage = "Ingrese la descipción de la carrera")]
        [MaxLength(200, ErrorMessage = "La descripción de la carrera no puede pasar de los 200 caracteres")]
        [MinLength(3, ErrorMessage = "La descripción de la carrera no puede tener menos de 3 caracteres")]

        public string descripcioncarrera { get; set; }
       
    }
}
