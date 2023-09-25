using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Back
{
    public class CuentaBancaria
    {
        public CuentaBancaria(int NroCuenta_, Cliente Titular_, Tipos Tipo_)
        {
            NroCuenta = NroCuenta_;
            Titular = Titular_;
            Saldo = 0;
            Tipo = Tipo_;
        }
        public int Id { get; set; }
        public int NroCuenta { get; set; }
        public double Saldo { get; set; }
        public Cliente Titular { get; set; }
        public Tipos Tipo { get; set; } 
    }
}
