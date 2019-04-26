using System;
using CoreEscuela.Entidades;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("2rey" , 2010, TiposEscuela.Bachillerato
            , pais:"Venezuela", ciudad:"Caracas");
    
            Console.WriteLine(escuela);
        }
    }
}
