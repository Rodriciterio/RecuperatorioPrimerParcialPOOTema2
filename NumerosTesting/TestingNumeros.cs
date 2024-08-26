using Entidades;

namespace NumerosTesting
{
    [TestClass]
    public class TestingNumeros
    {
        [TestMethod]
        public void ConstructorValidaYAsignaValorCorrectamente()
        {
            // Arrange
            int valorValido = 35;
            //int valorInvalido = 4;

            // Act
            var numeroValido = new NumeroDivCincoSiete(valorValido);

            // Assert
            Assert.AreEqual(valorValido, numeroValido.Valor, "El valor asignado no es el esperado.");

            //// Assert exception
            //var exception = Assert.ThrowsException<ArgumentException>(() => new NumeroDivCincoSiete(valorInvalido));
            //Assert.AreEqual("El valor debe ser divisible por 5 o 7.", exception.Message);
        }

        [TestMethod]
        public void OperadoresIgualdadFuncionanCorrectamente()
        {
            // Arrange
            var numero1 = new NumeroDivCincoSiete(35);
            var numero2 = new NumeroDivCincoSiete(35);
            var numero3 = new NumeroDivCincoSiete(70);
            var numero4 = new NumeroDivCincoSiete(4);

            // Act
            bool sonIguales = numero1 == numero2;
            bool sonDiferentes = numero1 != numero3;
            bool esIgualAInvalido = numero1 == numero4;
            bool esDiferenteAInvalido = numero1 != numero4;

            // Assert
            Assert.IsTrue(sonIguales, "Los números que deberían ser iguales no lo son.");
            Assert.IsTrue(sonDiferentes, "Los números que deberían ser diferentes no lo son.");
            Assert.IsFalse(esIgualAInvalido, "El número válido no debería ser igual al número no válido.");
            Assert.IsTrue(esDiferenteAInvalido, "El número válido debería ser diferente al número no válido.");
        }
    }
}
}