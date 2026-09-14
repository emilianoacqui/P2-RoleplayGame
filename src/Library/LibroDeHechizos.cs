using System.Collections.Generic;
namespace Ucu.Poo.RolePlayGame
{
    public class Hechizo
{
    public string Nombre { get; set; }
    public int Poder { get; set; }

    public Hechizo(string nombre, int poder)
    {
        Nombre = nombre;
        Poder = poder;
    }
}

public class LibroDeHechizos
{
    public string Nombre { get; set; }
    private List<Hechizo> hechizos = new List<Hechizo>();

    public LibroDeHechizos(string nombre)
    {
        Nombre = nombre;
    }

    public void AprenderHechizo(Hechizo hechizo)
    {
        hechizos.Add(hechizo);
    }

    public void OlvidarHechizo(Hechizo hechizo)
    {
        hechizos.Remove(hechizo);
    }

    public int ObtenerAtaque()
    {
        int total = 0;

        foreach (Hechizo h in hechizos)
        {
            total += h.Poder;
        }

        return total;
    }
}
}