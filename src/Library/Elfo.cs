using System.Collections.Generic;
namespace Ucu.Poo.RolePlayGame {
public class Elfo : IPersonaje
{
    public string Nombre { get; set; }
    public int Vida { get; set; }
    private int vidaInicial;
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