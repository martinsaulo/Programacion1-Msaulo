using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.ComponentModel.DataAnnotations;

namespace Back
{
    public class CuentaBancaria
    {
        [Key]public int Id { get; set; }
        public string NroCuenta { get; set; }
        public double Saldo { get; set; }
        public Cliente Titular { get; set; }
        public string NombreTitular { get; set; }
        public Tipos Tipo { get; set; } 
    }
}
