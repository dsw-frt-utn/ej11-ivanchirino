using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

public class CasoLinq
{
    private List<Libro> libros;

    public CasoLinq()
    {
        libros = Libro.CrearLista();
    }

    public Libro GetPrimero()
    {
        return libros.First();
    }

    public Libro GetUltimo()
    {
        return libros.Last();
    }

    public decimal GetTotalPrecios()
    {
        return libros.Sum(l => l.Precio);
    }

    public decimal GetPromedioPrecios()
    {
        return libros.Average(l => l.Precio);
    }

    public List<Libro> GetListById()
    {
        return libros.Where(l => l.Id > 14).ToList();
    }

    public List<string> GetLibros()
    {
        return libros
            .Select(l => $"{l.Titulo} - ${l.Precio}")
            .ToList();
    }

    public Libro GetMayorPrecio()
    {
        return libros.OrderByDescending(l => l.Precio).First();
    }

    public Libro GetMenorPrecio()
    {
        return libros.OrderBy(l => l.Precio).First();
    }

    public int GetMayorPromedio()
    {
        decimal promedio = libros.Average(l => l.Precio);

        return libros.Count(l => l.Precio > promedio);
    }

    public List<Libro> GetLibrosDesc()
    {
        return libros
            .OrderByDescending(l => l.Titulo)
            .ToList();
    }
}
