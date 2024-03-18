using System;

namespace ola_mundo
{
    public class HelloWorld
    {
        // Método para retornar a saudação 'Olá, Mundo!'
        public static string Greet()
        {
            return "Olá, Mundo!";
        }

        // Método para retornar a saudação 'Seja bem-vindo, Tryber!'
        public static string GreetTryber()
        {
            return "Seja bem-vindo, Tryber!";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Chamando o método Greet e imprimindo a saída
            Console.WriteLine(HelloWorld.Greet());

            // Chamando o método GreetTryber e imprimindo a saída
            Console.WriteLine(HelloWorld.GreetTryber());
        }
    }
}
