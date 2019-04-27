using System;
using CoreEscuela.Entidades;
using static System.Console;

namespace Etapa1 {
    class Program {
        static void Main (string[] args) {
            var escuela = new Escuela ("2rey", 2010, TiposEscuela.Bachillerato, pais: "Venezuela", ciudad: "Caracas");

            escuela.Cursos = new Curso[] {
                new Curso { Nombre = "101" },
                new Curso { Nombre = "201" },
                new Curso { Nombre = "301" }
            };

            ImprimirCursosEscuela (escuela);

        }

        private static void ImprimirCursosEscuela (Escuela escuela) {
            Console.WriteLine ("======================");
            Console.WriteLine ("Cursos de la Escuela");
            Console.WriteLine ("======================");

            if (escuela != null && escuela.Cursos != null) {
                foreach (var curso in escuela.Cursos) {
                    Console.WriteLine ($"Nombre: {curso.Nombre} , Id: {curso.UniqueId}");
                }

            }
        }

        private static void ImprimirCursosforeach (Curso[] arregloCursos) {

            foreach (var curso in arregloCursos) {
                Console.WriteLine ($"Nombre: {curso.Nombre} , Id: {curso.UniqueId}");
            }

        }
    }
}