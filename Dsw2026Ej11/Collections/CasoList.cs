using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

public class CasoList
{
    private List<Alumno> alumnos;
    public CasoList()
    {
        alumnos = new List<Alumno>();
    }
    public void AgregarAlumno(Alumno alumno)
    {
        alumnos.Add(alumno);
    }
    public List<Alumno> RetornarLista()
    {
        return alumnos;
    }
    public Alumno BuscarAlumno(string nombre)
    {
        return alumnos.Find(a => a.Nombre == nombre);
    }
    public void EliminarAlumno(Alumno alumno)
    {
        alumnos.Remove(alumno);
    }
    public void EliminarAlumnoPorPosicion(int posicion)
    {
        alumnos.RemoveAt(posicion);
    }
}
