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
    /// Estilo: Arrange Act Assert
    /// Link: https://www.typemock.com/unit-test-patterns-for-net
    /// Benefícios:
    /// - Clareza nas operações sendo executadas
    /// - Padronização
    /// </summary>
    public class CpfTests
    {
        [Fact(DisplayName = "Cpf_CriarCom10Algaritmos_ArgumentException")]
        [Trait("Categoria", "Cpf")]
        public void Cpf_CriarCom10Algaritmos_ArgumentException()
        {
            // Arrange
            var numero = "1234567890";

            // Act
            Action criarCpfCom10Algarismos = () => Cpf.Novo(numero);

            // Assert
            Assert.Throws<ArgumentException>(criarCpfCom10Algarismos);
        }
    }
}
