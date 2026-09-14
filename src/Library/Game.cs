namespace Ucu.Poo.RolePlayGame {
public class Game
{
    public void Atacar(IPersonaje atacante, IPersonaje defensor)
    {
        int dano = atacante.ObtenerAtaqueTotal();
        defensor.Atacar(dano);
    }
}
}