using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Tests;

internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos

    public static void EjemploList()
    {
        CasoList casoList = new CasoList();

        Alumno alumno1 = new Alumno(1, "Juan", 8);
        Alumno alumno2 = new Alumno(2, "Ana", 9);
        Alumno alumno3 = new Alumno(3, "Pedro", 7);

        casoList.AgregarAlumno(alumno1);
        casoList.AgregarAlumno(alumno2);
        casoList.AgregarAlumno(alumno3);

        Console.WriteLine("LISTA DE ALUMNOS");

        foreach (Alumno alumno in casoList.RetornarLista())
        {
            Console.WriteLine(alumno);
        }

        Console.WriteLine();

        Alumno encontrado = casoList.BuscarAlumno("Ana");

        if (encontrado != null)
        {
            Console.WriteLine("ALUMNO ENCONTRADO");
            Console.WriteLine(encontrado);
        }

        Console.WriteLine();

        Alumno noExiste = casoList.BuscarAlumno("Carlos");

        if (noExiste == null)
        {
            Console.WriteLine("No existe");
        }

        Console.WriteLine();

        casoList.EliminarAlumno(alumno2);

        Console.WriteLine("LISTA DESPUES DE ELIMINAR ANA");

        foreach (Alumno alumno in casoList.RetornarLista())
        {
            Console.WriteLine(alumno);
        }

        Console.WriteLine();

        casoList.EliminarAlumnoPorPosicion(0);

        Console.WriteLine("LISTA DESPUES DE ELIMINAR PRIMER ELEMENTO");

        foreach (Alumno alumno in casoList.RetornarLista())
        {
            Console.WriteLine(alumno);
        }
    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos

    public static void EjemploDictionary()
    {
        CasoDictionary casoDictionary = new CasoDictionary();

        Alumno alumno1 = new Alumno(1, "Juan", 8);
        Alumno alumno2 = new Alumno(2, "Ana", 9);
        Alumno alumno3 = new Alumno(3, "Pedro", 7);

        casoDictionary.AgregarAlumno(alumno1);
        casoDictionary.AgregarAlumno(alumno2);
        casoDictionary.AgregarAlumno(alumno3);

        Console.WriteLine("DICCIONARIO DE ALUMNOS");

        foreach (KeyValuePair<int, Alumno> item in casoDictionary.RetornarDiccionario())
        {
            Console.WriteLine(item.Value);
        }

        Console.WriteLine();

        Alumno encontrado = casoDictionary.BuscarAlumno(2);

        if (encontrado != null)
        {
            Console.WriteLine("ALUMNO ENCONTRADO");
            Console.WriteLine(encontrado);
        }

        Console.WriteLine();

        Alumno noExiste = casoDictionary.BuscarAlumno(10);

        if (noExiste == null)
        {
            Console.WriteLine("No existe");
        }

        Console.WriteLine();

        casoDictionary.EliminarAlumno(1);

        Console.WriteLine("DICCIONARIO DESPUES DE ELIMINAR");

        foreach (KeyValuePair<int, Alumno> item in casoDictionary.RetornarDiccionario())
        {
            Console.WriteLine(item.Value);
        }
    }

    //Realizar una llamada a cada método definido en CasoLinq y mostrar por consola según corresponda

    public static void EjemploLinq()
    {
        CasoLinq casoLinq = new CasoLinq();

        Console.WriteLine("PRIMER LIBRO");
        Console.WriteLine(casoLinq.GetPrimero());

        Console.WriteLine();

        Console.WriteLine("ULTIMO LIBRO");
        Console.WriteLine(casoLinq.GetUltimo());

        Console.WriteLine();

        Console.WriteLine("TOTAL PRECIOS");
        Console.WriteLine(casoLinq.GetTotalPrecios());

        Console.WriteLine();

        Console.WriteLine("PROMEDIO PRECIOS");
        Console.WriteLine(casoLinq.GetPromedioPrecios());

        Console.WriteLine();

        Console.WriteLine("LIBROS CON ID MAYOR A 14");

        foreach (Libro libro in casoLinq.GetListById())
        {
            Console.WriteLine(libro.Titulo);
        }

        Console.WriteLine();

        Console.WriteLine("LIBROS FORMATEADOS");

        foreach (string libro in casoLinq.GetLibros())
        {
            Console.WriteLine(libro);
        }

        Console.WriteLine();

        Console.WriteLine("LIBRO MAS CARO");
        Console.WriteLine(casoLinq.GetMayorPrecio().Titulo);

        Console.WriteLine();

        Console.WriteLine("LIBRO MAS BARATO");
        Console.WriteLine(casoLinq.GetMenorPrecio().Titulo);

        Console.WriteLine();

        Console.WriteLine("CANTIDAD MAYOR AL PROMEDIO");
        Console.WriteLine(casoLinq.GetMayorPromedio());

        Console.WriteLine();

        Console.WriteLine("LIBROS DESCENDENTES");

        foreach (Libro libro in casoLinq.GetLibrosDesc())
        {
            Console.WriteLine(libro.Titulo);
        }
    }
}
