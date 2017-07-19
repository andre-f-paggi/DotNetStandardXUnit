using ExperimentoDotNetStandard.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ExperimentoDotNetStandardTests
{
    /// <summary>
    /// Estilo: Subclasse por método testado
    /// Link: http://haacked.com/archive/2012/01/02/structuring-unit-tests.aspx/
    /// Benefícios:
    /// - Legibilidade (Aperte Ctrl-M + Ctrl-O)
    /// - Agrupamento de testes do mesmo método
    /// </summary>
    public class CpfTests2
    {
        public class OMetodoNovo
        {
            [Fact(DisplayName = "Cpf_CriarCom10Algaritmos_ArgumentException")]
            [Trait("Categoria", "Cpf")]
            public void LancaArgumentExceptionAoPassarNumeroCom10Algarismos()
            {
                var numero = "1234567890";
                Action criarCpfCom10Algarismos = () => Cpf.Novo(numero);
                Assert.Throws<ArgumentException>(criarCpfCom10Algarismos);
            }
        }
    }
}
