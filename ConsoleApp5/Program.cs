using System;
namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ändra bakgrundsfärg till blå
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();

            // Ändra textfärgen till vit
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Denna dator har fått ett fel");
        }
    }
}