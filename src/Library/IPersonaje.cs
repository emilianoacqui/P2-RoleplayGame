namespace Ucu.Poo.RolePlayGame {
    public interface IPersonaje
    {
        int ObtenerAtaqueTotal();
        void Atacar(int dano);
        void Curar();
    }
}