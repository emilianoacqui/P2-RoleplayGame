using System.Collections.Generic;
namespace Ucu.Poo.RolePlayGame {
public class ItemEnano
{
    public string Nombre { get; set; }
    public int Ataque { get; set; }
    public int Defensa { get; set; }

    public ItemEnano(string nombre, int ataque, int defensa)
    {
        Nombre = nombre;
        Ataque = ataque;
        Defensa = defensa;
    }
}
}