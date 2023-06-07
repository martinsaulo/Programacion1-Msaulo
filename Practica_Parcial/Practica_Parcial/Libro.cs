using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Parcial
{
    public abstract class Libro
    {
        public string Autor { get; set; }
        public string Titulo { get; set; }
        public int AnioPublicacion { get; set; }
        public bool Disponible { get; set; } = true;
        public abstract string ObtenerInformacion();
        public abstract string ObtenerTipo();
        public Libro(string Titulo_, string Autor_, int AnioPublicacion_)
        {
            Titulo = Titulo_;
            Autor = Autor_;
            AnioPublicacion = AnioPublicacion_;
        }
    }
}
