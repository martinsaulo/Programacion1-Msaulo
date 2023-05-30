﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public abstract class Empleado
    {
        public string Nombre { get; set; }
        public double Salario { get; set; }
        public abstract double CalcularSalario();
    }
}
