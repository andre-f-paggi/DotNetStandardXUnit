using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ExperimentoDotNetStandardTests
{
    public class StringExtensionsTests
    {
        public class OMetodoObterSomenteNumeros
        {
            [Fact]
            public void Retorna_123_AoPassarOValor_Abc123()
            {
                var entrada = "abc123";
                var esperado = "123";
                var real = entrada.ObterSomenteNumeros();

                Assert.Equal(esperado, real);
            }

            [Fact]
            public void NaoRetorna_1234_AoPassarOValor_Abc123()
            {
                var entrada = "abc123";
                var esperado = "1234";
                var real = entrada.ObterSomenteNumeros();

                Assert.NotEqual(esperado, real);
            }
        }
    }
}
