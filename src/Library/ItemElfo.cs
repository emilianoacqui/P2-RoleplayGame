namespace Ucu.Poo.RolePlayGame {
public class ItemElfo
{
    public string Nombre { get; set; }
    public int Ataque { get; set; }
    public int Defensa { get; set; }

    public ItemElfo(string nombre, int ataque, int defensa)
    {
        Nombre = nombre;
        Ataque = ataque;
        Defensa = defensa;
    }
}
}