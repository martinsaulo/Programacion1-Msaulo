using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back
{
    public class Principal
    {
        ApplicationDbContext context = new ApplicationDbContext();

        public void AgregarCliente(string NombreCliente, string ApellidoCliente, int DNICliente)
        {
            Cliente nuevoCliente = new Cliente(NombreCliente, ApellidoCliente, DNICliente);

            context.Clientes.Add(nuevoCliente);
            context.SaveChanges();
        }
        public void CrearCuentaBancaria(int NroCuenta, Cliente Titular, Tipos Tipo)
        {
            CuentaBancaria nuevaCuenta = new CuentaBancaria(NroCuenta, Titular, Tipo);

            context.CuentasBancarias.Add(nuevaCuenta);
            context.SaveChanges();
        }
        public void RealizarDeposito(double Monto, int IdCuenta)
        {
            var cuentaEncontrada = context.CuentasBancarias.Find(IdCuenta);

            if (Monto > 0)
            {
                if (cuentaEncontrada != null)
                {
                    cuentaEncontrada.Saldo += Monto;
                    context.SaveChanges();
                }
            }
        }
        public void RealizarExtraccion(double Monto, int IdCuenta)
        {
            var cuentaEncontrada = context.CuentasBancarias.Find(IdCuenta);

            if(cuentaEncontrada != null)
            {
                if (Monto > 0 && Monto <= cuentaEncontrada.Saldo)
                {
                    cuentaEncontrada.Saldo -= Monto;
                    context.SaveChanges();
                }
            }
        }
        public void RealizarTransferencia(double Monto, int IdCuentaOrigen, int IdCuentaDestinatario)
        {
            if (Monto > 0)
            {
                var cuentaOrigen = context.CuentasBancarias.Find(IdCuentaOrigen);
                var cuentaDestinatario = context.CuentasBancarias.Find(IdCuentaDestinatario);

                if (cuentaOrigen != null && cuentaDestinatario != null && cuentaOrigen.Saldo >= Monto)
                {
                    cuentaOrigen.Saldo -= Monto;
                    cuentaDestinatario.Saldo += Monto;
                    context.SaveChanges();
                }
            }
        }
        public void EmitirTarjetaCredito(int NroTarjeta, Cliente Titular, double LimiteCredito, double Saldo)
        {
            TarjetaCredito nuevaTarjeta = new TarjetaCredito(NroTarjeta, Titular, LimiteCredito, Saldo);

            context.TarjetasDeCredito.Add(nuevaTarjeta);
            context.SaveChanges();
        }
        public void CambiarEstadoTarjeta(int IdTarjeta, Estados Estado)
        {
            var tarjetaEncontrada = context.TarjetasDeCredito.Find(IdTarjeta);

            if (tarjetaEncontrada != null)
            {
                tarjetaEncontrada.Estado = Estado;
                context.SaveChanges();
            }
        }
        public void PagarTarjetaCredito(double Monto, int IdTarjeta)
        {
            var tarjetaEncontrada = context.TarjetasDeCredito.Find(IdTarjeta);

            if(tarjetaEncontrada != null)
            {
                if(tarjetaEncontrada.Estado == Estados.Activo && tarjetaEncontrada.MontoDeuda >= Monto)
                {
                    tarjetaEncontrada.MontoDeuda -= Monto;
                    context.SaveChanges();
                }
            }
        }
        public void GenerarResumenTarjeta() { }
    }
}
