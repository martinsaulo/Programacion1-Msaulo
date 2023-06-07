using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Parcial
{
    public class LibroFisico : Libro
    {
        public int NroPaginas { get; set; }
        public override string ObtenerInformacion()
        {
            return NroPaginas.ToString();
        }
        public override string ObtenerTipo()
        {
            return "Libro Físico";
        }
        public LibroFisico(string Titulo_, string Autor_, int AnioPublicacion_, int NroPaginas_) 
            : base (Titulo_, Autor_, AnioPublicacion_)
        {
            Titulo = Titulo_;
            Autor = Autor_;
            AnioPublicacion = AnioPublicacion_;
            NroPaginas = NroPaginas_;
        }
    }
}
