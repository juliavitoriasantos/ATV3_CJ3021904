using System.ComponentModel.Design;

namespace ATV3_CJ3021904
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float n;

            Console.WriteLine("Digite sua nota: ");
            n = float.Parse(Console.ReadLine());

            if (n >= 6f)
            {
                Console.WriteLine("Aluno foi aprovado!");
            }

            else{ Console.WriteLine("Aluno reprovado");


             
            }


            //Exercécio 1

            float npi;

            Console.WriteLine("Digite um número: ");
            npi = float.Parse(Console.ReadLine());

            if(npi % 2 == 0f)
            {
                Console.WriteLine("O número é par");
            }

            else{ Console.WriteLine("O número é ímpar"); 
            }

            //Exercécio 2

            float l1, l2, l3;

            Console.WriteLine("Digite a medida do lado 1: ");
            l1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a medida do lado 2: ");
            l2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a medida do lado 3: ");
            l3 = float.Parse(Console.ReadLine());

            if ((l1 + l2 > l3) && (l1 + l3 > l2) && (l2 + l3 > l1))
            {
                Console.WriteLine("É um triângulo");

                if (l1 == l2 && l1 == l3) { Console.WriteLine("Triângulo equilátero");
                }

                if (l1 != l2 && l1 != l3 && l2!= l3) { Console.WriteLine("Triângulo escaleno");
                }
                else
                {
                    Console.WriteLine("Triângulo Isósceles");
                }
            }
            else { Console.WriteLine("Não é um triângulo");
            }

            //Exercécio 3

            //Exercício 4

            //Exercício 5

            int nota;

            Console.WriteLine("Digite uma nota de o a 100");
            nota = int.Parse(Console.ReadLine());

            if (nota >= 90 && nota <= 100)
            {
                Console.WriteLine("Nota A");
            }
            if (nota >= 80 && nota <= 89)
            {
                Console.WriteLine("Nota B");
            }
            if (nota >= 70 && nota <= 79)
            {
                Console.WriteLine("NOta C");
            }
            if (nota >= 60 && nota <= 69)
            {
                Console.WriteLine("Nota D");
            }

            else { Console.WriteLine("Nota F");
            }

            //Exercécio 6
            //Exercício 7
        }
    }
}