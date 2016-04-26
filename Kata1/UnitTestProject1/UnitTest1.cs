using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kata1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PiedraGanaATijeras()
        {
            Jugada jugada = new Jugada();
            Resultado result = jugada.Play(Gesto.Piedra, Gesto.Tijera);
            Assert.AreEqual(Resultado.Gana, result);
        }

        [TestMethod]
        public void PiedraGanaALagarto()
        {
            Jugada jugada = new Jugada();
            Resultado result = jugada.Play(Gesto.Piedra, Gesto.Lagarto);
            Assert.AreEqual(Resultado.Gana, result);
        }

        [TestMethod]
        public void PiedraPierdeContraPapel()
        {
            Jugada jugada = new Jugada();
            Resultado result = jugada.Play(Gesto.Piedra, Gesto.Papel);
            Assert.AreEqual(Resultado.Pierde, result);
        }

        [TestMethod]
        public void PiedraPierdeContraSpock()
        {
            Jugada jugada = new Jugada();
            Enum result = jugada.Play(Gesto.Piedra, Gesto.Spock);
            Assert.AreEqual(Resultado.Pierde, result);
        }

        [TestMethod]
        public void PapelGanaAPiedra()
        {
            Jugada jugada = new Jugada();
            Enum result = jugada.Play(Gesto.Papel, Gesto.Piedra);
            Assert.AreEqual(Resultado.Gana, result);
        }

        [TestMethod]
        public void PapelGanaASpock()
        {
            Jugada jugada = new Jugada();
            Enum result = jugada.Play(Gesto.Papel, Gesto.Spock);
            Assert.AreEqual(Resultado.Gana, result);
        }

        [TestMethod]
        public void PapelPierdeContraTijeras()
        {
            Jugada jugada = new Jugada();
            Enum result = jugada.Play(Gesto.Papel, Gesto.Tijera);
            Assert.AreEqual(Resultado.Pierde, result);
        }

        [TestMethod]
        public void PapelPierdeContraLagarto()
        {
            Jugada jugada = new Jugada();
            Enum result = jugada.Play(Gesto.Papel, Gesto.Lagarto);
            Assert.AreEqual(Resultado.Pierde, result);
        }

        public void TijeraGanaAPapel()
        {
            Jugada jugada = new Jugada();
            Enum result = jugada.Play(Gesto.Tijera, Gesto.Papel);
            Assert.AreEqual(Resultado.Gana, result);
        }

        [TestMethod]
        public void TijeraGanaALagarto()
        {
            Jugada jugada = new Jugada();
            Enum result = jugada.Play(Gesto.Tijera, Gesto.Lagarto);
            Assert.AreEqual(Resultado.Gana, result);
        }

        [TestMethod]
        public void TijeraPierdeContraPiedra()
        {
            Jugada jugada = new Jugada();
            Enum result = jugada.Play(Gesto.Tijera, Gesto.Piedra);
            Assert.AreEqual(Resultado.Pierde, result);
        }

        [TestMethod]
        public void TijeraPierdeContraSpock()
        {
            Jugada jugada = new Jugada();
            Enum result = jugada.Play(Gesto.Tijera, Gesto.Spock);
            Assert.AreEqual(Resultado.Pierde, result);
        }

        [TestMethod]
        public void LagartoGanaASpock()
        {
            Jugada jugada = new Jugada();
            Enum result = jugada.Play(Gesto.Lagarto, Gesto.Spock);
            Assert.AreEqual(Resultado.Gana, result);
        }

        [TestMethod]
        public void LagartoGanaAPapel()
        {
            Jugada jugada = new Jugada();
            Enum result = jugada.Play(Gesto.Lagarto, Gesto.Papel);
            Assert.AreEqual(Resultado.Gana, result);
        }

        [TestMethod]
        public void LagartoPierdeContraPiedra()
        {
            Jugada jugada = new Jugada();
            Enum result = jugada.Play(Gesto.Lagarto, Gesto.Piedra);
            Assert.AreEqual(Resultado.Pierde, result);
        }

        [TestMethod]
        public void LagartoPierdeContraTijeras()
        {
            Jugada jugada = new Jugada();
            Enum result = jugada.Play(Gesto.Lagarto, Gesto.Tijera);
            Assert.AreEqual(Resultado.Pierde, result);
        }

        [TestMethod]
        public void SpockGanaTijeras()
        {
            Jugada jugada = new Jugada();
            Enum result = jugada.Play(Gesto.Spock, Gesto.Tijera);
            Assert.AreEqual(Resultado.Gana, result);
        }

        [TestMethod]
        public void SpockGanaAPiedra()
        {
            Jugada jugada = new Jugada();
            Enum result = jugada.Play(Gesto.Spock, Gesto.Piedra);
            Assert.AreEqual(Resultado.Gana, result);
        }

        [TestMethod]
        public void SpockPierdeContraPapel()
        {
            Jugada jugada = new Jugada();
            Enum result = jugada.Play(Gesto.Spock, Gesto.Papel);
            Assert.AreEqual(Resultado.Pierde, result);
        }

        [TestMethod]
        public void SpockPierdeContraLagarto()
        {
            Jugada jugada = new Jugada();
            Enum result = jugada.Play(Gesto.Spock, Gesto.Lagarto);
            Assert.AreEqual(Resultado.Pierde, result);
        }

        [TestMethod]
        public void PiedraContraPiedra()
        {
            Jugada jugada = new Jugada();
            Enum result = jugada.Play(Gesto.Piedra, Gesto.Piedra);
            Assert.AreEqual(Resultado.Empate, result);
        }

        [TestMethod]
        public void JugadaNula()
        {
            Jugada jugada = new Jugada();
            Enum result = jugada.Play(Gesto.Piedra, Gesto.Piedra);
            Assert.AreEqual(Resultado.Empate, result);
        }
    }
}
