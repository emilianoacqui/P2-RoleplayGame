using NUnit.Framework;

namespace Ucu.Poo.RolePlayGame
{
    [TestFixture]
    public class ElfoTests
    {
        [Test]
        public void ObtenerAtaqueTotal_ItemAgregado_SumaAtaque()
        {
            var elfo = new Elfo("Juan", 100);
            var item = new ItemElfo("Arco", 20, 0);

            elfo.AgregarItem(item);

            Assert.That(elfo.ObtenerAtaqueTotal(), Is.EqualTo(20));
        }

        [Test]
        public void QuitarItem_ItemAgregado_NoSumaAtaque()
        {
            var elfo = new Elfo("Juan", 100);
            var item = new ItemElfo("Arco", 20, 0);
            elfo.AgregarItem(item);

            elfo.QuitarItem(item);

            Assert.That(elfo.ObtenerAtaqueTotal(), Is.EqualTo(0));
        }

        [Test]
        public void Atacar_DanoMenorQueVida_RestaVida()
        {
            var elfo = new Elfo("Juan", 100);

            elfo.Atacar(30);

            Assert.That(elfo.Vida, Is.EqualTo(70));
        }

        [Test]
        public void Curar_DespuesDeAtaque_RestauraVidaInicial()
        {
            var elfo = new Elfo("Juan", 100);
            elfo.Atacar(40);

            elfo.Curar();

            Assert.That(elfo.Vida, Is.EqualTo(100));
        }
    }
}