using System;
using System.Collections.Generic;
using CoreEscuela.Entidades;
using static System.Console;

namespace Etapa1 {
    class Program {
        static void Main (string[] args) {
            var escuela = new Escuela ("2rey", 2010, TiposEscuela.Bachillerato, pais: "Venezuela", ciudad: "Caracas");

            escuela.Cursos = new List<Curso> () {
                new Curso { Nombre = "101", Jornada = TiposJornada.Mañana },
                new Curso { Nombre = "201", Jornada = TiposJornada.Mañana },
                new Curso { Nombre = "301", Jornada = TiposJornada.Mañana }
            };
               //añadir uno solamente 
            escuela.Cursos.Add (new Curso { Nombre = "102", Jornada = TiposJornada.Tarde });
            escuela.Cursos.Add (new Curso { Nombre = "202", Jornada = TiposJornada.Tarde });
            escuela.Cursos.Add (new Curso { Nombre = "302", Jornada = TiposJornada.Tarde });

            var OtraCollection = new List<Curso> () {
                new Curso { Nombre = "401", Jornada = TiposJornada.Noche },
                new Curso { Nombre = "501", Jornada = TiposJornada.Noche },
                new Curso { Nombre = "601", Jornada = TiposJornada.Noche }
            };

             //limpiar una collecion completa
           //OtraCollection.Clear();
            //borrar un solo archivo de la colleccion
            escuela.Cursos.Remove();

            //añadir un rango de colleciones
            //escuela.Cursos.AddRange(OtraCollection);
           


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