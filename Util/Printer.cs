using static System.Console;

namespace CoreEscuela.Util
{
    public static class Printer
    // Las clases estáticas son clases que no permiten crear nuevas instancias. La clase en sí misma va a funcionar como un objeto
    // No voy a poder crear nuevas clases pero se pueden utilizar todas las funcionalidades de printer, por sí mismo sin instanciarlo
    {
        public static void DrawLine(int tam = 10)
        {

            var linea = "".PadLeft(tam, '=');
            WriteLine(linea);

        }

        public static void WriteTitle(string titulo)
        {
            var tamaño = titulo.Length + 4;
            DrawLine(tamaño);
            WriteLine($"| {titulo} |");
            DrawLine(tamaño);

        }

        public static void Beep(int hz = 2000, int tiempo = 500, int cantidad = 1)
        {
            while (cantidad-- > 0)
            {
                System.Console.Beep(hz, tiempo);
            }
        }

    }
}