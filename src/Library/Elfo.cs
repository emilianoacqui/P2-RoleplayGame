using System.Collections.Generic;
namespace Ucu.Poo.RolePlayGame {
public class Elfo : IPersonaje
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
    private List<ItemElfo> items = new List<ItemElfo>();


    public Elfo(string nombre, int vida)
    {
        Nombre = nombre;
        Vida = vida;
        vidaInicial = vida;
    }

    public void AgregarItem(ItemElfo item)
    {
        items.Add(item);
    }
    public void QuitarItem(ItemElfo item)
{
    items.Remove(item);
}

    public int ObtenerAtaqueTotal()
    {
        int total = 0;

        foreach (ItemElfo item in items)
        {
            total += item.Ataque;
        }

        return total;
    }

    public int ObtenerDefensaTotal()
    {
        int total = 0;

        foreach (ItemElfo item in items)
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