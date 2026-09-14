namespace Ucu.Poo.RolePlayGame {
//cada especie tiene su propia clase de Item, 
// en vez de una clase Item generica compartida, para que no se
// pueda, por error, agregarle un Item de un personaje a otro, 
// si no le pertenece a su "grupo de items".
public class ItemMago
{
    public string Nombre { get; set; }
    public int Ataque { get; set; }
    public int Defensa { get; set; }

    public ItemMago(string nombre, int ataque, int defensa)
    {
        Nombre = nombre;
        Ataque = ataque;
        Defensa = defensa;
    }
}
public class LibroH
{
    
}
}