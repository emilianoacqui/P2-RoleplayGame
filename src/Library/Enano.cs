using System.Collections.Generic;
namespace Ucu.Poo.RolePlayGame {
public class Enano : IPersonaje
{
    public string Nombre { get; set; }
    public int Vida { get; set; }
    private int vidaInicial;
    private List<ItemEnano> items = new List<ItemEnano>();

    public Enano(string nombre, int vida)
    {
        Nombre = nombre;
        Vida = vida;
        vidaInicial = vida;
    }

    public void AgregarItem(ItemEnano item)
    {
        items.Add(item);
    }
    public void QuitarItem(ItemEnano item)
{
    items.Remove(item);
}

    public int ObtenerAtaqueTotal()
    {
        int total = 0;
        foreach (ItemEnano item in items)
        {
            total += item.Ataque;
        }
        return total;
    }

    public int ObtenerDefensaTotal()
    {
        int total = 0;
        foreach (ItemEnano item in items)
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