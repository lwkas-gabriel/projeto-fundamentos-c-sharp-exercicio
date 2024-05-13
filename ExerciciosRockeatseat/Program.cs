
using System.Text;

namespace ExerciciosRocketseat
{
    class Program
    {
        public static void Main()
        {
            Exercicio4();
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

        public static void Exercicio3()
        {
            double primeiroFator ;
            double segundoFator;

            Console.WriteLine("Digite o primeiro fator:");
            primeiroFator = Convert.ToDouble(Console.ReadLine());
            do
            {
                Console.WriteLine("Digite o segundo fator:");
                segundoFator = Convert.ToDouble(Console.ReadLine());
                if (segundoFator == 0)
                {
                    Console.WriteLine("Por favor, insira um número diferante de zero!");
                }
            } while (segundoFator == 0);
            

            Console.WriteLine($"A soma dos números é: {primeiroFator + segundoFator}");
            Console.WriteLine($"A subtração dos números é: {primeiroFator - segundoFator}");
            Console.WriteLine($"A multiplicação dos números é: { primeiroFator * segundoFator}");
            Console.WriteLine($"A divisão dos números é: { primeiroFator / segundoFator }");
            Console.WriteLine($"A média dos números é:{ (primeiroFator+segundoFator) / 2 }");
        }

        public static void Exercicio4()
        {
            //Retirei os espaços vazios da frase - Caso seja frase
            Console.WriteLine("Digite sua string:");
            string fraseOuPalavra = Console.ReadLine();
            string fraseOuPalavraSemEspacos = fraseOuPalavra.Replace(" ", "");

            Console.WriteLine($"{fraseOuPalavra} tem {fraseOuPalavraSemEspacos.Count()} letras");
        }
    }
}