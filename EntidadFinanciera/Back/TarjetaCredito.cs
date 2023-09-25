using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Back
{
    public class TarjetaCredito
    {
        public TarjetaCredito(int Nrotarjeta_, Cliente Titular_, double LimiteCredito_, double Saldo_)
        {
            NroTarjeta = Nrotarjeta_;
            Titular = Titular_;
            LimiteCredito = LimiteCredito_;
            Estado = Estados.Activo;
            Saldo = Saldo_;
            MontoDeuda = 0;
        }
        public int Id { get; set; }
        public int NroTarjeta {  get; set; }
        public double LimiteCredito { get; set; }
        public double Saldo { get; set; }
        public double MontoDeuda { get; set; }
        public Cliente Titular { get; set; }
        public Estados Estado { get; set; }
    }
}
