using System;
using CoreEscuela.Entidades;

namespace Etapa1 {
    class Program {
        static void Main (string[] args) {
            var escuela = new Escuela ("2rey", 2010, TiposEscuela.Bachillerato, pais: "Venezuela", ciudad: "Caracas");

            var arregloCursos = new Curso[3];

            arregloCursos[0] = new Curso () {
                Nombre = "101"
            };

            var curso2 = new Curso () {
                Nombre = "201"
            };
            arregloCursos[1] = curso2;

            arregloCursos[2] = new Curso {
                Nombre = "301"
            };

            Console.WriteLine (escuela);
            Console.WriteLine ("===============");
            ImprimirCursosdowhile (arregloCursos);

        }
        private static void ImprimirCursosdowhile (Curso[] arregloCursos) {
            int contador = 0;
            do {
                Console.WriteLine ($"Nombre: {arregloCursos[contador].Nombre} , Id: {arregloCursos[contador].UniqueId}");
                contador++;
            } while (contador < arregloCursos.Length);

        }
    }
}