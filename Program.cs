using System;
using System.Collections.Generic;
using CoreEscuela.Entidades;
using CoreEscuela.Util;
using static System.Console;

namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {

            var engine = new EscuelaEngine();

            engine.Inicializar();
            Printer.WriteTitle("BIENVENIDOS A LA ESCUELA");

            imprimirEscuela(engine.Escuela);

            var listaObjetos = engine.GetObjetosEscuela();

            // var obj = new ObjetoEscuelaBase();

            // ------------------ PRACTICA DE POLIMORFISMO ---------------------------
            // Printer.DrawLine(20);
            // Printer.DrawLine(20);
            // Printer.DrawLine(20);

            // Printer.WriteTitle("Pruebas de Polimorfismo");

            // var alumnoTest = new Alumno { Nombre = "Ramiro Sánchez" };

            // Printer.WriteTitle("Alumno");
            // WriteLine($"Alumno: {alumnoTest.Nombre}");
            // WriteLine($"Alumno: {alumnoTest.UniqueId}");
            // WriteLine($"Alumno: {alumnoTest.GetType()}");

            // ObjetoEscuelaBase ob = alumnoTest;

            // Printer.WriteTitle("ObjetoEscuela");
            // WriteLine($"Alumno: {ob.Nombre}");
            // WriteLine($"Alumno: {ob.UniqueId}");
            // WriteLine($"Alumno: {ob.GetType()}");


            // var objDummy = new ObjetoEscuelaBase() { Nombre = "Juan Perez" };
            // Printer.WriteTitle("ObjetoEscuelaBase ");
            // WriteLine($"Alumno: {objDummy.Nombre}");
            // WriteLine($"Alumno: {objDummy.UniqueId}");
            // WriteLine($"Alumno: {objDummy.GetType()}");


            // var evaluacion = new Evaluacion() { Nombre = "Evaluacion Matematicas", Nota = 8.5f, };
            // Printer.WriteTitle("Evaluacion");
            // WriteLine($"evaluacion: {evaluacion.Nombre}");
            // WriteLine($"evaluacion: {evaluacion.UniqueId}");
            // WriteLine($"evaluacion: {evaluacion.Nota}");
            // WriteLine($"evaluacion: {evaluacion.GetType()}");

            // // ob = evaluacion;
            // // Printer.WriteTitle("ObjetoEscuela");
            // // WriteLine($"Alumno: {ob.Nombre}");
            // // WriteLine($"Alumno: {ob.UniqueId}");
            // // WriteLine($"Alumno: {ob.GetType()}");

            // if (ob is Alumno)
            // {
            //     Alumno alumnoRecuperado = (Alumno)ob;
            // }

            // Alumno alumnoRecuperado02 = ob as Alumno;
        }

        private static bool Predicate(Curso cur)
        {
            return cur.Nombre == "301";
        }

        private static void imprimirEscuela(Escuela escuela)
        {
            Printer.WriteTitle("Cursos de la Escuela");

            if (escuela?.Cursos != null)
            {

                foreach (var curso in escuela.Cursos)
                {
                    WriteLine($"Nombre: {curso.Nombre}, Id: {curso.UniqueId}");

                }

            }

        }

        // private static void ImprimirCursosWhile(Curso[] arregloCursos)
        // {
        //     int contador = 0;

        //     while (contador < arregloCursos.Length)
        //     {
        //         Console.WriteLine($"Nombre: {arregloCursos[contador].Nombre}, Id: {arregloCursos[contador].UniqueId}");
        //         contador++;
        //     }
        // }

        // private static void ImprimirCursosDoWhile(Curso[] arregloCursos)
        // {
        //     int contador = 0;


        //     do
        //     {
        //         Console.WriteLine($"Nombre: {arregloCursos[contador].Nombre}, Id: {arregloCursos[contador].UniqueId}");
        //         contador++;
        //     } while (contador < arregloCursos.Length);
        // }

        // private static void ImprimirCursosFor(Curso[] arregloCursos)
        // {
        //     for (int i = 0; i < arregloCursos.Length; i++)
        //     {
        //         Console.WriteLine($"Nombre: {arregloCursos[i].Nombre}, Id: {arregloCursos[i].UniqueId}");

        //     }
        // }

        // private static void ImprimirCursosForEach(Curso[] arregloCursos)
        // {

        //     foreach (var curso in arregloCursos)
        //     {
        //         Console.WriteLine($"Nombre: {curso.Nombre}, Id: {curso.UniqueId}");

        //     }
        // }


    }
}
