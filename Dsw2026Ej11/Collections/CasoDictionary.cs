using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

public class CasoDictionary
{
    private Dictionary<int, Alumno> alumnos;

    public CasoDictionary()
    {
        alumnos = new Dictionary<int, Alumno>();
    }
    public void AgregarAlumno(Alumno alumno)
    {
        alumnos.Add(alumno.Id, alumno);
    }
    public Alumno BuscarAlumno(int id)
    {
        if (alumnos.ContainsKey(id))
        {
            return alumnos[id];
        }

        return null;
    }
    public Dictionary<int, Alumno> RetornarDiccionario()
    {
        return alumnos;
    }
    public void EliminarAlumno(int id)
    {
        alumnos.Remove(id);
    }
}