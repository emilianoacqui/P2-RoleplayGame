namespace Ucu.Poo.RolePlayGame {
public class Game
{
    // Al recibir IPersonaje en lugar de Mago, Elfo o Enano, este
    // unico metodo soporta cualquier combinacion de personajes atacandose entre sí.
    public void Atacar(IPersonaje atacante, IPersonaje defensor)
    {
        int dano = atacante.ObtenerAtaqueTotal();
        defensor.Atacar(dano);
    }
}
}