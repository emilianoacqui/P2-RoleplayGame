
using System.Collections.Generic;
namespace Ucu.Poo.RolePlayGame {
public class Mago : IPersonaje
{
    public string Nombre { get; set; }
    public int Vida { get; set; }
    private int vidaInicial;
    private List<ItemMago> items = new List<ItemMago>();
    public LibroDeHechizos Libro { get; set; }


    public Mago(string nombre, int vida)
    {
        Nombre = nombre;
        Vida = vida;
        vidaInicial = vida;
    }

    public void AgregarItem(ItemMago item)
    {
        items.Add(item);
    }
    public void QuitarItem(ItemMago item)
{
    items.Remove(item);
}

    public int ObtenerAtaqueTotal()
    {
        int total = 0;

        foreach (ItemMago item in items)
        {
            total += item.Ataque;
        }

        if (Libro != null)
        {
            total += Libro.ObtenerAtaque();
        }

        return total;
    }

    public int ObtenerDefensaTotal()
    {
        int total = 0;

        foreach (ItemMago item in items)
        {
            total += item.Defensa;
        }

        return total;
    }
     public void Atacar(int dano)
{
    Vida -= dano;
    if (Vida < 0) Vida = 0;
}

public void Curar()
{
    Vida = vidaInicial;
}

}
}