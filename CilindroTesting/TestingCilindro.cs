using Entidades._01;

namespace CilindroTesting
{
    [TestClass]
    public class TestingCilindro
    {
        [TestMethod]
        public void CilindroValidarRadioDevuelveTrue()
        {
            // Arrange
            var cilindro = new Cilindro(5, 10);

            // Act
            var esValido = cilindro.ValidarRadio();

            // Assert
            Assert.IsTrue(esValido);
        }

        [TestMethod]
        public void CilindroValidarAlturaDevuelveTrue()
        {
            // Arrange
            var cilindro = new Cilindro(5, 10);

            // Act
            var esValido = cilindro.ValidarAltura();

            // Assert
            Assert.IsTrue(esValido);
        }

        [TestMethod]
        public void CilindroCalcularAreaDevuelveCorrecto()
        {
            //Arrange
            var radio = 5;
            var altura = 10;
            var cilindro = new Cilindro(radio, altura);

            var areaBasesEsperada = 2 * Math.PI * Math.Pow(radio, 2);
            var areaLateralEsperada = 2 * Math.PI * radio * altura;
            var areaEsperada = areaBasesEsperada + areaLateralEsperada;

            // Act
            var areaObtenida = cilindro.GetArea();

            // Assert
            Assert.AreEqual(areaEsperada, areaObtenida, 0.00001, "El area calculada del cilindro no es la correcta");
        }

        [TestMethod]
        public void CilindroCalcularVolumenDevuelveCorrecto()
        {
            //Arrange
            var radio = 5;
            var altura = 10;
            var cilindro = new Cilindro(radio, altura);

            var volumenEsperado = Math.PI * Math.Pow(radio, 2) * altura;

            // Act
            var volumenObtenido = cilindro.GetVolumen();

            // Assert
            Assert.AreEqual(volumenEsperado, volumenObtenido, 0.00001, "El volumen calculado del cilindro no es el correcto.");
        }
    }
}