using NUnit.Framework;

namespace Ucu.Poo.RolePlayGame
{
    [TestFixture]
    public class MagoTests
    {
        [Test]
        public void ObtenerAtaqueTotal_ItemAgregado_SumaAtaque()
        {
            var mago = new Mago("Juan", 100);
            var item = new ItemMago("Bastón", 20, 0);

            mago.AgregarItem(item);

            Assert.That(mago.ObtenerAtaqueTotal(), Is.EqualTo(20));
        }

        [Test]
        public void QuitarItem_ItemAgregado_NoSumaAtaque()
        {
            var mago = new Mago("Juan", 100);
            var item = new ItemMago("Bastón", 20, 0);
            mago.AgregarItem(item);

            mago.QuitarItem(item);

            Assert.That(mago.ObtenerAtaqueTotal(), Is.EqualTo(0));
        }

        [Test]
        public void Atacar_DanoMenorQueVida_RestaVida()
        {
            var mago = new Mago("Juan", 100);

            mago.Atacar(30);

            Assert.That(mago.Vida, Is.EqualTo(70));
        }

        [Test]
        public void Curar_DespuesDeAtaque_RestauraVidaInicial()
        {
            var mago = new Mago("Juan", 100);
            mago.Atacar(40);

            mago.Curar();

            Assert.That(mago.Vida, Is.EqualTo(100));
        }
    }
}