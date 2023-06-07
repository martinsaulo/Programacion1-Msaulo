using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Parcial
{
    public class LibroDigital : Libro
    {
        public int TamanioArchivo { get; set; }
        public string Formato { get; set; }
        public override string ObtenerInformacion()
        {
            return Formato + "," + TamanioArchivo;
        }
        public override string ObtenerTipo()
        {
            return "Libro Dígital";
        }
        public LibroDigital(string Titulo_, string Autor_, int AnioPublicacion_, int TamanioArchivo_
            , string Formato_) :  base(Titulo_, Autor_, AnioPublicacion_)
        {
            Titulo = Titulo_;
            Autor = Autor_;
            AnioPublicacion = AnioPublicacion_;
            Formato = Formato_;
            TamanioArchivo = TamanioArchivo_;
        }
    }
}
