using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperimentoDotNetStandard.ValueObjects
{
    public class Cpf
    {
        private Cpf(string numero)
        {
            var cpfSomenteNumeros = numero.ObterSomenteNumeros();

            if (cpfSomenteNumeros.Length != 11)
                throw new ArgumentException("O CPF deve conter exatamente 11 caracteres");

            throw new NotImplementedException();
        }

        public static Cpf Novo(string numero)
        {
            return new Cpf(numero);
        }
    }
}
