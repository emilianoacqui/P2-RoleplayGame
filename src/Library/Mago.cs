
using System.Collections.Generic;
namespace Ucu.Poo.RolePlayGame {
public class Mago : IPersonaje
{
    public string Nombre { get; set; }
    public int Vida { get; set; }

// vidaInicial es un campo separado
// (no una constante) porque cada personaje puede nacer con vida distinta; así
// Curar() siempre tiene el valor propio de ESE personaje. 
    private int vidaInicial;

// La lista de items es privada y solo se modifica 
// con AgregarItem/QuitarItem, evitando que código externo la altere.
// directamente o le agregue items inválidos.
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