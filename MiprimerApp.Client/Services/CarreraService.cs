using MiPrimeraApp.Library;
using MiprimerApp.Client.Component.Carrera;

namespace MiprimerApp.Client.Services
{
    public class CarreraService
    {
        public event Func<Task> OnChange; 
        public event Func<CarreraCLS, Task> OnEdit;

        public List<CarreraCLS> listacarrera { get; set; }
        public CarreraService() {
            listacarrera = new List<CarreraCLS>();

            listacarrera.Add(new CarreraCLS
            {
                idcarrera = 1,
                nombrecarrera = "Informatica",
                descripcioncarrera = "Desc 1"
            });

            listacarrera.Add(new CarreraCLS
            {
                idcarrera = 2,
                nombrecarrera = "Medicina",
                descripcioncarrera = "Desc 2"
            });
        }

        public List<CarreraCLS> ListarCarreras()
        {
            return listacarrera;
        }
        public void Agregar(CarreraCLS oCarreraCLS)
        {
            listacarrera.Add(oCarreraCLS);
            NotificarCambios();
        }

        public void Eliminar(int idcarrera)
        {
            CarreraCLS obj = listacarrera.Where(p=>p.idcarrera== idcarrera).First();
            listacarrera.Remove(obj);
            NotificarCambios();
        }
        public void NotificarCambios()
        {
            OnChange?.Invoke();
        }

        public void NotificarEditar(CarreraCLS oCarreraCLS)
        {
            OnEdit?.Invoke(oCarreraCLS);
        }
    }
}
