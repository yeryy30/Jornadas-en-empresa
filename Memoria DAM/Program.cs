using System.IO;
using System.Text;
internal class Program
{
    static void LeerFichero()
    {
        StreamReader sr = new StreamReader("Fichero.txt", Encoding.UTF8, true); 
        while(!sr.EndOfStream)
            Console.WriteLine(sr.ReadLine());
        sr.Close();      

    }

    static void EscribirFichero()
    {
        do
        {
            Console.WriteLine("Pulsa Esc para dejar de escribir.");
            Console.WriteLine("Introduce el termino que quieres escribir: ");
            string termino = Console.ReadLine() ?? "";

            Console.WriteLine("Introduce la definicion del termino: ");
            string definicion = Console.ReadLine() ?? "";

            using StreamWriter sw = new StreamWriter("Fichero.txt", true, Encoding.UTF8);
            sw.WriteLine(termino + ": " + definicion);
            sw.Close();
        } while (Console.ReadKey().Key != ConsoleKey.Escape);
    }
    private static void Main(string[] args)
    {
        LeerFichero();

    }
}