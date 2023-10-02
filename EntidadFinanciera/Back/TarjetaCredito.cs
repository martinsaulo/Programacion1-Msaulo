using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace Back
{
    public class TarjetaCredito
    {
        public TarjetaCredito(double limiteCredito, double saldo)
        {
            LimiteCredito = limiteCredito;
            Estado = Estados.Activo;
            Saldo = saldo;
            MontoDeuda = 0;
        }
        [Key]public int NroTarjeta {  get; set; }
        public double LimiteCredito { get; set; }
        public double Saldo { get; set; }
        public double MontoDeuda { get; set; }
        public Cliente Titular { get; set; }
        public string NombreTitular { get; set; }
        public Estados Estado { get; set; }
    }
}
