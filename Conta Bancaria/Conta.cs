using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Course
{
    class Conta
    {
        public string Titular { get; set; }
        public int Numero { get; private set; }
        public double Saldo { get; private set; }

        public Conta(string titular, int numero)
        {
            Titular = titular;
            Numero = numero;
        }
        public Conta(string titular, int numero, double deposito) : this(titular, numero)
        {
            Saldo += Depositar(deposito);
        }

        private double Depositar(double valor)
        {
            valor -= 5.00; // Taxa de $ 5.00
            return valor;
        }

        public override string ToString()
        {
            return $"Titular: {Titular}, Numero: {Numero}, Saldo: {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
