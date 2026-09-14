namespace Ucu.Poo.RolePlayGame {

// Mago, Elfo y Enano implementan IPersonaje para
// que Game.Atacar pueda tratarlos de forma
// equivalente, evitando un llamar un metodo por cada combinacion posible.
    public interface IPersonaje
    {
        int ObtenerAtaqueTotal();
        void Atacar(int dano);
        void Curar();
    }
}