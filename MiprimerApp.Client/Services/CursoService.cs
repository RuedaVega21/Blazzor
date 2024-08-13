using MiPrimeraApp.Library;

namespace MiprimerApp.Client.Services
{
    public class CursoService
    {
        public List<CursoCLS> lista;
        public event Func<Task> Onchage;
        public event Func<CursoCLS, Task> OnEdit;

        public CursoService() { 
        lista = new List<CursoCLS>();
        lista.Add(new CursoCLS { idcurso = 1, nombrecurso = "Matematicas", numerocreditos = 5 });
        }


        public List<CursoCLS> ListarCursos() 
        {
            return lista;
        }
        public void Agregar(CursoCLS curso)
        {
            lista.Add(curso);
            NotificarCambios();
        }
        public void NotificarCambios()
        {
            Onchage?.Invoke();
        }

        public void NotificarEditar(CursoCLS oCursoCLS)
        {
            OnEdit?.Invoke(oCursoCLS);
        }
        public void Eliminar(int idcurso)
        {
            CursoCLS oCursoCLS = lista.Where(p=>p.idcurso == idcurso).First();
            lista.Remove(oCursoCLS);
            NotificarCambios();
        }

    }
}
