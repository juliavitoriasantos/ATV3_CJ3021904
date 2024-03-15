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

            float n;

            Console.WriteLine("Digite sua nota: ");
            n = float.Parse(Console.ReadLine());

            if (n >= 6f)
            {
                Console.WriteLine("Aluno foi aprovado!");
            }

            else
            {
                Console.WriteLine("Aluno reprovado");



            }


            //Exercécio 1

            float npi;

            Console.WriteLine("Digite um número: ");
            npi = float.Parse(Console.ReadLine());

            if (npi % 2 == 0f)
            {
                Console.WriteLine("O número é par");
            }

            else
            {
                Console.WriteLine("O número é ímpar");
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

                if (l1 == l2 && l1 == l3)
                {
                    Console.WriteLine("Triângulo equilátero");
                }

                if (l1 != l2 && l1 != l3 && l2 != l3)
                {
                    Console.WriteLine("Triângulo escaleno");
                }
                else
                {
                    Console.WriteLine("Triângulo Isósceles");
                }
            }
            else
            {
                Console.WriteLine("Não é um triângulo");
            }

            //Exercécio 3

            int numero, tentativa;

            Random gerador = new Random();
            numero = gerador.Next(1, 100);
            Console.WriteLine("Entre com um numero de 1 a 100: ");
            tentativa = int.Parse(Console.ReadLine());
            if (numero == tentativa)
            {
                Console.WriteLine("Acertou de Primeira");
            }
            if (numero < tentativa)
            {
                Console.WriteLine("O numero é menor que {0}");
            }
            Console.WriteLine("Entre com um numero de 1 a 100: ");
            tentatia = int.Parse(Console.ReadLine());
            if (numero > tentativa)
            {
                ConsoleConsole.WriteLine("O numero é maior que {0}");
                Console.WriteLine("Entre com um numero de 1 a 100: ");
                tentativa = int.Parse(Console.ReadLine());
                if (numero == tentativa)
                {
                    Console.WriteLine("Acertou!");
        else
                    {
                        Console.WriteLine("Errou");
                    }
                }
                tem menu de contexto

            //Exercício 4


            string nome, senha;

                Console.WriteLine("entre com um nome de usário");
                nome = Console.ReadLine();

                Console.WriteLine("Entre com uma senha");
                senha = Console.ReadLine();

                if (nome == "admin" && senha == "admin123")
                {
                    Console.WriteLine("acesso concedido");
                }
                //else{ console.Writeline("A...) (comoutador na frente


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

                else
                {
                    Console.WriteLine("Nota F");
                }

                //Exercécio 6

                int jogador, computrador;

                Console.WriteLine("Escolha: 1 - pedra, 2 - papel, 3- tesoura");
                jogador = int.Parse(Console.ReadLine());
                Random gerador = new Random();
                computador = gerador.Next(1, 3);
                if (computador == jogador)
                {
                    Console.WriteLine("Empate");
                }
                else
                {
                    if (compputador == 1 && jogador == 2 || computador == 2 && jogador == 3 || computador == 3 && jogador == 1) ;
                    {
                        Console.WriteLine("Jogador ganhou!");
                    }
                    else
                    {
                        Console.WriteLine("Computador ganhou!");
                    }
                }
            }

            //Exercício 7

            float valor;

            Console.WriteLine("Entre com o valor total da compra: ");
            valor = float.Parse(Console.ReadLine());

            if (valor >= 400) ;
            {
                Console.WriteLine("O desconto será de {0} e o total");
            }
else
            {
                if (valor > 300) ;
                Console.WriteLine("O descontpo será de {0}");
            }
else
            {
                if (valor >= 200)
                {
                    Console.WriteLine("O desconto será de {0}");
                }
                else
                {
                    if (valor > 100)
                    {
                        Console.WriteLine("O desconto será {1}", valor * 0.2f, valor - (valor * 0.2f));
                    }
                    {
                        Console.WriteLine("O desconto será {1}", valor * 0.1f, valor - (valor * 0.1f));
                    }
                }
            }

            //Exercício 8

            float peso, altura, imc;

            Console.WriteLine("Entre com o seu peso em kg: ");
            peso = float.Parse(Console.ReadLine());

            Console.WriteLine("Entre com a sua altura em metros: ");
            altura = float.Parse(Console.ReadLine());

            imc = peso / (altura * altura);

            if (imc < 18.5f)
            {
                Console.WriteLine("Abaixo do peso"):  
}
            else
            {
                if (imc >= 18.5f && imc <= 24.9f)
                {
                    Console.WriteLine("Peso normal");
                }
                {
                    if (imc <= 34.9f)
                    {
                        Console.WriteLine("Obesidade grau I");
                    }
                    else
                    {
                        if (imc <= 39.9f)
                        {
                            Console.WriteLine("Obesidade grau II");
                        }
                        else
                        {
                            Console.WriteLine("Obesidade grau III");
                        }
                    }
                }
            }
            








        }
    }
}