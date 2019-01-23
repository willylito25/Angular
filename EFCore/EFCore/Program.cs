using System;

namespace EFCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Estudiante
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}
