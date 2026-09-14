using NUnit.Framework;

namespace Ucu.Poo.RolePlayGame
{
    [TestFixture]
    public class EnanoTests
    {
        [Test]
        public void ObtenerAtaqueTotal_ItemAgregado_SumaAtaque()
        {
            var enano = new Enano("Juan", 100);
            var item = new ItemEnano("Hacha", 20, 0);

            enano.AgregarItem(item);

            Assert.That(enano.ObtenerAtaqueTotal(), Is.EqualTo(20));
        }

        [Test]
        public void QuitarItem_ItemAgregado_NoSumaAtaque()
        {
            var enano = new Enano("Juan", 100);
            var item = new ItemEnano("Hacha", 20, 0);
            enano.AgregarItem(item);

            enano.QuitarItem(item);

            Assert.That(enano.ObtenerAtaqueTotal(), Is.EqualTo(0));
        }

        [Test]
        public void Atacar_DanoMenorQueVida_RestaVida()
        {
            var enano = new Enano("Juan", 100);

            enano.Atacar(30);

            Assert.That(enano.Vida, Is.EqualTo(70));
        }

        [Test]
        public void Curar_DespuesDeAtaque_RestauraVidaInicial()
        {
            var enano = new Enano("Juan", 100);
            enano.Atacar(40);

            enano.Curar();

            Assert.That(enano.Vida, Is.EqualTo(100));
        }
    }
}