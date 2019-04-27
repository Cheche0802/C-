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
            ImprimirCursosforeach (arregloCursos);

        }
        private static void ImprimirCursosforeach (Curso[] arregloCursos) {
            
            
            foreach (var curso in arregloCursos)
            {
                Console.WriteLine ($"Nombre: {curso.Nombre} , Id: {curso.UniqueId}");
            }

        }
    }
}