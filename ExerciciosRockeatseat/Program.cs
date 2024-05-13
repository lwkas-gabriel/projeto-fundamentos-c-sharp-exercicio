
using System.Text;

namespace ExerciciosRocketseat
{
    class Program
    {
        public static void Main()
        {
            Exercicio2();
        }

        public static void Exercicio1()
        {
            Console.WriteLine("Digite seu nome:");
            string seuNome = Console.ReadLine();
            Console.WriteLine($"Olá, {seuNome}! Seja muito bem-vindo!");
        }

        public static void Exercicio2()
        {
            Console.WriteLine("Digite seu nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite seu sobrenome:");
            string sobrenome = Console.ReadLine();

            Console.WriteLine($"{nome} {sobrenome}");

        }
    }
}