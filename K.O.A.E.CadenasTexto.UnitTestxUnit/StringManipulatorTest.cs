using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K.O.A.E.CadenasTexto.UnitTestxUnit
{
    public class StringManipulatorTest
    {

        [Fact]
        public void ReverseString_InvierteCorrectamente()
        {
            StringManipulator _manipulator = new StringManipulator();
            string texto = "Hola";
            string resultadoEsperado = "aloH";

            string resultado = _manipulator.ReverseString(texto);

            Assert.Equal(resultadoEsperado, resultado);
        }

        [Fact]
        public void RemoveSpaces_EliminaEspaciosCorrectamente()
        {
            StringManipulator _manipulator = new StringManipulator();
            string texto = "Hola Mundo";
            string resultadoEsperado = "HolaMundo";

            string resultado = _manipulator.RemoveSpaces(texto);

            Assert.Equal(resultadoEsperado, resultado);
        }
    }
}
