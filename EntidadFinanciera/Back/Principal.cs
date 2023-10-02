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
        public void EliminarCliente(int idCliente)
        {
            Cliente clienteEncontrado = context.Clientes.Find(idCliente);

            if(clienteEncontrado != null)
            {
                context.Clientes.Remove(clienteEncontrado);
                context.SaveChanges();
            }
        }
        public List<Cliente> DevolverClientes()
        {
            return context.Clientes.ToList();
        }
        public void CrearCuentaBancaria(Cliente Titular, Tipos Tipo)
        {
            CuentaBancaria nuevaCuenta = new CuentaBancaria();
            nuevaCuenta.Titular = Titular;
            nuevaCuenta.NombreTitular = Titular.NombreCompleto;
            nuevaCuenta.Saldo = 0;
            nuevaCuenta.Tipo = Tipo;

            context.CuentasBancarias.Add(nuevaCuenta);
            context.SaveChanges();
        }
        public List<CuentaBancaria> DevolverCuentas()
        {
            return context.CuentasBancarias.ToList();
        }
        public void RealizarDeposito(double Monto, int NroCuenta)
        {
            var cuentaEncontrada = context.CuentasBancarias.Find(NroCuenta);

            if (Monto > 0)
            {
                if (cuentaEncontrada != null)
                {
                    cuentaEncontrada.Saldo += Monto;
                    context.SaveChanges();
                }
            }
        }
        public void RealizarExtraccion(double Monto, int NroCuenta)
        {
            var cuentaEncontrada = context.CuentasBancarias.Find(NroCuenta);

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
        public void EmitirTarjetaCredito(Cliente Titular_, double LimiteCredito, double Saldo)
        {
            TarjetaCredito nuevaTarjeta = new TarjetaCredito(LimiteCredito, Saldo);
            nuevaTarjeta.Titular = Titular_;
            nuevaTarjeta.NombreTitular = Titular_.Nombre;

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
                if(tarjetaEncontrada.Estado == Estados.Activo)
                {                    
                    tarjetaEncontrada.MontoDeuda += Monto;
                    context.SaveChanges();
                }
            }
        }
        public string GenerarResumenTarjeta(int idTarjeta) 
        {
            TarjetaCredito tarjeta = context.TarjetasDeCredito.Find(idTarjeta);
            if (tarjeta != null)
            {
                StringBuilder ret = new StringBuilder();

                ret.AppendLine("Resumen:");
                ret.AppendLine("Nro. tarjeta: " + tarjeta.NroTarjeta);
                ret.AppendLine("Titular: " + tarjeta.Titular.NombreCompleto);
                ret.AppendLine("Limite credito: " + tarjeta.LimiteCredito);
                ret.AppendLine("Saldo: " + tarjeta.Saldo);
                ret.AppendLine("Deuda: " + tarjeta.MontoDeuda);
                ret.AppendLine("Estado: " + tarjeta.Estado);

                return ret.ToString();
            }
            return "Error";
        }
        public List<TarjetaCredito> DevolverTarjetas()
        {
            return context.TarjetasDeCredito.ToList();
        }
    }
}
